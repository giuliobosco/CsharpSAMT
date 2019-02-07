using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using _01_Laurea.DA;
using _01_Laurea.DA.Model;

namespace _01_Laurea.WEB.Controllers
{
    public class AreaController : Controller {
        private LaureeContext ctx;

        public AreaController() {
            ctx = new LaureeContext();
        }
        // GET: Area
        public ActionResult Index()
        {
            var aree = from t in ctx.Aree
                orderby t.Nome
                select t;
            return View(aree);
        }

        // GET: Area/Details/5
        public ActionResult Details(int id) {
            var aree = from a in ctx.Aree
                where a.Id == id
                       select a;
            return View(aree);
        }

        // GET: Area/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Area/Create
        [HttpPost]
        public ActionResult Create(Area area)
        {
            try
            {
                // TODO: Add insert logic here
                ctx.Entry(area).State = EntityState.Added;
                ctx.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Area/Edit/5
        public ActionResult Edit(int id)
        {
            if (id is null) {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var dati = from t in ctx.Aree
                where t.Id == id
                select t;

            if (dati.Count() == 0) {
                return HttpNotFound();
            }

            return View(dati.FirstOrDefault());
        }

        // POST: Area/Edit/5
        [HttpPost]
        public ActionResult Edit(Area area)
        {
            try
            {
                // TODO: Add update logic here
                ctx.Entry(area).State = EntityState.Modified;
                ctx.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Area/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Area/Delete/5
        [HttpPost]
        public ActionResult Delete(Area area)
        {
            try
            {
                // TODO: Add delete logic here
                ctx.Entry(area).State = EntityState.Deleted;
                ctx.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
