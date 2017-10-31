using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SurfingMvC.Models;

namespace SurfingMvC.Controllers
{
    public class surfsController : Controller
    {
        private surfDBContext db = new surfDBContext();

        // GET: surfs
        public ActionResult Index(string continent, string searchstring)
        {
            var continentlist = new List<string>();

            var continentsearch = from c in db.surfs
                                  orderby c.Continent
                                  select c.Continent;

            continentlist.AddRange(continentsearch.Distinct());
            ViewBag.continent = new SelectList(continentlist);

            var search = from s in db.surfs
                         select s;

            if(!String.IsNullOrEmpty(searchstring))
            {
                search = search.Where(n => n.Location.Contains(searchstring));
            }

            if(!String.IsNullOrEmpty(continent))
            {
                search = search.Where(x => x.Continent == continent);
            }

            return View(search);

        }

        // GET: surfs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            surf surf = db.surfs.Find(id);
            if (surf == null)
            {
                return HttpNotFound();
            }
            return View(surf);
        }

        // GET: surfs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: surfs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Picture,Location,Continent,Wave_Size,Wave_type,Level,Description")] surf surf)
        {
            if (ModelState.IsValid)
            {
                db.surfs.Add(surf);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(surf);
        }

        // GET: surfs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            surf surf = db.surfs.Find(id);
            if (surf == null)
            {
                return HttpNotFound();
            }
            return View(surf);
        }

        // POST: surfs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Picture,Location,Continent,Wave_Size,Wave_type,Level,Description")] surf surf)
        {
            if (ModelState.IsValid)
            {
                db.Entry(surf).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(surf);
        }

        // GET: surfs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            surf surf = db.surfs.Find(id);
            if (surf == null)
            {
                return HttpNotFound();
            }
            return View(surf);
        }

        // POST: surfs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            surf surf = db.surfs.Find(id);
            db.surfs.Remove(surf);
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
