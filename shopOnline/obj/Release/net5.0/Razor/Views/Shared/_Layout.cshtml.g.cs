#pragma checksum "D:\Temp\XDPMWeb\shopOnline\shopOnline\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "73092afce714942e21a190cd5a99708e5b7968ce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"73092afce714942e21a190cd5a99708e5b7968ce", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93df263b8727c0ed29c8512d7db7fe0112f8a996", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Contact", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "About", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "order_lookup", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("target", new global::Microsoft.AspNetCore.Html.HtmlString("_blank"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("carts"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("carts"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ShoppingCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "73092afce714942e21a190cd5a99708e5b7968ce6505", async() => {
                WriteLiteral("\r\n    <title>");
#nullable restore
#line 4 "D:\Temp\XDPMWeb\shopOnline\shopOnline\Views\Shared\_Layout.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</title>
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width"">

    <!-- Include All CSS -->
    <link rel=""stylesheet"" href=""/assets/css/bootstrap.min.css"" />
    <link rel=""stylesheet"" href=""/assets/css/themewar-icons.css"" />
    <link rel=""stylesheet"" href=""/assets/css/flaticon.css"" />
    <link rel=""stylesheet"" href=""/assets/css/animate.css"" />
    <link rel=""stylesheet"" href=""/assets/css/owl.carousel.min.css"">
    <link rel=""stylesheet"" href=""/assets/css/owl.theme.default.min.css"">
    <link rel=""stylesheet"" href=""/assets/css/settings.css"">
    <link rel=""stylesheet"" href=""/assets/css/lightcase.css"">
    <link rel=""stylesheet"" href=""/assets/css/preset.css"" />
    <link rel=""stylesheet"" href=""/assets/css/ignore_in_wp.css"" />
    <link rel=""stylesheet"" href=""/assets/css/theme.css"" />
    <link rel=""stylesheet"" href=""/assets/css/responsive.css"" />
    <!-- End Include All CSS -->
    <!-- Favicon Icon -->
    <link rel=""icon"" type=""image/png"" href=""/assets/ima");
                WriteLiteral("ges/favicon.png\">\r\n    <!-- Favicon Icon -->\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "73092afce714942e21a190cd5a99708e5b7968ce8866", async() => {
                WriteLiteral(@"

    <!-- Header Start -->
    <header class=""header-01 inner-header fix-header"">
        <div class=""container-fluid"">
            <div class=""row"">
                <div class=""col-lg-2 col-md-2"">
                    <div class=""logo"">
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "73092afce714942e21a190cd5a99708e5b7968ce9401", async() => {
                    WriteLiteral("\r\n                            <img src=\"/assets/images/logo.png\" />\r\n                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
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
                <div class=""col-lg-6 col-md-6"">
                    <nav class=""mainmenu mobile-menu"">
                        <div class=""mobile-btn"">
                            <a href=""javascript: void(0);""><span>Menu</span><i class=""twi-bars""></i></a>
                        </div>
                        <ul>
                            <li class=""menu-item-has-children"">
                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "73092afce714942e21a190cd5a99708e5b7968ce11410", async() => {
                    WriteLiteral("Li??n h???");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            </li>\r\n                            <li class=\"menu-item-has-children\">\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "73092afce714942e21a190cd5a99708e5b7968ce12983", async() => {
                    WriteLiteral("Gi???i thi???u");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            </li>\r\n                            <li class=\"menu-item-has-children\">\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "73092afce714942e21a190cd5a99708e5b7968ce14559", async() => {
                    WriteLiteral("Tra c???u ????n h??ng");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            </li>\r\n                            <li class=\"menu-item-has-children\">\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "73092afce714942e21a190cd5a99708e5b7968ce16141", async() => {
                    WriteLiteral("Trang Admin");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            </li>\r\n                        </ul>\r\n                    </nav>\r\n                </div>\r\n                <div class=\"col-lg-4 col-md-4\">\r\n                    <div class=\"header-cogs\">\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "73092afce714942e21a190cd5a99708e5b7968ce18129", async() => {
#nullable restore
#line 62 "D:\Temp\XDPMWeb\shopOnline\shopOnline\Views\Shared\_Layout.cshtml"
                                                                                                Write(await Component.InvokeAsync("NumberCart"));

#line default
#line hidden
#nullable disable
                    WriteLiteral("<img src=\"/assets/images/cart.png\"");
                    BeginWriteAttribute("alt", " alt=\"", 3115, "\"", 3121, 0);
                    EndWriteAttribute();
                    WriteLiteral(">");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_9.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </header>\r\n    <!-- Header End -->\r\n    <!-- Shop Section Start -->\r\n    ");
#nullable restore
#line 70 "D:\Temp\XDPMWeb\shopOnline\shopOnline\Views\Shared\_Layout.cshtml"
Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
    <!-- Shop Section End -->
    <!-- Footer Start -->
    <footer class=""footer-01 inner-footer"">
        <div class=""container-fluid"">
            <div class=""row"">
                <div class=""col-lg-3 col-md-4"">
                    <aside class=""widget about-widget"">
                        <div class=""foo-logo"">
                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "73092afce714942e21a190cd5a99708e5b7968ce20977", async() => {
                    WriteLiteral("<img src=\"/assets/images/logo.png\"");
                    BeginWriteAttribute("alt", " alt=\"", 3742, "\"", 3748, 0);
                    EndWriteAttribute();
                    WriteLiteral(" />");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                        </div>
                    </aside>
                </div>
                <div class="" col-lg-4 col-custome-3"" id=""contact"">
                    <aside class=""widget contact-widget"">
                        <h3 class=""widget-title"">Contact & Address</h3>
                        <p>
                            ?????a ch???: 180 Cao L???, Ph?????ng 4, Qu???n 8, Tp. H??? Ch?? Minh<br />
                            ??T: (028) 38 505 520; Fax: (84.8) 3850 6595<br />
                            Email: contact@stu.edu.vn
                        </p>
                    </aside>
                </div>
                <div class=""col-lg-4 col-md-6 col-custome-3"" id=""about"">
                    <aside class=""widget contact-widget"">
                        <h3 class=""widget-title"">About</h3>
                        <p>
                            X??y d???ng ph???n m???m web s??ng th??? 2 v?? th??? 4<br />
                            Nh??m 4
                        </p>
                    </aside>
   ");
                WriteLiteral(@"             </div>
            </div>
        </div>
    </footer>
    <!-- Footer Ened -->
    <!-- Coryight Start -->
    <section class=""copyright-section"">
        <div class=""container-fluid"">
            <div class=""row"">
                <div class=""col-lg-6 col-md-5"">
                    <ul class=""menu-link"">
                        <li><a href=""#"">Privacy Policy</a></li> |
                        <li><a href=""#"">Terms of Service</a></li>
                    </ul>
                </div>
                <div class=""col-lg-6 col-md-7"">
                    <div class=""copys-text""><i class=""twi-copyright""></i>Shop Online | All Rights Reserved</div>
                </div>
            </div>
        </div>
    </section>
    <!-- Coryight End -->
    <!-- Back To Top -->
    <a href=""#"" id=""backtotop""><i class=""twi-angle-double-up2""></i></a>

    <!-- Include All JS -->
    <script src=""/assets/js/jquery.js""></script>
    <script src=""/assets/js/bootstrap.min.js""></script>
    <");
                WriteLiteral(@"script src=""/assets/js/modernizr.custom.js""></script>
    <script src=""/assets/js/jquery.appear.js""></script>
    <script src=""/assets/js/jquery-ui.js""></script>
    <script src=""/assets/js/owl.carousel.min.js""></script>
    <script src=""/assets/js/jquery.shuffle.min.js""></script>
    <script src=""/assets/js/lightcase.js""></script>
    <script src=""/assets/js/jquery.easing.1.3.js""></script>
    <script src=""/assets/js/jquery.plugin.min.js""></script>
    <script src=""/assets/js/jquery.countdown.min.js""></script>
    <script src=""/assets/js/tweenmax.min.js""></script>

    <script src=""/assets/js/jquery.themepunch.tools.min.js""></script>
    <script src=""/assets/js/jquery.themepunch.revolution.min.js""></script>

    <!-- Rev slider Add on Start -->
    <script src=""/assets/js/extensions/revolution.extension.actions.min.js""></script>
    <script src=""/assets/js/extensions/revolution.extension.carousel.min.js""></script>
    <script src=""/assets/js/extensions/revolution.extension.kenburn.min.js""></");
                WriteLiteral(@"script>
    <script src=""/assets/js/extensions/revolution.extension.layeranimation.min.js""></script>
    <script src=""/assets/js/extensions/revolution.extension.migration.min.js""></script>
    <script src=""/assets/js/extensions/revolution.extension.navigation.min.js""></script>
    <script src=""/assets/js/extensions/revolution.extension.parallax.min.js""></script>
    <script src=""/assets/js/extensions/revolution.extension.slideanims.min.js""></script>
    <script src=""/assets/js/extensions/revolution.extension.video.min.js""></script>
    <!-- Rev slider Add on End -->

    <script src=""/assets/js/theme.js""></script>

    <script>
        ele_amount_cart = document.getElementById(""amountCart"");
        ele_cart = document.getElementById(""carts"");

        function add_to_cart(productID, amount) {
            if (amount == -1) {
                amount = Number(document.getElementById(""amountD"").value);
            }
            amountCart = Number(ele_amount_cart.innerHTML);
            $.ajax");
                WriteLiteral(@"({
                url: '/api/cart/add',
                type: ""POST"",
                dataType: ""JSON"",
                data: {
                    productID: productID,
                    amount: amount
                },
                success: function (response) {
                    if (response.success) {
                        amountCart += amount;
                        ele_cart.style.zoom = 2;
                        ele_amount_cart.innerHTML = amountCart.toString();
                        setTimeout(function () { ele_cart.style.zoom = 1; }, 300);
                    }
                },
                error: function (error) {
                    alert(""There was an error posting the data to the server: "" + error.responseText);
                }
            });
        }

        function remove_product_in_cart(productID) {
            $.ajax({
                url: 'api/cart/remove',
                type: ""POST"",
                dataType: ""JSON"",
                dat");
                WriteLiteral(@"a: {
                    productID: productID
                },
                success: function (response) {
                    if (response.success) {
                        location.reload();
                    }
                },
                error: function (error) {
                    alert(""There was an error posting the data to the server: "" + error.responseText);
                }
            });
        }

        function remove_cart() {
            $.ajax({
                url: 'api/cart/removecart',
                type: ""GET"",
                success: function (response) {
                    if (response.success) {
                        location.reload();
                    }
                },
                error: function (error) {
                    alert(""There was an error posting the data to the server: "" + error.responseText);
                }
            });
        }

        function update_cart(productID, amount) {
            if (amount");
                WriteLiteral(@" == -1) {
                amount = Number(document.getElementById(""input_"" + productID).value) + 1;
            } else if (amount == -2) {
                amount = Number(document.getElementById(""input_"" + productID).value) - 1;
            } else if (amount == -3) {
                amount = Number(document.getElementById(""input_"" + productID).value);
            }
            $.ajax({
                url: 'api/cart/update',
                type: ""POST"",
                dataType: ""JSON"",
                data: {
                    productID: productID,
                    amount: amount
                },
                success: function (response) {
                    if (response.success) {
                        location.reload();
                    }
                },
                error: function (error) {
                    alert(""There was an error posting the data to the server: "" + error.responseText);
                }
            });
        }
    </script>

    ");
#nullable restore
#line 250 "D:\Temp\XDPMWeb\shopOnline\shopOnline\Views\Shared\_Layout.cshtml"
Write(await Component.InvokeAsync("Notyf"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
#nullable restore
#line 251 "D:\Temp\XDPMWeb\shopOnline\shopOnline\Views\Shared\_Layout.cshtml"
Write(await RenderSectionAsync("Scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
