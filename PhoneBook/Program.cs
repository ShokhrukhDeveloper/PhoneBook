using PhoneBook.Model;
using PhoneBook.Services;

 IContactService contactService= new ContactService();
bool running = true;

do
{
   
    Console.WriteLine("|-----------------------------------------------|");
    ControlMenu();
    int userInputNumber= Input("Tanlang");

    
    switch (userInputNumber)
    {
        case 1:
        System.Console.WriteLine();
        Console.Write("Nomi: ");
        string Name=Console.ReadLine();
        Console.Write("Raqami: ");
        string Phone=Console.ReadLine();
        contactService.AddContact(new(Name,Phone));
        break;
        case 2:
        int line =Input("Raqami:");
        Contact contact = contactService.DeleteContactById(line);
        Console.WriteLine($"{contact.Name} muovaqqiyatli o'chirildi");
        break;
        
        case 3:
        var res=contactService.GetAllContacts();
        foreach (Contact item in res)
        {
        Console.WriteLine(item.Name);
        }
        break;
        default:
        break;
    }
    // Console.Clear();

}while (running);

void ControlMenu() 
{

    Console.WriteLine("1) Contact list");
    Console.WriteLine("2) Create Contact");
    Console.WriteLine("3) Delete Contact");
    Console.WriteLine("4) Get ContactDetails");
    Console.WriteLine("5) Update Contact");
    Console.WriteLine("0) Exit");
}
int Input(string text)
{
    Console.Write(text);
    string userInput = Console.ReadLine();
    return Convert.ToInt32(userInput);
}
