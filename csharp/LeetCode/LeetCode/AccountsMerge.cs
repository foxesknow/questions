using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class AccountsMerge
    {
        public List<List<string>> Merge(Dictionary<string, List<string>> contactsToEmail)
        {
            Dictionary<string, List<string>> emailToContacts = new();

            foreach(var (contact, addresses) in contactsToEmail)
            {
                foreach(var address in addresses)
                {
                    if(emailToContacts.TryGetValue(address, out var contacts))
                    {
                        contacts.Add(contact);
                    }
                    else
                    {
                        emailToContacts[address] = new(){contact};
                    }
                }
            }

            var merge = new List<List<string>>();
            HashSet<string> seen = new();

            foreach(var (contact, emails) in contactsToEmail)
            {
                if(seen.Contains(contact)) continue;

                List<string> group = new();                

                foreach(var email in emails)
                {
                    WalkAddress(email, seen, group, contactsToEmail, emailToContacts);
                }

                merge.Add(group);
            }

            return merge;
        }

        private void WalkAddress(string address, HashSet<string> seen, List<string> group, Dictionary<string, List<string>> contactsToEmail, Dictionary<string, List<string>> emailToContacts)
        {
            var contacts = emailToContacts[address];

            foreach(var contact in contacts)
            {
                if(seen.Contains(contact)) continue;
                
                seen.Add(contact);
                group.Add(contact);

                foreach(var email in contactsToEmail[contact])
                {
                    WalkAddress(email, seen, group, contactsToEmail, emailToContacts);
                }
            }
        }
    }
}
