#pragma checksum "C:\Users\VishalKumar\Documents\vishal\Dhawal_Construction\construction\App\Views\User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f204e5eec9c313d3a4783946c468740c7aadb4b4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Index), @"mvc.1.0.view", @"/Views/User/Index.cshtml")]
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
#line 1 "C:\Users\VishalKumar\Documents\vishal\Dhawal_Construction\construction\App\Views\_ViewImports.cshtml"
using App;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\VishalKumar\Documents\vishal\Dhawal_Construction\construction\App\Views\_ViewImports.cshtml"
using App.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f204e5eec9c313d3a4783946c468740c7aadb4b4", @"/Views/User/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12334568134fabec32ff1911f23453426e7f6405", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable< App.Entity.tbl_user>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("avatar-img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/proj/assets/img/avatars/1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("user@email.com"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "C:\Users\VishalKumar\Documents\vishal\Dhawal_Construction\construction\App\Views\User\Index.cshtml"
  
    Layout = "~/Views/_adminlayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"wrapper d-flex flex-column min-vh-100 bg-light bg-opacity-50 dark:bg-transparent\">\r\n    ");
#nullable restore
#line 11 "C:\Users\VishalKumar\Documents\vishal\Dhawal_Construction\construction\App\Views\User\Index.cshtml"
Write(Html.Partial("_adminheader"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@";

    <div class=""body flex-grow-1 px-3"">
        <div class=""container-lg"">
            <nav aria-label=""breadcrumb"">
                <ol class=""breadcrumb mb-4"">
                    <li class=""breadcrumb-item"">
                        <span>Home</span>
                    </li>
                    <li class=""breadcrumb-item active""><span>Users</span></li>
                </ol>
            </nav>

            <div class=""row"">
                <div class=""col-lg-12"">
                    <div class=""card mb-4"">
                        <div class=""card-body p-4"">
                            <div class=""row"">
                                <div class=""col"">
                                    <div class=""card-title fs-4 fw-semibold"">Customers</div>
                                    <div class=""card-subtitle text-disabled mb-4"">1 registered users</div>
                                </div>
                                <div class=""col-auto ms-auto"">
                                  ");
            WriteLiteral("  <button class=\"btn btn-secondary\">\r\n                                        <svg class=\"icon me-2\">\r\n                                            <use");
            BeginWriteAttribute("xlink:href", " xlink:href=\"", 1525, "\"", 1594, 2);
            WriteAttributeValue("", 1538, "~/proj/vendors/", 1538, 15, true);
            WriteLiteral("@");
            WriteAttributeValue("", 1555, "coreui/icons/svg/free.svg#cil-user-plus", 1555, 39, true);
            EndWriteAttribute();
            WriteLiteral(@">
                                            </use>
                                        </svg>Add new Customer
                                    </button>
                                </div>
                            </div>
                            <div class=""table-responsive"">
                                <table class=""table mb-0"">
                                    <thead class=""fw-semibold text-disabled"">
                                        <tr class=""align-middle"">
                                            <th class=""text-center"">
                                                <svg class=""icon"">
                                                    <use");
            BeginWriteAttribute("xlink:href", " xlink:href=\"", 2297, "\"", 2363, 2);
            WriteAttributeValue("", 2310, "~/proj/vendors/", 2310, 15, true);
            WriteLiteral("@");
            WriteAttributeValue("", 2327, "coreui/icons/svg/free.svg#cil-people", 2327, 36, true);
            EndWriteAttribute();
            WriteLiteral(@">
                                                    </use>
                                                </svg>
                                            </th>
                                            <th class=""text-left"">Customer</th>
                                            <th class=""text-center"">Actions</th>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        <tr class=""align-middle"">
                                            <td class=""text-center"">
                                                <div class=""avatar avatar-md"">
                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f204e5eec9c313d3a4783946c468740c7aadb4b48304", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"<span class=""avatar-status bg-success""></span>
                                                </div>
                                            </td>
                                            <td>
                                                <div>Shreevatsa</div>
                                                <div class=""small text-disabled"">
                                                    <span>New</span> | Registered: Jan
                                                    1, 2020
                                                </div>
                                            </td>
                                            <td class=""text-end"">
                                                <button type=""button"" class=""btn btn-outline-info"">View</button>
                                                <button type=""button"" class=""btn btn-outline-warning"">Edit</button>
                                                <button type=""button"" class=""btn btn-outline-danger"" data-coreu");
            WriteLiteral(@"i-toggle=""modal"" data-coreui-target=""#deleteModal"" data-coreui-whatever="""">Delete</button>
                                            </td>
                                        </tr>
                                    </tbody>
                                </table>
                            </div>
                        </div>
                    </div>

                </div>
            </div>
        </div>
    </div>
    <div class=""modal fade"" id=""deleteModal"" tabindex=""-1"" aria-labelledby=""viewModalLabel"" aria-hidden=""true"">
        <div class=""modal-dialog modal-dialog-centered"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"" id=""viewModalLabel"">User Details</h5>
                    <button type=""button"" class=""btn-close"" data-coreui-dismiss=""modal"" aria-label=""Close""></button>
                </div>
                <div class=""modal-body"">
                    <p>Are you sure want to delete us");
            WriteLiteral(@"er with all details ?</p>
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-dark"" data-coreui-dismiss=""modal"">Back</button>
                    <button type=""button"" class=""btn btn-danger"">Delete User</button>
                </div>
            </div>
        </div>
    </div>

    ");
#nullable restore
#line 105 "C:\Users\VishalKumar\Documents\vishal\Dhawal_Construction\construction\App\Views\User\Index.cshtml"
Write(Html.Partial("_adminfooter"));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable< App.Entity.tbl_user>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
