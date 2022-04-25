namespace MyCheckedList.Models
{
    public class SmsSender : IMessageSender
    {
        public void SendMessage()
        {
            Console.WriteLine("Send by SMS.");
        }
    }
}
