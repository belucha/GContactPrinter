using System;
using System.Linq;
using System.IO;
using System.Windows.Forms;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace GContactPrinter
{
    public partial class MainForm : Form
    {
        ContactGetterDialog contacts;

        public MainForm()
        {
            InitializeComponent();
            this.contacts = new ContactGetterDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Text = String.Format("{0} {1}",
                Application.ProductName,
                Application.ProductVersion
            );
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            if (contacts.ShowDialog() == System.Windows.Forms.DialogResult.OK && contacts.Groups != null && contacts.Contacts != null)
            {
                this.groupEntryBindingSource.DataSource = contacts.Groups;
                this.contactEntryBindingSource.DataSource = contacts.Contacts;
            }
            else
                this.Close();
        }

        private void checkedListBox_FormatGroupEntry(object sender, ListControlConvertEventArgs e)
        {
            var group = e.ListItem as Google.GData.Contacts.GroupEntry;
            e.Value = group.Title.Text;
        }

        private void checkedListBoxContacts_Format(object sender, ListControlConvertEventArgs e)
        {
            var contact = e.ListItem as Google.GData.Contacts.ContactEntry;
            e.Value = contact.Title.Text;
        }

        private void checkedListBoxIncludeExclude_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            this.Text = String.Format("{0} of {1} selected for printing...", this.listBoxContacts.Items.Count, this.contacts.Contacts.Length);
        }

        private void buttonReport_Click(object sender, EventArgs e)
        {
            using (var dlg = new ReportForm(this.listBoxContacts.Items.OfType<Google.GData.Contacts.ContactEntry>(), this.contacts.Email))
                dlg.ShowDialog();
        }

        private void listBoxGroups_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
