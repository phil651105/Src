#pragma checksum "/Users/caizhiliang/Documents/GitHub/erichu62/Src/Web/KKday.Web.B2D.EC/KKday.Web.B2D.EC/Views/Booking/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3c5c84d0c94829ab6c3ddd0a5674e4bf8f86aee7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Booking_Index), @"mvc.1.0.view", @"/Views/Booking/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Booking/Index.cshtml", typeof(AspNetCore.Views_Booking_Index))]
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
#line 1 "/Users/caizhiliang/Documents/GitHub/erichu62/Src/Web/KKday.Web.B2D.EC/KKday.Web.B2D.EC/Views/_ViewImports.cshtml"
using KKday.Web.B2D.EC;

#line default
#line hidden
#line 2 "/Users/caizhiliang/Documents/GitHub/erichu62/Src/Web/KKday.Web.B2D.EC/KKday.Web.B2D.EC/Views/_ViewImports.cshtml"
using KKday.Web.B2D.EC.Models;

#line default
#line hidden
#line 1 "/Users/caizhiliang/Documents/GitHub/erichu62/Src/Web/KKday.Web.B2D.EC/KKday.Web.B2D.EC/Views/Booking/Index.cshtml"
using KKday.Web.B2D.EC.Models.Model.Product;

#line default
#line hidden
#line 2 "/Users/caizhiliang/Documents/GitHub/erichu62/Src/Web/KKday.Web.B2D.EC/KKday.Web.B2D.EC/Views/Booking/Index.cshtml"
using KKday.Web.B2D.EC.Models.Model.Booking;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c5c84d0c94829ab6c3ddd0a5674e4bf8f86aee7", @"/Views/Booking/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1decf7227a59ebd0c9a1b3569a3e4065089e3cb", @"/Views/_ViewImports.cshtml")]
    public class Views_Booking_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/js/bootstrap-datepicker.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery.validate.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/booking.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/booking.validate.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/booking.event.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("otherForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("otherFormClass"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(92, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(111, 6, true);
                WriteLiteral("\r\n\r\n\r\n");
                EndContext();
                BeginContext(176, 4, true);
                WriteLiteral("    ");
                EndContext();
                BeginContext(180, 71, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b599b5b139ee4e43876d34ca9f37ded4", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(251, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(257, 51, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dec4ef0513d64383a62898a18db09e1d", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(308, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(314, 39, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b8a45405803848e7bfce1c4d6bbf44eb", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(353, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(359, 48, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6d05fe36f70a48bd9e319d75c3eabaa9", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(407, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(413, 45, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7387af1086594ccbad431ae2693dc85b", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(458, 317, true);
                WriteLiteral(@"
    <script type=""text/javascript"">

        var dataModel;
        var cusModel;
        var module;
        var countryLst;

        $(function () {

             $("".defaultHide"").hide();

             initModule();
             initModule2();
             setModule();
        });
    </script>
");
                EndContext();
            }
            );
            BeginContext(778, 10, true);
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n");
            EndContext();
#line 35 "/Users/caizhiliang/Documents/GitHub/erichu62/Src/Web/KKday.Web.B2D.EC/KKday.Web.B2D.EC/Views/Booking/Index.cshtml"
  
    var guid = (string)ViewData["guid"];
    var confirm =(confirmPkgInfo) ViewData["confirmPkgInfo"];

    var prodTitle = (ProdTitleModel)ViewData["prodTitle"];
    var totalCus = (int)ViewData["totalCus"];
    var cusData = (CusData)ViewData["cusData"];
    var mainCat = (string)ViewData["mainCat"];
    var guide = (List<GuideLanguage>) ViewData["guide"];
    var wifi = (SimWifi)ViewData["wifi"];
    var exchange = (List<Location>)ViewData["exchange"];

    var flightInfoType = (string)ViewData["flightInfoType"];
    var venue = (VenueInfo)ViewData["venue"];

    var useDate = (string)ViewData["useDate"];
    var rentCar = (RentCar)ViewData["rentCar"];
    var carPsgr = (CarPasgr)ViewData["carPsgr"];

    var sendInfoType = (string)ViewData["sendInfoType"];
    var sendData = (SendData)ViewData["sendData"];

    var contactData = (ContactData)ViewData["contactData"];

    var flightInfo = (FlightInfo)ViewData["flightInfo"];
    var contactInfo = (distributorInfo)ViewData["contactInfo"];
    var dataModelStr = ViewData["dataModelStr"];

#line default
#line hidden
            BeginContext(1869, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1872, 43, false);
#line 64 "/Users/caizhiliang/Documents/GitHub/erichu62/Src/Web/KKday.Web.B2D.EC/KKday.Web.B2D.EC/Views/Booking/Index.cshtml"
Write(Html.Hidden("hdndataModelStr",dataModelStr));

#line default
#line hidden
            EndContext();
            BeginContext(1915, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1918, 45, false);
#line 65 "/Users/caizhiliang/Documents/GitHub/erichu62/Src/Web/KKday.Web.B2D.EC/KKday.Web.B2D.EC/Views/Booking/Index.cshtml"
Write(Html.Hidden("hdnAdultQty", confirm.price1Qty));

#line default
#line hidden
            EndContext();
            BeginContext(1963, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1966, 45, false);
#line 66 "/Users/caizhiliang/Documents/GitHub/erichu62/Src/Web/KKday.Web.B2D.EC/KKday.Web.B2D.EC/Views/Booking/Index.cshtml"
Write(Html.Hidden("hdnChildQty", confirm.price2Qty));

#line default
#line hidden
            EndContext();
            BeginContext(2011, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(2014, 46, false);
#line 67 "/Users/caizhiliang/Documents/GitHub/erichu62/Src/Web/KKday.Web.B2D.EC/KKday.Web.B2D.EC/Views/Booking/Index.cshtml"
Write(Html.Hidden("hdnInfantQty", confirm.price3Qty));

#line default
#line hidden
            EndContext();
            BeginContext(2060, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(2063, 33, false);
#line 68 "/Users/caizhiliang/Documents/GitHub/erichu62/Src/Web/KKday.Web.B2D.EC/KKday.Web.B2D.EC/Views/Booking/Index.cshtml"
Write(Html.Hidden("hdnUseDate",useDate));

#line default
#line hidden
            EndContext();
            BeginContext(2096, 127, true);
            WriteLiteral("\r\n\r\n<div class=\"container\" style=\" text-align:left;\">\r\n\r\n\r\n    <!--contactData-->\r\n    <div class=\"orderContactData\">\r\n        ");
            EndContext();
            BeginContext(2224, 44, false);
#line 75 "/Users/caizhiliang/Documents/GitHub/erichu62/Src/Web/KKday.Web.B2D.EC/KKday.Web.B2D.EC/Views/Booking/Index.cshtml"
   Write(await Html.PartialAsync("_orderContactData"));

#line default
#line hidden
            EndContext();
            BeginContext(2268, 75, true);
            WriteLiteral("\r\n    </div>\r\n    \r\n    <!--cusData-->\r\n    <div class=\"cusData\">\r\n        ");
            EndContext();
            BeginContext(2344, 35, false);
#line 80 "/Users/caizhiliang/Documents/GitHub/erichu62/Src/Web/KKday.Web.B2D.EC/KKday.Web.B2D.EC/Views/Booking/Index.cshtml"
   Write(await Html.PartialAsync("_cusData"));

#line default
#line hidden
            EndContext();
            BeginContext(2379, 26, true);
            WriteLiteral("\r\n    </div>\r\n\r\n    \r\n    ");
            EndContext();
            BeginContext(2405, 1825, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a580b35ae6244f828668bd1625d26d6c", async() => {
                BeginContext(2450, 81, true);
                WriteLiteral(" \r\n\r\n\r\n         <!--guideData-->\r\n          <div class=\"guideData\">\r\n            ");
                EndContext();
                BeginContext(2532, 33, false);
#line 89 "/Users/caizhiliang/Documents/GitHub/erichu62/Src/Web/KKday.Web.B2D.EC/KKday.Web.B2D.EC/Views/Booking/Index.cshtml"
       Write(await Html.PartialAsync("_guide"));

#line default
#line hidden
                EndContext();
                BeginContext(2565, 100, true);
                WriteLiteral("\r\n          </div>\r\n\r\n           <!--flight-->\r\n          <div class=\"flightData\">\r\n                ");
                EndContext();
                BeginContext(2666, 38, false);
#line 94 "/Users/caizhiliang/Documents/GitHub/erichu62/Src/Web/KKday.Web.B2D.EC/KKday.Web.B2D.EC/Views/Booking/Index.cshtml"
           Write(await Html.PartialAsync("_flightInfo"));

#line default
#line hidden
                EndContext();
                BeginContext(2704, 108, true);
                WriteLiteral(";\r\n\r\n\r\n          </div>\r\n\r\n\r\n          <!--shuttle-->\r\n          <div class=\"shuttleData\">\r\n                ");
                EndContext();
                BeginContext(2813, 35, false);
#line 102 "/Users/caizhiliang/Documents/GitHub/erichu62/Src/Web/KKday.Web.B2D.EC/KKday.Web.B2D.EC/Views/Booking/Index.cshtml"
           Write(await Html.PartialAsync("_shuttle"));

#line default
#line hidden
                EndContext();
                BeginContext(2848, 110, true);
                WriteLiteral(";\r\n          </div>\r\n\r\n          \r\n\r\n          <!--carRent-->\r\n          <div class=\"rentCar\">\r\n              ");
                EndContext();
                BeginContext(2959, 35, false);
#line 109 "/Users/caizhiliang/Documents/GitHub/erichu62/Src/Web/KKday.Web.B2D.EC/KKday.Web.B2D.EC/Views/Booking/Index.cshtml"
         Write(await Html.PartialAsync("_rentCar"));

#line default
#line hidden
                EndContext();
                BeginContext(2994, 112, true);
                WriteLiteral("\r\n          </div>\r\n\r\n\r\n           \r\n\r\n          <!--carPsgr-->\r\n          <div class=\"carPsgr\">\r\n              ");
                EndContext();
                BeginContext(3107, 35, false);
#line 117 "/Users/caizhiliang/Documents/GitHub/erichu62/Src/Web/KKday.Web.B2D.EC/KKday.Web.B2D.EC/Views/Booking/Index.cshtml"
         Write(await Html.PartialAsync("_carPsgr"));

#line default
#line hidden
                EndContext();
                BeginContext(3142, 101, true);
                WriteLiteral("\r\n          </div>\r\n\r\n\r\n\r\n          <!--sendData-->\r\n          <div class=\"sendData\">\r\n              ");
                EndContext();
                BeginContext(3244, 36, false);
#line 124 "/Users/caizhiliang/Documents/GitHub/erichu62/Src/Web/KKday.Web.B2D.EC/KKday.Web.B2D.EC/Views/Booking/Index.cshtml"
         Write(await Html.PartialAsync("_sendData"));

#line default
#line hidden
                EndContext();
                BeginContext(3280, 103, true);
                WriteLiteral("\r\n          </div>\r\n\r\n          <!--contactData-->\r\n          <div class=\"contactData\">\r\n              ");
                EndContext();
                BeginContext(3384, 39, false);
#line 129 "/Users/caizhiliang/Documents/GitHub/erichu62/Src/Web/KKday.Web.B2D.EC/KKday.Web.B2D.EC/Views/Booking/Index.cshtml"
         Write(await Html.PartialAsync("_contactData"));

#line default
#line hidden
                EndContext();
                BeginContext(3423, 114, true);
                WriteLiteral("\r\n          </div>   \r\n          \r\n          <!--wifi exchange-->\r\n          <div class=\"otherData\">\r\n            ");
                EndContext();
                BeginContext(3538, 33, false);
#line 134 "/Users/caizhiliang/Documents/GitHub/erichu62/Src/Web/KKday.Web.B2D.EC/KKday.Web.B2D.EC/Views/Booking/Index.cshtml"
       Write(await Html.PartialAsync("_other"));

#line default
#line hidden
                EndContext();
                BeginContext(3571, 148, true);
                WriteLiteral("\r\n          </div>\r\n           \r\n\r\n        <!-- 訂單備註 -->\r\n        <div class=\"traveler-con\">\r\n            <div class=\"sub-title\">\r\n                 ");
                EndContext();
                BeginContext(3720, 34, false);
#line 141 "/Users/caizhiliang/Documents/GitHub/erichu62/Src/Web/KKday.Web.B2D.EC/KKday.Web.B2D.EC/Views/Booking/Index.cshtml"
            Write(prodTitle.booking_step1_order_note);

#line default
#line hidden
                EndContext();
                BeginContext(3754, 26, true);
                WriteLiteral("\r\n                <small>(");
                EndContext();
                BeginContext(3781, 38, false);
#line 142 "/Users/caizhiliang/Documents/GitHub/erichu62/Src/Web/KKday.Web.B2D.EC/KKday.Web.B2D.EC/Views/Booking/Index.cshtml"
                   Write(prodTitle.booking_step1_order_note_tip);

#line default
#line hidden
                EndContext();
                BeginContext(3819, 404, true);
                WriteLiteral(@")</small>
            </div>
             <div class=""row mt-10"">
                <div class=""col-md-8 col-sm-12"">
                    <div class=""form-group"">
                        <textarea class=""form-control"" rows=""3"" id=""txtOrdNote"" name=""txtOrdNote"">
                        </textarea>
                    </div>
                </div>
            </div>
        </div>
        
    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4230, 113, true);
            WriteLiteral("\r\n\r\n    <br/>\r\n    <input type=\"button\" value=\"button\" onclick=\"chkValid()\" />\r\n<br/>\r\n\r\n    this is booking!  : ");
            EndContext();
            BeginContext(4344, 4, false);
#line 160 "/Users/caizhiliang/Documents/GitHub/erichu62/Src/Web/KKday.Web.B2D.EC/KKday.Web.B2D.EC/Views/Booking/Index.cshtml"
                   Write(guid);

#line default
#line hidden
            EndContext();
            BeginContext(4348, 438, true);
            WriteLiteral(@"  <br />
    booking.php <br />
    travelerData  <br />
    travelerQuantity <br />
    eventBackup <br />
    guideLanguage <br />
    arrivalFlightInfo <br />
    departureFlightInfo <br />
    shuttleData <br />
    carRenting <br />
    passengerDataUnit  <br />
    passengerDataUnitGroup <br />
    passengerData <br />
    sendData <br />
    contactData <br />
    otherData  <br />
    orderNote <br />


    ");
            EndContext();
            BeginContext(4787, 83, false);
#line 179 "/Users/caizhiliang/Documents/GitHub/erichu62/Src/Web/KKday.Web.B2D.EC/KKday.Web.B2D.EC/Views/Booking/Index.cshtml"
Write(Html.Hidden("booking_step1_length_error_1", prodTitle.booking_step1_length_error_1));

#line default
#line hidden
            EndContext();
            BeginContext(4870, 7, true);
            WriteLiteral(";\r\n    ");
            EndContext();
            BeginContext(4878, 83, false);
#line 180 "/Users/caizhiliang/Documents/GitHub/erichu62/Src/Web/KKday.Web.B2D.EC/KKday.Web.B2D.EC/Views/Booking/Index.cshtml"
Write(Html.Hidden("booking_step1_length_error_2", prodTitle.booking_step1_length_error_2));

#line default
#line hidden
            EndContext();
            BeginContext(4961, 7, true);
            WriteLiteral(";\r\n    ");
            EndContext();
            BeginContext(4969, 83, false);
#line 181 "/Users/caizhiliang/Documents/GitHub/erichu62/Src/Web/KKday.Web.B2D.EC/KKday.Web.B2D.EC/Views/Booking/Index.cshtml"
Write(Html.Hidden("booking_step1_required_error", prodTitle.booking_step1_required_error));

#line default
#line hidden
            EndContext();
            BeginContext(5052, 7, true);
            WriteLiteral(";\r\n    ");
            EndContext();
            BeginContext(5060, 81, false);
#line 182 "/Users/caizhiliang/Documents/GitHub/erichu62/Src/Web/KKday.Web.B2D.EC/KKday.Web.B2D.EC/Views/Booking/Index.cshtml"
Write(Html.Hidden("booking_step1_english_error", prodTitle.booking_step1_english_error));

#line default
#line hidden
            EndContext();
            BeginContext(5141, 11, true);
            WriteLiteral(";\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591