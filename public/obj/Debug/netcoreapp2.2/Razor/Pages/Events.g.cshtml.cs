#pragma checksum "/Users/RossJones/Desktop/App/public/Pages/Events.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f62a4d1fc5e83478a9c2119df2df1d244c97d4d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(VanGoGo.Pages.Pages_Events), @"mvc.1.0.razor-page", @"/Pages/Events.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Events.cshtml", typeof(VanGoGo.Pages.Pages_Events), null)]
namespace VanGoGo.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "/Users/RossJones/Desktop/App/public/Pages/_ViewImports.cshtml"
using VanGoGo;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f62a4d1fc5e83478a9c2119df2df1d244c97d4d", @"/Pages/Events.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"012812f26fa52350513831ff6122fdef374b097b", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Events : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "/Users/RossJones/Desktop/App/public/Pages/Events.cshtml"
  
    ViewData["Title"] = "Events";

#line default
#line hidden
            BeginContext(69, 101, true);
            WriteLiteral("<meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n\r\n<div class=\"text-center\">\r\n");
            EndContext();
            BeginContext(227, 52, true);
            WriteLiteral("    <h1 class=\"display-4\">Events </h1>\r\n\r\n\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EventsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<EventsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<EventsModel>)PageContext?.ViewData;
        public EventsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
