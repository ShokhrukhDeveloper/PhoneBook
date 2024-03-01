using PhoneBook.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Services
{
    internal interface IPhoneBookService
    {
        void CreateContact(Contact contact);
        void GetContactByIndex(int index);
        void DeleteContactByIndex(int index,Contact contact);
        void EditContactByIndex(int index,Contact contact);
        
    }
}
