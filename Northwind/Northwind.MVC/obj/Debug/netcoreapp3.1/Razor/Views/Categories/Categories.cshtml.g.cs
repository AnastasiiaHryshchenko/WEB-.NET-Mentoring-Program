#pragma checksum "C:\Users\Anastasiia_Hryshchen\Desktop\.net repos\WEB-.NET-Mentoring-Program\Northwind\Northwind.MVC\Views\Categories\Categories.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "75f6dfb8ea485f0f17b4b344e3b23a9d4b88ea10"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Categories_Categories), @"mvc.1.0.view", @"/Views/Categories/Categories.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75f6dfb8ea485f0f17b4b344e3b23a9d4b88ea10", @"/Views/Categories/Categories.cshtml")]
    public class Views_Categories_Categories : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Northwind.Core.Category>>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Anastasiia_Hryshchen\Desktop\.net repos\WEB-.NET-Mentoring-Program\Northwind\Northwind.MVC\Views\Categories\Categories.cshtml"
  
    ViewData["Title"] = "Categories";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "75f6dfb8ea485f0f17b4b344e3b23a9d4b88ea103097", async() => {
                WriteLiteral("\r\n    <title>Category</title>\r\n");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "75f6dfb8ea485f0f17b4b344e3b23a9d4b88ea104094", async() => {
                WriteLiteral("\r\n    <div style=\"display: flex; flex-flow: wrap; justify-content: center\">\r\n");
#nullable restore
#line 13 "C:\Users\Anastasiia_Hryshchen\Desktop\.net repos\WEB-.NET-Mentoring-Program\Northwind\Northwind.MVC\Views\Categories\Categories.cshtml"
         foreach (var category in Model)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"        <div style=""margin: 2rem"">
            <div class=""card"" style=""width: 18rem;"">
                <img src=""https://picsum.photos/id/237/200/300"" class=""card-img-top"" alt=""..."">
                <div class=""card-body"">
                    <h5 class=""card-title"">");
#nullable restore
#line 19 "C:\Users\Anastasiia_Hryshchen\Desktop\.net repos\WEB-.NET-Mentoring-Program\Northwind\Northwind.MVC\Views\Categories\Categories.cshtml"
                                      Write(category.CategoryName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n                    <a href=\"#\" class=\"btn btn-primary\">Go somewhere</a>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 24 "C:\Users\Anastasiia_Hryshchen\Desktop\.net repos\WEB-.NET-Mentoring-Program\Northwind\Northwind.MVC\Views\Categories\Categories.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </div>\r\n");
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
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Northwind.Core.Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
