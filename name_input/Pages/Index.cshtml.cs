using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace name_input.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        [BindProperty]
        public String FullName { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }

        public void OnPost()
        {
            this.FullName = Request.Form["name"];

            if (String.IsNullOrWhiteSpace(FullName))
            {
                ViewData["Message"] = " ";
            }
            else
            {
                ViewData["Message"] = FullName + " registered successfully!";
            }



        }
    }
}
