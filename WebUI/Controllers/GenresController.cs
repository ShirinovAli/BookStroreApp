using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Controllers
{
    public class GenresController : Controller
    {
        public IActionResult List()
        {
            return View();
        }
    }
}
