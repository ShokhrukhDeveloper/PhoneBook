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
        return storageBroker.InsertContact(contact);
    }

    public Contact DeleteContactById(int line)
    {
        return storageBroker.DeleteContactByLine(line);
    }

    public Contact[] GetAllContacts()
    {
        return storageBroker.GetAllContacts();
    }

    public Contact GetContactByLine(int line)
    {
        return storageBroker.GetContactByLine(line);
    }

    public Contact UpdateContactByLine(int line, Contact contact)
    {
        return storageBroker.UpdateContactByLine(line,contact);
    }
}