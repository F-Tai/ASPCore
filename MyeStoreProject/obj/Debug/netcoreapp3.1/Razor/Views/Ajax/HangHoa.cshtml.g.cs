#pragma checksum "C:\Users\NN\source\repos\ASPCore\MyeStoreProject\Views\Ajax\HangHoa.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e0a0e8a388f60614f248998353c1f4a8a29d4685"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ajax_HangHoa), @"mvc.1.0.view", @"/Views/Ajax/HangHoa.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0a0e8a388f60614f248998353c1f4a8a29d4685", @"/Views/Ajax/HangHoa.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2fd4e67b759e1c2c4f80021e37c4901a01f76290", @"/Views/_ViewImports.cshtml")]
    public class Views_Ajax_HangHoa : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\NN\source\repos\ASPCore\MyeStoreProject\Views\Ajax\HangHoa.cshtml"
  
    ViewData["Title"] = "HangHoa";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Tìm kiếm hàng hóa</h1>\r\n\r\n<input id=\"txtSearch\" placeholder=\"Nhập từ khóa\"/>\r\n<div id=\"result\" class=\"border\"></div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $(function () {
            // gắn sự kiện nhả phím
            $(""#txtSearch"").keyup(function () {
                $.ajax({
                    url: ""/Ajax/Search"",
                    data: { ""keyword"": $(this).val().trim().toLowerCase() },
                    success: function (dataReturn) {
                        $(""#result"").html(dataReturn);
                    },
                    error: function (xhr) {
                        alert: ""Loi"";
                        console.log(xhr);
                    }
                });

            });
        });

    </script>

 ");
            }
            );
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
