  
using Travel.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Travel.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Token { get; set; }

        public User()
        {
            this.Reviews = new HashSet<Review>();
        }
        public ICollection<Review> Reviews {get;}
    }
}