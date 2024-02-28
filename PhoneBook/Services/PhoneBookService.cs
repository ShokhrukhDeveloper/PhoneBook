using PhoneBook.Model;

namespace PhoneBook.Services
{
    internal class PhoneBookService
    {
        private static PhoneBooks?[] PhoneBooksArray= new PhoneBooks[] { };
        public void CreatePhoneBook() 
        {
            PhoneBooks phoneBooks = InputPhoneBook();
            phoneBooks.Id = PhoneBooksArray.Length;
            PhoneBooksArray.Append(phoneBooks);
            Console.Clear();
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
        
        public void UpdatePhoneBook(int index) 
        {
            PhoneBooks phoneBooks = InputPhoneBook();
            int Id = PhoneBooksArray[index].Id;
            PhoneBooksArray[index]=phoneBooks;
            PhoneBooksArray[index].Id = Id;
            Console.WriteLine("Muvifaqqiyatli yangilandi");
        }
        public void DeletePhoneBookByIndex(int index) 
        {
            PhoneBooksArray[index]=null;
        }
        public PhoneBooks GetPhoneBookByIndex(int index)
        {
           return PhoneBooksArray[index];
        }
        public PhoneBooks?[] GetAllPhoneBooks(int index)
        {
            return PhoneBooksArray;
        }



    }
}
