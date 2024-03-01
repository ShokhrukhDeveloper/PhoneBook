using PhoneBook.Model;
namespace PhoneBook.Brokers;
public partial interface IStorageBroker
    {
        Contact InsertContact(Contact contact);
        List<Contact> GetAllContacts();
        Contact GetContactById(Guid contactId);
        Contact UpdateContact(Contact contact);
        Contact DeleteContact(Contact contact);
    }