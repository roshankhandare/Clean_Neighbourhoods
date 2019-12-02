using System;
using System.Collections;
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
    public class JsonDataModel : PageModel
    {
        public JsonResult OnGet()
        {
            ArrayList Output = new ArrayList();

            using (WebClient webClient = new WebClient())
            {
                string neighborhoodData = webClient.DownloadString("https://data.cincinnati-oh.gov/resource/h8mv-4fsc.json");
                List<NeighborhoodData> neighborhoods = NeighborhoodData.FromJson(neighborhoodData);

                //Get Vacant Properties in Cincinnati
                string propertyData = webClient.DownloadString("https://data.cincinnati-oh.gov/resource/w3jp-dfxy.json");
                IEnumerable<PropertyData> properties = PropertyData.FromJson(propertyData);

                //Filter Vacant Properties by truly Vacant Properties
                IEnumerable<PropertyData> vacantProperties = properties.Where(property => property.DataStatusDisplay.Contains("Vacant"));

                //Sort Vacant Properties by Neighborhood and Unique ID for better display on View
                vacantProperties = vacantProperties.OrderBy(x => x.Neighborhood).ThenBy(x => x.Uniqueid);


                // iterate over the specimens, to find which ones like water.
                foreach (NeighborhoodData NeighborhoodDatum in neighborhoods)
                {
                    ArrayList NewData = new ArrayList();
                    ArrayList NewProp = new ArrayList();

                    IEnumerable<QuicktypeProperty.PropertyData> vacantPropertiesInNeighborhood = vacantProperties.Where(property => property.Neighborhood.Equals(NeighborhoodDatum.Neighborhood));

                    if (vacantPropertiesInNeighborhood.Any())
                    {
                        // find the matching plant record for this specimen.
                        foreach (PropertyData PropertyDatum in vacantProperties)
                        {
                            if (PropertyDatum.Neighborhood == NeighborhoodDatum.Neighborhood)
                            {
                                NewProp.Add(PropertyDatum);
                            }

                        }
                        NewData.Add(NeighborhoodDatum);
                        NewData.Add(NewProp);
                        Output.Add(NewData);

                    }
                }
            }

            return new JsonResult(Output);
        }
    }
}