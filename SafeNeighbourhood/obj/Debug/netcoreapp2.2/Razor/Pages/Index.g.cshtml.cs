#pragma checksum "C:\Users\Dominic\Documents\GitHub\Clean_Neighbourhoods\SafeNeighbourhood\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1e2658dced0f02ced55ebd70a2b15f09f40f9d31"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SafeNeighbourhood.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Index.cshtml", typeof(SafeNeighbourhood.Pages.Pages_Index), null)]
namespace SafeNeighbourhood.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Dominic\Documents\GitHub\Clean_Neighbourhoods\SafeNeighbourhood\Pages\_ViewImports.cshtml"
using SafeNeighbourhood;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e2658dced0f02ced55ebd70a2b15f09f40f9d31", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"019f322ed2755358251803a1b47abf6a8679bfc9", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Dominic\Documents\GitHub\Clean_Neighbourhoods\SafeNeighbourhood\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";
    var vacantProperties = (IEnumerable<QuicktypeProperty.PropertyData>)ViewData["VacantProperties"];
    var neighborhoods = (List<QuicktypeNeighborhood.NeighborhoodData>)ViewData["Neighborhoods"];

#line default
#line hidden
            BeginContext(272, 1050, true);
            WriteLiteral(@"
<h2>Vacant Homes in Cincinnati by Neighborhood Cleanliness</h2>
<p>(Data since 2012)</p>
<meta name=""viewport"" content=""width=device-width, initial-scale=1"">
<link rel=""stylesheet"" href=""https://www.w3schools.com/w3css/4/w3.css"">
<link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"">
<div class=""w3-container"">
    <div class=""w3-padding w3-xlarge w3-teal"">
        <i class=""fa fa-search""></i>
        <i class=""fa fa-globe""></i>
        <i class=""fa fa-handshake-o""></i>
        <i class=""fa fa-street-view""></i>
        <i class=""fa fa-archive""></i>
    </div>
   
    <h3>Search for a Neighborhood by Name</h3>
    <input id=""list"" list=""Ndata"" style=""width: 200px"" />
    <datalist id=""Ndata"">
    </datalist>
    <input type=""button"" id=""submit"" value=""Search"" />
    <input type=""button"" id=""clear"" value=""Clear"" />
    <br />
    <div>
        <table id=""searchout"" style=""width:100%"" class=""table table-bordered"">
        </table>");
            WriteLiteral("\r\n    </div>\r\n    <br />\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1344, 2694, true);
                WriteLiteral(@"
        <script>
            $(function () {
                loadData();

                var datalist = [];

                $(""#submit"").on(""click"", function () {

                    var searchterm = $(""#list"").val();

                    $(""#list"").val("""");


                    for (i = 0; i < datalist.length; i++) {

                        if (datalist[i][0].neighborhood == searchterm) {

                            $(""#searchout"").append('<tr><th style=""background-color:black; color:white"">Neighborhood</th><th style=""background-color:black; color:white"">Number of Cleanliness Complaints</th></tr><tr><td><strong>' + datalist[i][0].neighborhood + '</strong></td><td>' + datalist[i][0].wfdb + '</td></tr><tr class=""table-secondary""><th>Property ID</th><th>Street Number</th><th>Street Name</th><th>Neighborhood</th><th>Official Status</th><th>URL</th></tr>')

                            for (x = 0; x < datalist[i][1].length; x++) {

                                $(""#searchout"").append");
                WriteLiteral(@"('<tr class=""table-secondary""><td>' + datalist[i][1][x].uniqueid + '</td><td>' + datalist[i][1][x].street_no + '</td><td>' + datalist[i][1][x].street_name + '</td><td>' + datalist[i][1][x].neighborhood + '</td><td>' + datalist[i][1][x].data_status_display + '</td><th><a href=""' + datalist[i][1][x].url + '"">' + datalist[i][1][x].url + '</a></td></tr>')

                            }

                        }
                    }
                    $(""#searchout"").append('<tr><td>' + searchterm + '</td><td>' + crimerate + '</td></tr>')

                });
                $(""#clear"").on(""click"", function () {

                    $(""#searchout"").empty();

                });

                function loadData() {
                    $.ajax({
                        url: ""https://safeneighbourhood20191109063116.azurewebsites.net/jsondata"",
                        dataType: 'json',
                        contentType: 'application/json',
                        method: 'GET'
              ");
                WriteLiteral(@"      }).done(function (responseJSON, status, xhr) {
                        $.each(responseJSON, function (index, item) {

                            datalist.push(item);

                            $(""#Ndata"").append('<option value=""' + item[0].neighborhood + '"">');

                        });
                        console.log(datalist);

                    }).fail(function (xhr, status, error) {
                        console.log(""fail"", xhr, status, error);
                        alert(""There was an error retrieving the data"");
                    });

                };
            });
        </script>
    ");
                EndContext();
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591