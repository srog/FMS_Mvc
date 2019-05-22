#pragma checksum "D:\Code\FootManSim\FMS_Mvc\FMS3\Views\Team\TeamDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b846b22aa2f33360267e029bfca625e7f33a8ceb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Team_TeamDetails), @"mvc.1.0.view", @"/Views/Team/TeamDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Team/TeamDetails.cshtml", typeof(AspNetCore.Views_Team_TeamDetails))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b846b22aa2f33360267e029bfca625e7f33a8ceb", @"/Views/Team/TeamDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e236abf8294e3d95602ee79f6b237575f1daf205", @"/Views/_ViewImports.cshtml")]
    public class Views_Team_TeamDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FMS3.Models.Team>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Code\FootManSim\FMS_Mvc\FMS3\Views\Team\TeamDetails.cshtml"
  
    ViewData["Title"] = "Team Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(120, 21, true);
            WriteLiteral("\r\n<h2>Team Details - ");
            EndContext();
            BeginContext(142, 30, false);
#line 7 "D:\Code\FootManSim\FMS_Mvc\FMS3\Views\Team\TeamDetails.cshtml"
              Write(Html.LabelForModel(Model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(172, 9, true);
            WriteLiteral("</h2>\r\n\r\n");
            EndContext();
            BeginContext(182, 46, false);
#line 9 "D:\Code\FootManSim\FMS_Mvc\FMS3\Views\Team\TeamDetails.cshtml"
Write(Html.DisplayNameFor(model => model.DivisionId));

#line default
#line hidden
            EndContext();
            BeginContext(228, 3, true);
            WriteLiteral(":\r\n");
            EndContext();
            BeginContext(232, 83, false);
#line 10 "D:\Code\FootManSim\FMS_Mvc\FMS3\Views\Team\TeamDetails.cshtml"
Write(Component.InvokeAsync("DivisionName", new { divisionId = Model.DivisionId }).Result);

#line default
#line hidden
            EndContext();
            BeginContext(315, 12, true);
            WriteLiteral("\r\n<br />\r\n\r\n");
            EndContext();
            BeginContext(328, 46, false);
#line 13 "D:\Code\FootManSim\FMS_Mvc\FMS3\Views\Team\TeamDetails.cshtml"
Write(Html.DisplayNameFor(model => model.YearFormed));

#line default
#line hidden
            EndContext();
            BeginContext(374, 3, true);
            WriteLiteral(":\r\n");
            EndContext();
            BeginContext(378, 47, false);
#line 14 "D:\Code\FootManSim\FMS_Mvc\FMS3\Views\Team\TeamDetails.cshtml"
Write(Html.LabelForModel(Model.YearFormed.ToString()));

#line default
#line hidden
            EndContext();
            BeginContext(425, 12, true);
            WriteLiteral("\r\n<br />\r\n\r\n");
            EndContext();
            BeginContext(438, 40, false);
#line 17 "D:\Code\FootManSim\FMS_Mvc\FMS3\Views\Team\TeamDetails.cshtml"
Write(Html.DisplayNameFor(model => model.Cash));

#line default
#line hidden
            EndContext();
            BeginContext(478, 3, true);
            WriteLiteral(":\r\n");
            EndContext();
            BeginContext(482, 74, false);
#line 18 "D:\Code\FootManSim\FMS_Mvc\FMS3\Views\Team\TeamDetails.cshtml"
Write(Component.InvokeAsync("CashFormat", new { cashValue = Model.Cash }).Result);

#line default
#line hidden
            EndContext();
            BeginContext(556, 12, true);
            WriteLiteral("\r\n<br />\r\n\r\n");
            EndContext();
            BeginContext(569, 51, false);
#line 21 "D:\Code\FootManSim\FMS_Mvc\FMS3\Views\Team\TeamDetails.cshtml"
Write(Html.DisplayNameFor(model => model.StadiumCapacity));

#line default
#line hidden
            EndContext();
            BeginContext(620, 3, true);
            WriteLiteral(":\r\n");
            EndContext();
            BeginContext(624, 52, false);
#line 22 "D:\Code\FootManSim\FMS_Mvc\FMS3\Views\Team\TeamDetails.cshtml"
Write(Html.LabelForModel(Model.StadiumCapacity.ToString()));

#line default
#line hidden
            EndContext();
            BeginContext(676, 18, true);
            WriteLiteral("\r\n<br />\r\n<hr />\r\n");
            EndContext();
            BeginContext(695, 45, false);
#line 25 "D:\Code\FootManSim\FMS_Mvc\FMS3\Views\Team\TeamDetails.cshtml"
Write(Html.DisplayNameFor(model => model.Formation));

#line default
#line hidden
            EndContext();
            BeginContext(740, 3, true);
            WriteLiteral(":\r\n");
            EndContext();
            BeginContext(744, 46, false);
#line 26 "D:\Code\FootManSim\FMS_Mvc\FMS3\Views\Team\TeamDetails.cshtml"
Write(Html.LabelForModel(Model.Formation.ToString()));

#line default
#line hidden
            EndContext();
            BeginContext(790, 10, true);
            WriteLiteral("\r\n<br />\r\n");
            EndContext();
            BeginContext(801, 70, false);
#line 28 "D:\Code\FootManSim\FMS_Mvc\FMS3\Views\Team\TeamDetails.cshtml"
Write(Html.ActionLink("Squad", "Squad", "Player", new { teamId = Model.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(871, 40, true);
            WriteLiteral("\r\n<hr />\r\n<hr />\r\nRecent Form:\r\n<br />\r\n");
            EndContext();
            BeginContext(912, 69, false);
#line 33 "D:\Code\FootManSim\FMS_Mvc\FMS3\Views\Team\TeamDetails.cshtml"
Write(Component.InvokeAsync("RecentForm", new { teamId = Model.Id }).Result);

#line default
#line hidden
            EndContext();
            BeginContext(981, 42, true);
            WriteLiteral("\r\n<hr />\r\n<div>\r\n    This Week\'s Fixture: ");
            EndContext();
            BeginContext(1024, 47, false);
#line 36 "D:\Code\FootManSim\FMS_Mvc\FMS3\Views\Team\TeamDetails.cshtml"
                    Write(await Component.InvokeAsync("ThisWeeksFixture"));

#line default
#line hidden
            EndContext();
            BeginContext(1071, 18, true);
            WriteLiteral("\r\n</div>\r\n<br />\r\n");
            EndContext();
            BeginContext(1090, 129, false);
#line 39 "D:\Code\FootManSim\FMS_Mvc\FMS3\Views\Team\TeamDetails.cshtml"
Write(Html.ActionLink("All Team's Fixtures/Results", "TeamFixtures", "Match", new { teamId = Model.Id, divisionId = Model.DivisionId }));

#line default
#line hidden
            EndContext();
            BeginContext(1219, 25, true);
            WriteLiteral("\r\n<hr />\r\nNews:\r\n<br />\r\n");
            EndContext();
            BeginContext(1245, 67, false);
#line 43 "D:\Code\FootManSim\FMS_Mvc\FMS3\Views\Team\TeamDetails.cshtml"
Write(Component.InvokeAsync("TeamNews", new { teamId = Model.Id }).Result);

#line default
#line hidden
            EndContext();
            BeginContext(1312, 64, true);
            WriteLiteral("\r\n<hr />\r\n\r\n\r\n(History)\r\n<hr />\r\n\r\n(Records)\r\n<br />\r\n<br />\r\n\r\n");
            EndContext();
            BeginContext(1377, 53, false);
#line 54 "D:\Code\FootManSim\FMS_Mvc\FMS3\Views\Team\TeamDetails.cshtml"
Write(Html.ActionLink("Back To Main Page", "Index", "Game"));

#line default
#line hidden
            EndContext();
            BeginContext(1430, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FMS3.Models.Team> Html { get; private set; }
    }
}
#pragma warning restore 1591
