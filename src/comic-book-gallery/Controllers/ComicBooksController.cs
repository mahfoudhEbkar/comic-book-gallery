using comic_book_gallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using comic_book_gallery.Data;

namespace comic_book_gallery.Controllers
{
    public class ComicBooksController : Controller
    {
        private ComicBookRepository _comicBookRepository = null;

        public ComicBooksController()
        {
             _comicBookRepository = new ComicBookRepository();
        }
        

        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            var comicBook = _comicBookRepository.GetComicBook((int)id);

            if (comicBook == null)
            {
                return HttpNotFound();
            }
            return View(comicBook);

        }

        public ActionResult Index()
        {
 
            var comicBooks = _comicBookRepository.GetComicBooks();

            ViewBag.comicBooks = comicBooks;
            return View(comicBooks);

        }

    }
}