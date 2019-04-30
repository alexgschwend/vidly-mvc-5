
using System;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public DateTime DateAdded { get; set; }
        [Required]
        public short NumberInStock { get; set; }
        public GenreType GenreType { get; set; }
        public byte GenreTypeId { get; set; }

    }
}