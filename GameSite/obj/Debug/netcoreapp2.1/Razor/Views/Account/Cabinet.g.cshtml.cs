#pragma checksum "C:\Users\wais1\OneDrive\Рабочий стол\GameSite\GameSite\Views\Account\Cabinet.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "58a5f30d442f3fd468152aedb03023a4770dd1a0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Cabinet), @"mvc.1.0.view", @"/Views/Account/Cabinet.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/Cabinet.cshtml", typeof(AspNetCore.Views_Account_Cabinet))]
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
#line 1 "C:\Users\wais1\OneDrive\Рабочий стол\GameSite\GameSite\Views\_ViewImports.cshtml"
using GameSite;

#line default
#line hidden
#line 2 "C:\Users\wais1\OneDrive\Рабочий стол\GameSite\GameSite\Views\_ViewImports.cshtml"
using GameSite.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58a5f30d442f3fd468152aedb03023a4770dd1a0", @"/Views/Account/Cabinet.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f858600d8a2511a8556360a6ac2c09aae711a60f", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Cabinet : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/no-avatar.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("avatar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\wais1\OneDrive\Рабочий стол\GameSite\GameSite\Views\Account\Cabinet.cshtml"
  
    ViewData["Title"] = "Личный кабинет";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(99, 924, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f223193824b94a00ab3dd818960e2bbf", async() => {
                BeginContext(105, 170, true);
                WriteLiteral("\r\n    <div class=\"container-head\">\r\n        <h3 class=\"main-text-color\" style=\"margin: 0px; padding-top: 10px; padding-bottom:10px; padding-left:5px\">Профиль участника > ");
                EndContext();
                BeginContext(276, 20, false);
#line 8 "C:\Users\wais1\OneDrive\Рабочий стол\GameSite\GameSite\Views\Account\Cabinet.cshtml"
                                                                                                                                 Write(ViewData["Nickname"]);

#line default
#line hidden
                EndContext();
                BeginContext(296, 144, true);
                WriteLiteral("</h3>\r\n    </div>\r\n    <div class=\"\">\r\n        <div class=\"row\">\r\n            <div class=\"col-md-3\" style=\"text-align:center\">\r\n                ");
                EndContext();
                BeginContext(440, 50, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9fea746c1c8749748049deef418a7a9f", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(490, 95, true);
                WriteLiteral("\r\n            </div>\r\n            <div class=\"col-md-9\">\r\n                <span>Настоящее имя: ");
                EndContext();
                BeginContext(586, 16, false);
#line 16 "C:\Users\wais1\OneDrive\Рабочий стол\GameSite\GameSite\Views\Account\Cabinet.cshtml"
                                Write(ViewData["name"]);

#line default
#line hidden
                EndContext();
                BeginContext(602, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(604, 19, false);
#line 16 "C:\Users\wais1\OneDrive\Рабочий стол\GameSite\GameSite\Views\Account\Cabinet.cshtml"
                                                  Write(ViewData["Surname"]);

#line default
#line hidden
                EndContext();
                BeginContext(623, 64, true);
                WriteLiteral("</span>\r\n                <br />\r\n                <span>Никнейм: ");
                EndContext();
                BeginContext(688, 20, false);
#line 18 "C:\Users\wais1\OneDrive\Рабочий стол\GameSite\GameSite\Views\Account\Cabinet.cshtml"
                          Write(ViewData["Nickname"]);

#line default
#line hidden
                EndContext();
                BeginContext(708, 69, true);
                WriteLiteral("</span>\r\n                <br />\r\n                <span>Любимый жанр: ");
                EndContext();
                BeginContext(778, 14, false);
#line 20 "C:\Users\wais1\OneDrive\Рабочий стол\GameSite\GameSite\Views\Account\Cabinet.cshtml"
                               Write(ViewData["lt"]);

#line default
#line hidden
                EndContext();
                BeginContext(792, 70, true);
                WriteLiteral("</span>\r\n                <br />\r\n                <span>Роль на сайте: ");
                EndContext();
                BeginContext(863, 16, false);
#line 22 "C:\Users\wais1\OneDrive\Рабочий стол\GameSite\GameSite\Views\Account\Cabinet.cshtml"
                                Write(ViewData["Role"]);

#line default
#line hidden
                EndContext();
                BeginContext(879, 62, true);
                WriteLiteral("</span>\r\n                <br />\r\n                <span>Email: ");
                EndContext();
                BeginContext(942, 17, false);
#line 24 "C:\Users\wais1\OneDrive\Рабочий стол\GameSite\GameSite\Views\Account\Cabinet.cshtml"
                        Write(ViewData["email"]);

#line default
#line hidden
                EndContext();
                BeginContext(959, 57, true);
                WriteLiteral("</span>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
                EndContext();
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
            EndContext();
            BeginContext(1023, 4, true);
            WriteLiteral("\r\n\r\n");
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
