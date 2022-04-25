namespace MyCheckedList.Models
{
    public class EmailSender : IMessageSender
    {
        public void SendMessage()
        {
            Console.WriteLine("Send by Email.");
        }
    }
}
