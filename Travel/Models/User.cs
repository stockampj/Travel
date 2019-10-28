using System.Collections.Generic;
namespace Travel.Models
{
    public class User
    {
        public User()
        {
            this.Reviews = new HashSet<Review>();
        }
        public string UserName {get; set;}
        public int UserId {get; set;}
        public ICollection<Review> Reviews {get;}
    }
}