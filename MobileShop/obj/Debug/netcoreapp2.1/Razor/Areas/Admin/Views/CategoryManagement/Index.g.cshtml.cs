#pragma checksum "E:\MobileShop_ASP.NET-CORE\MobileShop\Areas\Admin\Views\CategoryManagement\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "240ccae08b87e789f6dd20d3508e0aa903563e43"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_CategoryManagement_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/CategoryManagement/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/CategoryManagement/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_CategoryManagement_Index))]
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
#line 1 "E:\MobileShop_ASP.NET-CORE\MobileShop\Areas\Admin\Views\_ViewImports.cshtml"
using MobileShop;

#line default
#line hidden
#line 2 "E:\MobileShop_ASP.NET-CORE\MobileShop\Areas\Admin\Views\_ViewImports.cshtml"
using MobileShop.ViewModels;

#line default
#line hidden
#line 3 "E:\MobileShop_ASP.NET-CORE\MobileShop\Areas\Admin\Views\_ViewImports.cshtml"
using MobileShop.Data.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"240ccae08b87e789f6dd20d3508e0aa903563e43", @"/Areas/Admin/Views/CategoryManagement/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7cb4f6b7a7aca57832721f64923c52f93d3a6df", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_CategoryManagement_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Category>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Admin/css/CategoryManagement/IndexCSS.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "GET", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "E:\MobileShop_ASP.NET-CORE\MobileShop\Areas\Admin\Views\CategoryManagement\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
            BeginContext(135, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(137, 76, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0beccd780f80489db74fb2c9e69b0531", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(213, 69, true);
            WriteLiteral("\r\n<div class=\"wrapper-content\">\r\n    <h2>QUẢN LÝ LOẠI SẢN PHẨM</h2>\r\n");
            EndContext();
#line 10 "E:\MobileShop_ASP.NET-CORE\MobileShop\Areas\Admin\Views\CategoryManagement\Index.cshtml"
     if (TempData["CantDelele"] != null)
    {

#line default
#line hidden
            BeginContext(331, 71, true);
            WriteLiteral("        <p style=\"color: red; text-align: center; margin-bottom: 5px;\">");
            EndContext();
            BeginContext(403, 22, false);
#line 12 "E:\MobileShop_ASP.NET-CORE\MobileShop\Areas\Admin\Views\CategoryManagement\Index.cshtml"
                                                                  Write(TempData["CantDelele"]);

#line default
#line hidden
            EndContext();
            BeginContext(425, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 13 "E:\MobileShop_ASP.NET-CORE\MobileShop\Areas\Admin\Views\CategoryManagement\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(438, 193, true);
            WriteLiteral("    <table>\r\n        <tr>\r\n            <th>#</th>\r\n            <th>Tên loại sản phẩm</th>\r\n            <th>Mô tả</th>\r\n            <th>SL</th>\r\n            <th>Hành động</th>\r\n        </tr>\r\n\r\n");
            EndContext();
#line 23 "E:\MobileShop_ASP.NET-CORE\MobileShop\Areas\Admin\Views\CategoryManagement\Index.cshtml"
          int i = 1, z = 0;

#line default
#line hidden
            BeginContext(661, 8, true);
            WriteLiteral("        ");
            EndContext();
#line 24 "E:\MobileShop_ASP.NET-CORE\MobileShop\Areas\Admin\Views\CategoryManagement\Index.cshtml"
          
            int[] q = new int[Model.Count()];
            foreach (var item in ViewBag.query)
            {
                q[z] = item;
                z++;
            }

            z = 0;
            foreach (var category in Model)
            {

#line default
#line hidden
            BeginContext(933, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(980, 1, false);
#line 36 "E:\MobileShop_ASP.NET-CORE\MobileShop\Areas\Admin\Views\CategoryManagement\Index.cshtml"
                   Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(981, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1013, 22, false);
#line 37 "E:\MobileShop_ASP.NET-CORE\MobileShop\Areas\Admin\Views\CategoryManagement\Index.cshtml"
                   Write(category.Category_Name);

#line default
#line hidden
            EndContext();
            BeginContext(1035, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1067, 29, false);
#line 38 "E:\MobileShop_ASP.NET-CORE\MobileShop\Areas\Admin\Views\CategoryManagement\Index.cshtml"
                   Write(category.Category_Description);

#line default
#line hidden
            EndContext();
            BeginContext(1096, 33, true);
            WriteLiteral("</td>\r\n\r\n                    <td>");
            EndContext();
            BeginContext(1130, 4, false);
#line 40 "E:\MobileShop_ASP.NET-CORE\MobileShop\Areas\Admin\Views\CategoryManagement\Index.cshtml"
                   Write(q[z]);

#line default
#line hidden
            EndContext();
            BeginContext(1134, 59, true);
            WriteLiteral("</td>\r\n\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1193, 316, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76f26e8cd87f4f5e98763ba1e1737e3b", async() => {
                BeginContext(1267, 235, true);
                WriteLiteral("\r\n                            <button type=\"submit\" class=\"action-edit\">\r\n                                <i class=\"fas fa-edit\"></i>\r\n                                Sửa\r\n                            </button>\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 43 "E:\MobileShop_ASP.NET-CORE\MobileShop\Areas\Admin\Views\CategoryManagement\Index.cshtml"
                                                  WriteLiteral(category.Category_Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1509, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(1535, 401, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "72668490901a4afbb712e2697c4f9113", async() => {
                BeginContext(1612, 317, true);
                WriteLiteral(@"
                            <button type=""submit"" class=""action-delete"" onclick=""return confirm('Bạn có chắc chắn muốn xóa loại sản phẩm này ?');"">
                                <i class=""fas fa-trash-alt""></i>
                                Xóa
                            </button>
                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 49 "E:\MobileShop_ASP.NET-CORE\MobileShop\Areas\Admin\Views\CategoryManagement\Index.cshtml"
                                                    WriteLiteral(category.Category_Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1936, 52, true);
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 57 "E:\MobileShop_ASP.NET-CORE\MobileShop\Areas\Admin\Views\CategoryManagement\Index.cshtml"
                i++;
                z++;
            }
        

#line default
#line hidden
            BeginContext(2058, 32, true);
            WriteLiteral("\r\n    </table>\r\n</div>\r\n\r\n\r\n\r\n\r\n");
            EndContext();
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
