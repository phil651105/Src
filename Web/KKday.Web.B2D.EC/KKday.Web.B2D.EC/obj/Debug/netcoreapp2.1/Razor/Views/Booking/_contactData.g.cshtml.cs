#pragma checksum "/Users/zhangfengrong/Documents/Core_Test/KKday.Web.B2D.EC_ok/KKday.Web.B2D.EC/Views/Booking/_contactData.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "149ed985dba3d3bc317317019adf6aac0b800166"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Booking__contactData), @"mvc.1.0.view", @"/Views/Booking/_contactData.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Booking/_contactData.cshtml", typeof(AspNetCore.Views_Booking__contactData))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
#line 3 "/Users/zhangfengrong/Documents/Core_Test/KKday.Web.B2D.EC_ok/KKday.Web.B2D.EC/Views/Booking/_contactData.cshtml"
using System.Linq;

#line default
#line hidden
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
#line 1 "/Users/zhangfengrong/Documents/Core_Test/KKday.Web.B2D.EC_ok/KKday.Web.B2D.EC/Views/Booking/_contactData.cshtml"
using KKday.Web.B2D.EC.Models.Model.Product;

#line default
#line hidden
#line 2 "/Users/zhangfengrong/Documents/Core_Test/KKday.Web.B2D.EC_ok/KKday.Web.B2D.EC/Views/Booking/_contactData.cshtml"
using KKday.Web.B2D.EC.Models.Model.Booking;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"149ed985dba3d3bc317317019adf6aac0b800166", @"/Views/Booking/_contactData.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1decf7227a59ebd0c9a1b3569a3e4065089e3cb", @"/Views/_ViewImports.cshtml")]
    public class Views_Booking__contactData : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "null", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("selected", new global::Microsoft.AspNetCore.Html.HtmlString("selected"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(112, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 6 "/Users/zhangfengrong/Documents/Core_Test/KKday.Web.B2D.EC_ok/KKday.Web.B2D.EC/Views/Booking/_contactData.cshtml"
  
    var contactData = (ContactData)ViewData["contactData"];
    var prodTitle = (ProdTitleModel)ViewData["prodTitle"];


#line default
#line hidden
            BeginContext(246, 20, true);
            WriteLiteral("\r\n<!-- 旅遊期間聯絡人 -->\r\n");
            EndContext();
#line 13 "/Users/zhangfengrong/Documents/Core_Test/KKday.Web.B2D.EC_ok/KKday.Web.B2D.EC/Views/Booking/_contactData.cshtml"
 if (contactData != null)
{
    

#line default
#line hidden
#line 15 "/Users/zhangfengrong/Documents/Core_Test/KKday.Web.B2D.EC_ok/KKday.Web.B2D.EC/Views/Booking/_contactData.cshtml"
     if (contactData.is_require == true)
    {

#line default
#line hidden
            BeginContext(345, 98, true);
            WriteLiteral("        <div class=\"traveler-con\">\r\n\r\n            <div class=\"sub-title\">\r\n                <label>");
            EndContext();
            BeginContext(444, 36, false);
#line 20 "/Users/zhangfengrong/Documents/Core_Test/KKday.Web.B2D.EC_ok/KKday.Web.B2D.EC/Views/Booking/_contactData.cshtml"
                  Write(prodTitle.booking_step1_contact_data);

#line default
#line hidden
            EndContext();
            BeginContext(480, 65, true);
            WriteLiteral("</label>\r\n\r\n            </div>\r\n            <div class=\"row\">\r\n\r\n");
            EndContext();
#line 25 "/Users/zhangfengrong/Documents/Core_Test/KKday.Web.B2D.EC_ok/KKday.Web.B2D.EC/Views/Booking/_contactData.cshtml"
                 if (contactData.contact_name.is_require_FirstName == true)
                {

#line default
#line hidden
            BeginContext(641, 94, true);
            WriteLiteral("                    <div class=\"col-md-4 col-sm-6 col-xs-12\">\r\n                        <label>");
            EndContext();
            BeginContext(736, 46, false);
#line 28 "/Users/zhangfengrong/Documents/Core_Test/KKday.Web.B2D.EC_ok/KKday.Web.B2D.EC/Views/Booking/_contactData.cshtml"
                          Write(prodTitle.booking_step1_contact_data_firstname);

#line default
#line hidden
            EndContext();
            BeginContext(782, 149, true);
            WriteLiteral("</label>\r\n                        <input type=\"text\" id=\"txtContactfName\" name=\"txtContactfName\"\r\n                               class=\"form-control\"");
            EndContext();
            BeginWriteAttribute("placeholder", "\r\n                               placeholder=\"", 931, "\"", 1036, 1);
#line 31 "/Users/zhangfengrong/Documents/Core_Test/KKday.Web.B2D.EC_ok/KKday.Web.B2D.EC/Views/Booking/_contactData.cshtml"
WriteAttributeValue("", 977, prodTitle.booking_step1_contact_data_firstname_placeholder, 977, 59, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1037, 31, true);
            WriteLiteral(">\r\n                    </div>\r\n");
            EndContext();
#line 33 "/Users/zhangfengrong/Documents/Core_Test/KKday.Web.B2D.EC_ok/KKday.Web.B2D.EC/Views/Booking/_contactData.cshtml"
                }

#line default
#line hidden
            BeginContext(1087, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 35 "/Users/zhangfengrong/Documents/Core_Test/KKday.Web.B2D.EC_ok/KKday.Web.B2D.EC/Views/Booking/_contactData.cshtml"
                 if (contactData.contact_name.is_require_LastName == true)
                {

#line default
#line hidden
            BeginContext(1184, 94, true);
            WriteLiteral("                    <div class=\"col-md-4 col-sm-6 col-xs-12\">\r\n                        <label>");
            EndContext();
            BeginContext(1279, 45, false);
#line 38 "/Users/zhangfengrong/Documents/Core_Test/KKday.Web.B2D.EC_ok/KKday.Web.B2D.EC/Views/Booking/_contactData.cshtml"
                          Write(prodTitle.booking_step1_contact_data_lastname);

#line default
#line hidden
            EndContext();
            BeginContext(1324, 149, true);
            WriteLiteral("</label>\r\n                        <input type=\"text\" id=\"txtContactlName\" name=\"txtContactlName\"\r\n                               class=\"form-control\"");
            EndContext();
            BeginWriteAttribute("placeholder", "\r\n                               placeholder=\"", 1473, "\"", 1577, 1);
#line 41 "/Users/zhangfengrong/Documents/Core_Test/KKday.Web.B2D.EC_ok/KKday.Web.B2D.EC/Views/Booking/_contactData.cshtml"
WriteAttributeValue("", 1519, prodTitle.booking_step1_contact_data_lastname_placeholder, 1519, 58, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1578, 31, true);
            WriteLiteral(">\r\n                    </div>\r\n");
            EndContext();
#line 43 "/Users/zhangfengrong/Documents/Core_Test/KKday.Web.B2D.EC_ok/KKday.Web.B2D.EC/Views/Booking/_contactData.cshtml"
                }

#line default
#line hidden
            BeginContext(1628, 112, true);
            WriteLiteral("            </div>\r\n\r\n            <div class=\"row\">\r\n                <div class=\"col-md-4 col-sm-6 col-xs-12\">\r\n");
            EndContext();
#line 48 "/Users/zhangfengrong/Documents/Core_Test/KKday.Web.B2D.EC_ok/KKday.Web.B2D.EC/Views/Booking/_contactData.cshtml"
                     if (contactData.contact_tel.is_require_TelNumber == true)
                    {

#line default
#line hidden
            BeginContext(1843, 31, true);
            WriteLiteral("                        <label>");
            EndContext();
            BeginContext(1875, 48, false);
#line 50 "/Users/zhangfengrong/Documents/Core_Test/KKday.Web.B2D.EC_ok/KKday.Web.B2D.EC/Views/Booking/_contactData.cshtml"
                          Write(prodTitle.booking_step1_contact_data_contact_tel);

#line default
#line hidden
            EndContext();
            BeginContext(1923, 363, true);
            WriteLiteral(@"</label>
                        <div class=""form-inline radio-has-son"">
                            <label>
                                <input type=""radio"" id=""rdoContactPhone1""
                                       name=""contact_phone""
                                       value=""true"" onclick=""showContatPhone(1)"">
                                ");
            EndContext();
            BeginContext(2287, 21, false);
#line 56 "/Users/zhangfengrong/Documents/Core_Test/KKday.Web.B2D.EC_ok/KKday.Web.B2D.EC/Views/Booking/_contactData.cshtml"
                           Write(prodTitle.common_have);

#line default
#line hidden
            EndContext();
            BeginContext(2308, 329, true);
            WriteLiteral(@"
                            </label>
                            <label>
                                <input type=""radio"" id=""rdoContactPhone2""
                                       name=""contact_phone""
                                       value=""false"" onclick=""showContatPhone(2)"">
                                ");
            EndContext();
            BeginContext(2638, 25, false);
#line 62 "/Users/zhangfengrong/Documents/Core_Test/KKday.Web.B2D.EC_ok/KKday.Web.B2D.EC/Views/Booking/_contactData.cshtml"
                           Write(prodTitle.common_have_not);

#line default
#line hidden
            EndContext();
            BeginContext(2663, 253, true);
            WriteLiteral("\r\n                            </label>\r\n                        </div>\r\n                        <div class=\"form-group-son form-group must\">\r\n                            <input type=\"text\" class=\"form-control\" id=\"txtContactPhone\" name=\"txtContactPhone\"");
            EndContext();
            BeginWriteAttribute("placeholder", " placeholder=\"", 2916, "\"", 2991, 1);
#line 66 "/Users/zhangfengrong/Documents/Core_Test/KKday.Web.B2D.EC_ok/KKday.Web.B2D.EC/Views/Booking/_contactData.cshtml"
WriteAttributeValue("", 2930, prodTitle.booking_step1_contact_data_contact_tel_placeholder, 2930, 61, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2992, 37, true);
            WriteLiteral(" />\r\n                        </div>\r\n");
            EndContext();
#line 68 "/Users/zhangfengrong/Documents/Core_Test/KKday.Web.B2D.EC_ok/KKday.Web.B2D.EC/Views/Booking/_contactData.cshtml"
                    }

#line default
#line hidden
            BeginContext(3052, 136, true);
            WriteLiteral("                </div>\r\n            </div>\r\n\r\n            <div class=\"row\">\r\n                <div class=\"col-md-8 col-sm-6 col-xs-12\">\r\n");
            EndContext();
#line 74 "/Users/zhangfengrong/Documents/Core_Test/KKday.Web.B2D.EC_ok/KKday.Web.B2D.EC/Views/Booking/_contactData.cshtml"
                     if (contactData.contact_app.is_require == true)
                    {

#line default
#line hidden
            BeginContext(3281, 31, true);
            WriteLiteral("                        <label>");
            EndContext();
            BeginContext(3313, 48, false);
#line 76 "/Users/zhangfengrong/Documents/Core_Test/KKday.Web.B2D.EC_ok/KKday.Web.B2D.EC/Views/Booking/_contactData.cshtml"
                          Write(prodTitle.booking_step1_contact_data_contact_app);

#line default
#line hidden
            EndContext();
            BeginContext(3361, 392, true);
            WriteLiteral(@"</label>
                        <div class=""form-inline radio-has-son"">
                            <label>
                                <input type=""radio"" id=""rdoContactApp1"" onclick=""showContactApp(1)""
                                       name=""contact_app""
                                       value=""true"">
                                
                                ");
            EndContext();
            BeginContext(3754, 21, false);
#line 83 "/Users/zhangfengrong/Documents/Core_Test/KKday.Web.B2D.EC_ok/KKday.Web.B2D.EC/Views/Booking/_contactData.cshtml"
                           Write(prodTitle.common_have);

#line default
#line hidden
            EndContext();
            BeginContext(3775, 324, true);
            WriteLiteral(@"
                            </label>
                            <label>
                                <input type=""radio"" id=""rdoContactApp2"" onclick=""showContactApp(2)""
                                       name=""contact_app""
                                       value=""false"">
                                ");
            EndContext();
            BeginContext(4100, 25, false);
#line 89 "/Users/zhangfengrong/Documents/Core_Test/KKday.Web.B2D.EC_ok/KKday.Web.B2D.EC/Views/Booking/_contactData.cshtml"
                           Write(prodTitle.common_have_not);

#line default
#line hidden
            EndContext();
            BeginContext(4125, 72, true);
            WriteLiteral("\r\n                            </label>\r\n                        </div>\r\n");
            EndContext();
            BeginContext(4199, 45, true);
            WriteLiteral("                        <div class=\"row\">\r\n\r\n");
            EndContext();
#line 95 "/Users/zhangfengrong/Documents/Core_Test/KKday.Web.B2D.EC_ok/KKday.Web.B2D.EC/Views/Booking/_contactData.cshtml"
                             if (contactData.contact_app != null)
                            {
                                

#line default
#line hidden
#line 97 "/Users/zhangfengrong/Documents/Core_Test/KKday.Web.B2D.EC_ok/KKday.Web.B2D.EC/Views/Booking/_contactData.cshtml"
                                 if (contactData.contact_app.app_type_list != null)
                                {

#line default
#line hidden
            BeginContext(4462, 225, true);
            WriteLiteral("                                    <div class=\"col-md-4 col-sm-12\">\r\n                                        <select class=\"form-control\" id=\"selContactApp\" name=\"selContactApp\">\r\n                                            ");
            EndContext();
            BeginContext(4687, 214, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cb3bb044dc6e4ff1bc31b24a270e84ff", async() => {
                BeginContext(4735, 50, true);
                WriteLiteral("\r\n                                                ");
                EndContext();
                BeginContext(4786, 60, false);
#line 102 "/Users/zhangfengrong/Documents/Core_Test/KKday.Web.B2D.EC_ok/KKday.Web.B2D.EC/Views/Booking/_contactData.cshtml"
                                           Write(prodTitle.booking_step1_contact_data_contact_app_placeholder);

#line default
#line hidden
                EndContext();
                BeginContext(4846, 46, true);
                WriteLiteral("\r\n                                            ");
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
            BeginContext(4901, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 105 "/Users/zhangfengrong/Documents/Core_Test/KKday.Web.B2D.EC_ok/KKday.Web.B2D.EC/Views/Booking/_contactData.cshtml"
                                             foreach (App a in contactData.contact_app.app_type_list)
                                            {
                                                

#line default
#line hidden
#line 107 "/Users/zhangfengrong/Documents/Core_Test/KKday.Web.B2D.EC_ok/KKday.Web.B2D.EC/Views/Booking/_contactData.cshtml"
                                                 if (a.is_supported == true)
                                                {

#line default
#line hidden
            BeginContext(5184, 52, true);
            WriteLiteral("                                                    ");
            EndContext();
            BeginContext(5236, 160, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "45dce6347007482b8b3edf39ed1db8db", async() => {
                BeginContext(5264, 58, true);
                WriteLiteral("\r\n                                                        ");
                EndContext();
                BeginContext(5323, 10, false);
#line 110 "/Users/zhangfengrong/Documents/Core_Test/KKday.Web.B2D.EC_ok/KKday.Web.B2D.EC/Views/Booking/_contactData.cshtml"
                                                   Write(a.app_name);

#line default
#line hidden
                EndContext();
                BeginContext(5333, 54, true);
                WriteLiteral("\r\n                                                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#line 109 "/Users/zhangfengrong/Documents/Core_Test/KKday.Web.B2D.EC_ok/KKday.Web.B2D.EC/Views/Booking/_contactData.cshtml"
                                                       WriteLiteral(a.app_type);

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
            BeginContext(5396, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 112 "/Users/zhangfengrong/Documents/Core_Test/KKday.Web.B2D.EC_ok/KKday.Web.B2D.EC/Views/Booking/_contactData.cshtml"
                                                }

#line default
#line hidden
#line 112 "/Users/zhangfengrong/Documents/Core_Test/KKday.Web.B2D.EC_ok/KKday.Web.B2D.EC/Views/Booking/_contactData.cshtml"
                                                 
                                            }

#line default
#line hidden
            BeginContext(5496, 95, true);
            WriteLiteral("                                        </select>\r\n                                    </div>\r\n");
            EndContext();
#line 117 "/Users/zhangfengrong/Documents/Core_Test/KKday.Web.B2D.EC_ok/KKday.Web.B2D.EC/Views/Booking/_contactData.cshtml"
                                     if (contactData.contact_app.is_require_AppAccount == true)
                                    {

#line default
#line hidden
            BeginContext(5729, 211, true);
            WriteLiteral("                                        <div class=\"col-md-8 col-sm-12\">\r\n                                            <input type=\"text\" class=\"form-control\" id=\"txtContactAppAccount\" name=\"txtContactAppAccount\"");
            EndContext();
            BeginWriteAttribute("placeholder", "\r\n                                                   placeholder=\"", 5940, "\"", 6063, 1);
#line 121 "/Users/zhangfengrong/Documents/Core_Test/KKday.Web.B2D.EC_ok/KKday.Web.B2D.EC/Views/Booking/_contactData.cshtml"
WriteAttributeValue("", 6006, prodTitle.booking_step1_contact_data_contact_app_account, 6006, 57, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(6064, 51, true);
            WriteLiteral(">\r\n                                        </div>\r\n");
            EndContext();
#line 123 "/Users/zhangfengrong/Documents/Core_Test/KKday.Web.B2D.EC_ok/KKday.Web.B2D.EC/Views/Booking/_contactData.cshtml"
                                    }

#line default
#line hidden
#line 123 "/Users/zhangfengrong/Documents/Core_Test/KKday.Web.B2D.EC_ok/KKday.Web.B2D.EC/Views/Booking/_contactData.cshtml"
                                     
                                }

#line default
#line hidden
#line 124 "/Users/zhangfengrong/Documents/Core_Test/KKday.Web.B2D.EC_ok/KKday.Web.B2D.EC/Views/Booking/_contactData.cshtml"
                                 

                            }

#line default
#line hidden
            BeginContext(6222, 34, true);
            WriteLiteral("\r\n                        </div>\r\n");
            EndContext();
#line 129 "/Users/zhangfengrong/Documents/Core_Test/KKday.Web.B2D.EC_ok/KKday.Web.B2D.EC/Views/Booking/_contactData.cshtml"
                    }

#line default
#line hidden
            BeginContext(6279, 62, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 134 "/Users/zhangfengrong/Documents/Core_Test/KKday.Web.B2D.EC_ok/KKday.Web.B2D.EC/Views/Booking/_contactData.cshtml"
    }

#line default
#line hidden
#line 134 "/Users/zhangfengrong/Documents/Core_Test/KKday.Web.B2D.EC_ok/KKday.Web.B2D.EC/Views/Booking/_contactData.cshtml"
     
}

#line default
#line hidden
            BeginContext(6351, 6, true);
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
