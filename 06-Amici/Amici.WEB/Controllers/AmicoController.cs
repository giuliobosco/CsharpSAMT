using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Amici.DA.Services;
using Microsoft.AspNetCore.Mvc;

namespace Amici.WEB.Controllers
{
    public class AmicoController : Controller {
        private IAmicoRepository ctx;

        public AmicoController(IAmicoRepository ctx) {
            this.ctx = ctx;
        }

        public IActionResult Index()
        {
            return View(ctx.Get());
        }
    }
}