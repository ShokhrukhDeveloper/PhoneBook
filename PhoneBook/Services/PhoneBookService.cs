using PhoneBook.Model;

namespace PhoneBook.Services
{
    internal class PhoneBookService
    {
        public PhoneBookService() { }
        private static PhoneBooks?[] PhoneBooksArray= new PhoneBooks[20];
        public void CreatePhoneBook() 
        {
            PhoneBooks phoneBooks = InputPhoneBook();
            phoneBooks.Id = PhoneBooksArray.Length;
            PhoneBooksArray.Append(phoneBooks);
            Console.WriteLine("Muvifaqqiyatli qo'shildi");
        }
        private PhoneBooks InputPhoneBook() 
        {
            Console.Write("Isimi: ");
            string name=Console.ReadLine();
            Console.Write("Raqami: ");
            string phone = Console.ReadLine();
            PhoneBooks phoneBooks = new PhoneBooks{Name=name,Phone=phone };
            return phoneBooks;
        }
        
        public void UpdatePhoneBookBy() 
        {

            int id = Input("Enter Id:");
            PhoneBooks? phoneBooks = GetById(id);
            if (phoneBooks != null)
            {
                PhoneBooks newPhoneBooks = InputPhoneBook();
                int Id = phoneBooks.Id;
                newPhoneBooks.Id = Id;
                PhoneBooksArray[Array.IndexOf(PhoneBooksArray, phoneBooks)]=newPhoneBooks;
                Console.WriteLine("Successufully updated");
            }
          
        }
        public void DeletePhoneBookById() 
        {
            int id=Input("Enter Id:");
            PhoneBooks? phoneBooks = GetById(id); 
            if (phoneBooks != null)
            {
                PhoneBooksArray[Array.IndexOf(PhoneBooksArray,phoneBooks)] = null;
                Console.WriteLine("Successfully deleted");
            }

        }
        public void PrintPhoneBookById()
        {
            int id = Input("Enter Id:");
            PhoneBooks? phoneBooks = PhoneBooksArray.FirstOrDefault(e=>e.Id==id);
            if (phoneBooks is null)
            {
                Console.WriteLine("Berilgan Id bo'yicha ma'lumot toplimadi");
                return;
            }
            Console.WriteLine($"Id: {phoneBooks.Id}; \tName: {phoneBooks.Name}\t Phone: {phoneBooks.Phone}");
        }
        public void PrintAllPhoneBooks()
        {
            foreach (PhoneBooks item in PhoneBooksArray)
            {
                if (item != null)
                {
                    Console.WriteLine($"Id:{item.Id} \tName: {item.Name}");
                }
            }
        }

        private int Input(string text)
        {
            Console.Write(text);
            string userInput = Console.ReadLine();
            return Convert.ToInt32(userInput);
        }
        private PhoneBooks? GetById(int id)
        {
            return PhoneBooksArray.FirstOrDefault(e => e.Id == id);
        }

    }
}
