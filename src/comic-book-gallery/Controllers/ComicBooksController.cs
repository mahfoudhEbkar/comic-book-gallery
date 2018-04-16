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

        public ActionResult Detail()
        {
            var comicBookRepository = new ComicBookRepository();
            var comicBook = comicBookRepository.GetComicBook(1);
            
            return View(comicBook);

        }
    }
}