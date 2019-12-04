using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using QuickType;

namespace SafeNeighbourhood.Pages
{
    public class ClassmatesJsonModel : PageModel
    {
        public void OnGet()
        {
            using (WebClient webClient = new WebClient())
            {
                

                string breweryData = webClient.DownloadString("https://breweryratings20191109050130.azurewebsites.net/Privacy");
                List<BreweryData> Breweries = BreweryData.FromJson(breweryData);
                ViewData["Breweries"] = Breweries;
                

            }

        }
    }
}