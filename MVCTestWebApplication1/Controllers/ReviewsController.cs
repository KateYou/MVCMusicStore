using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVCTestWebApplication1.Models;

namespace MVCTestWebApplication1.Controllers
{
    public class ReviewsController : Controller
        //This is called "scaffolding".  See http://www.asp.net/visual-studio/overview/2013/aspnet-scaffolding-overview. CTRL-Shift-B before making Controller.
        //Creating this Controller creates a new views folder in Views, "Reviews", and thus the new Reviews page on website,  
        //like http://localhost/Reviews.  MVC auto-sets up URLs for you.
        //VS auto-gets it from the Review class I created, Review.cs.  So there is also the potential for an Artist Controller and Artist site page and 
        //an Album Controller and Album site page.  All the classes on this page like Create, Delete, Index are auto-created templates by VS and now 
        //appear in VS sidebar and become new views.  Data on Reviews page is displayed in html table.
        //So: Add Class (a new Model) -> Add Controller from class -> makes new website page

    {
        private MVCTestWebApplication1Context db = new MVCTestWebApplication1Context();



        // GET: Reviews
        public ActionResult Index()
        {
            var reviews = db.Reviews.Include(r => r.Album);
            return View(reviews.ToList());
        }



        // GET: Reviews/Details/5
        public ActionResult Details(int? id)  // creates the Details view, requires parameter of review ID. Thus, url "Reviews/Details/5"  5=ID
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Review review = db.Reviews.Find(id);

            if (review == null)
            {
                return HttpNotFound();
            }

            return View(review);
        }



        // GET: Reviews/Create
        public ActionResult Create()
        {
            ViewBag.AlbumID = new SelectList(db.Albums, "AlbumID", "Title");
            return View();
        }



        // POST: Reviews/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ReviewID,AlbumID,Contents,ReviewerEmail")] Review review)
        {
            if (ModelState.IsValid)
            {
                db.Reviews.Add(review);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.AlbumID = new SelectList(db.Albums, "AlbumID", "Title", review.AlbumID);
            return View(review);
        }



        // GET: Reviews/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Review review = db.Reviews.Find(id);
            if (review == null)
            {
                return HttpNotFound();
            }
            ViewBag.AlbumID = new SelectList(db.Albums, "AlbumID", "Title", review.AlbumID);
            return View(review);
        }



        // POST: Reviews/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ReviewID,AlbumID,Contents,ReviewerEmail")] Review review)
        {
            if (ModelState.IsValid)
            {
                db.Entry(review).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.AlbumID = new SelectList(db.Albums, "AlbumID", "Title", review.AlbumID);
            return View(review);
        }



        // GET: Reviews/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Review review = db.Reviews.Find(id);
            if (review == null)
            {
                return HttpNotFound();
            }
            return View(review);
        }



        // POST: Reviews/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Review review = db.Reviews.Find(id);
            db.Reviews.Remove(review);
            db.SaveChanges();
            return RedirectToAction("Index");
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
