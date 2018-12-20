using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _101_Mercatino.Models;

namespace _101_Mercatino.Controllers
{
    public class MercatinoController : Controller
    {
        DataContext ctx = new DataContext();

        // GET: Mercatino
        public ActionResult Index() {
            var dati = ctx.Mercatini.OrderBy(m => m.Luogo);
            return View(dati);
        }

        public ActionResult Details(int id) {
            var dati = ctx.Mercatini.FirstOrDefault(m => m.Id == id);
            return View(dati);
        }

        public ActionResult Edit(int id) {
            var dati = ctx.Mercatini.FirstOrDefault(m => m.Id == id);
            return View(dati);
        }

        [HttpPost]
        public ActionResult Edit(int id, Mercatino dato) {
            try {
                var dati = ctx.Mercatini.FirstOrDefault(m => m.Id == id);
                dati.Luogo = dato.Luogo;
                dati.Nazione = dato.Nazione;

                return RedirectToAction(nameof(Index));
            }
            catch {
                return View();
            }
        }

    }
}