using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public interface IRepoBook
    {
        IEnumerable<Book> GetBooks { get; }
        Book GetBook(int id);
        Book AddBook(Book book);
        Book Update(Book book);
        Book Delete(int id);
    }

    public class RepoBook: IRepoBook
    {
        private static List<Book> list = new List<Book>()
        {
               new Book{Id=1, AuthorName="Jessica T", Title="Wind comes", Price=20, Year=2010, Genre="Romane"},
                new Book{Id=2, AuthorName="Loiuse T", Title="The man and the tiger", Price=20, Year=2015, Genre="Adventure"},
                new Book{Id=3, AuthorName="Lorraine Q", Title="Come Out", Price=10, Year=2000, Genre="Comedy"},
                new Book{Id=4, AuthorName="Pierre Francoise T", Title="The sea and the whale", Price=8, Year=2016, Genre="Adventure"},
                new Book{Id=5, AuthorName="Margot Rice", Title="Children and the dog", Price=15, Year=2019, Genre="Adventure"},
                new Book{Id=6, AuthorName="James Paul", Title="Welcome Home", Price=10, Year=2020, Genre="Comedy"},
                new Book{Id=7, AuthorName="Nicole Wallas", Title="Technology and the Future", Price=10, Year=2017, Genre="Science Fiction"},
                new Book{Id=8, AuthorName="Josh Lorraine", Title="The killer return home", Price=10, Year=2017, Genre="Adventure-Action"},
                new Book{Id=9, AuthorName="Adams Freeman", Title="The long drive", Price=10, Year=2015, Genre="Comedy"}
        };

        // getting all books
        public IEnumerable<Book> GetBooks => list;

        // adding one book
        public Book AddBook(Book book)
        {
           list.Add(book);

            return book;
        }

        // delete one book
        public Book Delete(int id)
        {
            var d = list.SingleOrDefault(t => t.Id == id);
            if(d != null)
            {
                list.Remove(d);
            }

            return d;

        }

        // getting one book
        public Book GetBook(int id)
        {
            return list.FirstOrDefault(b => b.Id == id);
        }

        // save a book
        public Book Update(Book book)
        {
            var b = this.GetBook(book.Id);
            if(b != null)
            {
                b = this.AddBook(book);
            }

            return b;


        }
    }
}
