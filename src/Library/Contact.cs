namespace Library
{
    public class Contact
    {
        public Phonebook phoneBook {get;}
        public Contact(string name)
        {
            this.phoneBook= new Phonebook(this);
            this.Name = name;
        }

        public string Name { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }
    }
}