#pragma checksum "D:\Code\FootManSim\FMS_Mvc\FMS3\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5221b05e46e36e8a3a9747dba3f79e7414c49927"
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
#line 1 "D:\Code\FootManSim\FMS_Mvc\FMS3\Views\_ViewImports.cshtml"
using FMS3;

#line default
#line hidden
#line 2 "D:\Code\FootManSim\FMS_Mvc\FMS3\Views\_ViewImports.cshtml"
using FMS3.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5221b05e46e36e8a3a9747dba3f79e7414c49927", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e236abf8294e3d95602ee79f6b237575f1daf205", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\Code\FootManSim\FMS_Mvc\FMS3\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 459, true);
            WriteLiteral(@"
<div id=""myCarousel"" class=""carousel slide"" data-ride=""carousel"" data-interval=""6000"">
    <ol class=""carousel-indicators"">
        <li data-target=""#myCarousel"" data-slide-to=""0"" class=""active""></li>
        <li data-target=""#myCarousel"" data-slide-to=""1""></li>
        <li data-target=""#myCarousel"" data-slide-to=""2""></li>
    </ol>
    

<div class=""row"">
    <div class=""col-md-3"">
        <h2>Main Menu</h2>
        <ul>
            <li>1. ");
            EndContext();
            BeginContext(505, 46, false);
#line 17 "D:\Code\FootManSim\FMS_Mvc\FMS3\Views\Home\Index.cshtml"
              Write(Html.ActionLink("New Game", "NewGame", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(551, 26, true);
            WriteLiteral("</li>\r\n            <li>2. ");
            EndContext();
            BeginContext(578, 48, false);
#line 18 "D:\Code\FootManSim\FMS_Mvc\FMS3\Views\Home\Index.cshtml"
              Write(Html.ActionLink("Load Game", "LoadGame", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(626, 28, true);
            WriteLiteral("</li>\r\n\r\n            <li>3. ");
            EndContext();
            BeginContext(655, 43, false);
#line 20 "D:\Code\FootManSim\FMS_Mvc\FMS3\Views\Home\Index.cshtml"
              Write(Html.ActionLink("Records", "Index", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(698, 26, true);
            WriteLiteral("</li>\r\n            <li>4. ");
            EndContext();
            BeginContext(725, 43, false);
#line 21 "D:\Code\FootManSim\FMS_Mvc\FMS3\Views\Home\Index.cshtml"
              Write(Html.ActionLink("Options", "Index", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(768, 26, true);
            WriteLiteral("</li>\r\n            <li>5. ");
            EndContext();
            BeginContext(795, 40, false);
#line 22 "D:\Code\FootManSim\FMS_Mvc\FMS3\Views\Home\Index.cshtml"
              Write(Html.ActionLink("Exit", "Index", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(835, 57, true);
            WriteLiteral("</li>\r\n\r\n\r\n        </ul>\r\n    </div>\r\n    \r\n   \r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
