﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using krabdev.Models;

namespace krabdev.Controllers
{
    public class TestController : Controller
    {
        private Context db = new Context();

        //
        // GET: /Test/

        public ActionResult Index()
        {
            return View(db.FAQs.ToList());
        }

        //
        // GET: /Test/Details/5

        public ActionResult Details(int id = 0)
        {
            FAQ faq = db.FAQs.Find(id);
            if (faq == null)
            {
                return HttpNotFound();
            }
            return View(faq);
        }

        //
        // GET: /Test/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Test/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(FAQ faq)
        {
            if (ModelState.IsValid)
            {
                db.FAQs.Add(faq);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(faq);
        }

        //
        // GET: /Test/Edit/5

        public ActionResult Edit(int id = 0)
        {
            FAQ faq = db.FAQs.Find(id);
            if (faq == null)
            {
                return HttpNotFound();
            }
            return View(faq);
        }

        //
        // POST: /Test/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(FAQ faq)
        {
            if (ModelState.IsValid)
            {
                db.Entry(faq).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(faq);
        }

        //
        // GET: /Test/Delete/5

        public ActionResult Delete(int id = 0)
        {
            FAQ faq = db.FAQs.Find(id);
            if (faq == null)
            {
                return HttpNotFound();
            }
            return View(faq);
        }

        //
        // POST: /Test/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            FAQ faq = db.FAQs.Find(id);
            db.FAQs.Remove(faq);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}