using PhoneBook.Brokers;
using PhoneBook.Model;

namespace PhoneBook.Services;
public class ContacService : IContactService
{
    private readonly IStorageBroker storageBroker;

    public ContacService(StorageBroker storageBroker)
    {
        this.storageBroker = storageBroker;
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