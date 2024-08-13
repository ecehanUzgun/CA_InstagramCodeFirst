namespace CA_InstagramCodeFirst.Models.Entities
{
    public class Message
    {
        public int ID { get; set; }
        public string MessageContent { get; set; }
        public User Sender { get; set; }
        public int SenderId {  get; set; }
        
        public User Receiver { get; set; }
        public int ReceiverId { get; set; }
    }
}
