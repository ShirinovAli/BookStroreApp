using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;

namespace WebUI.Controllers
{
    public class PublishersController : Controller
    {
        private IPublisherService _publisherService;

        public PublishersController(IPublisherService publisherService)
        {
            _publisherService = publisherService;
        }
        public async Task<IActionResult> List()
        {
            var publishers = await _publisherService.GetAllAsync();
            return View(publishers.Data);
        }
    }
}
