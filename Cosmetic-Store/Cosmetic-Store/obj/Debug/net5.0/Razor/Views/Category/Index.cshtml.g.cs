#pragma checksum "C:\Users\Islam\source\repos\E-Commerce-App\Cosmetic-Store\Cosmetic-Store\Views\Category\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c0bcf79e257248fb276d315173aa4dadf017e2c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_Index), @"mvc.1.0.view", @"/Views/Category/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c0bcf79e257248fb276d315173aa4dadf017e2c", @"/Views/Category/Index.cshtml")]
    #nullable restore
    public class Views_Category_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Cosmetic_Store.Models.Category>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n    <h1>List Of Categories: </h1>\r\n\r\n    <ul>\r\n");
#nullable restore
#line 6 "C:\Users\Islam\source\repos\E-Commerce-App\Cosmetic-Store\Cosmetic-Store\Views\Category\Index.cshtml"
         foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("             <li>\r\n                  <div>\r\n                    <h3>");
#nullable restore
#line 10 "C:\Users\Islam\source\repos\E-Commerce-App\Cosmetic-Store\Cosmetic-Store\Views\Category\Index.cshtml"
                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                  </div>\r\n             </li>\r\n");
#nullable restore
#line 13 "C:\Users\Islam\source\repos\E-Commerce-App\Cosmetic-Store\Cosmetic-Store\Views\Category\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n    ");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Cosmetic_Store.Models.Category>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591