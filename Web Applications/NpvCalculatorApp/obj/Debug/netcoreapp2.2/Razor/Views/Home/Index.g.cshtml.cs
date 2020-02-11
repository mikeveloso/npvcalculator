#pragma checksum "E:\ProSourceBPOExam\NpvCalculatorSolution\Web Applications\NpvCalculatorApp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f977a6be2c75ecf509155e82e0c177024b4aa20"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "E:\ProSourceBPOExam\NpvCalculatorSolution\Web Applications\NpvCalculatorApp\Views\_ViewImports.cshtml"
using NpvCalculatorCalculatorApp;

#line default
#line hidden
#line 1 "E:\ProSourceBPOExam\NpvCalculatorSolution\Web Applications\NpvCalculatorApp\Views\Home\Index.cshtml"
using NpvCalculator.Helpers;

#line default
#line hidden
#line 2 "E:\ProSourceBPOExam\NpvCalculatorSolution\Web Applications\NpvCalculatorApp\Views\Home\Index.cshtml"
using NpvCalculator.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f977a6be2c75ecf509155e82e0c177024b4aa20", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e27cdfe969a8d404ef099bb22c46e2d8f24f952f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Npv>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", "~/plugins/npv/jquery.npv.calculator.css", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/plugins/numeral/numeral.min.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/lib/jquery-validation/dist/jquery.validate.min.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/lib/jquery-validation/dist/additional-methods.min.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/plugins/npv/jquery.npv.calculator.min.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LinkTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(59, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(73, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 6 "E:\ProSourceBPOExam\NpvCalculatorSolution\Web Applications\NpvCalculatorApp\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "NPV Calculator";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(172, 61, true);
            WriteLiteral("\r\n<div class=\"box\">\r\n    <div class=\"calculator-container\">\r\n");
            EndContext();
#line 13 "E:\ProSourceBPOExam\NpvCalculatorSolution\Web Applications\NpvCalculatorApp\Views\Home\Index.cshtml"
         using (Html.BeginForm("CalculateNPV", "Home", FormMethod.Post, new { @id = "calculator-form", @name = "calculator-form", @class = "form-horizontal", @novalidate = "novalidate" }))
        {

#line default
#line hidden
            BeginContext(434, 252, true);
            WriteLiteral("            <div class=\"npv-form-field-container\">\r\n                <div class=\"control-group\">\r\n                    <label class=\"control-label\">Lower Bound Discount Rate : </label>\r\n                    <div class=\"controls\">\r\n                        ");
            EndContext();
            BeginContext(687, 151, false);
#line 19 "E:\ProSourceBPOExam\NpvCalculatorSolution\Web Applications\NpvCalculatorApp\Views\Home\Index.cshtml"
                   Write(Html.TextBoxFor(c => Model.LowerBoundRate, new { @id = "txtLowerBoundRate", @class = "valid", @maxlength = "6", @required = "", range = "0.0001,100" }));

#line default
#line hidden
            EndContext();
            BeginContext(838, 261, true);
            WriteLiteral(@"&nbsp;%
                    </div>
                </div>
                <div class=""control-group"">
                    <label class=""control-label"">Upper Bound Discount Rate : </label>
                    <div class=""controls"">
                        ");
            EndContext();
            BeginContext(1100, 151, false);
#line 25 "E:\ProSourceBPOExam\NpvCalculatorSolution\Web Applications\NpvCalculatorApp\Views\Home\Index.cshtml"
                   Write(Html.TextBoxFor(c => Model.UpperBoundRate, new { @id = "txtUpperBoundRate", @class = "valid", @maxlength = "6", @required = "", range = "0.0001,100" }));

#line default
#line hidden
            EndContext();
            BeginContext(1251, 259, true);
            WriteLiteral(@"&nbsp;%
                    </div>
                </div>
                <div class=""control-group"">
                    <label class=""control-label"">Discount Rate Increment : </label>
                    <div class=""controls"">
                        ");
            EndContext();
            BeginContext(1511, 149, false);
#line 31 "E:\ProSourceBPOExam\NpvCalculatorSolution\Web Applications\NpvCalculatorApp\Views\Home\Index.cshtml"
                   Write(Html.TextBoxFor(c => Model.RateIncrement, new { @id = "txtRateIncrement", @class = "valid", @maxlength = "6", @required = "", range = "0.0001,100" }));

#line default
#line hidden
            EndContext();
            BeginContext(1660, 249, true);
            WriteLiteral("&nbsp;%\r\n                    </div>\r\n                </div>\r\n                <div class=\"control-group\">\r\n                    <label class=\"control-label\">Initial Value : </label>\r\n                    <div class=\"controls\">\r\n                        ");
            EndContext();
            BeginContext(1910, 150, false);
#line 37 "E:\ProSourceBPOExam\NpvCalculatorSolution\Web Applications\NpvCalculatorApp\Views\Home\Index.cshtml"
                   Write(Html.TextBoxFor(c => Model.InitialValue, new { @id = "txtInitialValue", @class = "valid", @maxlength = "11", @required = "", range = "0,9999999999" }));

#line default
#line hidden
            EndContext();
            BeginContext(2060, 246, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n\r\n                <div class=\"control-group\">\r\n                    <label class=\"control-label\">Tenure in Years : </label>\r\n                    <div class=\"controls\">\r\n                        ");
            EndContext();
            BeginContext(2307, 144, false);
#line 44 "E:\ProSourceBPOExam\NpvCalculatorSolution\Web Applications\NpvCalculatorApp\Views\Home\Index.cshtml"
                   Write(Html.DropDownListFor(m => m.Years, ListHelper.TenureLists, "Select Tenure in Years", new { @id = "drpYears", @class = "valid", @required = "" }));

#line default
#line hidden
            EndContext();
            BeginContext(2451, 74, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
            EndContext();
            BeginContext(2527, 72, true);
            WriteLiteral("            <div id=\"cashflow-items\" class=\"cashflow-container\"></div>\r\n");
            EndContext();
            BeginContext(2601, 396, true);
            WriteLiteral(@"            <div class=""npv-form-action-container"">
                <div class=""control-group"">
                    <div class=""controls"">
                        <input id=""calculateNPV"" type=""submit"" value=""Calculate NPV"" />&nbsp;&nbsp;
                        <input id=""reset-button"" type=""submit"" value=""Reset"" />
                    </div>
                </div>
            </div>
");
            EndContext();
#line 59 "E:\ProSourceBPOExam\NpvCalculatorSolution\Web Applications\NpvCalculatorApp\Views\Home\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(3008, 22, true);
            WriteLiteral("    </div>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("CssSection", async() => {
                BeginContext(3052, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(3058, 98, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9f977a6be2c75ecf509155e82e0c177024b4aa2011716", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LinkTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.Href = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 65 "E:\ProSourceBPOExam\NpvCalculatorSolution\Web Applications\NpvCalculatorApp\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.AppendVersion = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3156, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(3161, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(3186, 8, true);
                WriteLiteral("\r\n\r\n    ");
                EndContext();
                BeginContext(3194, 82, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9f977a6be2c75ecf509155e82e0c177024b4aa2014187", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#line 71 "E:\ProSourceBPOExam\NpvCalculatorSolution\Web Applications\NpvCalculatorApp\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3276, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(3282, 101, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9f977a6be2c75ecf509155e82e0c177024b4aa2016285", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#line 72 "E:\ProSourceBPOExam\NpvCalculatorSolution\Web Applications\NpvCalculatorApp\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3383, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(3389, 104, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9f977a6be2c75ecf509155e82e0c177024b4aa2018383", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
#line 73 "E:\ProSourceBPOExam\NpvCalculatorSolution\Web Applications\NpvCalculatorApp\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3493, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(3499, 92, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9f977a6be2c75ecf509155e82e0c177024b4aa2020480", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
#line 74 "E:\ProSourceBPOExam\NpvCalculatorSolution\Web Applications\NpvCalculatorApp\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3591, 336, true);
                WriteLiteral(@"

    <script>
        $(document).ready(function () {
            $('#calculator-form').npvcalculator({
                resetButton: $('#reset-button'),
                yearsDropdown: $('#drpYears'),
                cashFlowItemsContainer: $('#cashflow-items'),
                urls: {
                    generateCashFlows: '");
                EndContext();
                BeginContext(3928, 39, false);
#line 83 "E:\ProSourceBPOExam\NpvCalculatorSolution\Web Applications\NpvCalculatorApp\Views\Home\Index.cshtml"
                                   Write(Url.Action("GenerateCashFlows", "Home"));

#line default
#line hidden
                EndContext();
                BeginContext(3967, 39, true);
                WriteLiteral("\',\r\n                    calculateNpv: \'");
                EndContext();
                BeginContext(4007, 34, false);
#line 84 "E:\ProSourceBPOExam\NpvCalculatorSolution\Web Applications\NpvCalculatorApp\Views\Home\Index.cshtml"
                              Write(Url.Action("CalculateNPV", "Home"));

#line default
#line hidden
                EndContext();
                BeginContext(4041, 67, true);
                WriteLiteral("\'\r\n                }\r\n            });\r\n        });\r\n    </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Npv> Html { get; private set; }
    }
}
#pragma warning restore 1591
