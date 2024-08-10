using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_InstagramCodeFirst.Models.Entities
{
    public class User
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public List<Photo> Photos { get; set; }
        public List<PhotoComment> PhotoComments { get; set; }
    }
}
