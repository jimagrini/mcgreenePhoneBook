namespace Library
{
    public interface IMessageChannel
    {
        void Send(Message message, Contact contact);
        Message GetMessage(Contact sender, Contact receiver);
    }
}