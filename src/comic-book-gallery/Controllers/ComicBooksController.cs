using comic_book_gallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace comic_book_gallery.Controllers
{
    public class ComicBooksController : Controller
    {

        public ActionResult Detail()
        {
            var comicBook = new ComicBook()
            {
                SeriesTitle = "The Amazing Spider-Man",
                IssueNumber = 700,
                Favorite = true,
                DescriptionHtml = "<p>" +
                        "Final issue! Witness the final hours of Doctor Octopus' life and his one, " +
                        "last, great act of revenge! Even if Spider-Man survives... " +
                        "<strong>will Peter Parker?</strong></p>",

                Artists = new Artist[]
                {
                    new Artist() { Role= "script", Name = "dan slott"},
                    new Artist() { Role= "pencils", Name = "humberto ramos"},
                    new Artist() { Role= "inks", Name = "victor olazaba"},
                    new Artist() { Role= "colors", Name = "edgar delgado"},
                    new Artist() { Role= "letters", Name = "chris eliopoulos"},

                }

            };


            return View(comicBook);

        }
    }
}