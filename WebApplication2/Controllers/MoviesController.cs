using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Index()
        {
            var movies = GetMovies();
            return View(movies);
        }

        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie
                {
                    Name ="Shrek"
                },
                new Movie
                {
                    Name = "Wall-e"
                }
            };
        }
    }
}