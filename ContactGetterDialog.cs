using System;
using System.IO;
using System.Threading;
using System.Globalization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;
using System.Windows.Forms;
// google stuff
using Google.GData;
using Google.GData.Contacts;
using Google.GData.Client;
using Google.GData.Extensions;
using Newtonsoft.Json;

namespace GContactPrinter
{
    public partial class ContactGetterDialog : Form
    {
        static string APPNAME = "GContactPrinter";
        OAuth2Parameters parameters;
        SynchronizationContext sync;

        public ContactEntry[] Contacts { get; private set; }
        public GroupEntry[] Groups { get; private set; }
        public string Email { get; private set; }
        public string UserName { get; private set; }

        public ContactGetterDialog()
        {
            InitializeComponent();
            this.sync = SynchronizationContext.Current;
            // see: https://developers.google.com/accounts/docs/OAuth2InstalledApp
            this.parameters = new OAuth2Parameters()
            {
                ClientId = @"901417380953-9mav3rrc3c8tdf4hrnnpvdqf5bmmi14c.apps.googleusercontent.com",
                ClientSecret = @"aIKReROooiOD-ZpgQAoFf8aa",
                RedirectUri = "urn:ietf:wg:oauth:2.0:oob:auto",
                Scope = "https://www.googleapis.com/auth/contacts.readonly https://www.googleapis.com/auth/userinfo.email",
            };
            // start authentification process
            this.webBrowser.Url = new Uri(OAuthUtil.CreateOAuth2AuthorizationUrl(this.parameters));
        }

        private void webBrowser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            const string ok = "Success code=";
            //            const string error = "Denied error=";
            var title = webBrowser.DocumentTitle;
            if (title.StartsWith(ok))
            {
                this.parameters.AccessCode = title.Substring(ok.Length);
                this.webBrowser.Visible = false;
                ThreadPool.QueueUserWorkItem(DoWork, this.parameters);
                this.webBrowser.Navigated -= this.webBrowser_Navigated;
            }
        }


        void DoWork(object state)
        {
            OAuthUtil.GetAccessToken(this.parameters);
            var userInfo = GetUserInfos();
            this.Email = userInfo["email"];
            this.UserName = userInfo["name"];
            var service = new ContactsService(APPNAME)
            {
                RequestFactory = new GOAuth2RequestFactory("apps", APPNAME, this.parameters),
            };
            this.Groups = service.Query(new GroupsQuery(GroupsQuery.CreateGroupsUri("default"))
            {
                NumberToRetrieve = 500,
            }).Entries.OfType<Google.GData.Contacts.GroupEntry>().ToArray();

            this.Contacts = service.Query(new ContactsQuery(ContactsQuery.CreateContactsUri("default"))
            {
                NumberToRetrieve = 50000,
            }).Entries.OfType<ContactEntry>().ToArray();
            // close dialog
            this.sync.Post(s => this.DialogResult = System.Windows.Forms.DialogResult.OK, null);
        }


        /// <summary>
        /// Checks wether a contact is a member of any given group
        /// </summary>
        /// <param name="contact"></param>
        /// <param name="groups"></param>
        /// <returns></returns>
        static bool IsMemberOf(ContactEntry contact, IEnumerable<GroupEntry> groups)
        {
            foreach (var groupMemberShip in contact.GroupMembership)
                foreach (var group in groups)
                    if (String.Compare(groupMemberShip.HRef, group.Id.AbsoluteUri, true) == 0)
                        return true;
            return false;
        }

        Dictionary<string, string> GetUserInfos()
        {
            Uri requestUri = new Uri(String.Format("https://www.googleapis.com/oauth2/v1/userinfo?access_token={0}", this.parameters.AccessToken));
            WebRequest request = WebRequest.Create(requestUri);
            request.Method = "GET";
            request.ContentLength = 0;
            request.ContentType = "application/x-www-form-urlencoded";
            WebResponse response = request.GetResponse();
            if (response != null)
                using (Stream responseStream = response.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(responseStream);
                    return JsonConvert.DeserializeObject<Dictionary<string, string>>(reader.ReadToEnd());
                }
            return new Dictionary<string, string>();
        }

        public IEnumerable<ContactEntry> GetFilteredContacts(IEnumerable<GroupEntry> includeGroups, IEnumerable<GroupEntry> excludeGroups)
        {
            var includeAll = includeGroups.Count() == 0;
            return this.Contacts
                //  1) that are not in the included list of groups, except if that list is empty
                .Where(contact => includeAll || contact.GroupMembership.Count == 0 || IsMemberOf(contact, includeGroups))
                //  2) that are in the exclude list
                .Where(contact => !IsMemberOf(contact, excludeGroups))
/*
                // we are not interested in contacts not having an adress 
                // nor a phone nor any notes, because plain eMail contacts 
                // need no printing
                .Where(contact =>
                    contact.Phonenumbers.Count > 0 ||
                    contact.PostalAddresses.Count > 0 ||
                    !String.IsNullOrEmpty(contact.Content.Content)
                )                
 */ 
                 ;
        }
    }
}
