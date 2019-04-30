using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pallavolo.DA;
using Pallavolo.DA.Models;

namespace Pallavolo.WEB.Controllers {
	public class GiocatoreController : Controller {
		private readonly AppDbContext _context;

		public GiocatoreController(AppDbContext _context) {
			this._context = _context;
		}

		private bool GiocatoreExists(int id) {
			return _context.Squadre.Any(giocatore => giocatore.Id == id);
		}
		
		// GET
		public async Task<IActionResult> Index() {
			return View(await _context.Giocatori.ToListAsync());
		}

		public async Task<IActionResult> Details(int? id) {
			if (id == null) {
				return NotFound();
			}

			var giocatore = await _context.Giocatori.FirstOrDefaultAsync(g => g.Id == id);

			if (giocatore == null) {
				return NotFound();
			}

			return View(giocatore);
		}

		public IActionResult Create() {
			return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Create(
			[Bind("Nome,Cognome,Nascita,Numero,Id,Added,Modified,Deleted")] Giocatore giocatore) {
			if (ModelState.IsValid) {
				_context.Add(giocatore);
				await _context.SaveChangesAsync();
				return RedirectToAction(nameof(Index));
			}

			return View(giocatore);
		}

		public async Task<IActionResult> Edit(int? id) {
			if (id == null) {
				return NotFound();
			}

			var giocatore = await _context.Giocatori.FindAsync(id);

			if (giocatore == null) {
				return NotFound();
			}

			return View(giocatore);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Edit(
			int id, [Bind("Nome,Cognome,Nascita,Numero,Id,Added,Modified,Deleted")]
			Giocatore giocatore) {
			
			if (id != giocatore.Id) {
				return NotFound();
			}

			if (ModelState.IsValid) {
				try {
					_context.Update(giocatore);
					await _context.SaveChangesAsync();
				} catch (DbUpdateConcurrencyException) {
					if (!GiocatoreExists(giocatore.Id)) {
						return NotFound();
					} else {
						throw;
					}
				}

				return RedirectToAction(nameof(Index));
			}

			return View(giocatore);
		}

		public async Task<IActionResult> Delete(int? id) {
			if (id == null) {
				return NotFound();
			}

			var giocatore = await _context.Giocatori.FirstOrDefaultAsync(g => g.Id == id);

			if (giocatore == null) {
				return NotFound();
			}

			return View(giocatore);
		}

		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> DeleteConfirmed(int id) {
			var giocatore = await _context.Giocatori.FindAsync(id);
			_context.Giocatori.Remove(giocatore);
			await _context.SaveChangesAsync();
			return RedirectToAction(nameof(Index));
		}
	}
}