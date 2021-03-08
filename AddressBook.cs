using System;
using System.Collections.Generic;

namespace AddressBook
{

    public class AddressBook
    {
        private Dictionary<string, Contact> ContactList;
        public void AddContact(Contact friend)
        {
            try
            {
                ContactList.Add(friend.Email, friend);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
        }
        public Contact GetByEmail(string email)
        {
            return ContactList[email];
        }

        public AddressBook()
        {
            ContactList = new Dictionary<string, Contact>();
        }
    }
}