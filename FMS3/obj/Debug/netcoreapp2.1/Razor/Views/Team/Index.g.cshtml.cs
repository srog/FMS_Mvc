#pragma checksum "D:\Code\FootManSim\FMS_Mvc\FMS3\Views\Team\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb7afe2a28abfce1cac534b6421e5063412254eb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Team_Index), @"mvc.1.0.view", @"/Views/Team/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Team/Index.cshtml", typeof(AspNetCore.Views_Team_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb7afe2a28abfce1cac534b6421e5063412254eb", @"/Views/Team/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e236abf8294e3d95602ee79f6b237575f1daf205", @"/Views/_ViewImports.cshtml")]
    public class Views_Team_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FMS3.Models.Team>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(38, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Code\FootManSim\FMS_Mvc\FMS3\Views\Team\Index.cshtml"
  
    ViewData["Title"] = "Team List";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(132, 31, true);
            WriteLiteral("\r\n\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(163, 113, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "95adfcc20d054bb7a3536841fffcf6d7", async() => {
                BeginContext(169, 72, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>");
                EndContext();
                BeginContext(242, 17, false);
#line 14 "D:\Code\FootManSim\FMS_Mvc\FMS3\Views\Team\Index.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
                EndContext();
                BeginContext(259, 10, true);
                WriteLiteral("</title>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(276, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(278, 1679, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7a00c65a3c024566bb2ec6db6b570d38", async() => {
                BeginContext(284, 161, true);
                WriteLiteral("\r\n\r\n    <h3>Team List</h3>\r\n\r\n    <div>\r\n        <table class=\"table table-bordered\">\r\n            <tr height=\"40px\">\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(446, 32, false);
#line 24 "D:\Code\FootManSim\FMS_Mvc\FMS3\Views\Team\Index.cshtml"
               Write(Html.LabelFor(t => t.First().Id));

#line default
#line hidden
                EndContext();
                BeginContext(478, 67, true);
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(546, 34, false);
#line 27 "D:\Code\FootManSim\FMS_Mvc\FMS3\Views\Team\Index.cshtml"
               Write(Html.LabelFor(t => t.First().Name));

#line default
#line hidden
                EndContext();
                BeginContext(580, 67, true);
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(648, 40, false);
#line 30 "D:\Code\FootManSim\FMS_Mvc\FMS3\Views\Team\Index.cshtml"
               Write(Html.LabelFor(t => t.First().DivisionId));

#line default
#line hidden
                EndContext();
                BeginContext(688, 67, true);
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(756, 40, false);
#line 33 "D:\Code\FootManSim\FMS_Mvc\FMS3\Views\Team\Index.cshtml"
               Write(Html.LabelFor(t => t.First().YearFormed));

#line default
#line hidden
                EndContext();
                BeginContext(796, 67, true);
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(864, 34, false);
#line 36 "D:\Code\FootManSim\FMS_Mvc\FMS3\Views\Team\Index.cshtml"
               Write(Html.LabelFor(t => t.First().Cash));

#line default
#line hidden
                EndContext();
                BeginContext(898, 71, true);
                WriteLiteral("\r\n                </td>\r\n                <td></td>\r\n            </tr>\r\n");
                EndContext();
#line 40 "D:\Code\FootManSim\FMS_Mvc\FMS3\Views\Team\Index.cshtml"
             foreach (var team in Model)
            {

#line default
#line hidden
                BeginContext(1026, 72, true);
                WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(1099, 18, false);
#line 44 "D:\Code\FootManSim\FMS_Mvc\FMS3\Views\Team\Index.cshtml"
                   Write(team.Id.ToString());

#line default
#line hidden
                EndContext();
                BeginContext(1117, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(1197, 20, false);
#line 47 "D:\Code\FootManSim\FMS_Mvc\FMS3\Views\Team\Index.cshtml"
                   Write(team.Name.ToString());

#line default
#line hidden
                EndContext();
                BeginContext(1217, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(1297, 83, false);
#line 50 "D:\Code\FootManSim\FMS_Mvc\FMS3\Views\Team\Index.cshtml"
                   Write(Component.InvokeAsync("DivisionName", new { divisionId = @team.DivisionId }).Result);

#line default
#line hidden
                EndContext();
                BeginContext(1380, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(1460, 26, false);
#line 53 "D:\Code\FootManSim\FMS_Mvc\FMS3\Views\Team\Index.cshtml"
                   Write(team.YearFormed.ToString());

#line default
#line hidden
                EndContext();
                BeginContext(1486, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(1566, 74, false);
#line 56 "D:\Code\FootManSim\FMS_Mvc\FMS3\Views\Team\Index.cshtml"
                   Write(Component.InvokeAsync("CashFormat", new { cashValue = @team.Cash }).Result);

#line default
#line hidden
                EndContext();
                BeginContext(1640, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(1720, 71, false);
#line 59 "D:\Code\FootManSim\FMS_Mvc\FMS3\Views\Team\Index.cshtml"
                   Write(Html.ActionLink("Details", "TeamDetails", "Team", new { id = team.Id }));

#line default
#line hidden
                EndContext();
                BeginContext(1791, 52, true);
                WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
                EndContext();
#line 62 "D:\Code\FootManSim\FMS_Mvc\FMS3\Views\Team\Index.cshtml"
            }

#line default
#line hidden
                BeginContext(1858, 36, true);
                WriteLiteral("        </table>\r\n    </div>\r\n\r\n    ");
                EndContext();
                BeginContext(1895, 53, false);
#line 66 "D:\Code\FootManSim\FMS_Mvc\FMS3\Views\Team\Index.cshtml"
Write(Html.ActionLink("Back To Main Page", "Index", "Game"));

#line default
#line hidden
                EndContext();
                BeginContext(1948, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1957, 13, true);
            WriteLiteral("\r\n</html>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FMS3.Models.Team>> Html { get; private set; }
    }
}
#pragma warning restore 1591
