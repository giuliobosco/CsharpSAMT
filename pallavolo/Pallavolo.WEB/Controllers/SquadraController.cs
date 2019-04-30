using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pallavolo.DA;
using Pallavolo.DA.Models;

namespace Pallavolo.WEB.Controllers {
	public class SquadraController : Controller {

		private readonly AppDbContext _context;

		public SquadraController(AppDbContext _context) {
			this._context = _context;
		}

		private bool SquadraExists(int id) {
			return _context.Squadre.Any(squadra => squadra.Id == id);
		}
		
		// GET
		public async Task<IActionResult> Index() {
			return
			View(await _context.Squadre.ToListAsync());
		}

		public async Task<IActionResult> Details(int? id) {
			if (id == null) {
				return NotFound();
			}

			var squarda = await _context.Squadre
			                            .FirstOrDefaultAsync(squadra => squadra.Id == id);

			if (squarda == null) {
				return NotFound();
			}

			return View(squarda);
		}

		public IActionResult Create() {
			return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Create([Bind("Nome,Id,Added,Modified,Deleted")]
		                                        Squadra squadra) {
			if (ModelState.IsValid) {
				_context.Add(squadra);
				await _context.SaveChangesAsync();
				return RedirectToAction(nameof(Index));
			}

			return View(squadra);
		}

		public async Task<IActionResult> Edit(int? id) {
			if (id == null) {
				return NotFound();
			}

			var squadra = await _context.Squadre.FindAsync(id);

			if (squadra == null) {
				return NotFound();
			}

			return View(squadra);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Edit(int id, [Bind("Nome,Id,Added,Modified,Deleted")]
		                                      Squadra squadra) {
			if (id != squadra.Id) {
				return NotFound();
			}

			if (ModelState.IsValid) {
				try {
					_context.Update(squadra);
					await _context.SaveChangesAsync();
				} catch (DbUpdateConcurrencyException) {
					if (!SquadraExists(squadra.Id)) {
						return NotFound();
					} else {
						throw;
					}
				}

				return RedirectToAction(nameof(Index));
			}

			return View(squadra);
		}

		public async Task<IActionResult> Delete(int? id) {
			if (id == null) {
				return NotFound();
			}

			var squadra = await _context.Squadre.FirstOrDefaultAsync(s => s.Id == id);

			if (squadra == null) {
				return NotFound();
			}

			return View(squadra);
		}


		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> DeleteConfirmed(int id) {
			var squadra = await _context.Squadre.FindAsync(id);
			_context.Squadre.Remove(squadra);
			await _context.SaveChangesAsync();
			return RedirectToAction(nameof(Index));
		}
	}
}