namespace CA_InstagramCodeFirst.Models.Entities
{
    public class PhotoComment
    {
        public int ID { get; set; }
        public string Comment { get; set; }
        public DateTime PublishedDate { get; set; }

        //Foreign Key
        public int PhotoId { get; set; }
        public int UserId { get; set; }
        public Photo Photo { get; set; }
        public User User { get; set; }
    }
}
