#pragma checksum "D:\Codes\NetLearnNote\013、NetX--NET跨平台基础\DemoNet5-01\DemoNet5Mvc\Views\First\Second.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9495fe39cb122ea7eabeab54d5957a46e96a9962"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_First_Second), @"mvc.1.0.view", @"/Views/First/Second.cshtml")]
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
#line 1 "D:\Codes\NetLearnNote\013、NetX--NET跨平台基础\DemoNet5-01\DemoNet5Mvc\Views\_ViewImports.cshtml"
using DemoNet5Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Codes\NetLearnNote\013、NetX--NET跨平台基础\DemoNet5-01\DemoNet5Mvc\Views\_ViewImports.cshtml"
using DemoNet5Mvc.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Codes\NetLearnNote\013、NetX--NET跨平台基础\DemoNet5-01\DemoNet5Mvc\Views\First\Second.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9495fe39cb122ea7eabeab54d5957a46e96a9962", @"/Views/First/Second.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ebbc934d8c80f7dbcf6e8b7b8b78af2fcaa4bdf", @"/Views/_ViewImports.cshtml")]
    public class Views_First_Second : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<string>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h3> ViewBag.User1=  ");
#nullable restore
#line 3 "D:\Codes\NetLearnNote\013、NetX--NET跨平台基础\DemoNet5-01\DemoNet5Mvc\Views\First\Second.cshtml"
                Write(base.ViewBag.User1);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h3>\r\n<h3> ViewData[\"User2\"]= ");
#nullable restore
#line 4 "D:\Codes\NetLearnNote\013、NetX--NET跨平台基础\DemoNet5-01\DemoNet5Mvc\Views\First\Second.cshtml"
                   Write(base.ViewData["User2"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h3>\r\n<h3> TempData[\"User3\"]= ");
#nullable restore
#line 5 "D:\Codes\NetLearnNote\013、NetX--NET跨平台基础\DemoNet5-01\DemoNet5Mvc\Views\First\Second.cshtml"
                   Write(base.TempData["User3"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h3>\r\n<h3> Model= ");
#nullable restore
#line 6 "D:\Codes\NetLearnNote\013、NetX--NET跨平台基础\DemoNet5-01\DemoNet5Mvc\Views\First\Second.cshtml"
       Write(Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<h3> Session-User5= ");
#nullable restore
#line 7 "D:\Codes\NetLearnNote\013、NetX--NET跨平台基础\DemoNet5-01\DemoNet5Mvc\Views\First\Second.cshtml"
               Write(Context.Session.GetString("User5"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<string> Html { get; private set; }
    }
}
#pragma warning restore 1591
