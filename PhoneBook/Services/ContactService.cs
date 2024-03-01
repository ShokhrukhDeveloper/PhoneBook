using PhoneBook.Brokers;
using PhoneBook.Model;

namespace PhoneBook.Services;
public class ContactService : IContactService
{

    private readonly IFileBroker storageBroker;

    public ContactService()
    {
        this.storageBroker = new FileBroker("contact.txt");
    }
    public Contact AddContact(Contact contact)
    {
        throw new NotImplementedException();
    }

    public Contact DeleteContactById(int line)
    {
        throw new NotImplementedException();
    }

    public Contact[] GetAllContacts()
    {
        throw new NotImplementedException();
    }

    public Contact GetContactByLine(int line)
    {
        throw new NotImplementedException();
    }

    public Contact UpdateContactByLine(int line, Contact contact)
    {
        throw new NotImplementedException();
    }
}