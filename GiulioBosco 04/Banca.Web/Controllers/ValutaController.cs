using System;
using Banca.DA.Models;
using Banca.DA.Services;
using Microsoft.AspNetCore.Mvc;

namespace Banca.Web.Controllers {
	public class ValutaController : Controller {

		private IValutaRepository ctx;

		public ValutaController(IValutaRepository repository) {
			ctx = repository;
		}
		
		// GET
		public IActionResult Index() {
			return View(ctx.Get());
		}

		public ActionResult Details(int id) {
			var risultato = ctx.Get(id);

			if (risultato is null) {
				return NotFound();
			}

			return View(risultato);
		}

		public ActionResult Create() {
			return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create(Valuta dati) {
			try {
				ctx.Insert(dati);
				return RedirectToAction(nameof(Index));
			} catch {
				return View();
			}
		}

		public ActionResult Edit(int id) {
			var risultato = ctx.Get(id);

			if (risultato is null) {
				return NotFound();
			}

			return View(risultato);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Edit(Valuta dati) {
			try {
				ctx.Update(dati);
				return RedirectToAction(nameof(Index));
			} catch {
				return View();
			}
		}

		public ActionResult Delete(int id) {
			var risultato = ctx.Get(id);

			if (risultato is null) {
				return NotFound(nameof(Index));
			}

			return View(risultato);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Delete(Valuta dati) {
			try {
				ctx.Delete(dati);
				return RedirectToAction(nameof(Index));
			} catch {
				return View();
			}
		}
	}
}