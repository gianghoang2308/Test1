using Microsoft.AspNetCore.Mvc;
using NetCoreMVCLab03.Models;

namespace NetCoreMVCLab03.Controllers
{
    
    public class BookController : Controller
    {
        protected Book book = new Book();
        public IActionResult Index()
        {
            ViewBag.AuthorsList = book.Authors;
            ViewBag.GenresList = book.Genres;
            var books = book.GetBookList();
            return View(books);
        }
        public IActionResult Create()
        {

            ViewBag.AuthorsList = book.Authors;
            ViewBag.GenresList = book.Genres;
            Book model = new Book();
            return View(model);
        }
        public IActionResult Edit(int id)
        {
            ViewBag.AuthorsList = book.Authors;
            ViewBag.GenresList = book.Genres;
            Book model = book.GetBookById(id);
            return View(model);
        }

        public PartialViewResult Popularbook()
        {
            var books = book.GetBookList();
            return PartialView(books);
        }

    }
}
