using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace AureliaTutorial.Api.Controllers
{
    [RoutePrefix("movies")]
    public class MoviesController : ApiController
    {
        private IList<Movie> movies = new List<Movie>
            {
                new Movie {id = 1, name = "Star Wars", releaseYear = 1979},
                new Movie {id = 2, name = "Star Trek", releaseYear = 2014},
                new Movie {id = 3, name = "Shrek", releaseYear = 2001}
            };

        //[HttpGet]
        //[Route("")]
        public IEnumerable<Movie> Get() => movies;

        //[HttpGet]
        //[Route("{id}")]
        public Movie Get(int id)
        {
            return movies.FirstOrDefault(x => x.id == id);
        }
    }

    public class Movie
    {
        public int id { get; set; }
        public string name { get; set; }
        public int releaseYear { get; set; }
    }
}
