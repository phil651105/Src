#pragma checksum "/Users/zhangfengrong/Documents/Core_Test/KKday.Web.B2D.EC_ok/KKday.Web.B2D.EC/Views/Booking/_rentCar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "249876b73e4dedee0e7f4c9d1b9997ff4db84b68"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Booking__rentCar), @"mvc.1.0.view", @"/Views/Booking/_rentCar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Booking/_rentCar.cshtml", typeof(AspNetCore.Views_Booking__rentCar))]
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
#line 1 "/Users/zhangfengrong/Documents/Core_Test/KKday.Web.B2D.EC_ok/KKday.Web.B2D.EC/Views/Booking/_rentCar.cshtml"
using KKday.Web.B2D.EC.Models.Model.Product;

#line default
#line hidden
#line 2 "/Users/zhangfengrong/Documents/Core_Test/KKday.Web.B2D.EC_ok/KKday.Web.B2D.EC/Views/Booking/_rentCar.cshtml"
using KKday.Web.B2D.EC.Models.Model.Booking;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"249876b73e4dedee0e7f4c9d1b9997ff4db84b68", @"/Views/Booking/_rentCar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1decf7227a59ebd0c9a1b3569a3e4065089e3cb", @"/Views/_ViewImports.cshtml")]
    public class Views_Booking__rentCar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "null", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("selected", new global::Microsoft.AspNetCore.Html.HtmlString("selected"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute(":value", new global::Microsoft.AspNetCore.Html.HtmlString("null"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(92, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "/Users/zhangfengrong/Documents/Core_Test/KKday.Web.B2D.EC_ok/KKday.Web.B2D.EC/Views/Booking/_rentCar.cshtml"
  
    var useDate = (string)ViewData["useDate"];
    var rentCar = ( RentCar)ViewData["rentCar"];
    var prodTitle = (ProdTitleModel)ViewData["prodTitle"];

#line default
#line hidden
            BeginContext(259, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 11 "/Users/zhangfengrong/Documents/Core_Test/KKday.Web.B2D.EC_ok/KKday.Web.B2D.EC/Views/Booking/_rentCar.cshtml"
 if (rentCar != null)
{
   

#line default
#line hidden
#line 13 "/Users/zhangfengrong/Documents/Core_Test/KKday.Web.B2D.EC_ok/KKday.Web.B2D.EC/Views/Booking/_rentCar.cshtml"
    if (rentCar.rent_type == "01" || rentCar.rent_type == "02")
   {

#line default
#line hidden
            BeginContext(356, 65, true);
            WriteLiteral("       <!--_.includes([\'01\', \'02\'], this.rentCarType) 連動還沒有做-->\r\n");
            EndContext();
            BeginContext(428, 32, false);
#line 16 "/Users/zhangfengrong/Documents/Core_Test/KKday.Web.B2D.EC_ok/KKday.Web.B2D.EC/Views/Booking/_rentCar.cshtml"
 Write(Html.Hidden("hdnSelPickUpId",""));

#line default
#line hidden
            EndContext();
            BeginContext(469, 33, false);
#line 17 "/Users/zhangfengrong/Documents/Core_Test/KKday.Web.B2D.EC_ok/KKday.Web.B2D.EC/Views/Booking/_rentCar.cshtml"
 Write(Html.Hidden("hdnSelDropOffId",""));

#line default
#line hidden
            EndContext();
#line 18 "/Users/zhangfengrong/Documents/Core_Test/KKday.Web.B2D.EC_ok/KKday.Web.B2D.EC/Views/Booking/_rentCar.cshtml"
     foreach (Office r in rentCar.rent_office.office_list)
    {
        

#line default
#line hidden
            BeginContext(580, 170, false);
#line 20 "/Users/zhangfengrong/Documents/Core_Test/KKday.Web.B2D.EC_ok/KKday.Web.B2D.EC/Views/Booking/_rentCar.cshtml"
   Write(Html.Hidden("hdnPickup_"+r.id, r.business_hour.from.hour+"%"+ r.business_hour.from.minute+"%" +r.business_hour.to.hour+"%"+ r.business_hour.to.minute+"%" + r.address_eng));

#line default
#line hidden
            EndContext();
#line 20 "/Users/zhangfengrong/Documents/Core_Test/KKday.Web.B2D.EC_ok/KKday.Web.B2D.EC/Views/Booking/_rentCar.cshtml"
                                                                                                                                                                                   
    }

#line default
#line hidden
            BeginContext(759, 63, true);
            WriteLiteral("    <div class=\"traveler-con\">\r\n        <div class=\"sub-title\">");
            EndContext();
            BeginContext(823, 32, false);
#line 23 "/Users/zhangfengrong/Documents/Core_Test/KKday.Web.B2D.EC_ok/KKday.Web.B2D.EC/Views/Booking/_rentCar.cshtml"
                          Write(prodTitle.booking_step1_rent_car);

#line default
#line hidden
            EndContext();
            BeginContext(855, 143, true);
            WriteLiteral("</div>\r\n          <div class=\"row\">\r\n              <div class=\"col-md-6 col-sm-12\">\r\n                  <!-- 取車地點 -->\r\n                  <label>");
            EndContext();
            BeginContext(999, 47, false);
#line 27 "/Users/zhangfengrong/Documents/Core_Test/KKday.Web.B2D.EC_ok/KKday.Web.B2D.EC/Views/Booking/_rentCar.cshtml"
                    Write(prodTitle.booking_step1_rent_car_pick_up_office);

#line default
#line hidden
            EndContext();
            BeginContext(1046, 175, true);
            WriteLiteral("</label>\r\n                  <select class=\"form-control \" id=\"selRentCarPickupOfiice\" name=\"selRentCarPickupOfiice\" onchange=\"chgRentCarTip(\'P\',this)\">\r\n                      ");
            EndContext();
            BeginContext(1221, 169, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de8e4b7376984be4b157bdc311bd0304", async() => {
                BeginContext(1269, 28, true);
                WriteLiteral("\r\n                          ");
                EndContext();
                BeginContext(1298, 59, false);
#line 30 "/Users/zhangfengrong/Documents/Core_Test/KKday.Web.B2D.EC_ok/KKday.Web.B2D.EC/Views/Booking/_rentCar.cshtml"
                     Write(prodTitle.booking_step1_rent_car_pick_up_office_placeholder);

#line default
#line hidden
                EndContext();
                BeginContext(1357, 24, true);
                WriteLiteral("\r\n                      ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1390, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 32 "/Users/zhangfengrong/Documents/Core_Test/KKday.Web.B2D.EC_ok/KKday.Web.B2D.EC/Views/Booking/_rentCar.cshtml"
                       foreach( Office r in rentCar.rent_office.office_list)
                      {

#line default
#line hidden
            BeginContext(1495, 25, true);
            WriteLiteral("                         ");
            EndContext();
            BeginContext(1520, 104, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1b4f579a30774e0c824687c884c057e4", async() => {
                BeginContext(1542, 32, true);
                WriteLiteral("\r\n                              ");
                EndContext();
                BeginContext(1575, 13, false);
#line 35 "/Users/zhangfengrong/Documents/Core_Test/KKday.Web.B2D.EC_ok/KKday.Web.B2D.EC/Views/Booking/_rentCar.cshtml"
                         Write(r.office_name);

#line default
#line hidden
                EndContext();
                BeginContext(1588, 27, true);
                WriteLiteral("\r\n                         ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#line 34 "/Users/zhangfengrong/Documents/Core_Test/KKday.Web.B2D.EC_ok/KKday.Web.B2D.EC/Views/Booking/_rentCar.cshtml"
                            WriteLiteral(r.id);

#line default
#line hidden
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
            EndContext();
            BeginContext(1624, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 37 "/Users/zhangfengrong/Documents/Core_Test/KKday.Web.B2D.EC_ok/KKday.Web.B2D.EC/Views/Booking/_rentCar.cshtml"
                      }

#line default
#line hidden
            BeginContext(1651, 283, true);
            WriteLiteral(@"
                  </select>
                  <div class=""pickupTip col-md-6 col-sm-12"">
                       
                  </div>
              </div>
          </div>
              <div class=""form-group"">
                  <!-- 取車時間 -->
                  <label> ");
            EndContext();
            BeginContext(1935, 45, false);
#line 47 "/Users/zhangfengrong/Documents/Core_Test/KKday.Web.B2D.EC_ok/KKday.Web.B2D.EC/Views/Booking/_rentCar.cshtml"
                     Write(prodTitle.booking_step1_rent_car_pick_up_date);

#line default
#line hidden
            EndContext();
            BeginContext(1980, 230, true);
            WriteLiteral("</label> \r\n                  <div class=\"row\">\r\n                      <div class=\"col-md-4 col-sm-6 col-xs-12\">\r\n                          <div class=\"input-group date\" onclick=\"\">\r\n                              <input type=\"text\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2210, "\"", 2226, 1);
#line 51 "/Users/zhangfengrong/Documents/Core_Test/KKday.Web.B2D.EC_ok/KKday.Web.B2D.EC/Views/Booking/_rentCar.cshtml"
WriteAttributeValue("", 2218, useDate, 2218, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2227, 21, true);
            WriteLiteral(" class=\"form-control\"");
            EndContext();
            BeginWriteAttribute("placeholder", " placeholder=\"", 2248, "\"", 2320, 1);
#line 51 "/Users/zhangfengrong/Documents/Core_Test/KKday.Web.B2D.EC_ok/KKday.Web.B2D.EC/Views/Booking/_rentCar.cshtml"
WriteAttributeValue("", 2262, prodTitle.booking_step1_rent_car_pick_up_date_placeholder, 2262, 58, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2321, 563, true);
            WriteLiteral(@" id=""txtRendCarPickUpDate"" name=""txtRendCarPickUpDate"" readonly=""readonly"" />
                              <span class=""input-group-addon""><i class=""glyphicon glyphicon-calendar""></i></span>
                          </div>
                      </div>
                      <div class=""col-sm-6 col-xs-12"">
                          <div class=""form-group form-select"">
                              <select class=""form-control"" id=""selRentCarPickUpHour"" name=""selRentCarPickUpHour"" onchange=""chgRentCarHour('P',this)"">
                                  ");
            EndContext();
            BeginContext(2884, 136, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "daa3b1c09c8748848f3ff39e31984c97", async() => {
                BeginContext(2933, 78, true);
                WriteLiteral("\r\n                                      --\r\n                                  ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3020, 294, true);
            WriteLiteral(@"
                              </select>
                          </div>
                          <div class=""form-group form-select"">
                              <select class=""form-control"" id=""selRentCarPickUpMinute"" name=""selRentCarPickUpMinute"">
                                  ");
            EndContext();
            BeginContext(3314, 138, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed125cb2d197482281c1ee0f3fad1506", async() => {
                BeginContext(3365, 78, true);
                WriteLiteral("\r\n                                      --\r\n                                  ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3452, 298, true);
            WriteLiteral(@"
                              </select>
                          </div>
                      </div>
                      <div class=""row"">
                         <div class=""col-md-4 col-sm-6 col-xs-12"">
                          <!-- 是否需要免費Wi-Fi機 -->
                          <label>");
            EndContext();
            BeginContext(3751, 50, false);
#line 74 "/Users/zhangfengrong/Documents/Core_Test/KKday.Web.B2D.EC_ok/KKday.Web.B2D.EC/Views/Booking/_rentCar.cshtml"
                            Write(prodTitle.booking_step1_rent_car_is_need_free_wifi);

#line default
#line hidden
            EndContext();
            BeginContext(3801, 241, true);
            WriteLiteral("</label>\r\n                          <div class=\"form-inline\">\r\n                              <label>\r\n                                  <input type=\"radio\" name=\"rentCarwifi\" value=\"true\" id=\"rdoWifiTrue\">\r\n                                  ");
            EndContext();
            BeginContext(4043, 21, false);
#line 78 "/Users/zhangfengrong/Documents/Core_Test/KKday.Web.B2D.EC_ok/KKday.Web.B2D.EC/Views/Booking/_rentCar.cshtml"
                             Write(prodTitle.common_need);

#line default
#line hidden
            EndContext();
            BeginContext(4064, 222, true);
            WriteLiteral("\r\n                              </label>\r\n                              <label>\r\n                                  <input type=\"radio\" name=\"rentCarwifi\" vaule=\"false\" id=\"rdoWifiFalse\">\r\n                                  ");
            EndContext();
            BeginContext(4287, 24, false);
#line 82 "/Users/zhangfengrong/Documents/Core_Test/KKday.Web.B2D.EC_ok/KKday.Web.B2D.EC/Views/Booking/_rentCar.cshtml"
                             Write(prodTitle.common_no_need);

#line default
#line hidden
            EndContext();
            BeginContext(4311, 155, true);
            WriteLiteral("\r\n                              </label>\r\n                          </div>\r\n                          <!-- 是否需要免費GPS -->\r\n                          <label>");
            EndContext();
            BeginContext(4467, 49, false);
#line 86 "/Users/zhangfengrong/Documents/Core_Test/KKday.Web.B2D.EC_ok/KKday.Web.B2D.EC/Views/Booking/_rentCar.cshtml"
                            Write(prodTitle.booking_step1_rent_car_is_need_free_gps);

#line default
#line hidden
            EndContext();
            BeginContext(4516, 241, true);
            WriteLiteral("</label>\r\n                          <div class=\"form-inline\">\r\n                              <label>\r\n                                  <input type=\"radio\"  name=\"rentCargps\" :value=\"true\" id=\"rdoGpsTrue\">\r\n                                  ");
            EndContext();
            BeginContext(4758, 21, false);
#line 90 "/Users/zhangfengrong/Documents/Core_Test/KKday.Web.B2D.EC_ok/KKday.Web.B2D.EC/Views/Booking/_rentCar.cshtml"
                             Write(prodTitle.common_need);

#line default
#line hidden
            EndContext();
            BeginContext(4779, 223, true);
            WriteLiteral(" \r\n                              </label>\r\n                              <label>\r\n                                  <input type=\"radio\"  name=\"rentCargps\" :value=\"false\" id=\"rdoGpsFalse\">\r\n                                  ");
            EndContext();
            BeginContext(5003, 24, false);
#line 94 "/Users/zhangfengrong/Documents/Core_Test/KKday.Web.B2D.EC_ok/KKday.Web.B2D.EC/Views/Booking/_rentCar.cshtml"
                             Write(prodTitle.common_no_need);

#line default
#line hidden
            EndContext();
            BeginContext(5027, 334, true);
            WriteLiteral(@" 
                              </label>
                          </div>
                         </div>
                     </div>
                  </div>
              </div>
              <div class=""row"">
                  <!-- 還車地點 -->
                  <div class=""col-md-6 col-sm-12"">
                      <label>");
            EndContext();
            BeginContext(5362, 48, false);
#line 104 "/Users/zhangfengrong/Documents/Core_Test/KKday.Web.B2D.EC_ok/KKday.Web.B2D.EC/Views/Booking/_rentCar.cshtml"
                        Write(prodTitle.booking_step1_rent_car_drop_off_office);

#line default
#line hidden
            EndContext();
            BeginContext(5410, 186, true);
            WriteLiteral("</label>\r\n                      <select class=\"form-control \" id=\"selRentCarDropOffOfiice\" name=\"selRentCarDropOffOfiice\" onchange=\"chgRentCarTip(\'D\',this)\" >\r\n                          ");
            EndContext();
            BeginContext(5596, 178, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "47e7a241904242559c8bdcfc9020a079", async() => {
                BeginContext(5644, 32, true);
                WriteLiteral("\r\n                              ");
                EndContext();
                BeginContext(5677, 60, false);
#line 107 "/Users/zhangfengrong/Documents/Core_Test/KKday.Web.B2D.EC_ok/KKday.Web.B2D.EC/Views/Booking/_rentCar.cshtml"
                         Write(prodTitle.booking_step1_rent_car_drop_off_office_placeholder);

#line default
#line hidden
                EndContext();
                BeginContext(5737, 28, true);
                WriteLiteral("\r\n                          ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5774, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 109 "/Users/zhangfengrong/Documents/Core_Test/KKday.Web.B2D.EC_ok/KKday.Web.B2D.EC/Views/Booking/_rentCar.cshtml"
                           foreach( Office r in rentCar.rent_office.office_list)
                          {

#line default
#line hidden
            BeginContext(5887, 26, true);
            WriteLiteral("                          ");
            EndContext();
            BeginContext(5913, 105, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a06b83d7f1ad4ecd95f8fdecc450e046", async() => {
                BeginContext(5935, 32, true);
                WriteLiteral("\r\n                              ");
                EndContext();
                BeginContext(5968, 13, false);
#line 112 "/Users/zhangfengrong/Documents/Core_Test/KKday.Web.B2D.EC_ok/KKday.Web.B2D.EC/Views/Booking/_rentCar.cshtml"
                         Write(r.office_name);

#line default
#line hidden
                EndContext();
                BeginContext(5981, 28, true);
                WriteLiteral("\r\n                          ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#line 111 "/Users/zhangfengrong/Documents/Core_Test/KKday.Web.B2D.EC_ok/KKday.Web.B2D.EC/Views/Booking/_rentCar.cshtml"
                             WriteLiteral(r.id);

#line default
#line hidden
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
            EndContext();
            BeginContext(6018, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 114 "/Users/zhangfengrong/Documents/Core_Test/KKday.Web.B2D.EC_ok/KKday.Web.B2D.EC/Views/Booking/_rentCar.cshtml"
                          }

#line default
#line hidden
            BeginContext(6049, 269, true);
            WriteLiteral(@"                      </select>
                      <div class=""dropOfftip col-md-6 col-sm-12""></div>
                  </div>
                  </div>
                  <div class=""form-group"">
                      <!-- 取車時間 -->
                      <label> ");
            EndContext();
            BeginContext(6319, 45, false);
#line 121 "/Users/zhangfengrong/Documents/Core_Test/KKday.Web.B2D.EC_ok/KKday.Web.B2D.EC/Views/Booking/_rentCar.cshtml"
                         Write(prodTitle.booking_step1_rent_car_pick_up_date);

#line default
#line hidden
            EndContext();
            BeginContext(6364, 266, true);
            WriteLiteral(@"</label>
                      <div class=""row"">
                          <div class=""col-md-4 col-sm-6 col-xs-12"">
                              <div class=""input-group date"" onclick="""">
                                  <input type=""text"" class=""form-control""");
            EndContext();
            BeginWriteAttribute("placeholder", " placeholder=\"", 6630, "\"", 6702, 1);
#line 125 "/Users/zhangfengrong/Documents/Core_Test/KKday.Web.B2D.EC_ok/KKday.Web.B2D.EC/Views/Booking/_rentCar.cshtml"
WriteAttributeValue("", 6644, prodTitle.booking_step1_rent_car_pick_up_date_placeholder, 6644, 58, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(6703, 595, true);
            WriteLiteral(@" id=""txtRendCarDropOffDate"" name=""txtRendCarDropOffDate"" readonly=""readonly"" />
                                  <span class=""input-group-addon""><i class=""glyphicon glyphicon-calendar""></i></span>
                              </div>
                          </div>
                          <div class=""col-sm-6 col-xs-12"">
                              <div class=""form-group form-select"">
                                  <select class=""form-control"" id=""selRentCarDropOffHour"" name=""selRentCarDropOffHour"" onchange=""chgRentCarHour('D',this)"">
                                      ");
            EndContext();
            BeginContext(7298, 146, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8cfefbaa93f5470d99697ea1e9aa7c1b", async() => {
                BeginContext(7349, 86, true);
                WriteLiteral("\r\n                                          --\r\n                                      ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7444, 316, true);
            WriteLiteral(@"
                                  </select>
                              </div>
                              <div class=""form-group form-select"">
                                  <select class=""form-control"" id=""selRentCarDropoffMinute"" name=""selRentCarDropoffMinute"">
                                      ");
            EndContext();
            BeginContext(7760, 146, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9b83167e1678406fa4483952e106af94", async() => {
                BeginContext(7811, 86, true);
                WriteLiteral("\r\n                                          --\r\n                                      ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7906, 187, true);
            WriteLiteral("\r\n                                  </select>\r\n                              </div>\r\n                          </div>\r\n                      </div>\r\n                  </div>\r\n    </div>\r\n");
            EndContext();
#line 148 "/Users/zhangfengrong/Documents/Core_Test/KKday.Web.B2D.EC_ok/KKday.Web.B2D.EC/Views/Booking/_rentCar.cshtml"

   }

#line default
#line hidden
#line 149 "/Users/zhangfengrong/Documents/Core_Test/KKday.Web.B2D.EC_ok/KKday.Web.B2D.EC/Views/Booking/_rentCar.cshtml"
    
}

#line default
#line hidden
            BeginContext(8104, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
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
