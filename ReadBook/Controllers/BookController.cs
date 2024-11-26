using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ReadBook.Controllers
{
    public class BookController : ApiController
    {
        [HttpPost]
        [Route("api/Book/Read")]
        public HttpResponseMessage Read()
        {
            HttpResponseMessage responseMessage = new HttpResponseMessage();
            Book book = new Book
            {
                Id = 1,
                Title = "Helloo World",
                Author = "C#",
                Created = DateTime.Now,
            };
            return Request.CreateResponse(HttpStatusCode.OK, book);
        }
    }
}
