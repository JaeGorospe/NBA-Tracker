#pragma checksum "C:\Users\jaenuz.gorospe\Documents\NBA-Tracker\NBATracker\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0e644a1a7583c60a19c6082f840bc8a1d8a71a33"
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
#line 1 "C:\Users\jaenuz.gorospe\Documents\NBA-Tracker\NBATracker\Views\_ViewImports.cshtml"
using NBATracker;

#line default
#line hidden
#line 2 "C:\Users\jaenuz.gorospe\Documents\NBA-Tracker\NBATracker\Views\_ViewImports.cshtml"
using NBATracker.Models;

#line default
#line hidden
#line 1 "C:\Users\jaenuz.gorospe\Documents\NBA-Tracker\NBATracker\Views\Home\Index.cshtml"
using Humanizer;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e644a1a7583c60a19c6082f840bc8a1d8a71a33", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1fd24686d9427e74d038f4565002fbe4df373a1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NBATracker.Models.HomeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(19, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\jaenuz.gorospe\Documents\NBA-Tracker\NBATracker\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(106, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 8 "C:\Users\jaenuz.gorospe\Documents\NBA-Tracker\NBATracker\Views\Home\Index.cshtml"
 foreach (Game game in Model.TodaysGames)
{

#line default
#line hidden
            BeginContext(154, 23, true);
            WriteLiteral("    <div>\r\n        <h2>");
            EndContext();
            BeginContext(178, 21, false);
#line 11 "C:\Users\jaenuz.gorospe\Documents\NBA-Tracker\NBATracker\Views\Home\Index.cshtml"
       Write(game.AwayTeam.TriCode);

#line default
#line hidden
            EndContext();
            BeginContext(199, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(201, 2, true);
            WriteLiteral("@ ");
            EndContext();
            BeginContext(204, 21, false);
#line 11 "C:\Users\jaenuz.gorospe\Documents\NBA-Tracker\NBATracker\Views\Home\Index.cshtml"
                                 Write(game.HomeTeam.TriCode);

#line default
#line hidden
            EndContext();
            BeginContext(225, 19, true);
            WriteLiteral("</h2>\r\n        <h2>");
            EndContext();
            BeginContext(245, 10, false);
#line 12 "C:\Users\jaenuz.gorospe\Documents\NBA-Tracker\NBATracker\Views\Home\Index.cshtml"
       Write(game.Clock);

#line default
#line hidden
            EndContext();
            BeginContext(255, 19, true);
            WriteLiteral("</h2>\r\n        <h2>");
            EndContext();
            BeginContext(275, 21, false);
#line 13 "C:\Users\jaenuz.gorospe\Documents\NBA-Tracker\NBATracker\Views\Home\Index.cshtml"
       Write(game.StartTimeEastern);

#line default
#line hidden
            EndContext();
            BeginContext(296, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(300, 28, false);
#line 13 "C:\Users\jaenuz.gorospe\Documents\NBA-Tracker\NBATracker\Views\Home\Index.cshtml"
                                Write(game.StartTimeUTC.Humanize());

#line default
#line hidden
            EndContext();
            BeginContext(328, 54, true);
            WriteLiteral("</h2>\r\n        <h2></h2>\r\n        <hr />\r\n    </div>\r\n");
            EndContext();
#line 17 "C:\Users\jaenuz.gorospe\Documents\NBA-Tracker\NBATracker\Views\Home\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NBATracker.Models.HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
