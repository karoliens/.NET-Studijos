using ApiMokymai;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ApiMokymai.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        List<Book> books = new List<Book>
        {
                new Book { Id = 1, Title = "Harry Potter and the Sorcerer’s Stone", Author = "J.K. Rowling", Year = 1997 },
                new Book { Id = 2, Title = "Harry Potter and the Chamber of Secrets", Author = "J.K. Rowling", Year = 1998 },
                new Book { Id = 3, Title = "Harry Potter and the Prisoner of Azkaban", Author = "J.K. Rowling", Year = 1999 },
                new Book { Id = 4, Title = "Harry Potter and the Goblet of Fire", Author = "J.K. Rowling", Year = 2000 },
                new Book { Id = 5, Title = "Harry Potter and the Order of the Phoenix", Author = "J.K. Rowling", Year = 2003 },
                new Book { Id = 6, Title = "Harry Potter and the Half-Blood Prince", Author = "J.K. Rowling", Year = 2005 },
                new Book { Id = 7, Title = "Harry Potter and the Deathly Hallows", Author = "J.K. Rowling", Year = 2007 },
                new Book { Id = 8, Title = "Harry Potter and the Cursed Child", Author = "J.K. Rowling", Year = 2016 },
                new Book { Id = 9, Title = "The Handmaid's Tale", Author = "Margaret Atwood", Year = 1985 },
                new Book { Id = 10, Title = "A Game of Thrones", Author = "George R. R. Martin", Year = 1996 }
            };


      

        [HttpGet("{id}")]
        public Book? GetBookById(int id)
        {
            return books.FirstOrDefault(b => b.Id == id);
        }

        [HttpGet]
        public Book? GetBookByTitle(string title)
        {
            return books.FirstOrDefault(b => b.Title == title);
        }


        [HttpGet("by")] 
        public Book? GetBookByTitleAndAuthor(string title, string author)
        {
            return books.FirstOrDefault(b => b.Title == title && b.Author == author);
        }

        [HttpGet("filter")]
        public IEnumerable<Book>? FilterByTitleAndAuthor(string? title, string? author)
        {
            //var allCapsTitle = title.ToUpper();

            var filteredBooksByTitle = books.Where(book => book.Title.Contains(title));
            var filteredBooksByAuthor = books.FindAll(book => book.Author == author);

            
            if (title != null && author == null)
            {
                return filteredBooksByTitle;
            }

            else if (title == null && author != null)
            {
                return filteredBooksByAuthor;
            }

            else
            {
                return null;
            }
        }
    }
}
