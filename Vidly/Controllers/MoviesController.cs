﻿using System;
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
        public ViewResult Index()
        {
            var movies = GetMovies();

            return View(movies);
        }

        public ActionResult Details (int id)
        {
            var movie = GetMovies().SingleOrDefault(m => m.Id == id);

            if(movie == null)
            {
                return HttpNotFound();
            }

            return View(movie);
        }

        public IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie {Id = 1, Name = "Shrek !"},
                new Movie {Id = 2, Name = "Wall-e"}
            };
        }
    }
}