using krabdev.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace krabdev.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        Context _db = new Context();

        public ActionResult Index()
        {
            return View();
        }
        
        [AllowAnonymous]
        public ActionResult FAQ()
        {
            var model =
                 from r in _db.FAQs
                 orderby r.FAQId
                 select r;
            return View(model);
        }

        // get / create
        public ActionResult Create()
        {
            return View();
        }

        //post / create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(FAQ faq)
        {
            if (ModelState.IsValid)
            {
                _db.FAQs.Add(faq);
                _db.SaveChanges();
                return RedirectToAction("FAQ");
            }
            return RedirectToAction("FAQ");
        }

        // get / edit 

        public ActionResult Edit(int id = 0)
        {
            FAQ faq = _db.FAQs.Find(id);
            if (faq == null)
            {
                return HttpNotFound();
            }
            return View(faq);
        }

        //post / edit

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(FAQ faq)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(faq).State = EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("FAQ");
            }
            return View(faq);
        }
    }
}
