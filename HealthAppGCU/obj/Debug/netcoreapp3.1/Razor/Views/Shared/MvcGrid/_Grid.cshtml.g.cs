#pragma checksum "C:\Users\Aadam\Documents\GitHub\HealthAppGCU\HealthAppGCU\Views\Shared\MvcGrid\_Grid.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae9a0a56c39968307e085a1a5f48d76944e34291"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_MvcGrid__Grid), @"mvc.1.0.view", @"/Views/Shared/MvcGrid/_Grid.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
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
#nullable restore
#line 1 "C:\Users\Aadam\Documents\GitHub\HealthAppGCU\HealthAppGCU\Views\Shared\MvcGrid\_Grid.cshtml"
using Microsoft.AspNetCore.Mvc.Rendering;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Aadam\Documents\GitHub\HealthAppGCU\HealthAppGCU\Views\Shared\MvcGrid\_Grid.cshtml"
using Microsoft.Extensions.Primitives;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Aadam\Documents\GitHub\HealthAppGCU\HealthAppGCU\Views\Shared\MvcGrid\_Grid.cshtml"
using NonFactors.Mvc.Grid;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Aadam\Documents\GitHub\HealthAppGCU\HealthAppGCU\Views\Shared\MvcGrid\_Grid.cshtml"
using System.Linq;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae9a0a56c39968307e085a1a5f48d76944e34291", @"/Views/Shared/MvcGrid/_Grid.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7da1098273bbaabc6bbfb53c2e674b104e7afc36", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_MvcGrid__Grid : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IGrid>
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\Aadam\Documents\GitHub\HealthAppGCU\HealthAppGCU\Views\Shared\MvcGrid\_Grid.cshtml"
  
    IGridRow<Object>[] rows = Model.Rows.ToArray();

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div");
            BeginWriteAttribute("id", " id=\"", 219, "\"", 233, 1);
#nullable restore
#line 12 "C:\Users\Aadam\Documents\GitHub\HealthAppGCU\HealthAppGCU\Views\Shared\MvcGrid\_Grid.cshtml"
WriteAttributeValue("", 224, Model.Id, 224, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 234, "\"", 305, 4);
            WriteAttributeValue("", 242, "mvc-grid", 242, 8, true);
            WriteAttributeValue(" ", 250, "mvc-grid-", 251, 10, true);
#nullable restore
#line 12 "C:\Users\Aadam\Documents\GitHub\HealthAppGCU\HealthAppGCU\Views\Shared\MvcGrid\_Grid.cshtml"
WriteAttributeValue("", 260, Model.FilterMode.ToString().ToLower(), 260, 40, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 300, "-mode", 300, 5, true);
            EndWriteAttribute();
            WriteLiteral(" data-name=\"");
#nullable restore
#line 12 "C:\Users\Aadam\Documents\GitHub\HealthAppGCU\HealthAppGCU\Views\Shared\MvcGrid\_Grid.cshtml"
                                                                                                  Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-filter-mode=\"");
#nullable restore
#line 12 "C:\Users\Aadam\Documents\GitHub\HealthAppGCU\HealthAppGCU\Views\Shared\MvcGrid\_Grid.cshtml"
                                                                                                                                 Write(Model.FilterMode);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-url=\"");
#nullable restore
#line 12 "C:\Users\Aadam\Documents\GitHub\HealthAppGCU\HealthAppGCU\Views\Shared\MvcGrid\_Grid.cshtml"
                                                                                                                                                              Write(Model.Url);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n    <");
            WriteLiteral("table");
#nullable restore
#line 13 "C:\Users\Aadam\Documents\GitHub\HealthAppGCU\HealthAppGCU\Views\Shared\MvcGrid\_Grid.cshtml"
       Write(Model.Attributes);

#line default
#line hidden
#nullable disable
            WriteLiteral(">\r\n        <thead>\r\n            <tr");
            BeginWriteAttribute("class", " class=\"", 457, "\"", 556, 2);
            WriteAttributeValue("", 465, "mvc-grid-headers", 465, 16, true);
#nullable restore
#line 15 "C:\Users\Aadam\Documents\GitHub\HealthAppGCU\HealthAppGCU\Views\Shared\MvcGrid\_Grid.cshtml"
WriteAttributeValue("", 481, Model.FilterMode == GridFilterMode.Header ? " mvc-grid-row-filters" : "", 481, 75, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 16 "C:\Users\Aadam\Documents\GitHub\HealthAppGCU\HealthAppGCU\Views\Shared\MvcGrid\_Grid.cshtml"
             foreach (IGridColumn column in Model.Columns)
            {
                String applied = (column.Filter.First ?? column.Filter.Second) == null ? "" : " applied";


#line default
#line hidden
#nullable disable
            WriteLiteral("                <th");
#nullable restore
#line 20 "C:\Users\Aadam\Documents\GitHub\HealthAppGCU\HealthAppGCU\Views\Shared\MvcGrid\_Grid.cshtml"
               Write(column.AsAttributes());

#line default
#line hidden
#nullable disable
            WriteLiteral(">\r\n");
#nullable restore
#line 21 "C:\Users\Aadam\Documents\GitHub\HealthAppGCU\HealthAppGCU\Views\Shared\MvcGrid\_Grid.cshtml"
                 if (column.Filter.IsEnabled == true && !String.IsNullOrEmpty(column.Filter.Name) && Model.FilterMode != GridFilterMode.Row)
                {
                    if (Model.FilterMode == GridFilterMode.Header)
                    {
                        String[] values = column.Filter.First?.Values ?? StringValues.Empty;
                        Int32 size = column.Title is String title && title.Length > 0 ? title.Length : 20;


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div>\r\n");
#nullable restore
#line 29 "C:\Users\Aadam\Documents\GitHub\HealthAppGCU\HealthAppGCU\Views\Shared\MvcGrid\_Grid.cshtml"
                         if (column.Filter.Options.Any())
                        {
                            values = column.Filter.Options.Where(option => values.Contains(option.Value)).Select(option => option.Text).ToArray();


#line default
#line hidden
#nullable disable
            WriteLiteral("                        <input class=\"mvc-grid-value\"");
            BeginWriteAttribute("value", " value=\"", 1562, "\"", 1596, 1);
#nullable restore
#line 33 "C:\Users\Aadam\Documents\GitHub\HealthAppGCU\HealthAppGCU\Views\Shared\MvcGrid\_Grid.cshtml"
WriteAttributeValue("", 1570, String.Join(", ", values), 1570, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("size", " size=\"", 1597, "\"", 1609, 1);
#nullable restore
#line 33 "C:\Users\Aadam\Documents\GitHub\HealthAppGCU\HealthAppGCU\Views\Shared\MvcGrid\_Grid.cshtml"
WriteAttributeValue("", 1604, size, 1604, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("placeholder", " placeholder=\"", 1610, "\"", 1637, 1);
#nullable restore
#line 33 "C:\Users\Aadam\Documents\GitHub\HealthAppGCU\HealthAppGCU\Views\Shared\MvcGrid\_Grid.cshtml"
WriteAttributeValue("", 1624, column.Title, 1624, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" tabindex=\"-1\" readonly />\r\n");
#nullable restore
#line 34 "C:\Users\Aadam\Documents\GitHub\HealthAppGCU\HealthAppGCU\Views\Shared\MvcGrid\_Grid.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <input class=\"mvc-grid-value\"");
            BeginWriteAttribute("value", " value=\"", 1803, "\"", 1837, 1);
#nullable restore
#line 37 "C:\Users\Aadam\Documents\GitHub\HealthAppGCU\HealthAppGCU\Views\Shared\MvcGrid\_Grid.cshtml"
WriteAttributeValue("", 1811, String.Join(", ", values), 1811, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("size", " size=\"", 1838, "\"", 1850, 1);
#nullable restore
#line 37 "C:\Users\Aadam\Documents\GitHub\HealthAppGCU\HealthAppGCU\Views\Shared\MvcGrid\_Grid.cshtml"
WriteAttributeValue("", 1845, size, 1845, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("placeholder", " placeholder=\"", 1851, "\"", 1878, 1);
#nullable restore
#line 37 "C:\Users\Aadam\Documents\GitHub\HealthAppGCU\HealthAppGCU\Views\Shared\MvcGrid\_Grid.cshtml"
WriteAttributeValue("", 1865, column.Title, 1865, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 38 "C:\Users\Aadam\Documents\GitHub\HealthAppGCU\HealthAppGCU\Views\Shared\MvcGrid\_Grid.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n");
#nullable restore
#line 40 "C:\Users\Aadam\Documents\GitHub\HealthAppGCU\HealthAppGCU\Views\Shared\MvcGrid\_Grid.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span class=\"mvc-grid-title\">");
#nullable restore
#line 43 "C:\Users\Aadam\Documents\GitHub\HealthAppGCU\HealthAppGCU\Views\Shared\MvcGrid\_Grid.cshtml"
                                            Write(column.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 44 "C:\Users\Aadam\Documents\GitHub\HealthAppGCU\HealthAppGCU\Views\Shared\MvcGrid\_Grid.cshtml"
                    }


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <select class=\"mvc-grid-options\">\r\n");
#nullable restore
#line 47 "C:\Users\Aadam\Documents\GitHub\HealthAppGCU\HealthAppGCU\Views\Shared\MvcGrid\_Grid.cshtml"
                         foreach (SelectListItem option in column.Filter.Options)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ae9a0a56c39968307e085a1a5f48d76944e3429112961", async() => {
#nullable restore
#line 49 "C:\Users\Aadam\Documents\GitHub\HealthAppGCU\HealthAppGCU\Views\Shared\MvcGrid\_Grid.cshtml"
                                                 Write(option.Text);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 49 "C:\Users\Aadam\Documents\GitHub\HealthAppGCU\HealthAppGCU\Views\Shared\MvcGrid\_Grid.cshtml"
                           WriteLiteral(option.Value);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 50 "C:\Users\Aadam\Documents\GitHub\HealthAppGCU\HealthAppGCU\Views\Shared\MvcGrid\_Grid.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </select>\r\n");
#nullable restore
#line 52 "C:\Users\Aadam\Documents\GitHub\HealthAppGCU\HealthAppGCU\Views\Shared\MvcGrid\_Grid.cshtml"

                    if (column.Sort.IsEnabled == true)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <button type=\"button\" class=\"mvc-grid-sort\"><span>");
#nullable restore
#line 55 "C:\Users\Aadam\Documents\GitHub\HealthAppGCU\HealthAppGCU\Views\Shared\MvcGrid\_Grid.cshtml"
                                                                  Write(column.Sort.Index + 1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></button>\r\n");
#nullable restore
#line 56 "C:\Users\Aadam\Documents\GitHub\HealthAppGCU\HealthAppGCU\Views\Shared\MvcGrid\_Grid.cshtml"
                    }


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <button type=\"button\"");
            BeginWriteAttribute("class", " class=\"", 2666, "\"", 2699, 2);
            WriteAttributeValue("", 2674, "mvc-grid-filter", 2674, 15, true);
#nullable restore
#line 58 "C:\Users\Aadam\Documents\GitHub\HealthAppGCU\HealthAppGCU\Views\Shared\MvcGrid\_Grid.cshtml"
WriteAttributeValue("", 2689, applied, 2689, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></button>\r\n");
#nullable restore
#line 59 "C:\Users\Aadam\Documents\GitHub\HealthAppGCU\HealthAppGCU\Views\Shared\MvcGrid\_Grid.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span class=\"mvc-grid-title\">");
#nullable restore
#line 62 "C:\Users\Aadam\Documents\GitHub\HealthAppGCU\HealthAppGCU\Views\Shared\MvcGrid\_Grid.cshtml"
                                            Write(column.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 63 "C:\Users\Aadam\Documents\GitHub\HealthAppGCU\HealthAppGCU\Views\Shared\MvcGrid\_Grid.cshtml"

                    if (column.Sort.IsEnabled == true)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <button type=\"button\" class=\"mvc-grid-sort\"><span>");
#nullable restore
#line 66 "C:\Users\Aadam\Documents\GitHub\HealthAppGCU\HealthAppGCU\Views\Shared\MvcGrid\_Grid.cshtml"
                                                                  Write(column.Sort.Index + 1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></button>\r\n");
#nullable restore
#line 67 "C:\Users\Aadam\Documents\GitHub\HealthAppGCU\HealthAppGCU\Views\Shared\MvcGrid\_Grid.cshtml"
                    }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </th>\r\n");
#nullable restore
#line 70 "C:\Users\Aadam\Documents\GitHub\HealthAppGCU\HealthAppGCU\Views\Shared\MvcGrid\_Grid.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tr>\r\n");
#nullable restore
#line 72 "C:\Users\Aadam\Documents\GitHub\HealthAppGCU\HealthAppGCU\Views\Shared\MvcGrid\_Grid.cshtml"
         if (Model.FilterMode == GridFilterMode.Row)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr class=\"mvc-grid-row-filters\">\r\n");
#nullable restore
#line 75 "C:\Users\Aadam\Documents\GitHub\HealthAppGCU\HealthAppGCU\Views\Shared\MvcGrid\_Grid.cshtml"
             foreach (IGridColumn column in Model.Columns)
            {
                String hidden = column.IsHidden ? " mvc-grid-hidden" : "";

                if (column.Filter.IsEnabled == true && !String.IsNullOrEmpty(column.Filter.Name))
                {
                    String applied = (column.Filter.First ?? column.Filter.Second) == null ? "" : " applied";


#line default
#line hidden
#nullable disable
            WriteLiteral("                <th");
            BeginWriteAttribute("class", " class=\"", 3650, "\"", 3698, 3);
            WriteAttributeValue("", 3658, "filterable", 3658, 10, true);
#nullable restore
#line 83 "C:\Users\Aadam\Documents\GitHub\HealthAppGCU\HealthAppGCU\Views\Shared\MvcGrid\_Grid.cshtml"
WriteAttributeValue(" ", 3668, column.CssClasses, 3669, 20, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 83 "C:\Users\Aadam\Documents\GitHub\HealthAppGCU\HealthAppGCU\Views\Shared\MvcGrid\_Grid.cshtml"
WriteAttributeValue("", 3689, hidden, 3689, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <div>\r\n");
#nullable restore
#line 85 "C:\Users\Aadam\Documents\GitHub\HealthAppGCU\HealthAppGCU\Views\Shared\MvcGrid\_Grid.cshtml"
                     if (column.Filter.Options.Any())
                    {
                        if (column.Filter.Type == GridFilterType.Multi)
                        {
                            String[] values = column.Filter.First?.Values ?? StringValues.Empty;
                            values = column.Filter.Options.Where(option => values.Contains(option.Value)).Select(option => option.Text).ToArray();


#line default
#line hidden
#nullable disable
            WriteLiteral("                        <input class=\"mvc-grid-value\"");
            BeginWriteAttribute("value", " value=\"", 4208, "\"", 4242, 1);
#nullable restore
#line 92 "C:\Users\Aadam\Documents\GitHub\HealthAppGCU\HealthAppGCU\Views\Shared\MvcGrid\_Grid.cshtml"
WriteAttributeValue("", 4216, String.Join(", ", values), 4216, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" tabindex=\"-1\" readonly />\r\n");
            WriteLiteral("                        <select class=\"mvc-grid-options\">\r\n");
#nullable restore
#line 95 "C:\Users\Aadam\Documents\GitHub\HealthAppGCU\HealthAppGCU\Views\Shared\MvcGrid\_Grid.cshtml"
                             foreach (SelectListItem option in column.Filter.Options)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ae9a0a56c39968307e085a1a5f48d76944e3429121462", async() => {
#nullable restore
#line 97 "C:\Users\Aadam\Documents\GitHub\HealthAppGCU\HealthAppGCU\Views\Shared\MvcGrid\_Grid.cshtml"
                                                     Write(option.Text);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 97 "C:\Users\Aadam\Documents\GitHub\HealthAppGCU\HealthAppGCU\Views\Shared\MvcGrid\_Grid.cshtml"
                               WriteLiteral(option.Value);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 98 "C:\Users\Aadam\Documents\GitHub\HealthAppGCU\HealthAppGCU\Views\Shared\MvcGrid\_Grid.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </select>\r\n");
#nullable restore
#line 100 "C:\Users\Aadam\Documents\GitHub\HealthAppGCU\HealthAppGCU\Views\Shared\MvcGrid\_Grid.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <select class=\"mvc-grid-value\">\r\n");
#nullable restore
#line 104 "C:\Users\Aadam\Documents\GitHub\HealthAppGCU\HealthAppGCU\Views\Shared\MvcGrid\_Grid.cshtml"
                             foreach (SelectListItem option in column.Filter.Options)
                            {
                                if (column.Filter.First?.Values.Contains(option.Value) == true)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ae9a0a56c39968307e085a1a5f48d76944e3429124407", async() => {
#nullable restore
#line 108 "C:\Users\Aadam\Documents\GitHub\HealthAppGCU\HealthAppGCU\Views\Shared\MvcGrid\_Grid.cshtml"
                                                              Write(option.Text);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 108 "C:\Users\Aadam\Documents\GitHub\HealthAppGCU\HealthAppGCU\Views\Shared\MvcGrid\_Grid.cshtml"
                               WriteLiteral(option.Value);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 109 "C:\Users\Aadam\Documents\GitHub\HealthAppGCU\HealthAppGCU\Views\Shared\MvcGrid\_Grid.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ae9a0a56c39968307e085a1a5f48d76944e3429126910", async() => {
#nullable restore
#line 112 "C:\Users\Aadam\Documents\GitHub\HealthAppGCU\HealthAppGCU\Views\Shared\MvcGrid\_Grid.cshtml"
                                                     Write(option.Text);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 112 "C:\Users\Aadam\Documents\GitHub\HealthAppGCU\HealthAppGCU\Views\Shared\MvcGrid\_Grid.cshtml"
                               WriteLiteral(option.Value);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 113 "C:\Users\Aadam\Documents\GitHub\HealthAppGCU\HealthAppGCU\Views\Shared\MvcGrid\_Grid.cshtml"
                                }
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </select>\r\n");
#nullable restore
#line 116 "C:\Users\Aadam\Documents\GitHub\HealthAppGCU\HealthAppGCU\Views\Shared\MvcGrid\_Grid.cshtml"
                        }
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <input class=\"mvc-grid-value\"");
            BeginWriteAttribute("value", " value=\"", 5520, "\"", 5556, 1);
#nullable restore
#line 120 "C:\Users\Aadam\Documents\GitHub\HealthAppGCU\HealthAppGCU\Views\Shared\MvcGrid\_Grid.cshtml"
WriteAttributeValue("", 5528, column.Filter.First?.Values, 5528, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 121 "C:\Users\Aadam\Documents\GitHub\HealthAppGCU\HealthAppGCU\Views\Shared\MvcGrid\_Grid.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <button type=\"button\"");
            BeginWriteAttribute("class", " class=\"", 5630, "\"", 5663, 2);
            WriteAttributeValue("", 5638, "mvc-grid-filter", 5638, 15, true);
#nullable restore
#line 122 "C:\Users\Aadam\Documents\GitHub\HealthAppGCU\HealthAppGCU\Views\Shared\MvcGrid\_Grid.cshtml"
WriteAttributeValue("", 5653, applied, 5653, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></button>\r\n                    </div>\r\n                </th>\r\n");
#nullable restore
#line 125 "C:\Users\Aadam\Documents\GitHub\HealthAppGCU\HealthAppGCU\Views\Shared\MvcGrid\_Grid.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <th");
            BeginWriteAttribute("class", " class=\"", 5806, "\"", 5843, 2);
#nullable restore
#line 128 "C:\Users\Aadam\Documents\GitHub\HealthAppGCU\HealthAppGCU\Views\Shared\MvcGrid\_Grid.cshtml"
WriteAttributeValue("", 5814, column.CssClasses, 5814, 20, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 128 "C:\Users\Aadam\Documents\GitHub\HealthAppGCU\HealthAppGCU\Views\Shared\MvcGrid\_Grid.cshtml"
WriteAttributeValue("", 5834, hidden, 5834, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></th>\r\n");
#nullable restore
#line 129 "C:\Users\Aadam\Documents\GitHub\HealthAppGCU\HealthAppGCU\Views\Shared\MvcGrid\_Grid.cshtml"
                }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tr>\r\n");
#nullable restore
#line 132 "C:\Users\Aadam\Documents\GitHub\HealthAppGCU\HealthAppGCU\Views\Shared\MvcGrid\_Grid.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 135 "C:\Users\Aadam\Documents\GitHub\HealthAppGCU\HealthAppGCU\Views\Shared\MvcGrid\_Grid.cshtml"
         foreach (IGridRow<Object> row in rows)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <");
            WriteLiteral("tr");
#nullable restore
#line 137 "C:\Users\Aadam\Documents\GitHub\HealthAppGCU\HealthAppGCU\Views\Shared\MvcGrid\_Grid.cshtml"
            Write(row.Attributes);

#line default
#line hidden
#nullable disable
            WriteLiteral(">\r\n");
#nullable restore
#line 138 "C:\Users\Aadam\Documents\GitHub\HealthAppGCU\HealthAppGCU\Views\Shared\MvcGrid\_Grid.cshtml"
             foreach (IGridColumn column in Model.Columns)
            {
                String classes = (column.IsHidden ? column.CssClasses + " mvc-grid-hidden" : column.CssClasses).Trim();

                if (String.IsNullOrEmpty(classes))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>");
#nullable restore
#line 144 "C:\Users\Aadam\Documents\GitHub\HealthAppGCU\HealthAppGCU\Views\Shared\MvcGrid\_Grid.cshtml"
               Write(column.ValueFor(row));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 145 "C:\Users\Aadam\Documents\GitHub\HealthAppGCU\HealthAppGCU\Views\Shared\MvcGrid\_Grid.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td");
            BeginWriteAttribute("class", " class=\"", 6443, "\"", 6459, 1);
#nullable restore
#line 148 "C:\Users\Aadam\Documents\GitHub\HealthAppGCU\HealthAppGCU\Views\Shared\MvcGrid\_Grid.cshtml"
WriteAttributeValue("", 6451, classes, 6451, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 148 "C:\Users\Aadam\Documents\GitHub\HealthAppGCU\HealthAppGCU\Views\Shared\MvcGrid\_Grid.cshtml"
                                Write(column.ValueFor(row));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 149 "C:\Users\Aadam\Documents\GitHub\HealthAppGCU\HealthAppGCU\Views\Shared\MvcGrid\_Grid.cshtml"
                }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </");
            WriteLiteral("tr>\r\n");
#nullable restore
#line 152 "C:\Users\Aadam\Documents\GitHub\HealthAppGCU\HealthAppGCU\Views\Shared\MvcGrid\_Grid.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 153 "C:\Users\Aadam\Documents\GitHub\HealthAppGCU\HealthAppGCU\Views\Shared\MvcGrid\_Grid.cshtml"
         if (!Model.Rows.Any() && Model.EmptyText != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr class=\"mvc-grid-empty-row\">\r\n                <td");
            BeginWriteAttribute("colspan", " colspan=\"", 6689, "\"", 6721, 1);
#nullable restore
#line 156 "C:\Users\Aadam\Documents\GitHub\HealthAppGCU\HealthAppGCU\Views\Shared\MvcGrid\_Grid.cshtml"
WriteAttributeValue("", 6699, Model.Columns.Count(), 6699, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    ");
#nullable restore
#line 157 "C:\Users\Aadam\Documents\GitHub\HealthAppGCU\HealthAppGCU\Views\Shared\MvcGrid\_Grid.cshtml"
               Write(Html.Raw(Model.EmptyText));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 160 "C:\Users\Aadam\Documents\GitHub\HealthAppGCU\HealthAppGCU\Views\Shared\MvcGrid\_Grid.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n");
#nullable restore
#line 162 "C:\Users\Aadam\Documents\GitHub\HealthAppGCU\HealthAppGCU\Views\Shared\MvcGrid\_Grid.cshtml"
     if (!String.IsNullOrEmpty(Model.FooterPartialViewName))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tfoot>\r\n            ");
#nullable restore
#line 165 "C:\Users\Aadam\Documents\GitHub\HealthAppGCU\HealthAppGCU\Views\Shared\MvcGrid\_Grid.cshtml"
       Write(await Html.PartialAsync(Model.FooterPartialViewName, Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </tfoot>\r\n");
#nullable restore
#line 167 "C:\Users\Aadam\Documents\GitHub\HealthAppGCU\HealthAppGCU\Views\Shared\MvcGrid\_Grid.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </");
            WriteLiteral("table>\r\n");
#nullable restore
#line 169 "C:\Users\Aadam\Documents\GitHub\HealthAppGCU\HealthAppGCU\Views\Shared\MvcGrid\_Grid.cshtml"
     if (Model.Pager != null)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 171 "C:\Users\Aadam\Documents\GitHub\HealthAppGCU\HealthAppGCU\Views\Shared\MvcGrid\_Grid.cshtml"
   Write(await Html.PartialAsync(Model.Pager.PartialViewName, Model.Pager));

#line default
#line hidden
#nullable disable
#nullable restore
#line 171 "C:\Users\Aadam\Documents\GitHub\HealthAppGCU\HealthAppGCU\Views\Shared\MvcGrid\_Grid.cshtml"
                                                                          
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IGrid> Html { get; private set; }
    }
}
#pragma warning restore 1591
