#pragma checksum "E:\ProSourceBPOExam\NpvCalculatorSolution\Web Applications\NpvCalculatorApp\Views\Home\Partials\_CashFlows.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8960a107c7f1bdcffeaf992400cb70b82a9421a9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Partials__CashFlows), @"mvc.1.0.view", @"/Views/Home/Partials/_CashFlows.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Partials/_CashFlows.cshtml", typeof(AspNetCore.Views_Home_Partials__CashFlows))]
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
#line 1 "E:\ProSourceBPOExam\NpvCalculatorSolution\Web Applications\NpvCalculatorApp\Views\Home\Partials\_CashFlows.cshtml"
using HtmlHelpers.BeginCollectionItemCore;

#line default
#line hidden
#line 2 "E:\ProSourceBPOExam\NpvCalculatorSolution\Web Applications\NpvCalculatorApp\Views\Home\Partials\_CashFlows.cshtml"
using NpvCalculator.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8960a107c7f1bdcffeaf992400cb70b82a9421a9", @"/Views/Home/Partials/_CashFlows.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e27cdfe969a8d404ef099bb22c46e2d8f24f952f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Partials__CashFlows : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CashFlow>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(73, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(105, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 6 "E:\ProSourceBPOExam\NpvCalculatorSolution\Web Applications\NpvCalculatorApp\Views\Home\Partials\_CashFlows.cshtml"
 foreach (var cashFlow in Model)
{
    

#line default
#line hidden
#line 8 "E:\ProSourceBPOExam\NpvCalculatorSolution\Web Applications\NpvCalculatorApp\Views\Home\Partials\_CashFlows.cshtml"
     using (Html.BeginCollectionItem("CashFlows"))
    {

#line default
#line hidden
            BeginContext(203, 102, true);
            WriteLiteral("        <div class=\"cashflow-item control-group\">\r\n            <label class=\"control-label\">Cash flow ");
            EndContext();
            BeginContext(306, 13, false);
#line 11 "E:\ProSourceBPOExam\NpvCalculatorSolution\Web Applications\NpvCalculatorApp\Views\Home\Partials\_CashFlows.cshtml"
                                              Write(cashFlow.Year);

#line default
#line hidden
            EndContext();
            BeginContext(319, 11, true);
            WriteLiteral(":</label>\r\n");
            EndContext();
            BeginContext(435, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(448, 34, false);
#line 13 "E:\ProSourceBPOExam\NpvCalculatorSolution\Web Applications\NpvCalculatorApp\Views\Home\Partials\_CashFlows.cshtml"
       Write(Html.HiddenFor(c => cashFlow.Year));

#line default
#line hidden
            EndContext();
            BeginContext(482, 38, true);
            WriteLiteral("\r\n            <div class=\"controls\">\r\n");
            EndContext();
            BeginContext(745, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(762, 164, false);
#line 16 "E:\ProSourceBPOExam\NpvCalculatorSolution\Web Applications\NpvCalculatorApp\Views\Home\Partials\_CashFlows.cshtml"
           Write(Html.TextBoxFor(c => cashFlow.Amount, new { @class = "valid", @maxlength = "11", @required = "", @pattern = "^-?([0-9]+|[0-9]{1,3}(,[0-9]{3})*)(\\.[0-9]{1,2})?$" }));

#line default
#line hidden
            EndContext();
            BeginContext(926, 38, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 19 "E:\ProSourceBPOExam\NpvCalculatorSolution\Web Applications\NpvCalculatorApp\Views\Home\Partials\_CashFlows.cshtml"
    }

#line default
#line hidden
#line 19 "E:\ProSourceBPOExam\NpvCalculatorSolution\Web Applications\NpvCalculatorApp\Views\Home\Partials\_CashFlows.cshtml"
     
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CashFlow>> Html { get; private set; }
    }
}
#pragma warning restore 1591