#pragma checksum "C:\Users\Administrator\Desktop\pizza Test\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d4e048bf083596ea8863c8ca06251b8bd52c9875"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Administrator\Desktop\pizza Test\Views\_ViewImports.cshtml"
using PizzaApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Administrator\Desktop\pizza Test\Views\_ViewImports.cshtml"
using PizzaApplication.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4e048bf083596ea8863c8ca06251b8bd52c9875", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ba295415eabbe47cee94bfd856e3b8f99d2f3b1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Administrator\Desktop\pizza Test\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"btn btn-dark \">\r\n\r\n        ");
#nullable restore
#line 8 "C:\Users\Administrator\Desktop\pizza Test\Views\Home\Index.cshtml"
   Write(Html.ActionLink("Login", "Login"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    </div>\r\n    <div class=\"btn btn-dark \">\r\n\r\n        ");
#nullable restore
#line 13 "C:\Users\Administrator\Desktop\pizza Test\Views\Home\Index.cshtml"
   Write(Html.ActionLink("Register", "Register"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    </div>\r\n");
#nullable restore
#line 16 "C:\Users\Administrator\Desktop\pizza Test\Views\Home\Index.cshtml"
     foreach (var item in ViewBag.images)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <img");
            BeginWriteAttribute("src", " src=", 326, "", 336, 1);
#nullable restore
#line 18 "C:\Users\Administrator\Desktop\pizza Test\Views\Home\Index.cshtml"
WriteAttributeValue("", 331, item, 331, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Image Missed\" style=\"height:100%; width:100%; background-size:100% 100%; background-repeat: no-repeat; overflow-y:hidden; overflow-x:hidden\" />\r\n");
#nullable restore
#line 19 "C:\Users\Administrator\Desktop\pizza Test\Views\Home\Index.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n</div>\r\n");
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
