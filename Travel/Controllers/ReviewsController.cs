using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Travel.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace Travel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewsController : ControllerBase
    {
        private ApplicationDbContext _db;

        public ReviewsController(ApplicationDbContext db)
        {
            _db = db;
        }

        // GET api/animals
        [HttpGet]
        public ActionResult<IEnumerable<Review>> Get(string cityId, string rating)
        {
            var query = _db.Reviews.AsQueryable();

            if(cityId != null)
            {
            int cityIdInt = Int32.Parse(cityId);
            query = query
                .Where(review => review.CityId == cityIdInt);
            }

            if(rating != null)
            {
            double ratingDouble = Double.Parse(rating);
            query = query
                .Where(review => review.Rating >= ratingDouble);
            }

            return query.ToList();
        }
        // POST api/animals
        [HttpPost]
        public void Post([FromBody] Review review)
        {
            _db.Reviews.Add(review);
            _db.SaveChanges();
            
        }
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Review review)
        {
            review.ReviewId = id;
            _db.Entry(review).State = EntityState.Modified;
            _db.SaveChanges();
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var reviewToDelete = _db.Reviews.FirstOrDefault(entry => entry.ReviewId == id);
            _db.Reviews.Remove(reviewToDelete);
            _db.SaveChanges();
        }
    }
}