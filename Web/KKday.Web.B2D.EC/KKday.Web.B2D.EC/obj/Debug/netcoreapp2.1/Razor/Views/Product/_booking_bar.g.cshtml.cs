#pragma checksum "/Users/zhangfengrong/Documents/Core_Test/KKday.Web.B2D.EC_ok/KKday.Web.B2D.EC/Views/Product/_booking_bar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b2e1f8575eca1d2c929ec4a1a1d91f54b1e42650"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product__booking_bar), @"mvc.1.0.view", @"/Views/Product/_booking_bar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/_booking_bar.cshtml", typeof(AspNetCore.Views_Product__booking_bar))]
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
#line 1 "/Users/zhangfengrong/Documents/Core_Test/KKday.Web.B2D.EC_ok/KKday.Web.B2D.EC/Views/_ViewImports.cshtml"
using KKday.Web.B2D.EC;

#line default
#line hidden
#line 2 "/Users/zhangfengrong/Documents/Core_Test/KKday.Web.B2D.EC_ok/KKday.Web.B2D.EC/Views/_ViewImports.cshtml"
using KKday.Web.B2D.EC.Models;

#line default
#line hidden
#line 1 "/Users/zhangfengrong/Documents/Core_Test/KKday.Web.B2D.EC_ok/KKday.Web.B2D.EC/Views/Product/_booking_bar.cshtml"
using KKday.Web.B2D.EC.Models.Model.Product;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2e1f8575eca1d2c929ec4a1a1d91f54b1e42650", @"/Views/Product/_booking_bar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1decf7227a59ebd0c9a1b3569a3e4065089e3cb", @"/Views/_ViewImports.cshtml")]
    public class Views_Product__booking_bar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductforEcModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "/Users/zhangfengrong/Documents/Core_Test/KKday.Web.B2D.EC_ok/KKday.Web.B2D.EC/Views/Product/_booking_bar.cshtml"
  
    var prodTitle = (ProdTitleModel)ViewData["prodTitle"];
    var currency = (string)ViewData["currency"];

#line default
#line hidden
            BeginContext(189, 39, true);
            WriteLiteral("\r\n\r\n<div class=\"row minPriceBar\">\r\n    ");
            EndContext();
            BeginContext(229, 27, false);
#line 10 "/Users/zhangfengrong/Documents/Core_Test/KKday.Web.B2D.EC_ok/KKday.Web.B2D.EC/Views/Product/_booking_bar.cshtml"
Write(prodTitle.common_per_person);

#line default
#line hidden
            EndContext();
            BeginContext(256, 3, true);
            WriteLiteral(" : ");
            EndContext();
            BeginContext(260, 15, false);
#line 10 "/Users/zhangfengrong/Documents/Core_Test/KKday.Web.B2D.EC_ok/KKday.Web.B2D.EC/Views/Product/_booking_bar.cshtml"
                              Write(Model.b2d_price);

#line default
#line hidden
            EndContext();
            BeginContext(275, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(277, 8, false);
#line 10 "/Users/zhangfengrong/Documents/Core_Test/KKday.Web.B2D.EC_ok/KKday.Web.B2D.EC/Views/Product/_booking_bar.cshtml"
                                               Write(currency);

#line default
#line hidden
            EndContext();
            BeginContext(285, 17, true);
            WriteLiteral("   <br />\r\n    \r\n");
            EndContext();
#line 12 "/Users/zhangfengrong/Documents/Core_Test/KKday.Web.B2D.EC_ok/KKday.Web.B2D.EC/Views/Product/_booking_bar.cshtml"
     if (Model.prod_mkt.is_ec_sale == true)
    {

#line default
#line hidden
            BeginContext(354, 112, true);
            WriteLiteral("        <div class=\"row\"><button type=\"button\" class=\"btn btn-info\" id=\"btnConfirm\" onclick=\"chgPkgInfo(\'\',\'\')\">");
            EndContext();
            BeginContext(467, 24, false);
#line 14 "/Users/zhangfengrong/Documents/Core_Test/KKday.Web.B2D.EC_ok/KKday.Web.B2D.EC/Views/Product/_booking_bar.cshtml"
                                                                                                           Write(prodTitle.common_booking);

#line default
#line hidden
            EndContext();
            BeginContext(491, 18, true);
            WriteLiteral(" </button></div>\r\n");
            EndContext();
#line 15 "/Users/zhangfengrong/Documents/Core_Test/KKday.Web.B2D.EC_ok/KKday.Web.B2D.EC/Views/Product/_booking_bar.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(533, 105, true);
            WriteLiteral("       <div class=\"row\"><button type = \"button\" class=\"btn btn-info\" id=\"btnConfirm\" disabled=\"disabled\">");
            EndContext();
            BeginContext(639, 35, false);
#line 18 "/Users/zhangfengrong/Documents/Core_Test/KKday.Web.B2D.EC_ok/KKday.Web.B2D.EC/Views/Product/_booking_bar.cshtml"
                                                                                                    Write(prodTitle.product_index_coming_soon);

#line default
#line hidden
            EndContext();
            BeginContext(674, 18, true);
            WriteLiteral(" </button></div>\r\n");
            EndContext();
#line 19 "/Users/zhangfengrong/Documents/Core_Test/KKday.Web.B2D.EC_ok/KKday.Web.B2D.EC/Views/Product/_booking_bar.cshtml"
    }

#line default
#line hidden
            BeginContext(699, 46, true);
            WriteLiteral("\r\n</div>\r\n\r\n<div class=\"row confirmBar\">\r\n    ");
            EndContext();
            BeginContext(746, 35, false);
#line 24 "/Users/zhangfengrong/Documents/Core_Test/KKday.Web.B2D.EC_ok/KKday.Web.B2D.EC/Views/Product/_booking_bar.cshtml"
Write(Html.Hidden("hdnConfirmPkgOid", ""));

#line default
#line hidden
            EndContext();
            BeginContext(781, 98, true);
            WriteLiteral("\r\n    <label id=\"confirmName\"></label><br />\r\n    <label id=\"confirmSelDate\"></label> <br />\r\n    ");
            EndContext();
            BeginContext(880, 22, false);
#line 27 "/Users/zhangfengrong/Documents/Core_Test/KKday.Web.B2D.EC_ok/KKday.Web.B2D.EC/Views/Product/_booking_bar.cshtml"
Write(prodTitle.common_total);

#line default
#line hidden
            EndContext();
            BeginContext(902, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(907, 19, false);
#line 27 "/Users/zhangfengrong/Documents/Core_Test/KKday.Web.B2D.EC_ok/KKday.Web.B2D.EC/Views/Product/_booking_bar.cshtml"
                          Write(Model.prod_currency);

#line default
#line hidden
            EndContext();
            BeginContext(926, 190, true);
            WriteLiteral("  <label id=\"confirmPrice\">0</label>\r\n    <div class=\"row\"><button type=\"button\" class=\"btn btn-info\" id=\"btnConfirm\" onclick=\"btnConfirm()\">立即預訂2</button></div>\r\n</div>\r\n\r\n<div class=\"row\">");
            EndContext();
            BeginContext(1117, 17, false);
#line 31 "/Users/zhangfengrong/Documents/Core_Test/KKday.Web.B2D.EC_ok/KKday.Web.B2D.EC/Views/Product/_booking_bar.cshtml"
            Write(Model.confirmInfo);

#line default
#line hidden
            EndContext();
            BeginContext(1134, 25, true);
            WriteLiteral("</div>\r\n<div class=\"row\">");
            EndContext();
            BeginContext(1160, 15, false);
#line 32 "/Users/zhangfengrong/Documents/Core_Test/KKday.Web.B2D.EC_ok/KKday.Web.B2D.EC/Views/Product/_booking_bar.cshtml"
            Write(Model.policy_no);

#line default
#line hidden
            EndContext();
            BeginContext(1175, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(1180, 16, false);
#line 32 "/Users/zhangfengrong/Documents/Core_Test/KKday.Web.B2D.EC_ok/KKday.Web.B2D.EC/Views/Product/_booking_bar.cshtml"
                                Write(Model.policyInfo);

#line default
#line hidden
            EndContext();
            BeginContext(1196, 10, true);
            WriteLiteral("</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductforEcModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
