#pragma checksum "C:\Users\Dell\Desktop\SMU\Semester 1\MCDA 5510 - Software Dev in Business Envir\Project\HRP_Final\HRP\Views\Civilian\WithDrewComplaintPenalty.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3c3328acbadc6eb0e36920312efb40bf8e23a766"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Civilian_WithDrewComplaintPenalty), @"mvc.1.0.view", @"/Views/Civilian/WithDrewComplaintPenalty.cshtml")]
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
#line 1 "C:\Users\Dell\Desktop\SMU\Semester 1\MCDA 5510 - Software Dev in Business Envir\Project\HRP_Final\HRP\Views\_ViewImports.cshtml"
using HRP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Dell\Desktop\SMU\Semester 1\MCDA 5510 - Software Dev in Business Envir\Project\HRP_Final\HRP\Views\_ViewImports.cshtml"
using HRP.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c3328acbadc6eb0e36920312efb40bf8e23a766", @"/Views/Civilian/WithDrewComplaintPenalty.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3d97a09a4067066ac9300b6a10ea6ebc1de3e30", @"/Views/_ViewImports.cshtml")]
    public class Views_Civilian_WithDrewComplaintPenalty : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Complaints>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Civilian", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "WithDrewComplaint", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Dell\Desktop\SMU\Semester 1\MCDA 5510 - Software Dev in Business Envir\Project\HRP_Final\HRP\Views\Civilian\WithDrewComplaintPenalty.cshtml"
  

    Layout = "~/Views/Shared/_ValidationScriptsPartial.cshtml";
            

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

    <h2>Complaint Withdraw HRP-Penality</h2>
    <p>Withdraw complaints leads loss of time and energy spent for the case, it our regulation for the civilian to pay for the penality for withdraw. Hence, next time complaint for fun/mistake will not occur. We appreciate your responsible act. </p>
    <div class=""row"">
        <div class=""col-75"">
            <div class=""container"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3c3328acbadc6eb0e36920312efb40bf8e23a7665132", async() => {
                WriteLiteral(@">

                    
                    <div class=""col-50"">
                        <h3>Payment</h3>
                        <label for=""fname"">Accepted Cards</label>
                        <div class=""icon-container"">
                            <i class=""fa fa-cc-visa"" style=""color:navy;""></i>
                            <i class=""fa fa-cc-amex"" style=""color:blue;""></i>
                            <i class=""fa fa-cc-mastercard"" style=""color:red;""></i>
                            <i class=""fa fa-cc-discover"" style=""color:orange;""></i>
                        </div>
                        <input type=""number"" id=""id"" name=""id""");
                BeginWriteAttribute("value", " value=\"", 1244, "\"", 1261, 1);
#nullable restore
#line 26 "C:\Users\Dell\Desktop\SMU\Semester 1\MCDA 5510 - Software Dev in Business Envir\Project\HRP_Final\HRP\Views\Civilian\WithDrewComplaintPenalty.cshtml"
WriteAttributeValue("", 1252, Model.id, 1252, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" hidden>
                        <label for=""cname"">Name on Card</label>
                        <input type=""text"" id=""cname"" name=""cname"" placeholder=""John More Doe"">
                        <label for=""ccnum"">Credit card number</label>
                        <input type=""text"" id=""ccnum"" name=""ccnum"" placeholder=""1111-2222-3333-4444"">
                        <label for=""expmonth"">Exp Date</label>
                        <input type=""text"" id=""exp"" name=""exp"" placeholder=""02/12"">
                        
                        <div class=""row"">

                            <div class=""col-50"">
                                <label for=""cvv"">CVV</label>
                                <input type=""text"" id=""cvv"" name=""cvv"" placeholder=""352"">
                            </div>
                        </div>
                    </div>

                    
                    <input type=""submit"" value=""Continue to PAY"" class=""btn"">
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
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
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"col-25\">\r\n            <div class=\"container\">\r\n                <h6>Complaint ID ");
#nullable restore
#line 50 "C:\Users\Dell\Desktop\SMU\Semester 1\MCDA 5510 - Software Dev in Business Envir\Project\HRP_Final\HRP\Views\Civilian\WithDrewComplaintPenalty.cshtml"
                            Write(Model.id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" Charging Details</h6>
                <p>Reporting Charge <span class=""price"">$14</span></p>
                <p>Cancellation Fee <span class=""price"">$6</span></p>
                <p>Service Tax <span class=""price"">$0.25</span></p>
                <hr>
                <p>Total <span class=""price"" style=""color:black""><b>$20.25</b></span></p>
            </div>
        </div>
    </div>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Complaints> Html { get; private set; }
    }
}
#pragma warning restore 1591
