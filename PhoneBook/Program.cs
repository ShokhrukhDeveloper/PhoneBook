using PhoneBook.Services;

PhoneBookService PhoneBookService = new PhoneBookService();
bool running = true;

do
{
    PhoneBookService.PrintAllPhoneBooks();
    Console.WriteLine("-----------------------------------------------");
    ControlMenu();
    int input = Input();
    if (input == 0)
    {
        running = false;
    }
    switch (input)
    {
        case 1:
            PhoneBookService.CreatePhoneBook();
            break;
        case 2:
            PhoneBookService.DeletePhoneBookById();
            break;
        case 3:
            PhoneBookService.PrintPhoneBookById();
            break;
        case 4:
            PhoneBookService.UpdatePhoneBookBy();
            break;
        default:
            Console.WriteLine("Nomalum raqam");
            break;
    }
    Console.Clear();


}while (running);

void ControlMenu() 
{

    Console.WriteLine("1) Create Contact");
    Console.WriteLine("2) Delete Contact by Id");
    Console.WriteLine("3) Get Contact by Id");
    Console.WriteLine("4) Update Contact by Id");
    Console.WriteLine("0) Exit");
 
}
int Input()
{
    Console.Write(" ");
    string userInput = Console.ReadLine();
    return Convert.ToInt32(userInput);
}
