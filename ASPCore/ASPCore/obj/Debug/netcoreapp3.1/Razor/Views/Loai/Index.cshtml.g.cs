#pragma checksum "C:\Users\NN\Source\Repos\ASPCore\ASPCore\ASPCore\Views\Loai\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7bfb8512c877f34cb263fb9f695bb2cdedaf8c78"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Loai_Index), @"mvc.1.0.view", @"/Views/Loai/Index.cshtml")]
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
#line 1 "C:\Users\NN\Source\Repos\ASPCore\ASPCore\ASPCore\Views\_ViewImports.cshtml"
using ASPCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\NN\Source\Repos\ASPCore\ASPCore\ASPCore\Views\_ViewImports.cshtml"
using ASPCore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7bfb8512c877f34cb263fb9f695bb2cdedaf8c78", @"/Views/Loai/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c4ada19fa78fcc822c8d676fe3956dba96f0df0", @"/Views/_ViewImports.cshtml")]
    public class Views_Loai_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ASPCore.Models.Loai>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\NN\Source\Repos\ASPCore\ASPCore\ASPCore\Views\Loai\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7bfb8512c877f34cb263fb9f695bb2cdedaf8c783625", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<div class=\"alert-danger\">");
#nullable restore
#line 12 "C:\Users\NN\Source\Repos\ASPCore\ASPCore\ASPCore\Views\Loai\Index.cshtml"
                     Write(TempData["ThongBao"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "C:\Users\NN\Source\Repos\ASPCore\ASPCore\ASPCore\Views\Loai\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.MaLoai));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "C:\Users\NN\Source\Repos\ASPCore\ASPCore\ASPCore\Views\Loai\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TenLoai));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "C:\Users\NN\Source\Repos\ASPCore\ASPCore\ASPCore\Views\Loai\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Hinh));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "C:\Users\NN\Source\Repos\ASPCore\ASPCore\ASPCore\Views\Loai\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.MoTa));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 32 "C:\Users\NN\Source\Repos\ASPCore\ASPCore\ASPCore\Views\Loai\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 35 "C:\Users\NN\Source\Repos\ASPCore\ASPCore\ASPCore\Views\Loai\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.MaLoai));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 38 "C:\Users\NN\Source\Repos\ASPCore\ASPCore\ASPCore\Views\Loai\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TenLoai));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 41 "C:\Users\NN\Source\Repos\ASPCore\ASPCore\ASPCore\Views\Loai\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Hinh));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 44 "C:\Users\NN\Source\Repos\ASPCore\ASPCore\ASPCore\Views\Loai\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.MoTa));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 47 "C:\Users\NN\Source\Repos\ASPCore\ASPCore\ASPCore\Views\Loai\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { id=item.MaLoai}));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n");
            WriteLiteral("                ");
#nullable restore
#line 49 "C:\Users\NN\Source\Repos\ASPCore\ASPCore\ASPCore\Views\Loai\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new { id=item.MaLoai }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 50 "C:\Users\NN\Source\Repos\ASPCore\ASPCore\ASPCore\Views\Loai\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new {  id=item.MaLoai }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 53 "C:\Users\NN\Source\Repos\ASPCore\ASPCore\ASPCore\Views\Loai\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ASPCore.Models.Loai>> Html { get; private set; }
    }
}
#pragma warning restore 1591
