using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNet.Mvc;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace AureliaTutorial.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class MoviesController : Controller
    {
        private IList<Movie> movies;
        public MoviesController()
        {
            movies = new List<Movie>
            {
                new Movie {Id = 1, Name = "Star Wars", ReleaseYear = 1979},
                new Movie {Id = 2, Name = "Star Trek", ReleaseYear = 2014},
                new Movie {Id = 3, Name = "Shrek", ReleaseYear = 2001}
            };
        }
        // GET: api/values
        [HttpGet]
        public IActionResult Get() => Ok(movies);

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            if (movies != null)
                return Ok(movies.FirstOrDefault(x => x.Id == id));
            return 
        }

        //{
        //    return Ok();
        //}

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }

    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ReleaseYear { get; set; }
    }
}
