#pragma checksum "C:\Users\Aadam\Documents\GitHub\HealthAppGCU\HealthAppGCU\Views\Swimming\SwimmingCounter.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "61e4323360058f2f4e7aaa4d47866714f1020415"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Swimming_SwimmingCounter), @"mvc.1.0.view", @"/Views/Swimming/SwimmingCounter.cshtml")]
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
#line 1 "C:\Users\Aadam\Documents\GitHub\HealthAppGCU\HealthAppGCU\Views\_ViewImports.cshtml"
using HealthAppGCU;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Aadam\Documents\GitHub\HealthAppGCU\HealthAppGCU\Views\_ViewImports.cshtml"
using HealthAppGCU.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61e4323360058f2f4e7aaa4d47866714f1020415", @"/Views/Swimming/SwimmingCounter.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7da1098273bbaabc6bbfb53c2e674b104e7afc36", @"/Views/_ViewImports.cshtml")]
    public class Views_Swimming_SwimmingCounter : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SwimmingCounter", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Swimming", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "61e4323360058f2f4e7aaa4d47866714f10204153918", async() => {
                WriteLiteral("\r\n    <div class=\"input-group\">\r\n        <div class=\"input-group-prepend\">\r\n            <span class=\"input-group-text\">Time started</span>\r\n        </div>\r\n        <input name=\"startedDate\" class=\"form-control col-sm-3\" type=\"date\"");
                BeginWriteAttribute("min", " min=\"", 426, "\"", 543, 1);
#nullable restore
#line 13 "C:\Users\Aadam\Documents\GitHub\HealthAppGCU\HealthAppGCU\Views\Swimming\SwimmingCounter.cshtml"
WriteAttributeValue("", 432, DateTime.Now.Year + "-" + DateTime.Now.Month.ToString("D2") + "-"
        + DateTime.Now.Day.ToString("D2"), 432, 111, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("max", "\r\n               max=\"", 544, "\"", 682, 1);
#nullable restore
#line 15 "C:\Users\Aadam\Documents\GitHub\HealthAppGCU\HealthAppGCU\Views\Swimming\SwimmingCounter.cshtml"
WriteAttributeValue("", 566, DateTime.Now.Year + "-" + DateTime.Now.Month.ToString("D2") + "-" + DateTime.Now.Day.ToString("D2"), 566, 116, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        <input name=\"startedHour\" style=\"width:50px\" class=\"form-control\" type=\"time\" />\r\n\r\n        <div class=\"input-group-prepend\">\r\n            <span class=\"input-group-text\">Time ended</span>\r\n        </div>\r\n        <input name=\"endedDate\"");
                BeginWriteAttribute("min", " min=\"", 932, "\"", 1040, 1);
#nullable restore
#line 21 "C:\Users\Aadam\Documents\GitHub\HealthAppGCU\HealthAppGCU\Views\Swimming\SwimmingCounter.cshtml"
WriteAttributeValue("", 938, DateTime.Now.Year + "-" + DateTime.Now.Month.ToString("D2") + "-" + DateTime.Now.Day.ToString("D2"), 938, 102, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("max", "\r\n               max=\"", 1041, "\"", 1165, 1);
#nullable restore
#line 22 "C:\Users\Aadam\Documents\GitHub\HealthAppGCU\HealthAppGCU\Views\Swimming\SwimmingCounter.cshtml"
WriteAttributeValue("", 1063, DateTime.Now.Year + "-" + DateTime.Now.Month.ToString("D2") + "-" + DateTime.Now.Day.ToString("D2"), 1063, 102, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" type=""date"" class=""form-control col-sm-3"" />
        <input name=""endedHour"" style=""width:50px"" class=""form-control"" type=""time"" />


        <div class=""input-group-append"">
            <input type=""submit"" class=""btn btn-outline-dark"" name=""Submit"" />
        </div>
    </div>
    <div class=""input-group"">
        <div class=""input-group-prepend"">
            <span class=""input-group-text"">Distance</span>
        </div>
        <input step=""0.01"" name=""distanceCovered"" style=""width:50px; "" class=""form-control"" type=""number"" />
    </div>

");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
