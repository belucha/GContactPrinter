using System;
using System.IO;
using System.Net;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Google.GData;
using Google.GData.AccessControl;
using Google.GData.Client;
using System.Globalization;
using Newtonsoft.Json;

namespace GContactPrinter
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public static Dictionary<string, string> QueryJson(string url, OAuth2Parameters parameters)
        {
            Uri requestUri = new Uri(String.Format("{0}?access_token={1}", url, parameters.AccessToken));
            WebRequest request = WebRequest.Create(requestUri);
            request.Method = "GET";
            request.ContentLength = 0;
            request.ContentType = "application/x-www-form-urlencoded";
            WebResponse response = request.GetResponse();
            string result = "";
            if (response != null)
            {
                Stream responseStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(responseStream);
                result = reader.ReadToEnd();
                return JsonConvert.DeserializeObject<Dictionary<string, string>>(result);
            }
            return new Dictionary<string, string>();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Text = String.Format("{0} {1}",
                Application.ProductName,
                Application.ProductVersion
            );
            // see: https://developers.google.com/accounts/docs/OAuth2InstalledApp
            OAuth2Parameters parameters = new OAuth2Parameters()
            {
                ClientId = @"901417380953-9mav3rrc3c8tdf4hrnnpvdqf5bmmi14c.apps.googleusercontent.com",
                ClientSecret = @"aIKReROooiOD-ZpgQAoFf8aa",
                RedirectUri = "urn:ietf:wg:oauth:2.0:oob:auto",
                Scope = "https://www.googleapis.com/auth/contacts.readonly https://www.googleapis.com/auth/userinfo.email",
            };
            // run the OAuth process in webBrowser
            parameters.AccessCode = LoginForm.Execute(OAuthUtil.CreateOAuth2AuthorizationUrl(parameters));
            // close app in case of failure
            if (String.IsNullOrEmpty(parameters.AccessCode))
            {
                Close();
                return;
            }
            // create temp form showing loading progress
            Form f = new Form();
            try
            {
                f.Text = "Authenticating...";
                f.FormBorderStyle = FormBorderStyle.FixedToolWindow;
                f.TopMost = true;
                f.ClientSize = new Size(500, 0);
                f.StartPosition = FormStartPosition.CenterScreen;
                /* google code */
                DateTime printDate = DateTime.Now;
                f.Show();
                // convert access 
                OAuthUtil.GetAccessToken(parameters);
                // get user infos
                var userInfo = QueryJson("https://www.googleapis.com/oauth2/v1/userinfo", parameters);
                f.Text = String.Format("Loading contact data for {0}. Please wait ... ", userInfo["email"]);
                try
                {
                    // fill the data source
                    this.addressDataSet.GoogleFill("GContactPrinter", parameters);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Close();
                    return;
                }
                // pass parameters to the report
                this.reportViewer.LocalReport.SetParameters(new ReportParameter[] {
                        new ReportParameter("SourceFile", userInfo["email"]),
                        new ReportParameter("FileDateString", String.Format("{0} {1}", 
                            printDate.ToShortDateString(), 
                            printDate.ToShortTimeString())
                        ),
                    });
                this.reportViewer.SetDisplayMode(DisplayMode.PrintLayout);
                if (f.Visible)
                    f.Close();
            }
            finally
            {
                if (f.Visible)
                    f.Close();
            }
        }
    }
}