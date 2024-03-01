using PhoneBook.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Brokers
{
    public interface IFileBroker
    {
        Contact InsertContact(Contact contact); 
        Contact GetContactByIndex(int index); 
        Contact[] GetAllContacts();
        Contact UpdateContactByIndex(int index, Contact contact); 
        Contact DeleteContactByIndex(int index, Contact contact); 
    }
}
