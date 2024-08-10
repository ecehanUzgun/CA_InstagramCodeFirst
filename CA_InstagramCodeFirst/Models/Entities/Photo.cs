namespace CA_InstagramCodeFirst.Models.Entities
{
    public class Photo
    {
        public int ID { get; set; }
        public string PhotoPath { get; set; }
        public string Title { get; set; }
        public DateTime PublishedDate { get; set; }
        //Foreign Key
        public int UserId { get; set; }
        public User User { get; set; }
        //public List<PhotoComment> PhotoComments { get; set; }
    }
}
