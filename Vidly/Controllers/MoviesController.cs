using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            //return View(movie);
            //return Content("Hello World");
            //return HttpNotFound();
            //retur new EmptyResult();  
            //return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" });  

            var movies = new List<Movie>
            {
                new Movie {Id = 1, Name = "Shrek"},
                new Movie {Id = 2, Name = "Wall-e"}
            };
            var viewModel = new RandomMoviesViewModel
            {
                Movies = movies
            };

            return View(viewModel);
        }

        public ActionResult Edit(int id)
        {
            return Content("id = " + id);
        }

        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1, 12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }

        [Route("movies/details/{id}")]
        public ActionResult Details (int id)
        {
            var viewModel = new MovieViewModel();
            
            if(id == 1)
            {
                viewModel.Movie = new Movie { Id = 1, Name = "Shrek" };
                return View(viewModel);
            }
            else if(id == 2)
            {
                viewModel.Movie = new Movie { Id = 2, Name = "Wall-e" };
                return View(viewModel);
            }
            else
            {
                return HttpNotFound();
            }
        }
    }
}