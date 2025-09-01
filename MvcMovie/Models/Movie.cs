using System;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Movie 
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; } = string.Empty;

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [StringLength(50)]
        public string? Genre { get; set; }

        [Range(0, 1000)]
        [DataType(DataType.Currency)]
        public decimal? Price { get; set; }
    }
}
