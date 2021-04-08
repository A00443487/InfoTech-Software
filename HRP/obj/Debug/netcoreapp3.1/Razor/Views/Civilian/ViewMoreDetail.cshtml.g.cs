#pragma checksum "D:\PK\HRP\Views\Civilian\ViewMoreDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7fa6bbb529af34c977d63f7d8c406b0fdc2d7fe9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Civilian_ViewMoreDetail), @"mvc.1.0.view", @"/Views/Civilian/ViewMoreDetail.cshtml")]
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
#line 1 "D:\PK\HRP\Views\_ViewImports.cshtml"
using HRP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\PK\HRP\Views\_ViewImports.cshtml"
using HRP.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7fa6bbb529af34c977d63f7d8c406b0fdc2d7fe9", @"/Views/Civilian/ViewMoreDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3d97a09a4067066ac9300b6a10ea6ebc1de3e30", @"/Views/_ViewImports.cshtml")]
    public class Views_Civilian_ViewMoreDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HRP.ViewModels.ComplaintVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("login"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Civilian", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ViewComplaints", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 6 "D:\PK\HRP\Views\Civilian\ViewMoreDetail.cshtml"
  

    Layout = "~/Views/Shared/_CivilianLayout.cshtml";
    var title = "Complaint Report";
    ViewData["Title"] = title;


#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row\">\r\n    <div class=\"col-md-8\">\r\n        <section>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7fa6bbb529af34c977d63f7d8c406b0fdc2d7fe94487", async() => {
                WriteLiteral("\r\n                ");
#nullable restore
#line 17 "D:\PK\HRP\Views\Civilian\ViewMoreDetail.cshtml"
           Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                <h4>");
#nullable restore
#line 19 "D:\PK\HRP\Views\Civilian\ViewMoreDetail.cshtml"
               Write(title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>\r\n                <hr />\r\n\r\n                ");
#nullable restore
#line 22 "D:\PK\HRP\Views\Civilian\ViewMoreDetail.cshtml"
           Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                <div class=\"form-group\">\r\n\r\n                    ");
#nullable restore
#line 26 "D:\PK\HRP\Views\Civilian\ViewMoreDetail.cshtml"
               Write(Html.LabelFor(m => m.complaints.id, new { @class = "col-md-8 control-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <div class=\"col-md-10\">\r\n                        ");
#nullable restore
#line 28 "D:\PK\HRP\Views\Civilian\ViewMoreDetail.cshtml"
                   Write(Html.TextBoxFor(m => m.complaints.id, new { @class = "form-control", id = "id", @Value = Model.complaints.id, autofocus = "", @readonly = "readonly" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\r\n                    </div>\r\n                </div>\r\n\r\n                <div class=\"form-group\">\r\n\r\n                    ");
#nullable restore
#line 36 "D:\PK\HRP\Views\Civilian\ViewMoreDetail.cshtml"
               Write(Html.LabelFor(m => m.status_name, new { @class = "col-md-8 control-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <div class=\"col-md-10\">\r\n                        <input for=\"sin\" type=\"text\" readonly placeholder=\"Provide the SIN\" name=\"sin\" id=\"sin\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 1382, "\"", 1408, 1);
#nullable restore
#line 38 "D:\PK\HRP\Views\Civilian\ViewMoreDetail.cshtml"
WriteAttributeValue("", 1390, Model.status_name, 1390, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" required>\r\n\r\n\r\n\r\n                    </div>\r\n                </div>\r\n                <div class=\"form-group\">\r\n\r\n                    ");
#nullable restore
#line 46 "D:\PK\HRP\Views\Civilian\ViewMoreDetail.cshtml"
               Write(Html.LabelFor(m => m.complaint_type_name, new { @class = "col-md-8 control-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <div class=\"col-md-10\">\r\n                        <input for=\"sin\" type=\"text\" placeholder=\"Provide the SIN\" name=\"sin\" id=\"sin\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 1798, "\"", 1832, 1);
#nullable restore
#line 48 "D:\PK\HRP\Views\Civilian\ViewMoreDetail.cshtml"
WriteAttributeValue("", 1806, Model.complaint_type_name, 1806, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" readonly required>\r\n                        \r\n\r\n\r\n                    </div>\r\n                </div>\r\n                <div class=\"form-group\">\r\n\r\n                    ");
#nullable restore
#line 56 "D:\PK\HRP\Views\Civilian\ViewMoreDetail.cshtml"
               Write(Html.LabelFor(m => m.complaints.description, new { @class = "col-md-8 control-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <div class=\"col-md-10\">\r\n                        <p class=\"form-control\">");
#nullable restore
#line 58 "D:\PK\HRP\Views\Civilian\ViewMoreDetail.cshtml"
                                           Write(Model.complaints.description);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"""</p>
                        


                    </div>
                </div>







                <div class=""form-group"">
                    <div class=""col-md-offset-2 col-md-10"">
                        <button type=""submit"" class=""btn btn-default"">BACK</button>
                    </div>
                </div>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </section>\r\n    </div>\r\n</div>\r\n");
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
