using System;
using System.IO;
using System.Linq;
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
                this.listBoxGroups.Items.AddRange(contacts.Groups);
                this.updateFilter(null, null);
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

        private void buttonSaveToXml_Click(object sender, EventArgs e)
        {
            if (this.saveFileDialogXml.ShowDialog() == DialogResult.OK)
            {
            }
        }

        private void updateFilter(object sender, EventArgs e)
        {
            this.listBoxGroups.Enabled = !this.radioButtonAll.Checked;
            this.listBoxContacts.BeginUpdate();
            this.listBoxContacts.Items.Clear();
            var selected = this.listBoxGroups.SelectedItems.Cast<Google.GData.Contacts.GroupEntry>().ToArray();
            IEnumerable<Google.GData.Contacts.ContactEntry> c;
            if (this.radioButtonOnlySelected.Checked)
                c = this.contacts.Contacts.Where(contact => contact.IsMemberOf(selected));
            else if (this.radioButtonButSelected.Checked)
                c = this.contacts.Contacts.Where(contact => !contact.IsMemberOf(selected));
            else
                c = this.contacts.Contacts;

            if (this.radioButtonExcludeWithoutAddress.Checked)
                c = c.Where(contact => contact.PostalAddresses.Count > 0);
            else if (this.radioButtonExcludeWithoutPhone.Checked)
                c = c.Where(contact => contact.Phonenumbers.Count > 0);
            else if (this.radioButtonExcludeWithoutAddressNorPhone.Checked)
                c = c.Where(contact => contact.Phonenumbers.Count > 0 || contact.PostalAddresses.Count > 0);

            this.listBoxContacts.Items.AddRange(c.ToArray());
            this.groupBoxContacts.Text = String.Format("{0}/{1} contacts selected for report...", this.listBoxContacts.Items.Count, this.contacts.Contacts.Length);
            this.listBoxContacts.EndUpdate();
        }
    }
}
