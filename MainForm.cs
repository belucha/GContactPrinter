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

namespace GContactPrinter
{
    public partial class MainForm : Form
    {
        string username;
        public MainForm()
        {
            username = "";
            InitializeComponent();
        }

        public MainForm(string username)
        {
            this.username = username;
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Text = String.Format("{0} {1}",
                Application.ProductName,
                Application.ProductVersion
            );
            // create temp form showing loading progress
            Form f = new Form();
            try
            {
                f.FormBorderStyle = FormBorderStyle.FixedToolWindow;
                f.TopMost = true;
                f.ClientSize = new Size(500, 0);
                f.StartPosition = FormStartPosition.CenterScreen;
                /* google code */
                string password;
                if (LogonForm.Execute(ref username, out password))
                {
                    f.Text = String.Format("Loading contact data for '{0}'. Please wait ... ", username);
                    DateTime printDate = DateTime.Now;
                    f.Show();
                    try
                    {
                        // fill the data source
                        this.addressDataSet.GoogleFill(username, password);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        Close();
                        return;
                    }
                    // pass parameters to the report
                    this.reportViewer.LocalReport.SetParameters(new ReportParameter[] {
                        new ReportParameter("SourceFile", username),
                        new ReportParameter("FileDateString", String.Format("{0} {1}", 
                            printDate.ToShortDateString(), 
                            printDate.ToShortTimeString())
                        ),
                    });
                    this.reportViewer.SetDisplayMode(DisplayMode.PrintLayout);
                    if (f.Visible)
                        f.Close();
                }
                else
                {
                    Close();
                    return;
                }
            }
            finally
            {
                if (f.Visible)
                    f.Close();
            }
        }
    }
}