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
            this.textBoxProgress.Clear();
            this.sync = SynchronizationContext.Current;
            // see: https://developers.google.com/accounts/docs/OAuth2InstalledApp
            this.parameters = new OAuth2Parameters()
            {
                ClientId = @"901417380953-9mav3rrc3c8tdf4hrnnpvdqf5bmmi14c.apps.googleusercontent.com",
                ClientSecret = @"aIKReROooiOD-ZpgQAoFf8aa",
                RedirectUri = "urn:ietf:wg:oauth:2.0:oob:auto",
                Scope = "https://www.googleapis.com/auth/contacts.readonly https://www.googleapis.com/auth/userinfo.email",
            };
            this.WriteLine("{0} started...", APPNAME);
            // start authentification process
            this.webBrowser.Url = new Uri(OAuthUtil.CreateOAuth2AuthorizationUrl(this.parameters));
        }

        private void WriteLine(string format, params object[] args)
        {
            this.sync.Post(s =>
                this.textBoxProgress.AppendText((args.Length > 0 ? String.Format(format, args) : format) + Environment.NewLine), null);
        }

        private void webBrowser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            this.WriteLine("goto: \"{0}\"", e.Url);
            const string ok = "Success code=";
            //            const string error = "Denied error=";
            var title = webBrowser.DocumentTitle;
            if (title.StartsWith(ok))
            {
                this.parameters.AccessCode = title.Substring(ok.Length);
                this.WriteLine("Access granted, code: \"{0}\"", this.parameters.AccessCode);
                this.webBrowser.Visible = false;
                ThreadPool.QueueUserWorkItem(DoWork, this.parameters);
                this.webBrowser.Navigated -= this.webBrowser_Navigated;
            }
        }


        void DoWork(object state)
        {
            try
            {
                this.WriteLine("Requesting access token...");
                OAuthUtil.GetAccessToken(this.parameters);
                this.WriteLine("Access token: {0}", parameters.AccessToken);
                this.WriteLine("Requesting user infos...");
                var userInfo = GetUserInfos();
                this.WriteLine("Email: {0}", this.Email = userInfo["email"]);
                this.WriteLine("UserName : {0}", this.UserName = userInfo["name"]);
                this.WriteLine("Create contact service...");
                var service = new ContactsService(APPNAME)
                {
                    RequestFactory = new GOAuth2RequestFactory("apps", APPNAME, this.parameters),
                };
                // groups
                this.WriteLine("Query groups...");
                this.Groups = service.Query(new GroupsQuery(GroupsQuery.CreateGroupsUri("default"))
                {
                    NumberToRetrieve = 500,
                }).Entries.OfType<Google.GData.Contacts.GroupEntry>().ToArray();
                this.WriteLine("Received {0} contact groups.", this.Groups.Length);
                // contacts
                this.WriteLine("Query contacts...");
                this.Contacts = service.Query(new ContactsQuery(ContactsQuery.CreateContactsUri("default"))
                {
                    NumberToRetrieve = 50000,
                }).Entries.OfType<ContactEntry>().ToArray();
                this.WriteLine("Received {0} contacts.", this.Contacts.Length);
                // close dialog
                this.WriteLine("Done.");
                this.WriteLine("Application starting....in 3 seconds");
                Thread.Sleep(3000);
                this.sync.Post(s => this.DialogResult = System.Windows.Forms.DialogResult.OK, null);
            }
            catch (Exception error)
            {
                this.WriteLine("");
                this.WriteLine("{0}: {1}", error.GetType().Name, error.Message);
                this.WriteLine("");
                this.WriteLine("Failure. Close dialog!");
            }
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
    }
}
