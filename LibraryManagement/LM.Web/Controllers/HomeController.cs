using LM.BuisnessEntities;
using LM.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LM.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBookService _bookService;
        public HomeController (IBookService bookService)
	    {
                this._bookService = bookService;
	    }
        public ActionResult Index()
        {
            Book book = new Book{
                Name = "Test Book",
                AuthorId = 1,
            };
            Book newbook = _bookService.Create(book);
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}