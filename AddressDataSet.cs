using System;
using System.Linq;
using System.IO;
using System.Windows.Forms;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;
// google stuff
using Google.GData.Contacts;
using Google.GData.Client;
using Google.GData.Extensions;

namespace GContactPrinter
{
    partial class AddressDataSet
    {
        public void AddContacts(IEnumerable<ContactEntry> contacts)
        {
            foreach (var contact in contacts)
            {
                // get name
                string name = contact.Title.Text;
                // format date
                string lastUpdate = contact.Updated.Date.ToShortDateString();
                // add only primary email
                if (contact.PrimaryEmail != null)
                    this.AddressesTable.AddAddressesTableRow(name, contact.PrimaryEmail.Address, lastUpdate);
                // add all phones
                foreach (PhoneNumber phone in contact.Phonenumbers)
                {
                    string p = phone.Value;
                    switch (phone.Rel)
                    {
                        case ContactsRelationships.IsMobile:
                            p += "(h)";
                            break;
                        case ContactsRelationships.IsWork:
                            p += "(w)";
                            break;
                        case ContactsRelationships.IsHome:
                            p += "(p)";
                            break;
                        case ContactsRelationships.IsFax:
                        case ContactsRelationships.IsWorkFax:
                        case ContactsRelationships.IsHomeFax:
                            p += "(f)";
                            break;
                    }
                    this.AddressesTable.AddAddressesTableRow(name, p, lastUpdate);
                }
                // address
                foreach (var adr in contact.PostalAddresses)
                    this.AddressesTable.AddAddressesTableRow(name, adr.FormattedAddress, lastUpdate);
                // comments
                if (!String.IsNullOrEmpty(contact.Content.Content))
                    this.AddressesTable.AddAddressesTableRow(name, contact.Content.Content, lastUpdate);
            }
            this.AcceptChanges();
        }
    }
}
