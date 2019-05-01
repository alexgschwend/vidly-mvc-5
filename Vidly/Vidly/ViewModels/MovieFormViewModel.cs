using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class MovieFormViewModel
    {
        public IEnumerable<GenreType> GenreTypes { get; set; }

        public int? Id { get; set; }

        [Required]
        public string Name { get; set; }


        [Required]
        [Display(Name = "Release Date")]
        public DateTime? ReleaseDate { get; set; }

        [Required]
        [Display(Name = "Number in Stock")]
        [Range(1, 20)]
        public short? NumberInStock { get; set; }

        [Required]
        [Display(Name = "Genre")]
        public byte? GenreTypeId { get; set; }

        public string Title
        {
            get
            {
                return Id != 0 ? "Edit Movie" : "New Movie";
            }
        }

        public MovieFormViewModel()
        {
            this.Id = 0;
        }

        public MovieFormViewModel(Movie movie)
        {
            this.Id = movie.Id;
            this.Name = movie.Name;
            this.ReleaseDate = movie.ReleaseDate;
            this.NumberInStock = movie.NumberInStock;
            this.GenreTypeId = movie.GenreTypeId;
        }
    }
}