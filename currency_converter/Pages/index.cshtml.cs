using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace currency_converter.Pages
{
    public class currencyconverterModel : PageModel
    {
        private readonly ILogger<currencyconverterModel> _logger;

        [BindProperty]
        public String FullCurr { get; set; }

        [BindProperty]
        public String currency { get; set; }

        [BindProperty]
        public double amount { get; set; }

        public currencyconverterModel(ILogger<currencyconverterModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {

        }
        public void OnPost()
        {
            if (currency == "Pounds")
                {
                amount = amount * 1.8;

                string x = amount.ToString();

                @ViewData["Result"] = "€" + x;

            }
            else if (currency == "Euros")
            {

                amount = amount * 0.8;

                string x = amount.ToString();

                @ViewData["Result"] = "£" + x;

            }
            else
            {
                @ViewData["Result"] = "Failed";
            }
        }
    }
}
