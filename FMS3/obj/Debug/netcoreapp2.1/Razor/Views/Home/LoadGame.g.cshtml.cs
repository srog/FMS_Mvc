#pragma checksum "D:\Projects\Projects\FMS3\FMS_Mvc\FMS3\Views\Home\LoadGame.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2bb25134875aebe93219af06aa26be24e06cf4b3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_LoadGame), @"mvc.1.0.view", @"/Views/Home/LoadGame.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/LoadGame.cshtml", typeof(AspNetCore.Views_Home_LoadGame))]
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
#line 1 "D:\Projects\Projects\FMS3\FMS_Mvc\FMS3\Views\_ViewImports.cshtml"
using FMS3;

#line default
#line hidden
#line 2 "D:\Projects\Projects\FMS3\FMS_Mvc\FMS3\Views\_ViewImports.cshtml"
using FMS3.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2bb25134875aebe93219af06aa26be24e06cf4b3", @"/Views/Home/LoadGame.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e236abf8294e3d95602ee79f6b237575f1daf205", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_LoadGame : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FMS3.Models.GameDetails>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(45, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Projects\Projects\FMS3\FMS_Mvc\FMS3\Views\Home\LoadGame.cshtml"
  
    ViewData["Title"] = "LoadGame";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(138, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 8 "D:\Projects\Projects\FMS3\FMS_Mvc\FMS3\Views\Home\LoadGame.cshtml"
 if (Model == null)
{

#line default
#line hidden
            BeginContext(164, 30, true);
            WriteLiteral("    <h4>No Games Saved!</h4>\r\n");
            EndContext();
#line 11 "D:\Projects\Projects\FMS3\FMS_Mvc\FMS3\Views\Home\LoadGame.cshtml"
}
else
{


#line default
#line hidden
            BeginContext(208, 24, true);
            WriteLiteral("    <h2>Load Game</h2>\r\n");
            EndContext();
            BeginContext(234, 86, true);
            WriteLiteral("<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(321, 47, false);
#line 22 "D:\Projects\Projects\FMS3\FMS_Mvc\FMS3\Views\Home\LoadGame.cshtml"
           Write(Html.DisplayNameFor(model => model.ManagerName));

#line default
#line hidden
            EndContext();
            BeginContext(368, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(424, 42, false);
#line 25 "D:\Projects\Projects\FMS3\FMS_Mvc\FMS3\Views\Home\LoadGame.cshtml"
           Write(Html.DisplayNameFor(model => model.TeamId));

#line default
#line hidden
            EndContext();
            BeginContext(466, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(522, 51, false);
#line 28 "D:\Projects\Projects\FMS3\FMS_Mvc\FMS3\Views\Home\LoadGame.cshtml"
           Write(Html.DisplayNameFor(model => model.CurrentSeasonId));

#line default
#line hidden
            EndContext();
            BeginContext(573, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(629, 47, false);
#line 31 "D:\Projects\Projects\FMS3\FMS_Mvc\FMS3\Views\Home\LoadGame.cshtml"
           Write(Html.DisplayNameFor(model => model.CurrentWeek));

#line default
#line hidden
            EndContext();
            BeginContext(676, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 37 "D:\Projects\Projects\FMS3\FMS_Mvc\FMS3\Views\Home\LoadGame.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(811, 62, true);
            WriteLiteral("            <tr>\r\n\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(874, 46, false);
#line 42 "D:\Projects\Projects\FMS3\FMS_Mvc\FMS3\Views\Home\LoadGame.cshtml"
               Write(Html.DisplayFor(modelItem => item.ManagerName));

#line default
#line hidden
            EndContext();
            BeginContext(920, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(988, 69, false);
#line 45 "D:\Projects\Projects\FMS3\FMS_Mvc\FMS3\Views\Home\LoadGame.cshtml"
               Write(await Component.InvokeAsync("TeamName", new { teamId = item.TeamId }));

#line default
#line hidden
            EndContext();
            BeginContext(1057, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1125, 82, false);
#line 48 "D:\Projects\Projects\FMS3\FMS_Mvc\FMS3\Views\Home\LoadGame.cshtml"
               Write(await Component.InvokeAsync("SeasonName", new { seasonId = item.CurrentSeasonId }));

#line default
#line hidden
            EndContext();
            BeginContext(1207, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1275, 16, false);
#line 51 "D:\Projects\Projects\FMS3\FMS_Mvc\FMS3\Views\Home\LoadGame.cshtml"
               Write(item.WeekDisplay);

#line default
#line hidden
            EndContext();
            BeginContext(1291, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1359, 62, false);
#line 54 "D:\Projects\Projects\FMS3\FMS_Mvc\FMS3\Views\Home\LoadGame.cshtml"
               Write(Html.ActionLink("Select","Start","Game", new { id = item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(1421, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 57 "D:\Projects\Projects\FMS3\FMS_Mvc\FMS3\Views\Home\LoadGame.cshtml"

        }

#line default
#line hidden
            BeginContext(1478, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            EndContext();
#line 61 "D:\Projects\Projects\FMS3\FMS_Mvc\FMS3\Views\Home\LoadGame.cshtml"
}

#line default
#line hidden
            BeginContext(1505, 13, true);
            WriteLiteral("\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1518, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bff3c9ee1dce4377a5b84422e7f6b612", async() => {
                BeginContext(1540, 12, true);
                WriteLiteral("Back to Menu");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1556, 8, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FMS3.Models.GameDetails>> Html { get; private set; }
    }
}
#pragma warning restore 1591
