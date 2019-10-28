using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Travel.Models;
using Microsoft.EntityFrameworkCore;

namespace Travel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitiesController : ControllerBase
    {
        private ApplicationDbContext _db;

        public CitiesController(ApplicationDbContext db)
        {
            _db = db;
        }

        // GET api/animals
        [HttpGet("{id}")]
        public ActionResult<City> Get(int id)
        {
            return _db.Cities.FirstOrDefault(entry => entry.CityId == id);
        }
        // POST api/animals
        [HttpPost]
        public void Post([FromBody] City city)
        {
            _db.Cities.Add(city);
            _db.SaveChanges();
        }
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] City city)
        {
            city.CityId = id;
            _db.Entry(city).State = EntityState.Modified;
            _db.SaveChanges();
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var cityToDelete = _db.Cities.FirstOrDefault(entry => entry.CityId == id);
            _db.Cities.Remove(cityToDelete);
            _db.SaveChanges();
        }
    }
}