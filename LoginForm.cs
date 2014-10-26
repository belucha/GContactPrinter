using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GContactPrinter
{
    public partial class LoginForm : Form
    {
        string code;

        LoginForm()
        {
            InitializeComponent();
        }

        public static string Execute(string url)
        {
            using (var dlg = new LoginForm())
            {
                dlg.webBrowser.Url = new Uri(url);
                dlg.ShowDialog();
                return dlg.code;
            }
        }

        private void webBrowser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            const string ok = "Success code=";
            const string error = "Denied error=";
            var title = webBrowser.DocumentTitle;
            if (title.StartsWith(ok))
            {
                this.code = title.Substring(ok.Length);
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                return;
            }
            if (title.StartsWith(error))
            {
                this.code = null;
                this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                return;
            }
        }
    }
}
