using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CowboyCafe.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Website.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public string SearchTerms { get; set; }

        public int MinCalories { get; set; }
        public int MaxCalories { get; set; }
        public int PriceMin { get; set; }
        public int PriceMax { get; set; }
        public bool EntreeSelected { get; set; }
        public bool DrinkSelected { get; set; }
        public bool SideSelected { get; set; }

        public void OnGet()
        {
            SearchTerms = Request.Query["SearchTerms"];
            int d = 0;
            if(int.TryParse(Request.Query["MinCalories"], out d))
            {
                MinCalories = d;
            }
            int f = 0;
            if(int.TryParse(Request.Query["MaxCalories"], out f))
            {
                MaxCalories = f;
            }
            foreach(string s in Request.Query["TypeFood"])
            {
                if (s.Equals("Entree"))
                {
                    EntreeSelected = true;
                }
                if (s.Equals("Side"))
                {
                    SideSelected = true;
                }
                if (s.Equals("Drink"))
                {
                    DrinkSelected = true;
                }
            }


        }
    }
}
