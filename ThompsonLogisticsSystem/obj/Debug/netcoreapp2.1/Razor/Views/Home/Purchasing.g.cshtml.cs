#pragma checksum "C:\Users\cn102514\Source\Repos\ThompsonLogisticsSystem\ThompsonLogisticsSystem\Views\Home\Purchasing.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0d7606e25f8815783f4129d8ffd4bfecaa592bf1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Purchasing), @"mvc.1.0.view", @"/Views/Home/Purchasing.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Purchasing.cshtml", typeof(AspNetCore.Views_Home_Purchasing))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\cn102514\Source\Repos\ThompsonLogisticsSystem\ThompsonLogisticsSystem\Views\_ViewImports.cshtml"
using ThompsonLogisticsSystem;

#line default
#line hidden
#line 2 "C:\Users\cn102514\Source\Repos\ThompsonLogisticsSystem\ThompsonLogisticsSystem\Views\_ViewImports.cshtml"
using ThompsonLogisticsSystem.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d7606e25f8815783f4129d8ffd4bfecaa592bf1", @"/Views/Home/Purchasing.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"771337d3c18da9b240efdc1af2c4bc8f3bdd01d8", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Purchasing : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\cn102514\Source\Repos\ThompsonLogisticsSystem\ThompsonLogisticsSystem\Views\Home\Purchasing.cshtml"
  
    ViewData["Title"] = "Purchasing";

#line default
#line hidden
            BeginContext(46, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(51, 17, false);
#line 4 "C:\Users\cn102514\Source\Repos\ThompsonLogisticsSystem\ThompsonLogisticsSystem\Views\Home\Purchasing.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(68, 11, true);
            WriteLiteral("</h2>\r\n<h3>");
            EndContext();
            BeginContext(80, 19, false);
#line 5 "C:\Users\cn102514\Source\Repos\ThompsonLogisticsSystem\ThompsonLogisticsSystem\Views\Home\Purchasing.cshtml"
Write(ViewData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(99, 590, true);
            WriteLiteral(@"</h3>

<div class=""row"">

    <div class=""col-md-6"">
        <h3>What would you like to do?</h3>
        <ul>
            <li><a href=""https://go.microsoft.com/fwlink/?LinkID=398600"">View My Purchase Orders</a></li>
            <li><a href=""https://go.microsoft.com/fwlink/?LinkId=699315"">Create New Purchase Order</a></li>
            <li><a href=""https://go.microsoft.com/fwlink/?LinkId=699316"">Schedule Inventory Audit</a></li>
            <li><a href=""https://go.microsoft.com/fwlink/?LinkId=699317"">Generate Reports</a></li>
            
        </ul>
    </div>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
