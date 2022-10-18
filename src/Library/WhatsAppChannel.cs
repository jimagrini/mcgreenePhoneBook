namespace Library
{
    public class WhatsAppChannel : IMessageChannel
    {
        public void Send(Message message, Contact receiver)
        {
            receiver.phoneBook.MessageBox.Add(message);
        }
        public Message GetMessage(Contact sender, Contact receiver)
        {
            return new Message(sender.Name, receiver.Name  );
        }
    }
}

