
namespace PhoneBook.Model;
    public class Contact
    {
        public Contact(string name,string phone)
        {
            Name=name;
            Phone=phone;
        }
        public string Name { get; set; }
        public string Phone { get; set; }
    }


