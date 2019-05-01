using System.Collections.Generic;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;
using System.Data.Entity;
using System.Linq;
using System;
using System.Data.Entity.Validation;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext context = new ApplicationDbContext();

        protected override void Dispose(bool disposing)
        {
            context.Dispose();
        }

        public ViewResult Index()
        {
            var movies = context.Movies.Include(m => m.GenreType).ToList();

            return View(movies);    
        }

        public ActionResult Details(int id)
        {
            var movie = context.Movies.Include(m => m.GenreType).SingleOrDefault(m => m.Id == id);

            if (movie == null)
                return HttpNotFound();

            return View(movie);
        }

        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };
            var customers = new List<Customer>
            {
                new Customer { Name = "Customer 1" },
                new Customer { Name = "Customer 2" }
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }

        public ActionResult Edit(int id)
        {
            var movie = context.Movies.SingleOrDefault(m => m.Id == id);

            if (movie == null)
                return HttpNotFound();

            var genreTypes = context.GenreTypes.ToList();
            var viewModel = new MovieFormViewModel()
            {
                Movie = movie,
                GenreTypes = genreTypes
            };

            return View("MovieForm", viewModel);
        }

        public ActionResult New()
        {
            var genreTypes = context.GenreTypes.ToList();
            var viewModel = new MovieFormViewModel()
            {
                GenreTypes = genreTypes
            };

            return View("MovieForm", viewModel);
        }

        [HttpPost]
        public ActionResult Save(Movie movie)
        {
            if(movie.Id == 0)
            {
                movie.DateAdded = DateTime.Now;
                context.Movies.Add(movie);
            }
            else
            {
                var dbMovie = context.Movies.Single(m => m.Id == movie.Id);
                dbMovie.Name = movie.Name;
                dbMovie.ReleaseDate = movie.ReleaseDate;
                dbMovie.GenreTypeId = movie.GenreTypeId;
                dbMovie.NumberInStock = movie.NumberInStock;
            }

            context.SaveChanges();

            return RedirectToAction("Index", "Movies");
        }
    }
}