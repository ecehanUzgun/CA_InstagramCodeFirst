namespace CA_InstagramCodeFirst.Models.Entities
{
    public class UserProfile
    {
        public int ID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        //Foreign Key
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
