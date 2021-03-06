#pragma checksum "D:\uni\2nd year\IP2\coursework\HealthAppGCU\HealthAppGCU\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a83ef1ae77d22e96b07e96d0ec9008d8306a0e06"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "D:\uni\2nd year\IP2\coursework\HealthAppGCU\HealthAppGCU\Views\_ViewImports.cshtml"
using HealthAppGCU;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\uni\2nd year\IP2\coursework\HealthAppGCU\HealthAppGCU\Views\_ViewImports.cshtml"
using HealthAppGCU.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\uni\2nd year\IP2\coursework\HealthAppGCU\HealthAppGCU\Views\Home\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a83ef1ae77d22e96b07e96d0ec9008d8306a0e06", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7da1098273bbaabc6bbfb53c2e674b104e7afc36", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HealthcareActivityViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\uni\2nd year\IP2\coursework\HealthAppGCU\HealthAppGCU\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 8 "D:\uni\2nd year\IP2\coursework\HealthAppGCU\HealthAppGCU\Views\Home\Index.cshtml"
 if (!this.User.Identity.IsAuthenticated)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""jumbotron"">
        <h1 style=""font-size:60px"">GCU Healthcare</h1>
        <p class=""lead"">Providing the best health tracking app from GCU Healthcare</p>
        <img src=""favicon.ico"" alt=""GCU logo"" width=""200"" height=""200"" />
        <!-- <p><a class=""btn btn-default"" href=""#"">Learn more &raquo;</a></p> -->
    </div>
");
            WriteLiteral(@"    <div class=""row"">
        <div class=""col-md-4"">
            <h2>Getting started</h2>
            <p>
                Start your healthy lifeststyle here. Register and track your progress.
            </p>
            <!-- <p><a class=""btn btn-default"" href=""#"">Learn more &raquo;</a></p> -->
        </div>
        <div class=""col-md-4"">
            <h2>What we offer</h2>
            <p>This service is to help you improve all aspects of your health</p>
            <p>- track your physiological data</p>
            <p>- track your physical data</p>
            <p>- improve your mental health</p>
            <!-- <p><a class=""btn btn-default"" href=""#"">Learn more &raquo;</a></p> -->
        </div>
        <div class=""col-md-4"">
            <h2>GCU Healthcare </h2>
            <p>Here for you</p>
            <img src=""favicon.ico"" alt=""GCU logo"" width=""200"" height=""200"">
        </div>
    </div>
");
#nullable restore
#line 39 "D:\uni\2nd year\IP2\coursework\HealthAppGCU\HealthAppGCU\Views\Home\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n    <h5 class=\"h5\" style=\"margin:8px\">Date: ");
#nullable restore
#line 43 "D:\uni\2nd year\IP2\coursework\HealthAppGCU\HealthAppGCU\Views\Home\Index.cshtml"
                                       Write(Model.Date.Value.ToShortDateString().TrimEnd(new char[] { '.', '??' }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n    <hr />\r\n    <h5 class=\"h5\" style=\"margin:8px; text-align:center\">Hello, ");
#nullable restore
#line 45 "D:\uni\2nd year\IP2\coursework\HealthAppGCU\HealthAppGCU\Views\Home\Index.cshtml"
                                                           Write(UserManager.GetUserName(User));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"! This is your daily healthcare information.</h5>
    <hr style=""width:50%; justify-content: left;"" />
</div>
    <div class=""row"" style=""text-align:center; margin-top:60px"">
        <div class=""col-3"">
            <h2 class=""display-3"">Calories</h2>
            <br />
            <hr />
            <h3 class=""display-4"">");
#nullable restore
#line 53 "D:\uni\2nd year\IP2\coursework\HealthAppGCU\HealthAppGCU\Views\Home\Index.cshtml"
                              Write(Model.Calories);

#line default
#line hidden
#nullable disable
            WriteLiteral("kcal.</h3>\r\n        </div>\r\n        <div class=\"col-3\">\r\n            <h2 class=\"display-3\">Water Intake</h2>\r\n            <hr />\r\n            <h3 class=\"display-4\">");
#nullable restore
#line 58 "D:\uni\2nd year\IP2\coursework\HealthAppGCU\HealthAppGCU\Views\Home\Index.cshtml"
                              Write(Model.WaterIntake);

#line default
#line hidden
#nullable disable
            WriteLiteral("ml.</h3>\r\n        </div>\r\n        <div class=\"col-3\">\r\n            <h2 class=\"display-3\">Hours Slept</h2>\r\n            <hr />\r\n            <h3 class=\"display-4\">");
#nullable restore
#line 63 "D:\uni\2nd year\IP2\coursework\HealthAppGCU\HealthAppGCU\Views\Home\Index.cshtml"
                              Write(Model.HoursSlept == null ? Model.HoursSlept : Model.HoursSlept.TrimStart('0'));

#line default
#line hidden
#nullable disable
            WriteLiteral("h.</h3>\r\n        </div>\r\n        <div class=\"col-3\">\r\n            <h2 class=\"display-3\">Weight</h2>\r\n            <br />\r\n            <hr />\r\n            <h3 class=\"display-4\">");
#nullable restore
#line 69 "D:\uni\2nd year\IP2\coursework\HealthAppGCU\HealthAppGCU\Views\Home\Index.cshtml"
                              Write(Model.Weight);

#line default
#line hidden
#nullable disable
            WriteLiteral("kg.</h3>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 72 "D:\uni\2nd year\IP2\coursework\HealthAppGCU\HealthAppGCU\Views\Home\Index.cshtml"

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<User> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HealthcareActivityViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
