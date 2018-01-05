using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/Books")]
    public class BooksController : Controller
    {

        private IRepoBook repo;
        
        public BooksController(IRepoBook _repo)
        {
            repo = _repo;
        }

        // GET: api/Books
        [HttpGet]
        public IActionResult GetBooks()
        {
            return this.Ok(repo.GetBooks);
        }

        // GET: api/Books/5
        [HttpGet("{id}")]
        public IActionResult GetBook(int id)
        {
            var book = repo.GetBook(id);
            if (book != null)
            {
                return this.Ok(book);
            }
            else
            {
                return this.NotFound();
            }
        }
        
        // POST: api/Books
        [HttpPost]
        public IActionResult PostBook([FromBody]Book book)
        {
            repo.AddBook(book);

            return this.Ok(book);
        }
        
        // PUT: api/Books/5
        [HttpPut("{id}")]
        public IActionResult PutBook(int id, [FromBody]Book book)
        {
            book.Id = id;
            if(repo.Update(book) == null)
            {
                return this.NotFound();
            }else
            {
                return this.Ok(book.Id);
            }
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var q = repo.Delete(id);
            if(q != null)
            {
                return this.NotFound();
            } else
            {
                return this.Ok(q.Id);
            }
        }
    }
}
