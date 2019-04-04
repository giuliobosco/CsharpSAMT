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

		public Action Create() {
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

	}
}