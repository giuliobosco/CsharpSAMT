using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using _03_Laurea.DA;

namespace _03_Laurea.WEB.Controllers
{
    public class AreaController : Controller {
        private LaureaContext ctx;

        public AreaController() {
            ctx = new LaureaContext();
        }

        // GET: Area
        public ActionResult Index() {
            var risultati = from a in ctx.Aree
                orderby a.Nome
                select a;
            return View(risultati);
        }

        // GET: Area/Details/5
        public ActionResult Details(int? id)
        {
            if (id is null) {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var risultati = from a in ctx.Aree
                where a.Id == id
                select a;

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
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

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
            return View();
        }

        // POST: Area/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

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
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
