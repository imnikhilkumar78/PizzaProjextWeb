#pragma checksum "C:\Users\Administrator\Desktop\PizzaWithOrders\Views\Pizza\Select_This.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0e49fff900b39d4be1530d79199434d7b9b4873d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pizza_Select_This), @"mvc.1.0.view", @"/Views/Pizza/Select_This.cshtml")]
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
#line 1 "C:\Users\Administrator\Desktop\PizzaWithOrders\Views\_ViewImports.cshtml"
using PizzaApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Administrator\Desktop\PizzaWithOrders\Views\_ViewImports.cshtml"
using PizzaApplication.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e49fff900b39d4be1530d79199434d7b9b4873d", @"/Views/Pizza/Select_This.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ba295415eabbe47cee94bfd856e3b8f99d2f3b1", @"/Views/_ViewImports.cshtml")]
    public class Views_Pizza_Select_This : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"card\">\r\n    <div class=\"card-header\">\r\n        <P style=\"color: darkolivegreen\"> Pizza Selected </P> \r\n        <p></p>\r\n    </div>\r\n    <div class=\"card-body\">\r\n        <div class=\"btn btn-dark\">\r\n            ");
#nullable restore
#line 13 "C:\Users\Administrator\Desktop\PizzaWithOrders\Views\Pizza\Select_This.cshtml"
       Write(Html.ActionLink("Go to Checkout", "Checkout"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <hr />\r\n        <div class=\"btn btn-dark\">\r\n            ");
#nullable restore
#line 17 "C:\Users\Administrator\Desktop\PizzaWithOrders\Views\Pizza\Select_This.cshtml"
       Write(Html.ActionLink("Add Another Pizza", "AddPizza"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <hr />\r\n        <div class=\"btn btn-dark\">\r\n            ");
#nullable restore
#line 21 "C:\Users\Administrator\Desktop\PizzaWithOrders\Views\Pizza\Select_This.cshtml"
       Write(Html.ActionLink("Add Toppings", "AddTopping"));

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
