#pragma checksum "D:\uni\2nd year\IP2\coursework\HealthAppGCU\HealthAppGCU\Views\Run\RunCounter.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ba752530678db19652a459c1a06d626f0dad299"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Run_RunCounter), @"mvc.1.0.view", @"/Views/Run/RunCounter.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ba752530678db19652a459c1a06d626f0dad299", @"/Views/Run/RunCounter.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7da1098273bbaabc6bbfb53c2e674b104e7afc36", @"/Views/_ViewImports.cshtml")]
    public class Views_Run_RunCounter : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RunCounter", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Run", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4ba752530678db19652a459c1a06d626f0dad2993855", async() => {
                WriteLiteral("\r\n    <div class=\"input-group\">\r\n        <div class=\"input-group-prepend\">\r\n            <span class=\"input-group-text\">Time started</span>\r\n        </div>\r\n        <input name=\"startedDate\" class=\"form-control col-sm-3\" type=\"date\"");
                BeginWriteAttribute("min", " min=\"", 416, "\"", 534, 1);
#nullable restore
#line 13 "D:\uni\2nd year\IP2\coursework\HealthAppGCU\HealthAppGCU\Views\Run\RunCounter.cshtml"
WriteAttributeValue("", 422, DateTime.Now.Year + "-" + DateTime.Now.Month.ToString("D2") + "-" 
        + DateTime.Now.Day.ToString("D2"), 422, 112, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("max", "\r\n               max=\"", 535, "\"", 673, 1);
#nullable restore
#line 15 "D:\uni\2nd year\IP2\coursework\HealthAppGCU\HealthAppGCU\Views\Run\RunCounter.cshtml"
WriteAttributeValue("", 557, DateTime.Now.Year + "-" + DateTime.Now.Month.ToString("D2") + "-" + DateTime.Now.Day.ToString("D2"), 557, 116, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        <input name=\"startedHour\" style=\"width:50px\" class=\"form-control\" type=\"time\" />\r\n\r\n        <div class=\"input-group-prepend\">\r\n            <span class=\"input-group-text\">Time ended</span>\r\n        </div>\r\n        <input name=\"endedDate\"");
                BeginWriteAttribute("min", " min=\"", 923, "\"", 1031, 1);
#nullable restore
#line 21 "D:\uni\2nd year\IP2\coursework\HealthAppGCU\HealthAppGCU\Views\Run\RunCounter.cshtml"
WriteAttributeValue("", 929, DateTime.Now.Year + "-" + DateTime.Now.Month.ToString("D2") + "-" + DateTime.Now.Day.ToString("D2"), 929, 102, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("max", "\r\n               max=\"", 1032, "\"", 1156, 1);
#nullable restore
#line 22 "D:\uni\2nd year\IP2\coursework\HealthAppGCU\HealthAppGCU\Views\Run\RunCounter.cshtml"
WriteAttributeValue("", 1054, DateTime.Now.Year + "-" + DateTime.Now.Month.ToString("D2") + "-" + DateTime.Now.Day.ToString("D2"), 1054, 102, false);

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
