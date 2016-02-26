using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LastBox.Models;

namespace LastBox.Controllers
{
    public class SubscriptionController : Controller
    {
        private RegisteredUserDbContext db = new RegisteredUserDbContext();

        // GET: Subscription
        public ActionResult Index()
        {
            return View(db.UserSubscriptions.ToList());
        }

        // GET: Subscription/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserSubscription userSubscription = db.UserSubscriptions.Find(id);
            if (userSubscription == null)
            {
                return HttpNotFound();
            }
            return View(userSubscription);
        }

        // GET: Subscription/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Subscription/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,SubscriptionCost,TotalSubscriptionCost")] UserSubscription userSubscription)
        {
            if (ModelState.IsValid)
            {
                db.UserSubscriptions.Add(userSubscription);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(userSubscription);
        }

        // GET: Subscription/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserSubscription userSubscription = db.UserSubscriptions.Find(id);
            if (userSubscription == null)
            {
                return HttpNotFound();
            }
            return View(userSubscription);
        }

        // POST: Subscription/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,SubscriptionCost,TotalSubscriptionCost")] UserSubscription userSubscription)
        {
            if (ModelState.IsValid)
            {
                db.Entry(userSubscription).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(userSubscription);
        }

        // GET: Subscription/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserSubscription userSubscription = db.UserSubscriptions.Find(id);
            if (userSubscription == null)
            {
                return HttpNotFound();
            }
            return View(userSubscription);
        }

        // POST: Subscription/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            UserSubscription userSubscription = db.UserSubscriptions.Find(id);
            db.UserSubscriptions.Remove(userSubscription);
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
