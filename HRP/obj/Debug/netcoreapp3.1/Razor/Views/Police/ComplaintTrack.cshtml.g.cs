#pragma checksum "D:\SMU\Gits\MCDA5510-GIT_IT\HRP\Views\Police\ComplaintTrack.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "52f3b9a14dba4246221df9ed057a6e9eb9c47826"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Police_ComplaintTrack), @"mvc.1.0.view", @"/Views/Police/ComplaintTrack.cshtml")]
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
#nullable restore
#line 1 "D:\SMU\Gits\MCDA5510-GIT_IT\HRP\Views\_ViewImports.cshtml"
using HRP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\SMU\Gits\MCDA5510-GIT_IT\HRP\Views\_ViewImports.cshtml"
using HRP.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52f3b9a14dba4246221df9ed057a6e9eb9c47826", @"/Views/Police/ComplaintTrack.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3d97a09a4067066ac9300b6a10ea6ebc1de3e30", @"/Views/_ViewImports.cshtml")]
    public class Views_Police_ComplaintTrack : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ComplaintHandle>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\SMU\Gits\MCDA5510-GIT_IT\HRP\Views\Police\ComplaintTrack.cshtml"
  
    Layout = "~/Views/Shared/_PoliceLayout.cshtml";
    var title = "Compaint Tracker";
    ViewData["Title"] = title;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>");
#nullable restore
#line 10 "D:\SMU\Gits\MCDA5510-GIT_IT\HRP\Views\Police\ComplaintTrack.cshtml"
Write(title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n\r\n<table class=\"table table-bordered table-sm table-striped\">\r\n    <thead>\r\n        <tr><th>Complaint ID</th><th>Your Last Update</th></tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 18 "D:\SMU\Gits\MCDA5510-GIT_IT\HRP\Views\Police\ComplaintTrack.cshtml"
         if (Model == null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr><td colspan=\"7\" class=\"text-center\">No Data</td></tr>\r\n");
#nullable restore
#line 21 "D:\SMU\Gits\MCDA5510-GIT_IT\HRP\Views\Police\ComplaintTrack.cshtml"

        }
        else
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "D:\SMU\Gits\MCDA5510-GIT_IT\HRP\Views\Police\ComplaintTrack.cshtml"
             foreach (var p in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 28 "D:\SMU\Gits\MCDA5510-GIT_IT\HRP\Views\Police\ComplaintTrack.cshtml"
                   Write(p.complaint_id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 29 "D:\SMU\Gits\MCDA5510-GIT_IT\HRP\Views\Police\ComplaintTrack.cshtml"
                   Write(p.last_update);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    \r\n\r\n                    \r\n                </tr>\r\n");
#nullable restore
#line 34 "D:\SMU\Gits\MCDA5510-GIT_IT\HRP\Views\Police\ComplaintTrack.cshtml"

            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "D:\SMU\Gits\MCDA5510-GIT_IT\HRP\Views\Police\ComplaintTrack.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ComplaintHandle>> Html { get; private set; }
    }
}
#pragma warning restore 1591
