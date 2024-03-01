using PhoneBook.Model;
using PhoneBook.Services;

 IContactService contactService= new ContactService();
bool running = true;

do
{  
    ControlMenu();
    int userInputNumber= Input("Quyidagilardan birini  tanlang:");
    if (userInputNumber == 0 )
    {
        running = false;
        break;
    }
    
    switch (userInputNumber)
    {
        case 1:
            Console.Clear();
            Console.WriteLine("|-----------------------------------------------|");
            Contact[] res = contactService.GetAllContacts();
            int i= 0;
            foreach (Contact item in res)
            {
                Console.WriteLine($"{++i}) "+item.Name);
            }
            Console.WriteLine("|-----------------------------------------------|");
            break;

        case 2:
            
            Console.WriteLine("Yangi qo'shish tanlandi ");
            Console.Write("Nomini kiriting: ");
            string Name=Console.ReadLine();
            Console.Write("Raqamini kiriting: ");
            string Phone=Console.ReadLine();
            Contact contact = contactService.AddContact(new(Name,Phone));
            Console.Clear();
            Console.WriteLine($"Nomi: {contact.Name}\t Tel: {contact.Phone} ");
            Console.WriteLine("Muvoffaqiyatli qo'shildi ");
            break;

        case 3:

            Console.WriteLine("O'chirish tanlandi");
            int line =Input("Contact tartib raqami: ");
            contact = contactService.DeleteContactById(line);
            Console.WriteLine($"{contact.Name} muovaqqiyatli o'chirildi");
            break;

        case 4:
            Console.WriteLine("Contact haqida ma'lumot");
            line = Input("Tartib raqami:");
            contact=contactService.GetContactByLine(line);
            Console.WriteLine();
            Console.WriteLine($"Nomi: {contact.Name}\t Tel: {contact.Phone}");
            Console.WriteLine();
            break;

        case 5:
            line = Input("Tartib raqami:");
            Console.Write("Nomi: ");
            Name = Console.ReadLine();
            Console.Write("Raqami: ");
            Phone = Console.ReadLine();
            contactService.UpdateContactByLine(line,new(Name, Phone));
            break;
        default:
            Console.Clear();
            Console.WriteLine("Noto'gri tanlov qayrtadan tanlang");
            break;
    }
}while (running);

void ControlMenu() 
{
    Console.WriteLine("1) Contactlar ro'yhati");
    Console.WriteLine("2) Contact yaratish");
    Console.WriteLine("3) Contact o'chirish");
    Console.WriteLine("4) Contact ma'lumotlari");
    Console.WriteLine("5) Contactni yangilash");
    Console.WriteLine("0) Exit");
}
int Input(string text)
{
    Console.Write(text);
    string userInput = Console.ReadLine();
    return Convert.ToInt32(userInput);
}
