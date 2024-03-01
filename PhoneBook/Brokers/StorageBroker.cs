using PhoneBook.Model;

namespace PhoneBook.Brokers;
public class FileBroker : IFileBroker
{
    private string fileName;
    public FileBroker(string fileName)
    {
        this.fileName=fileName;
    }
    public Contact DeleteContactByLine(int line)
    {
        string[] linesArray=File.ReadAllLines(fileName).ToArray();
        Contact contact=GetContactByLine(line);
        linesArray[line]=linesArray[line+1];
        File.WriteAllLines(fileName,linesArray);
        return contact; 
    }

    public Contact[] GetAllContacts()
    {
       return File.ReadAllLines(fileName).Select(e=>ToModel(e)).ToArray();
    }

    public Contact GetContactByLine(int line)
    {
        return File.ReadAllLines(fileName).Skip(line-1).Select((e)=>ToModel(e)).FirstOrDefault();
    }

    public Contact InsertContact(Contact contact)
    {
        File.AppendAllText(fileName,$"{contact.Name}:{contact.Phone}"+Environment.NewLine);
        return contact;
    }

    public Contact UpdateContactByLine(int line,Contact contact)
    {
        string[] linesArray=File.ReadAllLines(fileName).ToArray();
        linesArray[line]=$"{contact.Name}:{contact.Phone}";
        File.WriteAllLines(fileName,linesArray);
        return contact;
    }
    private Contact ToModel(string text)
    {
        string[] data= text.Split(':');
        return new Contact(data[0],data[1]);
    }
}