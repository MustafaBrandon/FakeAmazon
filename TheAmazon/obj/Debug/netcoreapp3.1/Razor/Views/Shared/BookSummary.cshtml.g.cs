#pragma checksum "C:\Users\brand\source\repos\TheAmazon\TheAmazon\Views\Shared\BookSummary.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fbb0fa7f696f979c2dbefddc2046eabc356f20a3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_BookSummary), @"mvc.1.0.view", @"/Views/Shared/BookSummary.cshtml")]
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
#line 1 "C:\Users\brand\source\repos\TheAmazon\TheAmazon\Views\_ViewImports.cshtml"
using TheAmazon;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\brand\source\repos\TheAmazon\TheAmazon\Views\_ViewImports.cshtml"
using TheAmazon.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\brand\source\repos\TheAmazon\TheAmazon\Views\_ViewImports.cshtml"
using TheAmazon.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\brand\source\repos\TheAmazon\TheAmazon\Views\_ViewImports.cshtml"
using TheAmazon.Infrastructure;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fbb0fa7f696f979c2dbefddc2046eabc356f20a3", @"/Views/Shared/BookSummary.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1276cbfbef7aafbaccf062ffb45e789de2a12cd3", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_BookSummary : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Book>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n<div class=\"card m-1 p-1\">\r\n    <div class=\"bg-light p-1\">\r\n        <h4>");
#nullable restore
#line 12 "C:\Users\brand\source\repos\TheAmazon\TheAmazon\Views\Shared\BookSummary.cshtml"
       Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n        <span class=\"badge badge-primary\">");
#nullable restore
#line 13 "C:\Users\brand\source\repos\TheAmazon\TheAmazon\Views\Shared\BookSummary.cshtml"
                                     Write(Model.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n    </div> \r\n    <ul>\r\n\r\n        <li>Author: ");
#nullable restore
#line 17 "C:\Users\brand\source\repos\TheAmazon\TheAmazon\Views\Shared\BookSummary.cshtml"
               Write(Model.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n        <li>Published by ");
#nullable restore
#line 18 "C:\Users\brand\source\repos\TheAmazon\TheAmazon\Views\Shared\BookSummary.cshtml"
                    Write(Model.Publisher);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n        <li>ISBN ");
#nullable restore
#line 19 "C:\Users\brand\source\repos\TheAmazon\TheAmazon\Views\Shared\BookSummary.cshtml"
            Write(Model.Isbn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n        <li>");
#nullable restore
#line 20 "C:\Users\brand\source\repos\TheAmazon\TheAmazon\Views\Shared\BookSummary.cshtml"
       Write(Model.PageCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" pages</li>\r\n");
            WriteLiteral("        <li>");
#nullable restore
#line 22 "C:\Users\brand\source\repos\TheAmazon\TheAmazon\Views\Shared\BookSummary.cshtml"
       Write(Model.Classification);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n        <li>$");
#nullable restore
#line 23 "C:\Users\brand\source\repos\TheAmazon\TheAmazon\Views\Shared\BookSummary.cshtml"
        Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    </ul>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fbb0fa7f696f979c2dbefddc2046eabc356f20a36456", async() => {
                WriteLiteral("\r\n        <input type=\"hidden\" ");
                WriteLiteral(" name=\"BookId\" value=\"");
#nullable restore
#line 26 "C:\Users\brand\source\repos\TheAmazon\TheAmazon\Views\Shared\BookSummary.cshtml"
                                                                  Write(Model.BookId);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" />\r\n        <input type=\"hidden\" name=\"returnUrl\"");
                BeginWriteAttribute("value", " value=\"", 804, "\"", 859, 1);
#nullable restore
#line 27 "C:\Users\brand\source\repos\TheAmazon\TheAmazon\Views\Shared\BookSummary.cshtml"
WriteAttributeValue("", 812, ViewContext.HttpContext.Request.PathAndQuery(), 812, 47, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        <span class=\"card-text\">\r\n            <button type=\"submit\" class=\"btn btn-success btn-sm float-left\">Add to Cart</button>\r\n        </span>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Book> Html { get; private set; }
    }
}
#pragma warning restore 1591
