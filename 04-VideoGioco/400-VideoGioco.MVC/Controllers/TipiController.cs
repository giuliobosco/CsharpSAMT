using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _400_VideoGioco.MVC.Controllers
{
    public class TipiController : Controller {

        // GET: Tipi
        public ActionResult Index()
        {
            return View();
        }

        // GET: Tipi/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Tipi/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tipi/Create
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

        // GET: Tipi/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Tipi/Edit/5
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

        // GET: Tipi/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Tipi/Delete/5
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
