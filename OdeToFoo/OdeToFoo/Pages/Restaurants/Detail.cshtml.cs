using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OdeToFood.core;

namespace OdeToFoo.Pages.Restaurants
{
    public class DetailModel : PageModel
    {
        public Restaurant Restaurant{ get; set; }

        public void OnGet(int restraurantId)
        {
            Restaurant = new Restaurant();
            Restaurant.Id = restraurantId;
        }
    }
}