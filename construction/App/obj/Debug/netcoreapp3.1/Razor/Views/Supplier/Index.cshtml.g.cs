#pragma checksum "C:\Users\DPanchalTech\Documents\vishal\Dhawal_Construction\construction\App\Views\Supplier\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b5519f4bfa1ebc8fdd5fef2f2336a6255db2112f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Supplier_Index), @"mvc.1.0.view", @"/Views/Supplier/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5519f4bfa1ebc8fdd5fef2f2336a6255db2112f", @"/Views/Supplier/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12334568134fabec32ff1911f23453426e7f6405", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Supplier_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<App.Models.suppliermodel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "/Views/_adminheader.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_mastertype", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_masterfield", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_mastertypefield", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_supplier", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_mastertypesupplier", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "/Views/_adminfooter.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\DPanchalTech\Documents\vishal\Dhawal_Construction\construction\App\Views\Supplier\Index.cshtml"
  
    Layout = "~/Views/_adminlayout.cshtml";
    var breadcrumb = Model.tabid == 1 ? "Master Type" : Model.tabid == 2 ? "Master Field" : Model.tabid == 3 ? "Master Type Field" : Model.tabid == 4 ? "Supplier" : "Master Type Supplier";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"wrapper d-flex flex-column min-vh-100 bg-light bg-opacity-50 dark:bg-transparent\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b5519f4bfa1ebc8fdd5fef2f2336a6255db2112f5867", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"


        <div class=""body flex-grow-1 px-3"">
            <div class=""container-lg"">
                <nav aria-label=""breadcrumb"">
                    <ol class=""breadcrumb mb-4"">
                        <li class=""breadcrumb-item"">
                            <span>Home</span>
                        </li>
                        <li class=""breadcrumb-item active""><span>Suppliers</span></li>
                    </ol>
                </nav>

                <div class=""row user-details"">
                    <div class=""col-lg-12"">
                        <!-- Tabs with icons on Card -->
                        <div class=""card card-nav-tabs"">
                            <div class=""card-header card-header-primary"">
                                <!-- colors: ""header-primary"", ""header-info"", ""header-success"", ""header-warning"", ""header-danger"" -->
                                <div class=""nav-tabs-navigation"">
                                    <div class=""nav-tabs-wrapper"">
         ");
            WriteLiteral("                               <ul class=\"nav nav-tabs\" data-tabs=\"tabs\">\r\n                                            <li class=\"nav-item\">\r\n\r\n");
#nullable restore
#line 33 "C:\Users\DPanchalTech\Documents\vishal\Dhawal_Construction\construction\App\Views\Supplier\Index.cshtml"
                                                 if (Model.tabid == 1)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                    <a class=""nav-link active"" data-coreui-target=""#mastertypes""
                                                   href=""/supplier/viewmastertype"">
                                                        Master Types
                                                    </a>
");
#nullable restore
#line 39 "C:\Users\DPanchalTech\Documents\vishal\Dhawal_Construction\construction\App\Views\Supplier\Index.cshtml"
                                                                                      
                                                }
                                                else
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                    <a class=""nav-link"" data-coreui-target=""#mastertypes""
                                                   href=""/supplier/viewmastertype"">
                                                        Master Types
                                                    </a>
");
#nullable restore
#line 47 "C:\Users\DPanchalTech\Documents\vishal\Dhawal_Construction\construction\App\Views\Supplier\Index.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </li>\r\n                                            <li class=\"nav-item\">\r\n");
#nullable restore
#line 51 "C:\Users\DPanchalTech\Documents\vishal\Dhawal_Construction\construction\App\Views\Supplier\Index.cshtml"
                                                 if (Model.tabid == 2)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                    <a class=""nav-link active"" data-coreui-target=""#masterfields""
                                                   href=""/supplier/viewmasterfield"">
                                                        Master Fields
                                                    </a>
");
#nullable restore
#line 57 "C:\Users\DPanchalTech\Documents\vishal\Dhawal_Construction\construction\App\Views\Supplier\Index.cshtml"
                                                }
                                                else
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                    <a class=""nav-link"" data-coreui-target=""#masterfields""
                                                   href=""/supplier/viewmasterfield"">
                                                        Master Fields
                                                    </a>
");
#nullable restore
#line 64 "C:\Users\DPanchalTech\Documents\vishal\Dhawal_Construction\construction\App\Views\Supplier\Index.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </li>\r\n                                            <li class=\"nav-item\">\r\n");
#nullable restore
#line 68 "C:\Users\DPanchalTech\Documents\vishal\Dhawal_Construction\construction\App\Views\Supplier\Index.cshtml"
                                                 if (Model.tabid == 3)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                    <a class=""nav-link active"" data-coreui-target=""#mastertypefields""
                                                   href=""/supplier/viewmastertypefield"">
                                                        Master Type Fields
                                                    </a>
");
#nullable restore
#line 74 "C:\Users\DPanchalTech\Documents\vishal\Dhawal_Construction\construction\App\Views\Supplier\Index.cshtml"
                                                }
                                                else
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                    <a class=""nav-link"" data-coreui-target=""#mastertypefields""
                                                   href=""/supplier/viewmastertypefield"">
                                                        Master Type Fields
                                                    </a>
");
#nullable restore
#line 81 "C:\Users\DPanchalTech\Documents\vishal\Dhawal_Construction\construction\App\Views\Supplier\Index.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </li>\r\n\r\n                                            <li class=\"nav-item\">\r\n");
#nullable restore
#line 86 "C:\Users\DPanchalTech\Documents\vishal\Dhawal_Construction\construction\App\Views\Supplier\Index.cshtml"
                                                 if (Model.tabid == 4)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                    <a class=""nav-link active"" data-coreui-target=""#suppliers""
                                                   href=""/supplier/viewsupplier"">
                                                        Suppliers
                                                    </a>
");
#nullable restore
#line 92 "C:\Users\DPanchalTech\Documents\vishal\Dhawal_Construction\construction\App\Views\Supplier\Index.cshtml"
                                                }
                                                else
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                    <a class=""nav-link"" data-coreui-target=""#suppliers""
                                                   href=""/supplier/viewsupplier"">
                                                        Suppliers
                                                    </a>
");
#nullable restore
#line 99 "C:\Users\DPanchalTech\Documents\vishal\Dhawal_Construction\construction\App\Views\Supplier\Index.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </li>\r\n\r\n                                            <li class=\"nav-item\">\r\n");
#nullable restore
#line 104 "C:\Users\DPanchalTech\Documents\vishal\Dhawal_Construction\construction\App\Views\Supplier\Index.cshtml"
                                                 if (Model.tabid == 5)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                    <a class=""nav-link active"" data-coreui-target=""#mastertypeSuppliers""
                                                   href=""/supplier/viewmastertypesupplier"">
                                                        Master Type Suppliers
                                                    </a>
");
#nullable restore
#line 110 "C:\Users\DPanchalTech\Documents\vishal\Dhawal_Construction\construction\App\Views\Supplier\Index.cshtml"
                                                }
                                                else
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                    <a class=""nav-link"" data-coreui-target=""#mastertypeSuppliers""
                                                   href=""/supplier/viewmastertypesupplier"">
                                                        Master Type Suppliers
                                                    </a>
");
#nullable restore
#line 117 "C:\Users\DPanchalTech\Documents\vishal\Dhawal_Construction\construction\App\Views\Supplier\Index.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                            </li>
                                        </ul>
                                    </div>
                                </div>
                            </div>
                            <div class=""card-body "">
                                <div class=""tab-content"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b5519f4bfa1ebc8fdd5fef2f2336a6255db2112f17480", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 126 "C:\Users\DPanchalTech\Documents\vishal\Dhawal_Construction\construction\App\Views\Supplier\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("for", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b5519f4bfa1ebc8fdd5fef2f2336a6255db2112f19176", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 127 "C:\Users\DPanchalTech\Documents\vishal\Dhawal_Construction\construction\App\Views\Supplier\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("for", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b5519f4bfa1ebc8fdd5fef2f2336a6255db2112f20876", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#nullable restore
#line 128 "C:\Users\DPanchalTech\Documents\vishal\Dhawal_Construction\construction\App\Views\Supplier\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("for", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b5519f4bfa1ebc8fdd5fef2f2336a6255db2112f22580", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
#nullable restore
#line 129 "C:\Users\DPanchalTech\Documents\vishal\Dhawal_Construction\construction\App\Views\Supplier\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("for", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b5519f4bfa1ebc8fdd5fef2f2336a6255db2112f24288", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
#nullable restore
#line 130 "C:\Users\DPanchalTech\Documents\vishal\Dhawal_Construction\construction\App\Views\Supplier\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("for", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                </div>
                            </div>
                        </div>
                        <!-- End Tabs with icons on Card -->
                    </div>
                </div>
            </div>
        </div>

        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b5519f4bfa1ebc8fdd5fef2f2336a6255db2112f26211", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<App.Models.suppliermodel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591