#pragma checksum "C:\Users\DPanchalTech\Documents\vishal\Dhawal_Construction\construction\App\Views\_adminsidebar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6be14e750f18e95f27f5629c2e0db9914374cbaa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views__adminsidebar), @"mvc.1.0.view", @"/Views/_adminsidebar.cshtml")]
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
#line 1 "C:\Users\DPanchalTech\Documents\vishal\Dhawal_Construction\construction\App\Views\_ViewImports.cshtml"
using App;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\DPanchalTech\Documents\vishal\Dhawal_Construction\construction\App\Views\_ViewImports.cshtml"
using App.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6be14e750f18e95f27f5629c2e0db9914374cbaa", @"/Views/_adminsidebar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12334568134fabec32ff1911f23453426e7f6405", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views__adminsidebar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n\r\n<div class=\"sidebar sidebar-dark sidebar-fixed bg-dark-gradient\" id=\"sidebar\">\r\n    <div class=\"sidebar-brand d-none d-md-flex\">\r\n");
            WriteLiteral("        <button class=\"sidebar-toggler\" type=\"button\" data-coreui-toggle=\"unfoldable\"></button>\r\n    </div>\r\n    <ul class=\"sidebar-nav\" data-coreui=\"navigation\" data-simplebar=\"\">\r\n\r\n");
            WriteLiteral(@"        <li class=""nav-divider""></li>
        <li class=""nav-title"">Admin</li>
        <li class=""nav-item"">
            <a class=""nav-link"" href=""\user\index"">
                User
            </a>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" href=""\supplier\index"">
                Supplier
            </a>
        </li>
");
            WriteLiteral(@"    </ul>
</div>
<div class=""sidebar sidebar-light sidebar-lg sidebar-end sidebar-overlaid hide"" id=""aside"">
    <div class=""sidebar-header bg-transparent p-0"">
        <button class=""sidebar-close"" type=""button"" data-coreui-close=""sidebar"">
            <svg class=""icon"">
                <use");
            BeginWriteAttribute("xlink:href", " xlink:href=\"", 3844, "\"", 3905, 2);
            WriteAttributeValue("", 3857, "~/proj/vendors/", 3857, 15, true);
            WriteLiteral("@");
            WriteAttributeValue("", 3874, "coreui/icons/svg/free.svg#cil-x", 3874, 31, true);
            EndWriteAttribute();
            WriteLiteral("></use>\r\n            </svg>\r\n        </button>\r\n    </div>\r\n</div>\r\n");
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