#pragma checksum "E:\MobileShop_ASP.NET-CORE\MobileShop\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e4fc5e11993d7c55156a378be84943ff07f0e54"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e4fc5e11993d7c55156a378be84943ff07f0e54", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f8282febc87a857b1dd3c8924bd5c37fdb8cfb2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/User/css/Home/IndexCSS.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "E:\MobileShop_ASP.NET-CORE\MobileShop\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(117, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c49b6271866f4977a8896a78e2613f32", async() => {
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
            BeginContext(178, 2912, true);
            WriteLiteral(@"
<div class=""row"">
    <div class=""row-box"">
        <h5>
            <i class=""fas fa-list""></i>
            DANH MỤC SẢN PHẨM
        </h5>
        <span>
            <i class=""fas fa-map-marker-alt""></i>
            Địa chỉ: 123 Bình Giã, Vũng Tàu
        </span>
        <span>
            <i class=""fas fa-phone-alt""></i>
            Hotline: 1900.0702
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
            <img class=""mySlides"" src=""https://cdn.tgdd.vn/2019/09/banner/huawei-3i-white-800-300-800x300-(1).png"" alt="""">
            <button class=""w3-button w3-black w3-display-left"" onclick=""plusDivs(-1)"">&#1");
            WriteLiteral(@"0094;</button>
            <button class=""w3-button w3-black w3-display-right"" onclick=""plusDivs(1)"">&#10095;</button>
        </div>
        <div class=""banner-right"">
            <img src=""https://cdn.cellphones.com.vn/media/ltsoft/promotion/thu-c_-galaxy-note-10-_-10_-_2_-750x350_2_1911.png"" alt=""banner"" />
            <img src=""https://cdn.cellphones.com.vn/media/ltsoft/promotion/Right-banner_iphone_11_111.png"" alt=""banner"" />
        </div>
        
    </div>
    <div class=""menu"">
        <h4><i class=""fas fa-list""></i>     Danh mục sản phẩm</h4>
        <ul>
            <li><a href=""#"">iPhone</a></li>
            <li><a href=""#"">Samsung</a></li>
            <li><a href=""#"">Xiaomi</a></li>
            <li><a href=""#"">ASUS</a></li>
            <li><a href=""#"">iPhone</a></li>
            <li><a href=""#"">Samsung</a></li>
            <li><a href=""#"">Xiaomi</a></li>
            <li><a href=""#"">ASUS</a></li>
            <li><a href=""#"">iPhone</a></li>
        </ul>
    </div>
    <div ");
            WriteLiteral(@"class=""filter-option"">
        <div class=""left"">
            <ul>
                <li><strong>Chọn mức giá:</strong></li>
                <li><a href=""#"">Dưới 4 triệu</a></li>
                <li><a href=""#"">4 - 7 triệu</a></li>
                <li><a href=""#"">7- 12 triệu</a></li>
                <li><a href=""#"">Trên 12 triệu</a></li>
            </ul>
        </div>
        <div class=""right"">
            <ul>
                <li><strong>Sắp xếp theo:</strong></li>
                <li><a href=""#"">Giá thấp đến cao</a></li>
                <li><a href=""#"">Giá cao đến thấp</a></li>
            </ul>
        </div>
    </div>
</div>
<!-- end container -->
<div class=""product"">
    <div class=""product-brand"">
        <h4>ĐIỆN THOẠI IPHONE</h4>
        <a href="""">Xem thêm</a>
    </div>
    <div class=""product-row"">
        <ul>
");
            EndContext();
#line 84 "E:\MobileShop_ASP.NET-CORE\MobileShop\Views\Home\Index.cshtml"
             foreach (var p in Model)
            {

#line default
#line hidden
            BeginContext(3144, 93, true);
            WriteLiteral("                <li>\r\n                    <div class=\"product-box\">\r\n                        ");
            EndContext();
            BeginContext(3237, 657, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8ccca24fe8c84fc5be587d23253bcf9f", async() => {
                BeginContext(3314, 246, true);
                WriteLiteral("\r\n                            <div class=\"image\">\r\n                                <img src=\"https://cdn.tgdd.vn/Products/Images/42/114115/iphone-x-64gb-21-400x400.jpg\" alt=\"\">\r\n                            </div>\r\n                            <h5>");
                EndContext();
                BeginContext(3561, 14, false);
#line 92 "E:\MobileShop_ASP.NET-CORE\MobileShop\Views\Home\Index.cshtml"
                           Write(p.Product_Name);

#line default
#line hidden
                EndContext();
                BeginContext(3575, 132, true);
                WriteLiteral("</h5>\r\n                            <div class=\"price\">\r\n                                <p>\r\n                                    <b>");
                EndContext();
                BeginContext(3708, 15, false);
#line 95 "E:\MobileShop_ASP.NET-CORE\MobileShop\Views\Home\Index.cshtml"
                                  Write(p.Product_Price);

#line default
#line hidden
                EndContext();
                BeginContext(3723, 167, true);
                WriteLiteral("₫</b>\r\n                                    <span>22.000.000₫</span>\r\n                                </p>\r\n                            </div>\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 88 "E:\MobileShop_ASP.NET-CORE\MobileShop\Views\Home\Index.cshtml"
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
            BeginContext(3894, 53, true);
            WriteLiteral("\r\n                    </div>\r\n                </li>\r\n");
            EndContext();
#line 102 "E:\MobileShop_ASP.NET-CORE\MobileShop\Views\Home\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(3962, 7388, true);
            WriteLiteral(@"        </ul>
    </div>
</div>

<div class=""product"">
    <div class=""product-brand"">
        <h4>ĐIỆN THOẠI IPHONE</h4>
        <a href="""">Xem thêm</a>
    </div>
    <div class=""product-row"">
        <ul>
            <li>
                <div class=""product-box"">
                    <a href=""#"">
                        <div class=""image"">
                            <img src=""https://cdn.tgdd.vn/Products/Images/42/114115/iphone-x-64gb-21-400x400.jpg"" alt="""">
                        </div>
                        <h5>iPhone X 64GB</h5>
                        <div class=""price"">
                            <p>
                                <b>20.000.000₫</b>
                                <span>22.000.000₫</span>
                            </p>
                        </div>
                    </a>
                </div>
            </li>
            <li>
                <div class=""product-box"">
                    <a href=""#"">
                        <div class=""image"">");
            WriteLiteral(@"
                            <img src=""https://cdn.tgdd.vn/Products/Images/42/114115/iphone-x-64gb-21-400x400.jpg"" alt="""">
                        </div>
                        <h5>iPhone X 64GB</h5>
                        <div class=""price"">
                            <p>
                                <b>20.000.000₫</b>
                                <span>22.000.000₫</span>
                            </p>
                        </div>
                    </a>
                </div>
            </li>
            <li>
                <div class=""product-box"">
                    <a href=""#"">
                        <div class=""image"">
                            <img src=""https://cdn.tgdd.vn/Products/Images/42/114115/iphone-x-64gb-21-400x400.jpg"" alt="""">
                        </div>
                        <h5>iPhone X 64GB</h5>
                        <div class=""price"">
                            <p>
                                <b>20.000.000₫</b>
                        ");
            WriteLiteral(@"        <span>22.000.000₫</span>
                            </p>
                        </div>
                    </a>
                </div>
            </li>
            <li>
                <div class=""product-box"">
                    <a href=""#"">
                        <div class=""image"">
                            <img src=""https://cdn.tgdd.vn/Products/Images/42/114115/iphone-x-64gb-21-400x400.jpg"" alt="""">
                        </div>
                        <h5>iPhone X 64GB</h5>
                        <div class=""price"">
                            <p>
                                <b>20.000.000₫</b>
                                <span>22.000.000₫</span>
                            </p>
                        </div>
                    </a>
                </div>
            </li>
            <li>
                <div class=""product-box"">
                    <a href=""#"">
                        <div class=""image"">
                            <img src=""https://cdn");
            WriteLiteral(@".tgdd.vn/Products/Images/42/114115/iphone-x-64gb-21-400x400.jpg"" alt="""">
                        </div>
                        <h5>iPhone X 64GB</h5>
                        <div class=""price"">
                            <p>
                                <b>20.000.000₫</b>
                                <span>22.000.000₫</span>
                            </p>
                        </div>
                    </a>
                </div>
            </li>
            <li>
                <div class=""product-box"">
                    <a href=""#"">
                        <div class=""image"">
                            <img src=""https://cdn.tgdd.vn/Products/Images/42/114115/iphone-x-64gb-21-400x400.jpg"" alt="""">
                        </div>
                        <h5>iPhone X 64GB</h5>
                        <div class=""price"">
                            <p>
                                <b>20.000.000₫</b>
                                <span>22.000.000₫</span>
                ");
            WriteLiteral(@"            </p>
                        </div>
                    </a>
                </div>
            </li>
            <li>
                <div class=""product-box"">
                    <a href=""#"">
                        <div class=""image"">
                            <img src=""https://cdn.tgdd.vn/Products/Images/42/114115/iphone-x-64gb-21-400x400.jpg"" alt="""">
                        </div>
                        <h5>iPhone X 64GB</h5>
                        <div class=""price"">
                            <p>
                                <b>20.000.000₫</b>
                                <span>22.000.000₫</span>
                            </p>
                        </div>
                    </a>
                </div>
            </li>
            <li>
                <div class=""product-box"">
                    <a href=""#"">
                        <div class=""image"">
                            <img src=""https://cdn.tgdd.vn/Products/Images/42/114115/iphone-x-64gb-2");
            WriteLiteral(@"1-400x400.jpg"" alt="""">
                        </div>
                        <h5>iPhone X 64GB</h5>
                        <div class=""price"">
                            <p>
                                <b>20.000.000₫</b>
                                <span>22.000.000₫</span>
                            </p>
                        </div>
                    </a>
                </div>
            </li>
            <li>
                <div class=""product-box"">
                    <a href=""#"">
                        <div class=""image"">
                            <img src=""https://cdn.tgdd.vn/Products/Images/42/114115/iphone-x-64gb-21-400x400.jpg"" alt="""">
                        </div>
                        <h5>iPhone X 64GB</h5>
                        <div class=""price"">
                            <p>
                                <b>20.000.000₫</b>
                                <span>22.000.000₫</span>
                            </p>
                        </div>
");
            WriteLiteral(@"                    </a>
                </div>
            </li>
            <li>
                <div class=""product-box"">
                    <a href=""#"">
                        <div class=""image"">
                            <img src=""https://cdn.tgdd.vn/Products/Images/42/114115/iphone-x-64gb-21-400x400.jpg"" alt="""">
                        </div>
                        <h5>iPhone X 64GB</h5>
                        <div class=""price"">
                            <p>
                                <b>20.000.000₫</b>
                                <span>22.000.000₫</span>
                            </p>
                        </div>
                    </a>
                </div>
            </li>
        </ul>
    </div>
</div>
<script>
    var slideIndex = 1;
    showDivs(slideIndex);

    function plusDivs(n) {
      showDivs(slideIndex += n);
    }

    function showDivs(n) {
      var i;
      var x = document.getElementsByClassName(""mySlides"");
      if (n > x.l");
            WriteLiteral("ength) {slideIndex = 1}\r\n      if (n < 1) {slideIndex = x.length} ;\r\n      for (i = 0; i < x.length; i++) {\r\n        x[i].style.display = \"none\";\r\n      }\r\n      x[slideIndex-1].style.display = \"block\";\r\n    }\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
