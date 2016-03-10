using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ELibrary.Models;
using Microsoft.AspNet.Identity;
using WebGrease.Css.Extensions;

namespace ELibrary.Controllers
{
    public class BooksController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Books
        public ActionResult Index()
        {
            return View(db.AllBooks.ToList());
        }

        // GET: Books/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Book book = db.AllBooks.Find(id);
            return View(book);
        }

        // GET: Books/MyBookList/5
        public ActionResult Retrieve(int? id)
        {
            Book book = db.AllBooks.Find(id);
            if (db.Users.Single(x => User.Identity.Name == x.UserName).MyBooks.Contains(book))
            {
                db.AllBooks.Find(id).Available = true;
                db.Users.Single(x => User.Identity.Name == x.UserName).MyBooks.Remove(book);
                db.SaveChanges();
            }
            return View();
        }

        // GET: Books/MyBookList/5
        public ActionResult MyBookList()
        {
            if (User.Identity.IsAuthenticated == false)
            {
                ViewBag.Head = "Сначала авторизуйтесь!";
                return View(new List<Book>());
            }
            ViewBag.Head = "Список ваших книг:";
            var myBooks = db.Users.First(y => y.UserName == User.Identity.Name).MyBooks;

            if (myBooks == null || myBooks.Count == 0)
            {
                return View(new List<Book>());
            }
            return View(myBooks.ToList());
        }

        // GET: Books/Details/5
        public ActionResult Add(int? id)
        {
            Book book = db.AllBooks.Find(id);
            if (book.Available==true)
            {
                db.AllBooks.Find(id).Available = false;
                db.Users.Single(x => User.Identity.Name == x.UserName).MyBooks.Add(book);
                db.SaveChanges();
                ViewBag.Head = "Книга была добавлена к вам.";
                return View();
            }
            ViewBag.Head = "Книга уже в вашем списке!";
            return View();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
