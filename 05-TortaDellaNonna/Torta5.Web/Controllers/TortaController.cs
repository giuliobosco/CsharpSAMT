using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Torta.DA.Services;

namespace Torta5.Web.Controllers
{
    public class TortaController : Controller {
        ITortaRepository ctx;

        public TortaController(ITortaRepository repo) {
            ctx = repo;
        }
        public IActionResult Index() {

            var dati = ctx.Get();

            return View(dati);
        }
    }
}