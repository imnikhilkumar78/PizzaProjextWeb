#pragma checksum "C:\Users\Administrator\Desktop\kaniniday1\dbms\day7\Test websites\test5\Views\Topping\Select_this.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "110a9a6f03c9623591120b7654243fb01ca52612"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Topping_Select_this), @"mvc.1.0.view", @"/Views/Topping/Select_this.cshtml")]
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
#line 1 "C:\Users\Administrator\Desktop\kaniniday1\dbms\day7\Test websites\test5\Views\_ViewImports.cshtml"
using PizzaApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Administrator\Desktop\kaniniday1\dbms\day7\Test websites\test5\Views\_ViewImports.cshtml"
using PizzaApplication.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"110a9a6f03c9623591120b7654243fb01ca52612", @"/Views/Topping/Select_this.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ba295415eabbe47cee94bfd856e3b8f99d2f3b1", @"/Views/_ViewImports.cshtml")]
    public class Views_Topping_Select_this : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Administrator\Desktop\kaniniday1\dbms\day7\Test websites\test5\Views\Topping\Select_this.cshtml"
  
    ViewData["Title"] = "Select_This";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"card\">\r\n    <div class=\"card-header\">\r\n        <P style=\"color: darkolivegreen\"> Topping Selected </P>\r\n    </div>\r\n    <div class=\"card-body\">\r\n        <div class=\"btn btn-dark\">\r\n            ");
#nullable restore
#line 11 "C:\Users\Administrator\Desktop\kaniniday1\dbms\day7\Test websites\test5\Views\Topping\Select_this.cshtml"
       Write(Html.ActionLink("Go to Checkout", "Checkout"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <hr />\r\n        <div class=\"btn btn-dark\">\r\n            ");
#nullable restore
#line 15 "C:\Users\Administrator\Desktop\kaniniday1\dbms\day7\Test websites\test5\Views\Topping\Select_this.cshtml"
       Write(Html.ActionLink("Add Another Pizza", "AddPizza"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n       <hr />\r\n        <div class=\"btn btn-dark\">\r\n            ");
#nullable restore
#line 19 "C:\Users\Administrator\Desktop\kaniniday1\dbms\day7\Test websites\test5\Views\Topping\Select_this.cshtml"
       Write(Html.ActionLink("Add Another Toppings", "AddTopping"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n    </div>\r\n</div>\r\n");
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
