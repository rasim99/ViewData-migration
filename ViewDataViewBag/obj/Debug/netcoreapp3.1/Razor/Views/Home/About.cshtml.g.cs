#pragma checksum "C:\Users\ASUS\Desktop\BACKEND\ViewDataViewBag\ViewDataViewBag\Views\Home\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6067a389a2cd40ee742dd0594dd4638be5e30dc7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_About), @"mvc.1.0.view", @"/Views/Home/About.cshtml")]
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
#line 1 "C:\Users\ASUS\Desktop\BACKEND\ViewDataViewBag\ViewDataViewBag\Views\_ViewImports.cshtml"
using ViewDataViewBag.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6067a389a2cd40ee742dd0594dd4638be5e30dc7", @"/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d3fc3122528e89685075d43395c7009895ea11d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\ASUS\Desktop\BACKEND\ViewDataViewBag\ViewDataViewBag\Views\Home\About.cshtml"
  
    ViewData["Title"] = "About";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>About</h1>\r\n\r\n<p> ViewData    =>>>      ");
#nullable restore
#line 8 "C:\Users\ASUS\Desktop\BACKEND\ViewDataViewBag\ViewDataViewBag\Views\Home\About.cshtml"
                     Write(ViewData["Name"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>ViewBag       =>>>         ");
#nullable restore
#line 9 "C:\Users\ASUS\Desktop\BACKEND\ViewDataViewBag\ViewDataViewBag\Views\Home\About.cshtml"
                         Write(ViewBag.SurName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>TempData    =>>        ");
#nullable restore
#line 10 "C:\Users\ASUS\Desktop\BACKEND\ViewDataViewBag\ViewDataViewBag\Views\Home\About.cshtml"
                     Write(TempData["Age"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n\r\n\r\n<a href=\"/home/index\">GO TO HOME</a>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
