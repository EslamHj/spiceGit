#pragma checksum "C:\Users\Eslam\Desktop\spice\spice\spice\Areas\Admin\Views\Categorise\CategoryView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2f3ddb70c761a8bef8604ffca0f591559bc17060"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Categorise_CategoryView), @"mvc.1.0.view", @"/Areas/Admin/Views/Categorise/CategoryView.cshtml")]
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
#line 1 "C:\Users\Eslam\Desktop\spice\spice\spice\Areas\Admin\Views\_ViewImports.cshtml"
using spice;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Eslam\Desktop\spice\spice\spice\Areas\Admin\Views\_ViewImports.cshtml"
using spice.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f3ddb70c761a8bef8604ffca0f591559bc17060", @"/Areas/Admin/Views/Categorise/CategoryView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f2ed86c783bf4c79000cbafe64aee5d4a8ac8ec", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Categorise_CategoryView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Category>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "creatbtn", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Eslam\Desktop\spice\spice\spice\Areas\Admin\Views\Categorise\CategoryView.cshtml"
  
    ViewData["Title"] = "CategoryView";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"borderList\" >\r\n    <div class=\"row\">\r\n        <div class=\" col-6\" >\r\n            <h2 class=\"list text-danger\">\r\n                catecories list\r\n            </h2>\r\n\r\n        </div>\r\n        <div class=\" col-6 text-right\" >\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2f3ddb70c761a8bef8604ffca0f591559bc170603977", async() => {
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
            WriteLiteral("\r\n        </div>\r\n        <div>\r\n");
#nullable restore
#line 18 "C:\Users\Eslam\Desktop\spice\spice\spice\Areas\Admin\Views\Categorise\CategoryView.cshtml"
             if (Model.Count() == 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("               <p class=\"text-danger\">No catecory.... </p> \r\n");
#nullable restore
#line 21 "C:\Users\Eslam\Desktop\spice\spice\spice\Areas\Admin\Views\Categorise\CategoryView.cshtml"

            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <table class=\"table table-striped border\" >\r\n                    <tr class=\"table-secondary\">\r\n                        <th>\r\n                            ");
#nullable restore
#line 28 "C:\Users\Eslam\Desktop\spice\spice\spice\Areas\Admin\Views\Categorise\CategoryView.cshtml"
                       Write(Html.DisplayNameFor(m => m.name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n\r\n                        </th>\r\n                    </tr>\r\n");
#nullable restore
#line 34 "C:\Users\Eslam\Desktop\spice\spice\spice\Areas\Admin\Views\Categorise\CategoryView.cshtml"
                     foreach(var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
#nullable restore
#line 38 "C:\Users\Eslam\Desktop\spice\spice\spice\Areas\Admin\Views\Categorise\CategoryView.cshtml"
                           Write(Html.DisplayFor(m=>item.name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                              Dateils | Edit | Delete\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 44 "C:\Users\Eslam\Desktop\spice\spice\spice\Areas\Admin\Views\Categorise\CategoryView.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </table>\r\n");
#nullable restore
#line 46 "C:\Users\Eslam\Desktop\spice\spice\spice\Areas\Admin\Views\Categorise\CategoryView.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
