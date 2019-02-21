using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Torta.WEB.Controllers
{
    public class TortaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}