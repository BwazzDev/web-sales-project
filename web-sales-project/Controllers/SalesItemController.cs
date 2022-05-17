using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using web_sales_project.DAL;
using web_sales_project.Models;

namespace web_sales_project.Controllers
{
    public class SalesItemController : Controller
    {
        private ShopContext db = new ShopContext();

        // GET: SalesItem
        public ActionResult Index(string searchString)
        {
            var salesItems = from s in db.SalesItems select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                salesItems = salesItems.Where(s => s.Name.Contains(searchString));
            }

            return View(salesItems.ToList());
        }

        // GET: SalesItem/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            SalesItem salesItem = db.SalesItems.Find(id);
            if (salesItem == null)
            {
                return HttpNotFound();
            }

            return View(salesItem);
        }

        // GET: SalesItem/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SalesItem/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(
            [Bind(Include = "Id,Name,Price,Quantity,ListingTimeStamp,Description,ImageUrl,SellerId,SalesCategory")]
            SalesItem salesItem)
        {
            if (ModelState.IsValid)
            {
                db.SalesItems.Add(salesItem);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(salesItem);
        }

        // GET: SalesItem/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            SalesItem salesItem = db.SalesItems.Find(id);
            if (salesItem == null)
            {
                return HttpNotFound();
            }

            return View(salesItem);
        }

        // POST: SalesItem/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(
            [Bind(Include = "Id,Name,Price,Quantity,ListingTimeStamp,Description,ImageUrl,SellerId,SalesCategory")]
            SalesItem salesItem)
        {
            if (ModelState.IsValid)
            {
                db.Entry(salesItem).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(salesItem);
        }

        // GET: SalesItem/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            SalesItem salesItem = db.SalesItems.Find(id);
            if (salesItem == null)
            {
                return HttpNotFound();
            }

            return View(salesItem);
        }

        // POST: SalesItem/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SalesItem salesItem = db.SalesItems.Find(id);
            db.SalesItems.Remove(salesItem);
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