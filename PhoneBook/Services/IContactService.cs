using PhoneBook.Model;

namespace PhoneBook.Services;
 public interface IContactService
    {
        Contact AddContact(Contact contact);
        Contact[] GetAllContacts();
        Contact GetContactByLine(int line);
        Contact UpdateContactByLine(int line,Contact contact);
        Contact DeleteContactById(int line);
    }