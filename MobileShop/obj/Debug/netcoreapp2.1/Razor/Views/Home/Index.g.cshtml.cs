#pragma checksum "E:\MobileShop_ASP.NET-CORE\MobileShop\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "42c0e808cb41b67784502e63d8f1f42112f947d0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "E:\MobileShop_ASP.NET-CORE\MobileShop\Views\_ViewImports.cshtml"
using MobileShop;

#line default
#line hidden
#line 2 "E:\MobileShop_ASP.NET-CORE\MobileShop\Views\_ViewImports.cshtml"
using MobileShop.ViewModels;

#line default
#line hidden
#line 3 "E:\MobileShop_ASP.NET-CORE\MobileShop\Views\_ViewImports.cshtml"
using MobileShop.Data.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42c0e808cb41b67784502e63d8f1f42112f947d0", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f8282febc87a857b1dd3c8924bd5c37fdb8cfb2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/User/css/Home/IndexCSS.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "E:\MobileShop_ASP.NET-CORE\MobileShop\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(90, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ac2d8052c19346b6b548a302cf87adee", async() => {
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
            BeginContext(151, 1721, true);
            WriteLiteral(@"
<div class=""row"">
    <div class=""row-box"">
        <span>
            <i class=""fas fa-map-marker-alt""></i>
            Địa chỉ: 123 Bình Giã, Vũng Tàu
        </span>
        <span style=""margin-left: 10px;"">
            <i class=""fas fa-phone-alt""></i>
            Hotline: 1900.0702
        </span>
        <span style=""float: right;"">
            <a href=""#"" style=""text-decoration: none; color: #000;"">
                <i class=""fas fa-envelope""></i>
                Liên hệ
            </a>
        </span>
    </div>
</div>
<style>
    .mySlides {
        display: none;
    }
</style>
<div class=""content-header"">
    <div class=""banner"">
        <div class=""banner-left"">
            <img class=""mySlides"" src=""https://cdn.tgdd.vn/2019/09/banner/thu-cu-note10-800-300-800x300-(1).png"" alt=""banner"">
            <img class=""mySlides"" src=""https://cdn.tgdd.vn/2019/09/banner/oppo-A9-800-300-800x300-(1).png"" alt="""">
            <img class=""mySlides"" src=""https://cdn.tgdd.vn/2019/09/ban");
            WriteLiteral(@"ner/huawei-3i-white-800-300-800x300-(1).png"" alt="""">
            <div class=""btn-banner"">
                <button onclick=""plusDivs(-1)"">&#10094;</button>
                <button onclick=""plusDivs(1)"">&#10095;</button>
            </div>
        </div>
        <div class=""banner-right"">
            <img src=""https://cdn.cellphones.com.vn/media/ltsoft/promotion/thu-c_-galaxy-note-10-_-10_-_2_-750x350_2_1911.png"" alt=""banner"" />
            <img src=""https://cdn.cellphones.com.vn/media/ltsoft/promotion/Right-banner_iphone_11_111.png"" alt=""banner"" />
        </div>
    </div>
    <div class=""menu"">
        <h4><i class=""fas fa-list""></i>     Danh mục sản phẩm</h4>
        <ul>
");
            EndContext();
#line 49 "E:\MobileShop_ASP.NET-CORE\MobileShop\Views\Home\Index.cshtml"
             foreach (var c in Model.Categories)
            {

#line default
#line hidden
            BeginContext(1937, 32, true);
            WriteLiteral("                <li><a href=\"#\">");
            EndContext();
            BeginContext(1970, 15, false);
#line 51 "E:\MobileShop_ASP.NET-CORE\MobileShop\Views\Home\Index.cshtml"
                           Write(c.Category_Name);

#line default
#line hidden
            EndContext();
            BeginContext(1985, 11, true);
            WriteLiteral("</a></li>\r\n");
            EndContext();
#line 52 "E:\MobileShop_ASP.NET-CORE\MobileShop\Views\Home\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(2011, 27, true);
            WriteLiteral("        </ul>\r\n    </div>\r\n");
            EndContext();
            BeginContext(2769, 216, true);
            WriteLiteral("</div>\r\n<!-- end container -->\r\n<div class=\"product\">\r\n    <div class=\"product-brand\">\r\n        <h4>ĐIỆN THOẠI BÁN CHẠY</h4>\r\n        <a href=\"\">Xem thêm</a>\r\n    </div>\r\n    <div class=\"product-row\">\r\n        <ul>\r\n");
            EndContext();
#line 82 "E:\MobileShop_ASP.NET-CORE\MobileShop\Views\Home\Index.cshtml"
             foreach (var p in Model.ProductsBestSelling)
            {

#line default
#line hidden
            BeginContext(3059, 93, true);
            WriteLiteral("                <li>\r\n                    <div class=\"product-box\">\r\n                        ");
            EndContext();
            BeginContext(3152, 622, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6d07055c91034893b7fefa5e4fe7a9ae", async() => {
                BeginContext(3229, 83, true);
                WriteLiteral("\r\n                            <div class=\"image\">\r\n                                ");
                EndContext();
                BeginContext(3312, 58, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "1e771e67c7554b42bd97bd10de9e02b0", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 3322, "~/images/", 3322, 9, true);
#line 88 "E:\MobileShop_ASP.NET-CORE\MobileShop\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 3331, p.Product_ImageThumbnail, 3331, 25, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3370, 70, true);
                WriteLiteral("\r\n                            </div>\r\n                            <h5>");
                EndContext();
                BeginContext(3441, 14, false);
#line 90 "E:\MobileShop_ASP.NET-CORE\MobileShop\Views\Home\Index.cshtml"
                           Write(p.Product_Name);

#line default
#line hidden
                EndContext();
                BeginContext(3455, 132, true);
                WriteLiteral("</h5>\r\n                            <div class=\"price\">\r\n                                <p>\r\n                                    <b>");
                EndContext();
                BeginContext(3588, 15, false);
#line 93 "E:\MobileShop_ASP.NET-CORE\MobileShop\Views\Home\Index.cshtml"
                                  Write(p.Product_Price);

#line default
#line hidden
                EndContext();
                BeginContext(3603, 167, true);
                WriteLiteral("₫</b>\r\n                                    <span>22.000.000₫</span>\r\n                                </p>\r\n                            </div>\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 86 "E:\MobileShop_ASP.NET-CORE\MobileShop\Views\Home\Index.cshtml"
                                                                          WriteLiteral(p.Product_Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3774, 53, true);
            WriteLiteral("\r\n                    </div>\r\n                </li>\r\n");
            EndContext();
#line 100 "E:\MobileShop_ASP.NET-CORE\MobileShop\Views\Home\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(3842, 222, true);
            WriteLiteral("        </ul>\r\n    </div>\r\n</div>\r\n\r\n<div class=\"product\">\r\n    <div class=\"product-brand\">\r\n        <h4>ĐIỆN THOẠI YÊU THÍCH</h4>\r\n        <a href=\"\">Xem thêm</a>\r\n    </div>\r\n    <div class=\"product-row\">\r\n        <ul>\r\n");
            EndContext();
#line 112 "E:\MobileShop_ASP.NET-CORE\MobileShop\Views\Home\Index.cshtml"
             foreach (var p in Model.PreferredProducts)
            {

#line default
#line hidden
            BeginContext(4136, 93, true);
            WriteLiteral("                <li>\r\n                    <div class=\"product-box\">\r\n                        ");
            EndContext();
            BeginContext(4229, 622, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2651063c59b64d4e99a447681df7716f", async() => {
                BeginContext(4306, 83, true);
                WriteLiteral("\r\n                            <div class=\"image\">\r\n                                ");
                EndContext();
                BeginContext(4389, 58, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d98221fe683b4fb0a381d6cd903a592e", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 4399, "~/images/", 4399, 9, true);
#line 118 "E:\MobileShop_ASP.NET-CORE\MobileShop\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 4408, p.Product_ImageThumbnail, 4408, 25, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4447, 70, true);
                WriteLiteral("\r\n                            </div>\r\n                            <h5>");
                EndContext();
                BeginContext(4518, 14, false);
#line 120 "E:\MobileShop_ASP.NET-CORE\MobileShop\Views\Home\Index.cshtml"
                           Write(p.Product_Name);

#line default
#line hidden
                EndContext();
                BeginContext(4532, 132, true);
                WriteLiteral("</h5>\r\n                            <div class=\"price\">\r\n                                <p>\r\n                                    <b>");
                EndContext();
                BeginContext(4665, 15, false);
#line 123 "E:\MobileShop_ASP.NET-CORE\MobileShop\Views\Home\Index.cshtml"
                                  Write(p.Product_Price);

#line default
#line hidden
                EndContext();
                BeginContext(4680, 167, true);
                WriteLiteral("₫</b>\r\n                                    <span>22.000.000₫</span>\r\n                                </p>\r\n                            </div>\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 116 "E:\MobileShop_ASP.NET-CORE\MobileShop\Views\Home\Index.cshtml"
                                                                          WriteLiteral(p.Product_Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4851, 53, true);
            WriteLiteral("\r\n                    </div>\r\n                </li>\r\n");
            EndContext();
#line 130 "E:\MobileShop_ASP.NET-CORE\MobileShop\Views\Home\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(4919, 219, true);
            WriteLiteral("        </ul>\r\n    </div>\r\n</div>\r\n\r\n<div class=\"product\">\r\n    <div class=\"product-brand\">\r\n        <h4>ĐIỆN THOẠI IPHONE</h4>\r\n        <a href=\"\">Xem thêm</a>\r\n    </div>\r\n    <div class=\"product-row\">\r\n        <ul>\r\n");
            EndContext();
#line 142 "E:\MobileShop_ASP.NET-CORE\MobileShop\Views\Home\Index.cshtml"
             foreach (var p in Model.Products)
            {

#line default
#line hidden
            BeginContext(5201, 93, true);
            WriteLiteral("                <li>\r\n                    <div class=\"product-box\">\r\n                        ");
            EndContext();
            BeginContext(5294, 622, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "630b78fd223a42f498f1716af393992a", async() => {
                BeginContext(5371, 83, true);
                WriteLiteral("\r\n                            <div class=\"image\">\r\n                                ");
                EndContext();
                BeginContext(5454, 58, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e58043c2a0594efbaccf3b1bcb7c8d99", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 5464, "~/images/", 5464, 9, true);
#line 148 "E:\MobileShop_ASP.NET-CORE\MobileShop\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 5473, p.Product_ImageThumbnail, 5473, 25, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5512, 70, true);
                WriteLiteral("\r\n                            </div>\r\n                            <h5>");
                EndContext();
                BeginContext(5583, 14, false);
#line 150 "E:\MobileShop_ASP.NET-CORE\MobileShop\Views\Home\Index.cshtml"
                           Write(p.Product_Name);

#line default
#line hidden
                EndContext();
                BeginContext(5597, 132, true);
                WriteLiteral("</h5>\r\n                            <div class=\"price\">\r\n                                <p>\r\n                                    <b>");
                EndContext();
                BeginContext(5730, 15, false);
#line 153 "E:\MobileShop_ASP.NET-CORE\MobileShop\Views\Home\Index.cshtml"
                                  Write(p.Product_Price);

#line default
#line hidden
                EndContext();
                BeginContext(5745, 167, true);
                WriteLiteral("₫</b>\r\n                                    <span>22.000.000₫</span>\r\n                                </p>\r\n                            </div>\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 146 "E:\MobileShop_ASP.NET-CORE\MobileShop\Views\Home\Index.cshtml"
                                                                          WriteLiteral(p.Product_Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5916, 53, true);
            WriteLiteral("\r\n                    </div>\r\n                </li>\r\n");
            EndContext();
#line 160 "E:\MobileShop_ASP.NET-CORE\MobileShop\Views\Home\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(5984, 725, true);
            WriteLiteral(@"        </ul>
    </div>
</div>



<script>
    var slideIndex = 1;

    showDivs(slideIndex);

    var time = setInterval(function () { plusDivs(slideIndex++) }, 3000);

    function plusDivs(n) {
        showDivs(slideIndex += n);
        clearTimeout(time);
        time = setInterval(function () { plusDivs(slideIndex++) }, 3000);
    }

    function showDivs(n) {
        var i;
        var x = document.getElementsByClassName(""mySlides"");
        if (n > x.length) { slideIndex = 1 }
        if (n < 1) { slideIndex = x.length };
        for (i = 0; i < x.length; i++) {
            x[i].style.display = ""none"";
        }
        x[slideIndex - 1].style.display = ""block"";
    }

</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
