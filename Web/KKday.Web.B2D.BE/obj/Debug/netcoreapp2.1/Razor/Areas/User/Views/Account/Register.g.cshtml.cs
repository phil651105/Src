#pragma checksum "/Users/eric/MyProjects/KKday.Web.B2D.BE/Areas/User/Views/Account/Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "420a961aa30fad03e61e092ac66863a2723ab6b6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_User_Views_Account_Register), @"mvc.1.0.view", @"/Areas/User/Views/Account/Register.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/User/Views/Account/Register.cshtml", typeof(AspNetCore.Areas_User_Views_Account_Register))]
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
#line 1 "/Users/eric/MyProjects/KKday.Web.B2D.BE/Areas/User/Views/_ViewImports.cshtml"
using KKday.Web.B2D.BE;

#line default
#line hidden
#line 2 "/Users/eric/MyProjects/KKday.Web.B2D.BE/Areas/User/Views/_ViewImports.cshtml"
using KKday.Web.B2D.BE.Areas.User.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"420a961aa30fad03e61e092ac66863a2723ab6b6", @"/Areas/User/Views/Account/Register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc7bac046ff07d4ef2ecf2ecf6161a63e44be55d", @"/Areas/User/Views/_ViewImports.cshtml")]
    public class Areas_User_Views_Account_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("selected", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "/Users/eric/MyProjects/KKday.Web.B2D.BE/Areas/User/Views/Account/Register.cshtml"
  
    Layout = "_LayoutShell";

#line default
#line hidden
            DefineSection("Stylesheet", async() => {
                BeginContext(57, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
            }
            );
            BeginContext(64, 731, true);
            WriteLiteral(@"
<div class=""page-wrap"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-10 col-lg-offset-1"">
                <h1 class=""title"">分銷商註冊</h1>
                <hr>
                <div class=""row"">
                    <div class=""col-md-3"">
                        <h2 class=""section-title"">基本資訊</h2>
                    </div>
                    <div class=""col-md-9"">
                        <div class=""row"">
                            <div class=""col-sm-2"">
                                <div class=""form-group"">
                                    <label>稱謂</label>
                                    <select class=""form-control"">
                                        ");
            EndContext();
            BeginContext(795, 20, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "88ebb4291a624c2ebdb530286347d34c", async() => {
                BeginContext(803, 3, true);
                WriteLiteral("請選擇");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(815, 42, true);
            WriteLiteral("\r\n                                        ");
            EndContext();
            BeginContext(857, 32, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a8d65862b21743a78efb42c4dce8d9af", async() => {
                BeginContext(877, 3, true);
                WriteLiteral("Mr.");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(889, 42, true);
            WriteLiteral("\r\n                                        ");
            EndContext();
            BeginContext(931, 20, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e33d69d563e44c7a4e62c69d32ce2bf", async() => {
                BeginContext(939, 3, true);
                WriteLiteral("Ms.");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(951, 42, true);
            WriteLiteral("\r\n                                        ");
            EndContext();
            BeginContext(993, 21, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "372114021fb34d3db7d692d6e5a90816", async() => {
                BeginContext(1001, 4, true);
                WriteLiteral("Mrs.");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1014, 2724, true);
            WriteLiteral(@"
                                    </select>
                                </div>
                            </div>
                            <div class=""col-sm-5"">
                                <div class=""form-group has-error"">
                                    <label>名<span class=""text-danger"">*</span></label>
                                    <input type=""text"" class=""form-control"" placeholder=""請輸入名字"">
                                    <div class=""tip"">不可為空</div>
                                </div>
                            </div>
                            <div class=""col-sm-5"">
                                <div class=""form-group"">
                                    <label>姓<span class=""text-danger"">*</span></label>
                                    <input type=""text"" class=""form-control"" placeholder=""請輸入姓氏"">
                                </div>
                            </div>

                            <div class=""col-sm-6"">
                          ");
            WriteLiteral(@"      <div class=""form-group"">
                                    <label>電子信箱<span class=""text-danger"">*</span></label>
                                    <input type=""email"" class=""form-control"" placeholder=""example@domain.com"">
                                </div>
                            </div>
                            <div class=""col-sm-6"">
                                <div class=""form-group"">
                                    <label>職稱<span class=""text-danger"">*</span></label>
                                    <input type=""text"" class=""form-control"">
                                </div>
                            </div>

                            <div class=""col-sm-6"">
                                <div class=""form-group"">
                                    <label>請輸入密碼<span class=""text-danger"">*</span></label>
                                    <input type=""password"" class=""form-control"">
                                </div>
                            </div>");
            WriteLiteral(@"
                            <div class=""col-sm-6"">
                                <div class=""form-group"">
                                    <label>再次輸入密碼<span class=""text-danger"">*</span></label>
                                    <input type=""password"" class=""form-control"">
                                </div>
                            </div>

                            <div class=""col-sm-5"">
                                <div class=""form-group"">
                                    <label>國家或地區代碼<span class=""text-danger"">*</span></label>
                                    <select class=""form-control"">
                                        ");
            EndContext();
            BeginContext(3738, 32, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa9e0ffe97fd404fbcf5485b8672a587", async() => {
                BeginContext(3758, 3, true);
                WriteLiteral("請選擇");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3770, 42, true);
            WriteLiteral("\r\n                                        ");
            EndContext();
            BeginContext(3812, 21, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ce4e6a9c49794b9eb24e61a88a0cc3eb", async() => {
                BeginContext(3820, 4, true);
                WriteLiteral("+886");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3833, 42, true);
            WriteLiteral("\r\n                                        ");
            EndContext();
            BeginContext(3875, 20, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d5cbbd155684cd3ad3c0117c3a354a1", async() => {
                BeginContext(3883, 3, true);
                WriteLiteral("+82");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3895, 42, true);
            WriteLiteral("\r\n                                        ");
            EndContext();
            BeginContext(3937, 20, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a90b4a23e2a4868911f89c30a658132", async() => {
                BeginContext(3945, 3, true);
                WriteLiteral("+81");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3957, 789, true);
            WriteLiteral(@"
                                    </select>
                                </div>
                            </div>
                            <div class=""col-sm-7"">
                                <div class=""form-group"">
                                    <label>聯絡電話<span class=""text-danger"">*</span></label>
                                    <input type=""tel"" class=""form-control"">
                                </div>
                            </div>

                            <div class=""col-sm-4"">
                                <div class=""form-group"">
                                    <label>慣用語言<span class=""text-danger"">*</span></label>
                                    <select class=""form-control"">
                                        ");
            EndContext();
            BeginContext(4746, 32, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a81157d6f03479fb9f89c802a2cf534", async() => {
                BeginContext(4766, 3, true);
                WriteLiteral("請選擇");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4778, 42, true);
            WriteLiteral("\r\n                                        ");
            EndContext();
            BeginContext(4820, 21, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "116b7eedd10544cbbdcb2519e101d910", async() => {
                BeginContext(4828, 4, true);
                WriteLiteral("繁體中文");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4841, 42, true);
            WriteLiteral("\r\n                                        ");
            EndContext();
            BeginContext(4883, 24, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5c058bbf572f45f1b2bbbd29d706f471", async() => {
                BeginContext(4891, 7, true);
                WriteLiteral("English");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4907, 42, true);
            WriteLiteral("\r\n                                        ");
            EndContext();
            BeginContext(4949, 21, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c9bff2aac7834ca8a33f2eae7d700990", async() => {
                BeginContext(4957, 4, true);
                WriteLiteral("簡體中文");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4970, 440, true);
            WriteLiteral(@"
                                    </select>
                                </div>
                            </div>
                            <div class=""col-sm-4"">
                                <div class=""form-group"">
                                    <label>交易貨幣 (不可更改)<span class=""text-danger"">*</span></label>
                                    <select class=""form-control"">
                                        ");
            EndContext();
            BeginContext(5410, 32, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cdbf0ee2f00245ed80f931dcaf87572c", async() => {
                BeginContext(5430, 3, true);
                WriteLiteral("請選擇");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5442, 42, true);
            WriteLiteral("\r\n                                        ");
            EndContext();
            BeginContext(5484, 20, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "db5143eee49d4009b336e4c9a5570800", async() => {
                BeginContext(5492, 3, true);
                WriteLiteral("USD");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5504, 42, true);
            WriteLiteral("\r\n                                        ");
            EndContext();
            BeginContext(5546, 20, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ae90591a9b148ff966efd415ad05412", async() => {
                BeginContext(5554, 3, true);
                WriteLiteral("TWD");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5566, 42, true);
            WriteLiteral("\r\n                                        ");
            EndContext();
            BeginContext(5608, 20, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b3ae691338354fd89959c3bb220a4594", async() => {
                BeginContext(5616, 3, true);
                WriteLiteral("KRW");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5628, 438, true);
            WriteLiteral(@"
                                    </select>
                                </div>
                            </div>
                            <div class=""col-sm-4"">
                                <div class=""form-group"">
                                    <label>公司註冊國家或區域<span class=""text-danger"">*</span></label>
                                    <select class=""form-control"">
                                        ");
            EndContext();
            BeginContext(6066, 32, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "43f67c705b7c4e65b9b86b1bb16fa38b", async() => {
                BeginContext(6086, 3, true);
                WriteLiteral("請選擇");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6098, 42, true);
            WriteLiteral("\r\n                                        ");
            EndContext();
            BeginContext(6140, 19, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "60d839b7580d4dd7a8458440b907a70c", async() => {
                BeginContext(6148, 2, true);
                WriteLiteral("台灣");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6159, 42, true);
            WriteLiteral("\r\n                                        ");
            EndContext();
            BeginContext(6201, 19, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c8273ff592eb4d1e95470ab05503b157", async() => {
                BeginContext(6209, 2, true);
                WriteLiteral("韓國");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6220, 42, true);
            WriteLiteral("\r\n                                        ");
            EndContext();
            BeginContext(6262, 19, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "80ce5954b004410f931c7d92a8cd391d", async() => {
                BeginContext(6270, 2, true);
                WriteLiteral("日本");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6281, 3954, true);
            WriteLiteral(@"
                                    </select>
                                </div>
                            </div>

                            <div class=""col-sm-7"">
                                <div class=""form-group"">
                                    <label>公司名稱<span class=""text-danger"">*</span></label>
                                    <input type=""text"" class=""form-control"">
                                </div>
                            </div>
                            <div class=""col-sm-5"">
                                <div class=""form-group"">
                                    <label>統一編號<span class=""text-danger"">*</span></label>
                                    <input type=""text"" class=""form-control"" placeholder=""僅台灣同業用"">
                                </div>
                            </div>

                            <div class=""col-sm-12"">
                                <div class=""form-group"">
                                    <label>公司網站網址<spa");
            WriteLiteral(@"n class=""text-danger"">*</span></label>
                                    <input type=""text"" class=""form-control"" placeholder=""僅台灣同業用"">
                                </div>
                            </div>

                            <div class=""col-sm-12"">
                                <div class=""form-group"">
                                    <label>聯絡地址<span class=""text-danger"">*</span></label>
                                    <input type=""text"" class=""form-control"" placeholder=""僅台灣同業用"">
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <hr>
                <div class=""row"">
                    <div class=""col-md-3"">
                        <h2 class=""section-title"">營業資訊</h2>
                    </div>
                    <div class=""col-md-9"">
                        <label>請提供至少一份下述文件</label>
                        <div class=""row"">
                 ");
            WriteLiteral(@"           <div class=""col-sm-6"">
                                <div class=""file-upload-area"">
                                    <div class=""content"">
                                        <label>營業執照</label>
                                        <div class=""text-light"">
                                            <i class=""icons icon-paper-clip""></i>
                                            酷遊天股份有限公司營業執照.pdf
                                            <a href=""javascript:;"" class=""delete-file""><i class=""icons icon-close""></i></a>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class=""col-sm-6"">
                                <div class=""file-upload-area"">
                                    <div class=""content"">
                                        <label>旅行社許可證</label>

                                        <a href=""javascript:");
            WriteLiteral(@";"" class=""file-upload"">點擊上傳檔案<input type=""file""></a>
                                        <div class=""tip"">(最大檔案限制：200MB)</div>

                                        <!-- Loding -->
                                        <!-- <i class=""fa fa-circle-o-notch fa-spin fa-2x text-lighter""></i> -->
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <hr>
                <div class=""form-footer"">
                    <label>
                        <input type=""checkbox"">
                        我已閱讀並同意<a href=""#"">旅行代理條款</a>
                    </label>
                    <a href=""#"" class=""btn btn-primary"">建立公司</a>
                </div>
            </div>
        </div>
    </div>
</div>");
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