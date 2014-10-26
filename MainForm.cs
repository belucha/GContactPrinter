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

namespace GContactPrinter
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Text = String.Format("{0} {1}",
                Application.ProductName,
                Application.ProductVersion
            );
            OAuth2Parameters parameters = new OAuth2Parameters()
            {
                ClientId = @"901417380953-9mav3rrc3c8tdf4hrnnpvdqf5bmmi14c.apps.googleusercontent.com",
                ClientSecret = @"aIKReROooiOD-ZpgQAoFf8aa",
                RedirectUri = "urn:ietf:wg:oauth:2.0:oob:auto",
                Scope = "https://www.googleapis.com/auth/contacts.readonly https://www.googleapis.com/auth/userinfo.email",
            };
            var accessCode = LoginForm.Execute(OAuthUtil.CreateOAuth2AuthorizationUrl(parameters));
            // create temp form showing loading progress
            if (String.IsNullOrEmpty(accessCode))
            {
                Close();
                return;
            }
            parameters.AccessCode = accessCode;
            OAuthUtil.GetAccessToken(parameters);
            Form f = new Form();
            try
            {
                f.FormBorderStyle = FormBorderStyle.FixedToolWindow;
                f.TopMost = true;
                f.ClientSize = new Size(500, 0);
                f.StartPosition = FormStartPosition.CenterScreen;
                /* google code */
                f.Text = "Loading contact data. Please wait ... ";
                DateTime printDate = DateTime.Now;
                f.Show();
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
                        new ReportParameter("SourceFile", "username"),
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