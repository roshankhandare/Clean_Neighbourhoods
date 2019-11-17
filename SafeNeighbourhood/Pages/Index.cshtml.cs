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
            string propertyData = GetData("https://data.cincinnati-oh.gov/resource/w3jp-dfxy.json");
            //string propSchema = System.IO.File.ReadAllText("Schema/VacantProperty.json");

            //var property = VacantProperty.FromJson(propertyData);
            QuickTypeVProperty.VacantProperty[] properties = QuickTypeVProperty.VacantProperty.FromJson(propertyData);
            List<QuickTypeVProperty.VacantProperty> occupiedProperties = new List<QuickTypeVProperty.VacantProperty>();
            List<QuickTypeVProperty.VacantProperty> vacantProperties = new List<QuickTypeVProperty.VacantProperty>();
            foreach (QuickTypeVProperty.VacantProperty property in properties)
            {
                if (property.DataStatusDisplay.ToString() == "CaseClosedBuildingOccupied")
                {
                    occupiedProperties.Add(property);
                }
                else
                {
                    vacantProperties.Add(property);
                }
            }
            ViewData["occupiedProperties"] = occupiedProperties;
            ViewData["vacantProperties"] = vacantProperties;
            
            

        }
        public string GetData(string endPoint)
        {
            string downloadedData = "";
            using (WebClient webClient = new WebClient())
            {
                downloadedData = webClient.DownloadString(endPoint);
            }
            return downloadedData;
        }
    }
}
