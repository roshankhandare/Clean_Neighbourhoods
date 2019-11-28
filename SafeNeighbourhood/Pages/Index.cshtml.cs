using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using QuicktypeNeighborhood;
using QuicktypeProperty;

namespace SafeNeighbourhood.Pages
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {
            using (var webClient = new WebClient())
            {
                //Get Summary Neighborhood Cleanliness Data
                string neighborhoodData = webClient.DownloadString("https://data.cincinnati-oh.gov/resource/h8mv-4fsc.json");
                List<NeighborhoodData> neighborhoods = NeighborhoodData.FromJson(neighborhoodData);

                //Get Vacant Properties in Cincinnati
                string propertyData = webClient.DownloadString("https://data.cincinnati-oh.gov/resource/w3jp-dfxy.json");
                IEnumerable<PropertyData> properties = PropertyData.FromJson(propertyData);

                //Filter Vacant Properties by truly Vacant Properties
                IEnumerable<PropertyData> vacantProperties = properties.Where(property => property.DataStatusDisplay.Contains("Vacant"));

                //Sort Vacant Properties by Neighborhood and Unique ID for better display on View
                vacantProperties = vacantProperties.OrderBy(x => x.Neighborhood).ThenBy(x => x.Uniqueid);

                ViewData["VacantProperties"] = vacantProperties;
                ViewData["Neighborhoods"] = neighborhoods;
            }

        }
    }
}
