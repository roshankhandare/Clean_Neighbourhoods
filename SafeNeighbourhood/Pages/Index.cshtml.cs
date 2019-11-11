using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace SafeNeighbourhood.Pages
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {
            using (var webClient = new WebClient())
            {
                string propertyData = webClient.DownloadString("https://data.cincinnati-oh.gov/resource/w3jp-dfxy.json");
                List<QuickType.Property> allProperty = QuickType.Property.FromJson(propertyData);
                IDictionary<string, QuickType.Property> propertDictionary = new Dictionary<string, QuickType.Property>();
                foreach(QuickType.Property property in allProperty)
                {
                    propertDictionary.Add(property.StreetName, property);
                }
                ViewData["allcad"] = allProperty;
            }

        }
    }
}
