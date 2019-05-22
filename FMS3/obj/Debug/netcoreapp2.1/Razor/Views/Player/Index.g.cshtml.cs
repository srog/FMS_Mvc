#pragma checksum "D:\Code\FootManSim\FMS_Mvc\FMS3\Views\Player\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d108553b27e92814eeea332193f28e650c1215ca"
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
#line 1 "D:\Code\FootManSim\FMS_Mvc\FMS3\Views\Player\Index.cshtml"
using FMS3.Enums;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d108553b27e92814eeea332193f28e650c1215ca", @"/Views/Player/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e236abf8294e3d95602ee79f6b237575f1daf205", @"/Views/_ViewImports.cshtml")]
    public class Views_Player_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FMS3.Models.PlayerListDisplay>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Game", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(57, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "D:\Code\FootManSim\FMS_Mvc\FMS3\Views\Player\Index.cshtml"
  
    ViewData["Title"] = "Player List";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(153, 12, true);
            WriteLiteral("\r\n<br />\r\n\r\n");
            EndContext();
#line 11 "D:\Code\FootManSim\FMS_Mvc\FMS3\Views\Player\Index.cshtml"
 if (Model.DisplayType == PlayerListDisplayTypeEnum.MySquad || Model.DisplayType == PlayerListDisplayTypeEnum.OtherSquad)
{
    

#line default
#line hidden
            BeginContext(296, 90, false);
#line 13 "D:\Code\FootManSim\FMS_Mvc\FMS3\Views\Player\Index.cshtml"
Write(Component.InvokeAsync("TeamName", new { teamId = Model.PlayerList.First().TeamId }).Result);

#line default
#line hidden
            EndContext();
            BeginContext(388, 12, true);
            WriteLiteral("    <hr />\r\n");
            EndContext();
            BeginContext(402, 22, true);
            WriteLiteral("    <span> Formation: ");
            EndContext();
            BeginContext(425, 19, false);
#line 16 "D:\Code\FootManSim\FMS_Mvc\FMS3\Views\Player\Index.cshtml"
                 Write(Model.TeamFormation);

#line default
#line hidden
            EndContext();
            BeginContext(444, 10, true);
            WriteLiteral(" </span>\r\n");
            EndContext();
#line 17 "D:\Code\FootManSim\FMS_Mvc\FMS3\Views\Player\Index.cshtml"
}

#line default
#line hidden
#line 18 "D:\Code\FootManSim\FMS_Mvc\FMS3\Views\Player\Index.cshtml"
 if (Model.DisplayType == PlayerListDisplayTypeEnum.AllPlayers)
{

#line default
#line hidden
            BeginContext(525, 26, true);
            WriteLiteral("    <h3>All Players</h3>\r\n");
            EndContext();
#line 21 "D:\Code\FootManSim\FMS_Mvc\FMS3\Views\Player\Index.cshtml"
}

#line default
#line hidden
#line 22 "D:\Code\FootManSim\FMS_Mvc\FMS3\Views\Player\Index.cshtml"
 if (Model.DisplayType == PlayerListDisplayTypeEnum.TransferMarket)
{

#line default
#line hidden
            BeginContext(626, 30, true);
            WriteLiteral("    <h3>Transfer Market</h3>\r\n");
            EndContext();
#line 25 "D:\Code\FootManSim\FMS_Mvc\FMS3\Views\Player\Index.cshtml"
}

#line default
#line hidden
            BeginContext(659, 130, true);
            WriteLiteral("\r\n<hr />\r\n<table class=\"table-bordered table-striped\" width=\"100%\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(790, 54, false);
#line 32 "D:\Code\FootManSim\FMS_Mvc\FMS3\Views\Player\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PlayerList[0].Name));

#line default
#line hidden
            EndContext();
            BeginContext(844, 21, true);
            WriteLiteral("\r\n            </th>\r\n");
            EndContext();
#line 34 "D:\Code\FootManSim\FMS_Mvc\FMS3\Views\Player\Index.cshtml"
             if (Model.DisplayType == PlayerListDisplayTypeEnum.AllPlayers)
            {

#line default
#line hidden
            BeginContext(957, 42, true);
            WriteLiteral("                <th>\r\n                    ");
            EndContext();
            BeginContext(1000, 56, false);
#line 37 "D:\Code\FootManSim\FMS_Mvc\FMS3\Views\Player\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.PlayerList[0].TeamId));

#line default
#line hidden
            EndContext();
            BeginContext(1056, 25, true);
            WriteLiteral("\r\n                </th>\r\n");
            EndContext();
#line 39 "D:\Code\FootManSim\FMS_Mvc\FMS3\Views\Player\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(1096, 36, true);
            WriteLiteral("\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1133, 56, false);
#line 42 "D:\Code\FootManSim\FMS_Mvc\FMS3\Views\Player\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PlayerList[0].Rating));

#line default
#line hidden
            EndContext();
            BeginContext(1189, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1245, 53, false);
#line 45 "D:\Code\FootManSim\FMS_Mvc\FMS3\Views\Player\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PlayerList[0].Age));

#line default
#line hidden
            EndContext();
            BeginContext(1298, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1354, 58, false);
#line 48 "D:\Code\FootManSim\FMS_Mvc\FMS3\Views\Player\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PlayerList[0].Position));

#line default
#line hidden
            EndContext();
            BeginContext(1412, 57, true);
            WriteLiteral("\r\n            </th>\r\n\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1470, 55, false);
#line 52 "D:\Code\FootManSim\FMS_Mvc\FMS3\Views\Player\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PlayerList[0].Value));

#line default
#line hidden
            EndContext();
            BeginContext(1525, 57, true);
            WriteLiteral("\r\n            </th>\r\n\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1583, 62, false);
#line 56 "D:\Code\FootManSim\FMS_Mvc\FMS3\Views\Player\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PlayerList[0].InjuredWeeks));

#line default
#line hidden
            EndContext();
            BeginContext(1645, 21, true);
            WriteLiteral("\r\n            </th>\r\n");
            EndContext();
#line 58 "D:\Code\FootManSim\FMS_Mvc\FMS3\Views\Player\Index.cshtml"
             if (Model.DisplayType == PlayerListDisplayTypeEnum.MySquad || Model.DisplayType == PlayerListDisplayTypeEnum.OtherSquad)
            {

#line default
#line hidden
            BeginContext(1816, 42, true);
            WriteLiteral("                <th>\r\n                    ");
            EndContext();
            BeginContext(1859, 63, false);
#line 61 "D:\Code\FootManSim\FMS_Mvc\FMS3\Views\Player\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.PlayerList[0].TeamSelection));

#line default
#line hidden
            EndContext();
            BeginContext(1922, 25, true);
            WriteLiteral("\r\n                </th>\r\n");
            EndContext();
#line 63 "D:\Code\FootManSim\FMS_Mvc\FMS3\Views\Player\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(1962, 88, true);
            WriteLiteral("            <th></th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 69 "D:\Code\FootManSim\FMS_Mvc\FMS3\Views\Player\Index.cshtml"
         foreach (var item in Model.PlayerList)
        {

#line default
#line hidden
            BeginContext(2110, 50, true);
            WriteLiteral("        <tr>\r\n\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2161, 39, false);
#line 74 "D:\Code\FootManSim\FMS_Mvc\FMS3\Views\Player\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2200, 21, true);
            WriteLiteral("\r\n            </td>\r\n");
            EndContext();
#line 76 "D:\Code\FootManSim\FMS_Mvc\FMS3\Views\Player\Index.cshtml"
             if (Model.DisplayType == PlayerListDisplayTypeEnum.AllPlayers)
            {

#line default
#line hidden
            BeginContext(2313, 42, true);
            WriteLiteral("                <td>\r\n                    ");
            EndContext();
            BeginContext(2356, 70, false);
#line 79 "D:\Code\FootManSim\FMS_Mvc\FMS3\Views\Player\Index.cshtml"
               Write(Component.InvokeAsync("TeamName", new { teamId = item.TeamId }).Result);

#line default
#line hidden
            EndContext();
            BeginContext(2426, 25, true);
            WriteLiteral("\r\n                </td>\r\n");
            EndContext();
#line 81 "D:\Code\FootManSim\FMS_Mvc\FMS3\Views\Player\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(2466, 34, true);
            WriteLiteral("            <td>\r\n                ");
            EndContext();
            BeginContext(2501, 41, false);
#line 83 "D:\Code\FootManSim\FMS_Mvc\FMS3\Views\Player\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Rating));

#line default
#line hidden
            EndContext();
            BeginContext(2542, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2598, 38, false);
#line 86 "D:\Code\FootManSim\FMS_Mvc\FMS3\Views\Player\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Age));

#line default
#line hidden
            EndContext();
            BeginContext(2636, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2692, 82, false);
#line 89 "D:\Code\FootManSim\FMS_Mvc\FMS3\Views\Player\Index.cshtml"
           Write(Component.InvokeAsync("PlayerPosition", new { positionId = item.Position }).Result);

#line default
#line hidden
            EndContext();
            BeginContext(2774, 57, true);
            WriteLiteral("\r\n            </td>\r\n\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2832, 74, false);
#line 93 "D:\Code\FootManSim\FMS_Mvc\FMS3\Views\Player\Index.cshtml"
           Write(Component.InvokeAsync("CashFormat", new { cashValue = item.Value }).Result);

#line default
#line hidden
            EndContext();
            BeginContext(2906, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2962, 86, false);
#line 96 "D:\Code\FootManSim\FMS_Mvc\FMS3\Views\Player\Index.cshtml"
           Write(Component.InvokeAsync("InjuryStatus", new { injuredWeeks = item.InjuredWeeks }).Result);

#line default
#line hidden
            EndContext();
            BeginContext(3048, 21, true);
            WriteLiteral("\r\n            </td>\r\n");
            EndContext();
#line 98 "D:\Code\FootManSim\FMS_Mvc\FMS3\Views\Player\Index.cshtml"
             if (Model.DisplayType == PlayerListDisplayTypeEnum.MySquad
             || Model.DisplayType == PlayerListDisplayTypeEnum.OtherSquad)
            {

#line default
#line hidden
            BeginContext(3233, 22, true);
            WriteLiteral("                <td>\r\n");
            EndContext();
#line 102 "D:\Code\FootManSim\FMS_Mvc\FMS3\Views\Player\Index.cshtml"
                     if (item.IsSelected)
                    {

#line default
#line hidden
            BeginContext(3321, 42, true);
            WriteLiteral("                        <span>Yes</span>\r\n");
            EndContext();
#line 105 "D:\Code\FootManSim\FMS_Mvc\FMS3\Views\Player\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(3386, 23, true);
            WriteLiteral("                </td>\r\n");
            EndContext();
#line 107 "D:\Code\FootManSim\FMS_Mvc\FMS3\Views\Player\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(3424, 34, true);
            WriteLiteral("            <td>\r\n                ");
            EndContext();
            BeginContext(3459, 65, false);
#line 109 "D:\Code\FootManSim\FMS_Mvc\FMS3\Views\Player\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new { playerId = item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(3524, 21, true);
            WriteLiteral("\r\n            </td>\r\n");
            EndContext();
#line 111 "D:\Code\FootManSim\FMS_Mvc\FMS3\Views\Player\Index.cshtml"
             if (Model.DisplayType == PlayerListDisplayTypeEnum.MySquad)
            {

#line default
#line hidden
            BeginContext(3634, 42, true);
            WriteLiteral("                <td>\r\n                    ");
            EndContext();
            BeginContext(3677, 59, false);
#line 114 "D:\Code\FootManSim\FMS_Mvc\FMS3\Views\Player\Index.cshtml"
               Write(Html.ActionLink("Sell", "Sell", new { playerId = item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(3736, 25, true);
            WriteLiteral("\r\n                </td>\r\n");
            EndContext();
#line 116 "D:\Code\FootManSim\FMS_Mvc\FMS3\Views\Player\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(3776, 15, true);
            WriteLiteral("        </tr>\r\n");
            EndContext();
#line 118 "D:\Code\FootManSim\FMS_Mvc\FMS3\Views\Player\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(3802, 43, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n<hr />\r\n<div>\r\n    ");
            EndContext();
            BeginContext(3845, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f6858ca5809f47cbb29a2d91a28941b0", async() => {
                BeginContext(3889, 17, true);
                WriteLiteral("Back to Game Home");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3910, 8, true);
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FMS3.Models.PlayerListDisplay> Html { get; private set; }
    }
}
#pragma warning restore 1591
