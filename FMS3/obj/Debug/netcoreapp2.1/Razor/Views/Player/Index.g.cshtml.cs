#pragma checksum "D:\Code\FootManSim\FMS_Mvc\FMS3\Views\Player\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "37a083b0bf7e680569d85bf64926400026e9237a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Player_Index), @"mvc.1.0.view", @"/Views/Player/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Player/Index.cshtml", typeof(AspNetCore.Views_Player_Index))]
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
#line 1 "D:\Code\FootManSim\FMS_Mvc\FMS3\Views\_ViewImports.cshtml"
using FMS3;

#line default
#line hidden
#line 2 "D:\Code\FootManSim\FMS_Mvc\FMS3\Views\_ViewImports.cshtml"
using FMS3.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37a083b0bf7e680569d85bf64926400026e9237a", @"/Views/Player/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e236abf8294e3d95602ee79f6b237575f1daf205", @"/Views/_ViewImports.cshtml")]
    public class Views_Player_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FMS3.Models.Player>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(40, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Code\FootManSim\FMS_Mvc\FMS3\Views\Player\Index.cshtml"
  
    ViewData["Title"] = "Player List";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(136, 86, true);
            WriteLiteral("\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(223, 40, false);
#line 12 "D:\Code\FootManSim\FMS_Mvc\FMS3\Views\Player\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(263, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(319, 42, false);
#line 15 "D:\Code\FootManSim\FMS_Mvc\FMS3\Views\Player\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Rating));

#line default
#line hidden
            EndContext();
            BeginContext(361, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(417, 39, false);
#line 18 "D:\Code\FootManSim\FMS_Mvc\FMS3\Views\Player\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Age));

#line default
#line hidden
            EndContext();
            BeginContext(456, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(512, 44, false);
#line 21 "D:\Code\FootManSim\FMS_Mvc\FMS3\Views\Player\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Position));

#line default
#line hidden
            EndContext();
            BeginContext(556, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(612, 42, false);
#line 24 "D:\Code\FootManSim\FMS_Mvc\FMS3\Views\Player\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TeamId));

#line default
#line hidden
            EndContext();
            BeginContext(654, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(710, 41, false);
#line 27 "D:\Code\FootManSim\FMS_Mvc\FMS3\Views\Player\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Value));

#line default
#line hidden
            EndContext();
            BeginContext(751, 66, true);
            WriteLiteral("\r\n            </th>\r\n         \r\n            <th>\r\n                ");
            EndContext();
            BeginContext(818, 48, false);
#line 31 "D:\Code\FootManSim\FMS_Mvc\FMS3\Views\Player\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.InjuredWeeks));

#line default
#line hidden
            EndContext();
            BeginContext(866, 99, true);
            WriteLiteral("\r\n            </th>\r\n           \r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 38 "D:\Code\FootManSim\FMS_Mvc\FMS3\Views\Player\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(1014, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1075, 37, false);
#line 42 "D:\Code\FootManSim\FMS_Mvc\FMS3\Views\Player\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1112, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1180, 39, false);
#line 45 "D:\Code\FootManSim\FMS_Mvc\FMS3\Views\Player\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1219, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1287, 41, false);
#line 48 "D:\Code\FootManSim\FMS_Mvc\FMS3\Views\Player\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Rating));

#line default
#line hidden
            EndContext();
            BeginContext(1328, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1396, 38, false);
#line 51 "D:\Code\FootManSim\FMS_Mvc\FMS3\Views\Player\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Age));

#line default
#line hidden
            EndContext();
            BeginContext(1434, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1502, 43, false);
#line 54 "D:\Code\FootManSim\FMS_Mvc\FMS3\Views\Player\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Position));

#line default
#line hidden
            EndContext();
            BeginContext(1545, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1613, 41, false);
#line 57 "D:\Code\FootManSim\FMS_Mvc\FMS3\Views\Player\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.TeamId));

#line default
#line hidden
            EndContext();
            BeginContext(1654, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1722, 74, false);
#line 60 "D:\Code\FootManSim\FMS_Mvc\FMS3\Views\Player\Index.cshtml"
               Write(Component.InvokeAsync("CashFormat", new { cashValue = item.Value }).Result);

#line default
#line hidden
            EndContext();
            BeginContext(1796, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1864, 42, false);
#line 63 "D:\Code\FootManSim\FMS_Mvc\FMS3\Views\Player\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Retired));

#line default
#line hidden
            EndContext();
            BeginContext(1906, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1974, 86, false);
#line 66 "D:\Code\FootManSim\FMS_Mvc\FMS3\Views\Player\Index.cshtml"
               Write(Component.InvokeAsync("InjuryStatus", new { injuredWeeks = item.InjuredWeeks }).Result);

#line default
#line hidden
            EndContext();
            BeginContext(2060, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2128, 48, false);
#line 69 "D:\Code\FootManSim\FMS_Mvc\FMS3\Views\Player\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.GameDetailsId));

#line default
#line hidden
            EndContext();
            BeginContext(2176, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2244, 57, false);
#line 72 "D:\Code\FootManSim\FMS_Mvc\FMS3\Views\Player\Index.cshtml"
               Write(Html.ActionLink("Details", "Details", new { id=item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(2301, 45, true);
            WriteLiteral(" \r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 75 "D:\Code\FootManSim\FMS_Mvc\FMS3\Views\Player\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(2357, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FMS3.Models.Player>> Html { get; private set; }
    }
}
#pragma warning restore 1591
