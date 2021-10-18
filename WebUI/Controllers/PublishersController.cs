using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Controllers
{
    public class PublishersController : Controller
    {
        public IActionResult List()
        {
            return View();
        }
    }
}
