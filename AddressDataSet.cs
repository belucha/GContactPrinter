using System;
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
        /// <summary>
        /// Fills the the Addressdataset with all google contacts
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        public void GoogleFill(string username, string password)
        {
            ContactsService contactService = new ContactsService("GContactPrinter");
            contactService.setUserCredentials(username, password);
            ContactsQuery q = new ContactsQuery(ContactsQuery.CreateContactsUri("default"));
            q.NumberToRetrieve = 500000;
            foreach (ContactEntry contact in contactService.Query(q).Entries)
            {
                // we are not interested in contacts not having an adress 
                // nor a phone nor any notes, because plain eMail contacts 
                // need no printing
                if (
                    contact.Phonenumbers.Count == 0 &&
                    contact.PostalAddresses.Count == 0 &&
                    String.IsNullOrEmpty(contact.Content.Content)
                    )
                    continue;
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
                        case ContactsRelationships.IsFax:
                            p += "(f)";
                            break;
                    }
                    this.AddressesTable.AddAddressesTableRow(name, p, lastUpdate);
                }
                // address
                foreach (PostalAddress adr in contact.PostalAddresses)
                    this.AddressesTable.AddAddressesTableRow(name, adr.Value, lastUpdate);
                // comments
                if (!String.IsNullOrEmpty(contact.Content.Content))
                    this.AddressesTable.AddAddressesTableRow(name, contact.Content.Content, lastUpdate);
            }
            this.AcceptChanges();
        }
    }
}
