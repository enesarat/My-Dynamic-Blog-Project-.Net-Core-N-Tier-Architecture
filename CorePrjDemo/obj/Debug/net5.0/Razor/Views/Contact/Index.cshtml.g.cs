#pragma checksum "C:\Users\Enes\Desktop\C#\c#\netCore\CorePrjDemo\Views\Contact\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b0582bda3cba83f551474bff122a9fcf6c13edef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contact_Index), @"mvc.1.0.view", @"/Views/Contact/Index.cshtml")]
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
#line 1 "C:\Users\Enes\Desktop\C#\c#\netCore\CorePrjDemo\Views\_ViewImports.cshtml"
using CorePrjDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Enes\Desktop\C#\c#\netCore\CorePrjDemo\Views\_ViewImports.cshtml"
using CorePrjDemo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0582bda3cba83f551474bff122a9fcf6c13edef", @"/Views/Contact/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e54bc505d063c4c466f6586e5a3a4f4a179aaa33", @"/Views/_ViewImports.cshtml")]
    public class Views_Contact_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/BlogThema/css/contact.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Enes\Desktop\C#\c#\netCore\CorePrjDemo\Views\Contact\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b0582bda3cba83f551474bff122a9fcf6c13edef4655", async() => {
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
            WriteLiteral(@"
<section class=""main-content-w3layouts-agileits"">

    <h3 class=""tittle"">Bize Ulaşın</h3>
    <p class=""sub text-center"">Fikirleriniz bizim için değerli</p>
    <div class=""contact-map inner-sec"">

        <iframe src=""https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d100949.24429313939!2d-122.44206553967531!3d37.75102885910819!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x80859a6d00690021%3A0x4a501367f076adff!2sSan+Francisco%2C+CA%2C+USA!5e0!3m2!1sen!2sin!4v1472190196783""
                class=""map"" style=""border:0""");
            BeginWriteAttribute("allowfullscreen", " allowfullscreen=\"", 697, "\"", 715, 0);
            EndWriteAttribute();
            WriteLiteral(@"></iframe>
    </div>
    <div class=""ad-inf-sec bg-light"">
        <div class=""container"">
            <div class=""address row"">

                <div class=""col-lg-4 address-grid"">
                    <div class=""row address-info"">
                        <div class=""col-md-4 address-left text-center"">
                            <i class=""far fa-map""></i>
                        </div>
                        <div class=""col-md-8 address-right text-left"">
                            <h6>Adres</h6>
                            <p>
                                İstanbul, TR

                            </p>
                        </div>
                    </div>

                </div>
                <div class=""col-lg-4 address-grid"">
                    <div class=""row address-info"">
                        <div class=""col-md-4 address-left text-center"">
                            <i class=""far fa-envelope""></i>
                        </div>
                        <div clas");
            WriteLiteral(@"s=""col-md-8 address-right text-left"">
                            <h6>Email</h6>
                            <p>
                                Email :
                                <a href=""mailto:example@email.com""> example@mail.com</a>

                            </p>
                        </div>

                    </div>
                </div>
                <div class=""col-lg-4 address-grid"">
                    <div class=""row address-info"">
                        <div class=""col-md-4 address-left text-center"">
                            <i class=""fas fa-mobile-alt""></i>
                        </div>
                        <div class=""col-md-8 address-right text-left"">
                            <h6>Telefon</h6>
                            <p>+90 234 567 8901</p>

                        </div>

                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""container"">
        <div class=""contact_grid_right"">
    ");
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b0582bda3cba83f551474bff122a9fcf6c13edef8644", async() => {
                WriteLiteral(@"
                <div class=""row contact_left_grid"">
                    <div class=""col-md-6 con-left"">
                        <div class=""form-group"">
                            <label for=""validationCustom01 my-2"">Kullanıcı Adı</label>
                            <input class=""form-control"" type=""text"" name=""ContactUserName""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 3128, "\"", 3142, 0);
                EndWriteAttribute();
                BeginWriteAttribute("required", " required=\"", 3143, "\"", 3154, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                        </div>\r\n                        <div class=\"form-group\">\r\n                            <label for=\"exampleFormControlInput1\">Email</label>\r\n                            <input class=\"form-control\" type=\"email\" name=\"ContactMail\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 3408, "\"", 3422, 0);
                EndWriteAttribute();
                BeginWriteAttribute("required", " required=\"", 3423, "\"", 3434, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                        </div>\r\n                        <div class=\"form-group\">\r\n                            <label for=\"validationCustom03 my-2\">Konu</label>\r\n                            <input class=\"form-control\" type=\"text\" name=\"ContactSubject\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 3688, "\"", 3702, 0);
                EndWriteAttribute();
                BeginWriteAttribute("required", " required=\"", 3703, "\"", 3714, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                        </div>
                    </div>
                    <div class=""col-md-6 con-right"">
                        <div class=""form-group"">
                            <label for=""textarea"">Mesajınız</label>
                            <textarea id=""textarea"" name=""ContactMessage""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 4024, "\"", 4038, 0);
                EndWriteAttribute();
                WriteLiteral("></textarea>\r\n                        </div>\r\n                        <input class=\"form-control\" type=\"submit\" value=\"Gönder\">\r\n\r\n                    </div>\r\n                </div>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</section>");
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