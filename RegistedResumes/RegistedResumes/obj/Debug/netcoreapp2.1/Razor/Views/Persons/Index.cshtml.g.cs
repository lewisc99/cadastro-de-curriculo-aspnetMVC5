#pragma checksum "C:\Users\Pichau\Desktop\curriculo\RegistedResumes\RegistedResumes\Views\Persons\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e24735ed54c8c01c84b47cdc1eb14e6e982d413f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Persons_Index), @"mvc.1.0.view", @"/Views/Persons/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Persons/Index.cshtml", typeof(AspNetCore.Views_Persons_Index))]
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
#line 1 "C:\Users\Pichau\Desktop\curriculo\RegistedResumes\RegistedResumes\Views\_ViewImports.cshtml"
using RegistedResumes;

#line default
#line hidden
#line 2 "C:\Users\Pichau\Desktop\curriculo\RegistedResumes\RegistedResumes\Views\_ViewImports.cshtml"
using RegistedResumes.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e24735ed54c8c01c84b47cdc1eb14e6e982d413f", @"/Views/Persons/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6956251800abafa52fe6b3fa821040b5c22aff7", @"/Views/_ViewImports.cshtml")]
    public class Views_Persons_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<RegistedResumes.Models.Person>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(51, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Pichau\Desktop\curriculo\RegistedResumes\RegistedResumes\Views\Persons\Index.cshtml"
  
    ViewData["Title"] = "Index Persons";

#line default
#line hidden
            BeginContext(102, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(109, 17, false);
#line 7 "C:\Users\Pichau\Desktop\curriculo\RegistedResumes\RegistedResumes\Views\Persons\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(126, 18, true);
            WriteLiteral("</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(144, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a63c3a5a50f148deb127dcfd3f643471", async() => {
                BeginContext(191, 6, true);
                WriteLiteral("Create");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(201, 137, true);
            WriteLiteral("\r\n\r\n</p>\r\n<table class=\"table table-hover\">\r\n    <thead class=\"thead-dark\">\r\n        <tr>\r\n            <th scope=\"row\">\r\n                ");
            EndContext();
            BeginContext(339, 38, false);
#line 17 "C:\Users\Pichau\Desktop\curriculo\RegistedResumes\RegistedResumes\Views\Persons\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(377, 67, true);
            WriteLiteral("\r\n            </th>\r\n            <th scope=\"row\">\r\n                ");
            EndContext();
            BeginContext(445, 40, false);
#line 20 "C:\Users\Pichau\Desktop\curriculo\RegistedResumes\RegistedResumes\Views\Persons\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(485, 67, true);
            WriteLiteral("\r\n            </th>\r\n            <th scope=\"row\">\r\n                ");
            EndContext();
            BeginContext(553, 41, false);
#line 23 "C:\Users\Pichau\Desktop\curriculo\RegistedResumes\RegistedResumes\Views\Persons\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(594, 67, true);
            WriteLiteral("\r\n            </th>\r\n            <th scope=\"row\">\r\n                ");
            EndContext();
            BeginContext(662, 45, false);
#line 26 "C:\Users\Pichau\Desktop\curriculo\RegistedResumes\RegistedResumes\Views\Persons\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.BirthDate));

#line default
#line hidden
            EndContext();
            BeginContext(707, 67, true);
            WriteLiteral("\r\n            </th>\r\n            <th scope=\"row\">\r\n                ");
            EndContext();
            BeginContext(775, 51, false);
#line 29 "C:\Users\Pichau\Desktop\curriculo\RegistedResumes\RegistedResumes\Views\Persons\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Department.Name));

#line default
#line hidden
            EndContext();
            BeginContext(826, 67, true);
            WriteLiteral("\r\n            </th>\r\n            <th scope=\"row\">\r\n                ");
            EndContext();
            BeginContext(894, 42, false);
#line 32 "C:\Users\Pichau\Desktop\curriculo\RegistedResumes\RegistedResumes\Views\Persons\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Resume));

#line default
#line hidden
            EndContext();
            BeginContext(936, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 38 "C:\Users\Pichau\Desktop\curriculo\RegistedResumes\RegistedResumes\Views\Persons\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(1071, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1132, 37, false);
#line 42 "C:\Users\Pichau\Desktop\curriculo\RegistedResumes\RegistedResumes\Views\Persons\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1169, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1237, 39, false);
#line 45 "C:\Users\Pichau\Desktop\curriculo\RegistedResumes\RegistedResumes\Views\Persons\Index.cshtml"
               Write(Html.DisplayFor(modelitem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1276, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1344, 40, false);
#line 48 "C:\Users\Pichau\Desktop\curriculo\RegistedResumes\RegistedResumes\Views\Persons\Index.cshtml"
               Write(Html.DisplayFor(modelitem => item.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1384, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1452, 44, false);
#line 51 "C:\Users\Pichau\Desktop\curriculo\RegistedResumes\RegistedResumes\Views\Persons\Index.cshtml"
               Write(Html.DisplayFor(modelitem => item.BirthDate));

#line default
#line hidden
            EndContext();
            BeginContext(1496, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1564, 50, false);
#line 54 "C:\Users\Pichau\Desktop\curriculo\RegistedResumes\RegistedResumes\Views\Persons\Index.cshtml"
               Write(Html.DisplayFor(modelitem => item.Department.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1614, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1682, 41, false);
#line 57 "C:\Users\Pichau\Desktop\curriculo\RegistedResumes\RegistedResumes\Views\Persons\Index.cshtml"
               Write(Html.DisplayFor(modelitem => item.Resume));

#line default
#line hidden
            EndContext();
            BeginContext(1723, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1790, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fa0e4f46eb17413a8d9915899b1e9d76", async() => {
                BeginContext(1835, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 60 "C:\Users\Pichau\Desktop\curriculo\RegistedResumes\RegistedResumes\Views\Persons\Index.cshtml"
                                           WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1843, 28, true);
            WriteLiteral("<br />\r\n                    ");
            EndContext();
            BeginContext(1871, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f40a7e0d9e44dc7b8a613edceb7fe8b", async() => {
                BeginContext(1918, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 61 "C:\Users\Pichau\Desktop\curriculo\RegistedResumes\RegistedResumes\Views\Persons\Index.cshtml"
                                             WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1928, 46, true);
            WriteLiteral("\r\n\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 65 "C:\Users\Pichau\Desktop\curriculo\RegistedResumes\RegistedResumes\Views\Persons\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1985, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<RegistedResumes.Models.Person>> Html { get; private set; }
    }
}
#pragma warning restore 1591
