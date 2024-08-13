namespace CA_InstagramCodeFirst.Models.Entities
{
    public class User
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        //Foreign Key
        public int UserProfileId { get; set; }
        public UserProfile UserProfile { get; set; }

        public List<Photo> Photos { get; set; }
        public List<Message> Messages { get; set; }
        public List<PhotoComment> PhotoComments { get; set; }   
    }
}
