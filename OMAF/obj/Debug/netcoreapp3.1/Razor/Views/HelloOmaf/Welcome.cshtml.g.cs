#pragma checksum "C:\Users\goric\source\repos\O-MAF\OMAF\Views\HelloOmaf\Welcome.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "058a93b3844c20a5831adccd303ea51bfeeda08f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HelloOmaf_Welcome), @"mvc.1.0.view", @"/Views/HelloOmaf/Welcome.cshtml")]
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
#line 1 "C:\Users\goric\source\repos\O-MAF\OMAF\Views\_ViewImports.cshtml"
using OMAF;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\goric\source\repos\O-MAF\OMAF\Views\_ViewImports.cshtml"
using OMAF.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\goric\source\repos\O-MAF\OMAF\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"058a93b3844c20a5831adccd303ea51bfeeda08f", @"/Views/HelloOmaf/Welcome.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d5ed1dc2081555074f55636c72245d772912f2c0", @"/Views/_ViewImports.cshtml")]
    public class Views_HelloOmaf_Welcome : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\goric\source\repos\O-MAF\OMAF\Views\HelloOmaf\Welcome.cshtml"
  
    ViewData["Title"] = "Welcome";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2>Welcome</h2>\n\n<ul>\n");
#nullable restore
#line 8 "C:\Users\goric\source\repos\O-MAF\OMAF\Views\HelloOmaf\Welcome.cshtml"
     for (int i = 0; i < (int)ViewData["NumTimes"]; i++)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>");
#nullable restore
#line 10 "C:\Users\goric\source\repos\O-MAF\OMAF\Views\HelloOmaf\Welcome.cshtml"
       Write(ViewData["Message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n");
#nullable restore
#line 11 "C:\Users\goric\source\repos\O-MAF\OMAF\Views\HelloOmaf\Welcome.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>");
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
