using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter a title name")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Please enter a year date")]
        public int Year { get; set; }
        [Required(ErrorMessage = "Please enter a price")]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
        [Required(ErrorMessage = "Please enter a genre name")]
        public string Genre { get; set; }
        [Required(ErrorMessage = "Please enter a genre name")]
        public string AuthorName { get; set; }
    }


    public class BookContext:DbContext
    {
        public BookContext(DbContextOptions<BookContext> options) : base(options) { }

        public DbSet<Book> Books { get; set; }
    }
}
