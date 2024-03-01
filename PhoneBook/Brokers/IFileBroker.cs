using PhoneBook.Model;
namespace PhoneBook.Brokers;
public interface IFileBroker
    {
        Contact InsertContact(Contact contact);
        Contact[] GetAllContacts();
        Contact GetContactByLine(int line);
        Contact UpdateContactByLine(int line,Contact contact);
        Contact DeleteContactByLine(int line);
    }