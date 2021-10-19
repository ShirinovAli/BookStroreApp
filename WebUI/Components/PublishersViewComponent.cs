using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Components
{
    public class PublishersViewComponent : ViewComponent
    {
        private IPublisherService _publisherService;

        public PublishersViewComponent(IPublisherService publisherService)
        {
            _publisherService = publisherService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var publishers = await _publisherService.GetAllAsync();
            return View(publishers.Data);
        }
    }
}
