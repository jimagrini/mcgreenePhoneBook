namespace Library
{
    public class WhatsAppChannel : IMessageChannel
    {
        public void Send(Message message, Contact receiver)
        {
            
        }
        public Message GetMessage(Contact sender, Contact receiver)
        {
            return new Message(sender.Name, receiver.Name  );
        }
    }
}

