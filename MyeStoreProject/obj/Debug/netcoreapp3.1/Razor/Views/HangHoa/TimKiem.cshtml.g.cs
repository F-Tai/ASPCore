#pragma checksum "C:\Users\NN\source\repos\ASPCore\MyeStoreProject\Views\HangHoa\TimKiem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee8ac5d42f08b0ea2dc779be20c472b8b85c1be1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HangHoa_TimKiem), @"mvc.1.0.view", @"/Views/HangHoa/TimKiem.cshtml")]
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
#line 1 "C:\Users\NN\source\repos\ASPCore\MyeStoreProject\Views\_ViewImports.cshtml"
using MyeStoreProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\NN\source\repos\ASPCore\MyeStoreProject\Views\_ViewImports.cshtml"
using MyeStoreProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\NN\source\repos\ASPCore\MyeStoreProject\Views\HangHoa\TimKiem.cshtml"
using MyeStoreProject.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee8ac5d42f08b0ea2dc779be20c472b8b85c1be1", @"/Views/HangHoa/TimKiem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2fd4e67b759e1c2c4f80021e37c4901a01f76290", @"/Views/_ViewImports.cshtml")]
    public class Views_HangHoa_TimKiem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<HangHoaViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "TimKiem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("80"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\NN\source\repos\ASPCore\MyeStoreProject\Views\HangHoa\TimKiem.cshtml"
  
    ViewData["Title"] = "TimKiem";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Tìm kiếm</h1>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee8ac5d42f08b0ea2dc779be20c472b8b85c1be14468", async() => {
                WriteLiteral("\r\n    Cần tìm: <input name=\"Keyword\" placeholder=\"Nhập tên hàng hóa cần tìm\" /><br />\r\n    Giá từ: <input type=\"number\" name=\"GiaTu\" min=\"0\" />\r\n    đến: <input type=\"number\" name=\"GiaDen\" min=\"0\" />\r\n    <button class=\"btn btn-primary\">Tìm</button>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 15 "C:\Users\NN\source\repos\ASPCore\MyeStoreProject\Views\HangHoa\TimKiem.cshtml"
 if(Model != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>Có <span class=\"text-danger\">");
#nullable restore
#line 17 "C:\Users\NN\source\repos\ASPCore\MyeStoreProject\Views\HangHoa\TimKiem.cshtml"
                                 Write(Model.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> hàng hóa</div>\r\n    <table>\r\n");
#nullable restore
#line 19 "C:\Users\NN\source\repos\ASPCore\MyeStoreProject\Views\HangHoa\TimKiem.cshtml"
         foreach(var hh in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 22 "C:\Users\NN\source\repos\ASPCore\MyeStoreProject\Views\HangHoa\TimKiem.cshtml"
               Write(hh.MaHh);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 23 "C:\Users\NN\source\repos\ASPCore\MyeStoreProject\Views\HangHoa\TimKiem.cshtml"
               Write(hh.TenHh);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ee8ac5d42f08b0ea2dc779be20c472b8b85c1be17497", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 703, "~/Hinh/", 703, 7, true);
#nullable restore
#line 24 "C:\Users\NN\source\repos\ASPCore\MyeStoreProject\Views\HangHoa\TimKiem.cshtml"
AddHtmlAttributeValue("", 710, hh.Hinh, 710, 8, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 25 "C:\Users\NN\source\repos\ASPCore\MyeStoreProject\Views\HangHoa\TimKiem.cshtml"
               Write(hh.DonGia.ToString("#,##0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" đ</td>\r\n            </tr>\r\n");
#nullable restore
#line 27 "C:\Users\NN\source\repos\ASPCore\MyeStoreProject\Views\HangHoa\TimKiem.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n");
#nullable restore
#line 29 "C:\Users\NN\source\repos\ASPCore\MyeStoreProject\Views\HangHoa\TimKiem.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<HangHoaViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
