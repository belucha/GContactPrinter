using System;
using System.Linq;
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
    public partial class ReportForm : Form
    {
        public ReportForm(IEnumerable<Google.GData.Contacts.ContactEntry> contacts, string email)
        {
            InitializeComponent();
            this.addressDataSet.AddContacts(contacts);
            var printDate = DateTime.Now;
            // pass parameters to the report
            this.reportViewer.LocalReport.SetParameters(new ReportParameter[] {
                new ReportParameter("SourceFile", email),
                new ReportParameter("FileDateString", String.Format("{0} {1}", 
                    printDate.ToShortDateString(), 
                    printDate.ToShortTimeString())
                ),
            });
            this.reportViewer.SetDisplayMode(DisplayMode.PrintLayout);
        }
    }
}