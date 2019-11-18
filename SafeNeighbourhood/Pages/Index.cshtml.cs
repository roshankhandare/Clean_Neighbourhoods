using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using QuickTypeVProperty;

namespace SafeNeighbourhood.Pages
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {
            using (var webClient = new WebClient())
            {
                string propertyData = GetData("https://data.cincinnati-oh.gov/resource/w3jp-dfxy.json"); // using a method here for flexibility

                JSchema schema = JSchema.Parse(System.IO.File.ReadAllText("Schema/VacantProperty.json"));
                JArray JsonArray = JArray.Parse(propertyData);

                IList<string> validationEvents = new List<string>();

                if (JsonArray.IsValid(schema))
                {
                    VacantProperty[] property = VacantProperty.FromJson(propertyData);
                    ViewData["property"] = property;
                } else
                {
                    foreach (string evt in validationEvents)
                    {
                        Console.WriteLine(evt);
                    }
                    ViewData["property"] = new List<VacantProperty>();
                }

            }

        }

        public string GetData(string endpoint)
        {
            string downloadedData = "";
            using (WebClient webClient = new WebClient())
            {
                downloadedData = webClient.DownloadString(endpoint);
            }
            return downloadedData;
        }
    }
}
