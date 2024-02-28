using PhoneBook.Services;

PhoneBookService PhoneBookService = new PhoneBookService();
    while(true)
    {
        
    

    }

void ControlMenu() 
{
    Console.WriteLine(" ListContacts");
    Console.WriteLine("1) Create Contact");
    Console.WriteLine("2) Delete Contact by Id");
    Console.WriteLine("3) Get Contact by Id");
    Console.WriteLine("4) Update Contact by Id");
 
}
int Input(string text)
{
    Console.Write(text);
    string userInput = Console.ReadLine();
    return Convert.ToInt32(userInput);
}
