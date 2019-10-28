using System.Collections.Generic;
namespace Travel.Models
{
    public class Review
    {
        public string Blurb {get; set;}
        public double Rating {get;set;}
        public int ReviewId {get; set;}
        public int UserId {get; set;}
        public int CityId {get; set;}
    }
}