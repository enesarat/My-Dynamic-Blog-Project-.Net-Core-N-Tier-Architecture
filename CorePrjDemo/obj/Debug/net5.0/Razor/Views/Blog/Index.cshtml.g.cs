#pragma checksum "C:\Users\Enes\Desktop\C#\c#\netCore\CorePrjDemo\Views\Blog\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a6d47ba0a4cb59bfc561ef5ec7d0ef44de8ae10"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Index), @"mvc.1.0.view", @"/Views/Blog/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Enes\Desktop\C#\c#\netCore\CorePrjDemo\Views\Blog\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a6d47ba0a4cb59bfc561ef5ec7d0ef44de8ae10", @"/Views/Blog/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e54bc505d063c4c466f6586e5a3a4f4a179aaa33", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Enes\Desktop\C#\c#\netCore\CorePrjDemo\Views\Blog\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<br />
<br />
<br />

<section class=""main-content-w3layouts-agileits"">
    <div class=""container"">
        <h3 class=""tittle"">Bloglar</h3>
        <div class=""inner-sec"">
            <!--left-->
            <div class=""left-blog-info-w3layouts-agileits text-left"">
                <div class=""row"">
");
#nullable restore
#line 21 "C:\Users\Enes\Desktop\C#\c#\netCore\CorePrjDemo\Views\Blog\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-lg-4 card\">\r\n                            <a href=\"single.html\">\r\n                                <img");
            BeginWriteAttribute("src", " src=", 670, "", 690, 1);
#nullable restore
#line 25 "C:\Users\Enes\Desktop\C#\c#\netCore\CorePrjDemo\Views\Blog\Index.cshtml"
WriteAttributeValue("", 675, item.BlogImage, 675, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 721, "\"", 727, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </a>
                            <div class=""card-body"">
                                <ul class=""blog-icons my-4"">
                                    <li>
                                        <a href=""#"">
                                            <i class=""far fa-calendar-alt""></i> ");
#nullable restore
#line 31 "C:\Users\Enes\Desktop\C#\c#\netCore\CorePrjDemo\Views\Blog\Index.cshtml"
                                                                           Write(item.BlogCreateDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </a>
                                    </li>
                                    <li class=""mx-2"">
                                        <a href=""#"">
                                            <i class=""far fa-comment""></i> 0
                                        </a>
                                    </li>
                                    <li>
                                        <a href=""#"">
                                            <i class=""fas fa-eye""></i> ");
#nullable restore
#line 41 "C:\Users\Enes\Desktop\C#\c#\netCore\CorePrjDemo\Views\Blog\Index.cshtml"
                                                                  Write(item.CategoryID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </a>\r\n                                    </li>\r\n\r\n                                </ul>\r\n                                <h5 class=\"card-title\">\r\n                                    <a href=\"single.html\">");
#nullable restore
#line 47 "C:\Users\Enes\Desktop\C#\c#\netCore\CorePrjDemo\Views\Blog\Index.cshtml"
                                                     Write(item.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
                                </h5>
                                <p class=""card-text mb-3"">Lorem ipsum dolor sit amet consectetur adipisicing elit sedc dnmo eiusmod tempor incididunt.. </p>
                                <a href=""single.html"" class=""btn btn-primary read-m"">Read More</a>
                            </div>
                        </div>
");
#nullable restore
#line 53 "C:\Users\Enes\Desktop\C#\c#\netCore\CorePrjDemo\Views\Blog\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


                </div>
                <nav aria-label=""Page navigation example"">
                    <ul class=""pagination justify-content-left mt-4"">
                        <li class=""page-item disabled"">
                            <a class=""page-link"" href=""#"" tabindex=""-1"">Previous</a>
                        </li>
                        <li class=""page-item"">
                            <a class=""page-link"" href=""#"">1</a>
                        </li>
                        <li class=""page-item"">
                            <a class=""page-link"" href=""#"">2</a>
                        </li>
                        <li class=""page-item"">
                            <a class=""page-link"" href=""#"">3</a>
                        </li>
                        <li class=""page-item"">
                            <a class=""page-link"" href=""#"">Next</a>
                        </li>
                    </ul>
                </nav>
                <!--//left-->
            </div>
        ");
            WriteLiteral("</div>\r\n    </div>\r\n</section>\r\n\r\n\r\n<br />\r\n<br />\r\n<br />");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Blog>> Html { get; private set; }
    }
}
#pragma warning restore 1591