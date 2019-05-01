
using System;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }


        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }
        public DateTime DateAdded { get; set; }

        [Required]
        [Display(Name = "Number in Stock")]
        public short NumberInStock { get; set; }

        public GenreType GenreType { get; set; }
        
        [Required]
        [Display(Name = "Genre")]
        public byte GenreTypeId { get; set; }

    }
}