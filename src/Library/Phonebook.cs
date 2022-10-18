using System.Collections.Generic;

namespace Library
{
    public class Phonebook
    {
        private List<Contact> persons;

        private List<Message> chatbox ;

        public void Add(Contact contact)
        {
            this.persons.Add(contact);
        }

        public void Remove(Contact contact)
        {
            this.persons.Remove(contact);
        }
        public Phonebook(Contact owner)
        {
            this.Owner = owner;
            this.persons = new List<Contact>();
            this.chatbox= new List<Message>();
        }

        public void SendWpp(string text, Contact receiver, IMessageChannel channel)
        {
            Message msg= channel.GetMessage(Owner, receiver);
            channel.Send(msg,receiver);
            chatbox.Add(msg);

        }

        public Contact Owner { get; }
 
        public List<Contact> Search(string[] names)
        {
            List<Contact> result = new List<Contact>();

            foreach (Contact person in this.persons)
            {
                foreach (string name in names)
                {
                    if (person.Name.Equals(name))
                    {
                        result.Add(person);
                    }
                }
            }

            return result;
        }
    }
}