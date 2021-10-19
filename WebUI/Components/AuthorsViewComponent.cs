using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Components
{
    public class AuthorsViewComponent:ViewComponent
    {
        private IAuthorService _authorService;

        public AuthorsViewComponent(IAuthorService authorService)
        {
            _authorService = authorService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var authors =await _authorService.GetAllAsync();
            return View(authors.Data);
        }
    }
}
