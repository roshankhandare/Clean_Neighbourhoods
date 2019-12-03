#pragma checksum "C:\Users\Dominic\Documents\GitHub\Clean_Neighbourhoods\SafeNeighbourhood\Pages\ClassmatesJson.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "323b934e5a052810fc8f3fcf28f46c6c364f9af7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SafeNeighbourhood.Pages.Pages_ClassmatesJson), @"mvc.1.0.razor-page", @"/Pages/ClassmatesJson.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/ClassmatesJson.cshtml", typeof(SafeNeighbourhood.Pages.Pages_ClassmatesJson), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"323b934e5a052810fc8f3fcf28f46c6c364f9af7", @"/Pages/ClassmatesJson.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"019f322ed2755358251803a1b47abf6a8679bfc9", @"/Pages/_ViewImports.cshtml")]
    public class Pages_ClassmatesJson : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Dominic\Documents\GitHub\Clean_Neighbourhoods\SafeNeighbourhood\Pages\ClassmatesJson.cshtml"
  
    ViewData["Title"] = "ClassmatesJson";

#line default
#line hidden
            BeginContext(109, 60, true);
            WriteLiteral("\r\n<h1>ClassmatesJson</h1>\r\n<table id=\"Output\">\r\n</table>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(187, 1114, true);
                WriteLiteral(@"
    <script>
        $(function () {

            loadData();

            function loadData() {
                $.ajax({
                    url: ""https://breweryratings20191109050130.azurewebsites.net/Privacy"",
                    dataType: 'json',
                    contentType: 'application/json',
                    method: 'GET'
                }).done(function (responseJSON, status, xhr) {
                    $.each(responseJSON, function (index, item) {

                        $(""#Output"").append('<tr><th>Brewery</th></tr><tr><th>' + item.name + '</th></tr><tr><th>User</th><th>Rating</th><th>Review</th></tr>');
                        console.log(item);

                        $.each(item.reviews, function (index, item) {

                            $(""#Output"").append('<tr><th>' + item.user.name + '</th><th>' + item.rating + '</th><th>' + item.text + '</th></tr>');
                            console.log(item);


                        });


                    });
 ");
                WriteLiteral("               })\r\n            }\r\n                        \r\n\r\n        });\r\n    </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SafeNeighbourhood.Pages.ClassmatesJsonModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SafeNeighbourhood.Pages.ClassmatesJsonModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SafeNeighbourhood.Pages.ClassmatesJsonModel>)PageContext?.ViewData;
        public SafeNeighbourhood.Pages.ClassmatesJsonModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
