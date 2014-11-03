using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// google stuff
using Google.GData;
using Google.GData.Contacts;
using Google.GData.Client;
using Google.GData.Extensions;

namespace GContactPrinter
{
    public static class Extensions
    {
        /// <summary>
        /// Checks wether a contact is a member of any given group
        /// </summary>
        /// <param name="contact"></param>
        /// <param name="groups"></param>
        /// <returns></returns>
        public static bool IsMemberOf(this ContactEntry contact, IEnumerable<GroupEntry> groups)
        {
            foreach (var groupMemberShip in contact.GroupMembership)
                foreach (var group in groups)
                    if (String.Compare(groupMemberShip.HRef, group.Id.AbsoluteUri, true) == 0)
                        return true;
            return false;
        }
    }
}
