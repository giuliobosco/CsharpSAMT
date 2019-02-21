using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using _03_Laurea.DA;
using _03_Laurea.DA.Model;
using _03_Laurea.DA.Services;

namespace _03_Laurea.WEB.Controllers
{
    public class AreaController : Controller {
        //private LaureaContext ctx;
        private AreaRepository ctx;

        public AreaController() {
            ctx = new AreaRepository();
        }

        // GET: Area
        public ActionResult Index() {
            //var risultati = from a in ctx.Aree
            //    orderby a.Nome
            //    select a;
            
            //return View(risultati);
            return View(ctx.Get());
        }

        // GET: Area/Details/5
        public ActionResult Details(int? id)
        {
            if (id is null) {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            //var risultati = (from a in ctx.Aree
            //    where a.Id == id
            //    select a).FirstOrDefault();

            var risultati = ctx.Get((int)id);

            if (risultati is null) {
                return HttpNotFound();
            }

            return View(risultati);
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
                //ctx.Entry(area).State = EntityState.Added;
                //ctx.SaveChanges();
                ctx.Insert(area);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Area/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id is null) {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            //var risultati = (from a in ctx.Aree
            //    where a.Id == id
            //    select a).FirstOrDefault();

            var risultati = ctx.Get((int) id);

            if (risultati is null) {
                return HttpNotFound();
            }
            return View(risultati);
        }

        // POST: Area/Edit/5
        [HttpPost]
        public ActionResult Edit(Area area)
        {
            try
            {
                // TODO: Add update logic here
                //ctx.Entry(area).State = EntityState.Modified;
                //ctx.SaveChanges();
                ctx.Update(area);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Area/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id is null) {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            //var risultati = (from a in ctx.Aree
            //    where a.Id == id
            //    select a).FirstOrDefault();
            var risultati = ctx.Get((int) id);
            if (risultati is null) {
                return HttpNotFound();
            }

            return View(risultati);
        }

        // POST: Area/Delete/5
        [HttpPost]
        public ActionResult Delete(Area area)
        {
            try
            {
                // TODO: Add delete logic here
                //ctx.Entry(area).State = EntityState.Deleted;
                //ctx.SaveChanges();
                ctx.Delete(area);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
