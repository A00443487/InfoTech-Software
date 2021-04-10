#pragma checksum "D:\SMU\Gits\MCDA5510-GIT_IT\HRP\Views\Police\UpdateComplaintStatus.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "caf938a033103461b91a7db4a66d5a07a3af5a23"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Police_UpdateComplaintStatus), @"mvc.1.0.view", @"/Views/Police/UpdateComplaintStatus.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"caf938a033103461b91a7db4a66d5a07a3af5a23", @"/Views/Police/UpdateComplaintStatus.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3d97a09a4067066ac9300b6a10ea6ebc1de3e30", @"/Views/_ViewImports.cshtml")]
    public class Views_Police_UpdateComplaintStatus : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HRP.ViewModels.ComplaintVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Police", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UpdatedComplaints", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 6 "D:\SMU\Gits\MCDA5510-GIT_IT\HRP\Views\Police\UpdateComplaintStatus.cshtml"
  

    Layout = "~/Views/Shared/_PoliceLayout.cshtml";
    var title = "Complaint Report Status Update";
    ViewData["Title"] = title;


#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row\">\r\n    <div class=\"col-md-8\">\r\n        <section>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "caf938a033103461b91a7db4a66d5a07a3af5a234406", async() => {
                WriteLiteral("\r\n                ");
#nullable restore
#line 17 "D:\SMU\Gits\MCDA5510-GIT_IT\HRP\Views\Police\UpdateComplaintStatus.cshtml"
           Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                <h4> Complaint Detail</h4>\r\n                <hr />\r\n\r\n                ");
#nullable restore
#line 22 "D:\SMU\Gits\MCDA5510-GIT_IT\HRP\Views\Police\UpdateComplaintStatus.cshtml"
           Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                <div class=\"form-group\">\r\n                    <label for=\"id\"><b>Complaint ID</b></label>\r\n                    <input for=\"id\" type=\"number\" placeholder=\"Provide the SIN\" name=\"id\" id=\"id\" readonly");
                BeginWriteAttribute("value", " value=\"", 860, "\"", 888, 1);
#nullable restore
#line 26 "D:\SMU\Gits\MCDA5510-GIT_IT\HRP\Views\Police\UpdateComplaintStatus.cshtml"
WriteAttributeValue("", 868, Model.complaints.id, 868, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" required>\r\n\r\n\r\n                </div>\r\n    \r\n\r\n\r\n    <div class=\"form-group\">\r\n        <label for=\"status\"><b>Status</b></label>\r\n        <select for=\"status\" id=\"status\" name=\"status\" class=\"form-control\" />\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "caf938a033103461b91a7db4a66d5a07a3af5a236154", async() => {
                    WriteLiteral(" ");
#nullable restore
#line 36 "D:\SMU\Gits\MCDA5510-GIT_IT\HRP\Views\Police\UpdateComplaintStatus.cshtml"
            Write(Model.status_name);

#line default
#line hidden
#nullable disable
                    WriteLiteral(" ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 37 "D:\SMU\Gits\MCDA5510-GIT_IT\HRP\Views\Police\UpdateComplaintStatus.cshtml"
         foreach (Status p in Model.status)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "caf938a033103461b91a7db4a66d5a07a3af5a237655", async() => {
                    WriteLiteral("\r\n                ");
#nullable restore
#line 40 "D:\SMU\Gits\MCDA5510-GIT_IT\HRP\Views\Police\UpdateComplaintStatus.cshtml"
           Write(p.name);

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 42 "D:\SMU\Gits\MCDA5510-GIT_IT\HRP\Views\Police\UpdateComplaintStatus.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"    </div>
    <div class=""form-group"">

        <label for=""code""><b>ACTIVATION CODE</b></label>
        <input for=""code"" type=""hidden"" placeholder=""Provide the activation Code"" name=""ode"" id=""code"" class=""form-control"" required>
    </div>

    <div class=""form-group"">

        ");
#nullable restore
#line 52 "D:\SMU\Gits\MCDA5510-GIT_IT\HRP\Views\Police\UpdateComplaintStatus.cshtml"
   Write(Html.LabelFor(m => m.complaint_type_name, new { @class = "col-md-8 control-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            <input for=\"sin\" type=\"text\" placeholder=\"Provide the SIN\" name=\"sin\" id=\"sin\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 1806, "\"", 1840, 1);
#nullable restore
#line 54 "D:\SMU\Gits\MCDA5510-GIT_IT\HRP\Views\Police\UpdateComplaintStatus.cshtml"
WriteAttributeValue("", 1814, Model.complaint_type_name, 1814, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" readonly required>\r\n\r\n\r\n\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n\r\n        ");
#nullable restore
#line 62 "D:\SMU\Gits\MCDA5510-GIT_IT\HRP\Views\Police\UpdateComplaintStatus.cshtml"
   Write(Html.LabelFor(m => m.complaints.description, new { @class = "col-md-8 control-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            <p class=\"form-control\">");
#nullable restore
#line 64 "D:\SMU\Gits\MCDA5510-GIT_IT\HRP\Views\Police\UpdateComplaintStatus.cshtml"
                               Write(Model.complaints.description);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"""</p>



        </div>


    </div>








    <div class=""form-group"">
        <div class=""col-md-offset-2 col-md-10"">
            <button type=""submit"" class=""btn btn-default"" style=""{background-color: #008CBA;}"">UPDATE</button>
        </div>
    </div>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </section>\r\n</div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HRP.ViewModels.ComplaintVM> Html { get; private set; }
    }
}
#pragma warning restore 1591