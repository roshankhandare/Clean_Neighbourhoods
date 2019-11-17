using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using QuickTypeVProperty;

namespace SafeNeighbourhood.Pages
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {
            using (var webClient = new WebClient())
            {
                string propertyData = webClient.DownloadString("https://data.cincinnati-oh.gov/resource/w3jp-dfxy.json");

                var property = VacantProperty.FromJson(propertyData);
                ViewData["property"] = property;

            }

        }
    }
}
