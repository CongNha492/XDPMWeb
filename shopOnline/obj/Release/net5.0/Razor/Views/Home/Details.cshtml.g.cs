#pragma checksum "D:\Temp\XDPMWeb\shopOnline\shopOnline\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f90780de6d26bc4783e25553eabf3c00ab53a99d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Details), @"mvc.1.0.view", @"/Views/Home/Details.cshtml")]
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
#line 1 "D:\Temp\XDPMWeb\shopOnline\shopOnline\Views\_ViewImports.cshtml"
using shopOnline;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Temp\XDPMWeb\shopOnline\shopOnline\Views\_ViewImports.cshtml"
using shopOnline.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f90780de6d26bc4783e25553eabf3c00ab53a99d", @"/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93df263b8727c0ed29c8512d7db7fe0112f8a996", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<shopOnline.Models.Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("sp-cart"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Temp\XDPMWeb\shopOnline\shopOnline\Views\Home\Details.cshtml"
  
    ViewData["Title"] = "Thông tin sản phẩm " + Model.ProductName;
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<section class=""single-product-section"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-7 col-md-12"">
                <div id=""product-slider"" class=""carousel slide product-slider"" data-ride=""carousel"">
                    <div class=""carousel-inner"">
                        <div class=""carousel-item active"">
                            <div class=""ps-img"">
                                <img");
            BeginWriteAttribute("src", " src=\"", 606, "\"", 641, 2);
            WriteAttributeValue("", 612, "/images/products/", 612, 17, true);
#nullable restore
#line 18 "D:\Temp\XDPMWeb\shopOnline\shopOnline\Views\Home\Details.cshtml"
WriteAttributeValue("", 629, Model.Image, 629, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 642, "\"", 648, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-lg-5 col-md-12"">
                <div class=""sin-product-details"">
                    <h3>");
#nullable restore
#line 26 "D:\Temp\XDPMWeb\shopOnline\shopOnline\Views\Home\Details.cshtml"
                   Write(Model.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                    <div class=\"product-price clearfix\">\r\n                        <span class=\"price\">\r\n                            <span><span class=\"woocommerce-Price-currencySymbol\"></span>");
#nullable restore
#line 29 "D:\Temp\XDPMWeb\shopOnline\shopOnline\Views\Home\Details.cshtml"
                                                                                   Write(Model.ProductPrice.Value.ToString("#,##0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" VNĐ</span>\r\n                        </span>\r\n                    </div>\r\n                    <div class=\"pro-excerp\">\r\n                        <p class=\"font-weight-bold\">\r\n                            Loại : ");
#nullable restore
#line 34 "D:\Temp\XDPMWeb\shopOnline\shopOnline\Views\Home\Details.cshtml"
                              Write(Model.Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n                        <p class=\"font-weight-bold\">\r\n                            Khối lượng : ");
#nullable restore
#line 37 "D:\Temp\XDPMWeb\shopOnline\shopOnline\Views\Home\Details.cshtml"
                                    Write(Model.Weight);

#line default
#line hidden
#nullable disable
            WriteLiteral(" kg\r\n                        </p>\r\n                        <p class=\"font-weight-bold\">\r\n                            Mô tả : ");
#nullable restore
#line 40 "D:\Temp\XDPMWeb\shopOnline\shopOnline\Views\Home\Details.cshtml"
                               Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </p>
                    </div>
                    <div class=""product-cart-qty"">
                        <div class=""quantityd clearfix"">
                            <button class=""qtyBtn btnMinus""><span>-</span></button>
                            <input id=""amountD"" value=""1"" class=""input-text qty text carqty"" type=""text"">
                            <button class=""qtyBtn btnPlus"">+</button>
                        </div>
                        <a");
            BeginWriteAttribute("href", " href=\"", 2184, "\"", 2229, 4);
            WriteAttributeValue("", 2191, "javascript:add_to_cart(", 2191, 23, true);
#nullable restore
#line 49 "D:\Temp\XDPMWeb\shopOnline\shopOnline\Views\Home\Details.cshtml"
WriteAttributeValue("", 2214, Model.Id, 2214, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2223, ",", 2223, 1, true);
            WriteAttributeValue(" ", 2224, "-1);", 2225, 5, true);
            EndWriteAttribute();
            WriteLiteral(@" class=""add-to-cart-btn"">Thêm vào giỏ hàng</a>
                    </div>
                </div>
            </div>
        </div>
        <div class=""row""><div class=""col-lg-12""><div class=""divider""></div></div></div>
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""related-product-area"">
                    <h3>Sản phẩm tương tự</h3>
                    <div class=""related-slider owl-carousel"">
");
#nullable restore
#line 60 "D:\Temp\XDPMWeb\shopOnline\shopOnline\Views\Home\Details.cshtml"
                         foreach (Product item in ViewBag.related_products)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"single-shop-product\">\r\n                                <div class=\"sp-thumb\">\r\n                                    <img");
            BeginWriteAttribute("src", " src=\"", 2945, "\"", 2979, 2);
            WriteAttributeValue("", 2951, "/images/products/", 2951, 17, true);
#nullable restore
#line 64 "D:\Temp\XDPMWeb\shopOnline\shopOnline\Views\Home\Details.cshtml"
WriteAttributeValue("", 2968, item.Image, 2968, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2980, "\"", 2986, 0);
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 2987, "\"", 2995, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                </div>\r\n                                <div class=\"sp-details\">\r\n                                    <h4>");
#nullable restore
#line 67 "D:\Temp\XDPMWeb\shopOnline\shopOnline\Views\Home\Details.cshtml"
                                   Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                    <div class=\"product-price clearfix\">\r\n                                        <span class=\"price\">\r\n                                            <ins><span><span class=\"woocommerce-Price-currencySymbol\"></span>");
#nullable restore
#line 70 "D:\Temp\XDPMWeb\shopOnline\shopOnline\Views\Home\Details.cshtml"
                                                                                                        Write(item.ProductPrice.Value.ToString("#,##0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" VNĐ</span></ins>\r\n                                        </span>\r\n                                    </div>\r\n                                    <div class=\"sp-details-hover\">\r\n                                        <a class=\"sp-cart\"");
            BeginWriteAttribute("href", " href=\"", 3686, "\"", 3729, 4);
            WriteAttributeValue("", 3693, "javascript:add_to_cart(", 3693, 23, true);
#nullable restore
#line 74 "D:\Temp\XDPMWeb\shopOnline\shopOnline\Views\Home\Details.cshtml"
WriteAttributeValue("", 3716, item.Id, 3716, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3724, ",", 3724, 1, true);
            WriteAttributeValue(" ", 3725, "1);", 3726, 4, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"twi-cart-plus\"></i><span>Thêm vào giỏ hàng</span></a>\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f90780de6d26bc4783e25553eabf3c00ab53a99d12026", async() => {
                WriteLiteral("<i></i><span>Chi tiết</span>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 75 "D:\Temp\XDPMWeb\shopOnline\shopOnline\Views\Home\Details.cshtml"
                                                                                                        WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 79 "D:\Temp\XDPMWeb\shopOnline\shopOnline\Views\Home\Details.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<shopOnline.Models.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591