using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GContactPrinter
{
    public partial class LogonForm : Form
    {
        LogonForm()
        {
            InitializeComponent();
        }

        static public bool Execute(ref string username, out string password)
        {
            using (LogonForm f = new LogonForm())
            {
                f.textBoxUsername.Text = username;
                if (f.ShowDialog() == DialogResult.OK)
                {
                    username = f.textBoxUsername.Text;
                    password = f.textBoxPassword.Text;
                    return true;
                }
                else
                {
                    password = null;
                    return false;
                }
            }
        }

        private void LogonForm_Shown(object sender, EventArgs e)
        {
            // set focus 
            if (this.textBoxUsername.Text.Trim().Length==0)
                this.textBoxUsername.Focus();
            else
                this.textBoxPassword.Focus();
        }
    }
}