#pragma checksum "E:\VSprj\AspPrj\HomeKala\ServiceHost\Pages\Shared\Components\ProductCategoriesWithProducts\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4a8d2e20d291f6f3f783a7e3176aafd84635e4ef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ServiceHost.Pages.Shared.Components.ProductCategoriesWithProducts.Pages_Shared_Components_ProductCategoriesWithProducts_Default), @"mvc.1.0.view", @"/Pages/Shared/Components/ProductCategoriesWithProducts/Default.cshtml")]
namespace ServiceHost.Pages.Shared.Components.ProductCategoriesWithProducts
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
#line 1 "E:\VSprj\AspPrj\HomeKala\ServiceHost\Pages\_ViewImports.cshtml"
using ServiceHost;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\VSprj\AspPrj\HomeKala\ServiceHost\Pages\_ViewImports.cshtml"
using HomekalaQuery.Contracts.Slide;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\VSprj\AspPrj\HomeKala\ServiceHost\Pages\_ViewImports.cshtml"
using HomekalaQuery.Contracts.ProductCategory;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a8d2e20d291f6f3f783a7e3176aafd84635e4ef", @"/Pages/Shared/Components/ProductCategoriesWithProducts/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84733754fed1b4329eb046000a475b9f457c43c4", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared_Components_ProductCategoriesWithProducts_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ProductCategoryQueryModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./ProductCategory", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""single-row-slider-tab-area section-space"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <!--=======  section title  =======-->
                <div class=""section-title-wrapper text-center section-space--half"">
                    <h2 class=""section-title"">محصولات ما</h2>
                    <p class=""section-subtitle"">
                        محصولات موجود در فروشگاه ما
                    </p>
                </div>
                <!--=======  End of section title  =======-->
            </div>
        </div>
        <div class=""row"">
            <div class=""col-lg-12"">
                <!--=======  tab slider wrapper  =======-->
                <div class=""tab-slider-wrapper"">

                    <!--=======  tab product navigation  =======-->
                    <div class=""tab-product-navigation"">
                        <div class=""nav nav-tabs justify-content-center"" id=""nav-tab2"" role=""tablist"">
");
#nullable restore
#line 25 "E:\VSprj\AspPrj\HomeKala\ServiceHost\Pages\Shared\Components\ProductCategoriesWithProducts\Default.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <a");
            BeginWriteAttribute("class", " class=\"", 1178, "\"", 1244, 3);
            WriteAttributeValue("", 1186, "nav-item", 1186, 8, true);
            WriteAttributeValue(" ", 1194, "nav-link", 1195, 9, true);
#nullable restore
#line 27 "E:\VSprj\AspPrj\HomeKala\ServiceHost\Pages\Shared\Components\ProductCategoriesWithProducts\Default.cshtml"
WriteAttributeValue(" ", 1203, Model.First() == item ? "active" : "", 1204, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 1245, "\"", 1270, 2);
            WriteAttributeValue("", 1250, "product-tab-", 1250, 12, true);
#nullable restore
#line 27 "E:\VSprj\AspPrj\HomeKala\ServiceHost\Pages\Shared\Components\ProductCategoriesWithProducts\Default.cshtml"
WriteAttributeValue("", 1262, item.Id, 1262, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-toggle=\"tab\"");
            BeginWriteAttribute("href", "\r\n                                   href=\"", 1289, "\"", 1356, 2);
            WriteAttributeValue("", 1332, "#product-series-", 1332, 16, true);
#nullable restore
#line 28 "E:\VSprj\AspPrj\HomeKala\ServiceHost\Pages\Shared\Components\ProductCategoriesWithProducts\Default.cshtml"
WriteAttributeValue("", 1348, item.Id, 1348, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"tab\" aria-selected=\"true\">");
#nullable restore
#line 28 "E:\VSprj\AspPrj\HomeKala\ServiceHost\Pages\Shared\Components\ProductCategoriesWithProducts\Default.cshtml"
                                                                                              Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 29 "E:\VSprj\AspPrj\HomeKala\ServiceHost\Pages\Shared\Components\ProductCategoriesWithProducts\Default.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                    </div>\r\n                    <!--=======  End of tab product navigation  =======-->\r\n                    <!--=======  tab product content  =======-->\r\n                    <div class=\"tab-content\">\r\n");
#nullable restore
#line 35 "E:\VSprj\AspPrj\HomeKala\ServiceHost\Pages\Shared\Components\ProductCategoriesWithProducts\Default.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div");
            BeginWriteAttribute("class", " class=\"", 1799, "\"", 1866, 4);
            WriteAttributeValue("", 1807, "tab-pane", 1807, 8, true);
            WriteAttributeValue(" ", 1815, "fade", 1816, 5, true);
            WriteAttributeValue(" ", 1820, "show", 1821, 5, true);
#nullable restore
#line 37 "E:\VSprj\AspPrj\HomeKala\ServiceHost\Pages\Shared\Components\ProductCategoriesWithProducts\Default.cshtml"
WriteAttributeValue(" ", 1825, Model.First() == item ? "active" : "", 1826, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 1867, "\"", 1895, 2);
            WriteAttributeValue("", 1872, "product-series-", 1872, 15, true);
#nullable restore
#line 37 "E:\VSprj\AspPrj\HomeKala\ServiceHost\Pages\Shared\Components\ProductCategoriesWithProducts\Default.cshtml"
WriteAttributeValue("", 1887, item.Id, 1887, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" role=""tabpanel""
                                 aria-labelledby=""product-tab-1"">
                                <div class=""single-row-slider-wrapper"">
                                    <div class=""ht-slick-slider"" data-slick-setting='{
                                            ""slidesToShow"": 4,
                                            ""slidesToScroll"": 1,
                                            ""arrows"": true,
                                            ""autoplay"": false,
                                            ""autoplaySpeed"": 5000,
                                            ""speed"": 1000,
                                            ""infinite"": true,
                                            ""rtl"": true,
                                            ""prevArrow"": {""buttonClass"": ""slick-prev"", ""iconClass"": ""ion-chevron-left"" },
                                            ""nextArrow"": {""buttonClass"": ""slick-next"", ""iconClass"": ""ion-chevron-right"" }
                            ");
            WriteLiteral(@"                }' data-slick-responsive='[
                                            {""breakpoint"":1501, ""settings"": {""slidesToShow"": 4} },
                                            {""breakpoint"":1199, ""settings"": {""slidesToShow"": 4, ""arrows"": false} },
                                            {""breakpoint"":991, ""settings"": {""slidesToShow"": 3, ""arrows"": false} },
                                            {""breakpoint"":767, ""settings"": {""slidesToShow"": 2, ""arrows"": false} },
                                            {""breakpoint"":575, ""settings"": {""slidesToShow"": 2, ""arrows"": false} },
                                            {""breakpoint"":479, ""settings"": {""slidesToShow"": 1, ""arrows"": false} }
                                            ]'>

");
#nullable restore
#line 60 "E:\VSprj\AspPrj\HomeKala\ServiceHost\Pages\Shared\Components\ProductCategoriesWithProducts\Default.cshtml"
                                         foreach (var product in item.Products)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                            <div class=""col"">
                                                <!--=======  single grid product  =======-->
                                                <div class=""single-grid-product"">
                                                    <div class=""single-grid-product__image"">
                                                        <div class=""single-grid-product__label"">
");
#nullable restore
#line 67 "E:\VSprj\AspPrj\HomeKala\ServiceHost\Pages\Shared\Components\ProductCategoriesWithProducts\Default.cshtml"
                                                             if (product.HasDiscount)
                                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                <span class=\"sale\">");
#nullable restore
#line 69 "E:\VSprj\AspPrj\HomeKala\ServiceHost\Pages\Shared\Components\ProductCategoriesWithProducts\Default.cshtml"
                                                                              Write(product.DiscountRate);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</span>\r\n");
#nullable restore
#line 70 "E:\VSprj\AspPrj\HomeKala\ServiceHost\Pages\Shared\Components\ProductCategoriesWithProducts\Default.cshtml"
                                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                            <span class=""new"">جدید</span>
                                                        </div>
                                                        <a href=""single-product.html"">
                                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4a8d2e20d291f6f3f783a7e3176aafd84635e4ef13936", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4892, "~/Images/", 4892, 9, true);
#nullable restore
#line 74 "E:\VSprj\AspPrj\HomeKala\ServiceHost\Pages\Shared\Components\ProductCategoriesWithProducts\Default.cshtml"
AddHtmlAttributeValue("", 4901, product.Picture, 4901, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 74 "E:\VSprj\AspPrj\HomeKala\ServiceHost\Pages\Shared\Components\ProductCategoriesWithProducts\Default.cshtml"
AddHtmlAttributeValue("", 4942, product.PictureAlt, 4942, 19, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4a8d2e20d291f6f3f783a7e3176aafd84635e4ef16083", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5035, "~/Images/", 5035, 9, true);
#nullable restore
#line 75 "E:\VSprj\AspPrj\HomeKala\ServiceHost\Pages\Shared\Components\ProductCategoriesWithProducts\Default.cshtml"
AddHtmlAttributeValue("", 5044, product.Picture, 5044, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 75 "E:\VSprj\AspPrj\HomeKala\ServiceHost\Pages\Shared\Components\ProductCategoriesWithProducts\Default.cshtml"
AddHtmlAttributeValue("", 5085, product.PictureAlt, 5085, 19, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                                        </a>

                                                    </div>
                                                    <div class=""single-grid-product__content"">
                                                        <div class=""single-grid-product__category-rating"">
                                                            <span class=""category"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4a8d2e20d291f6f3f783a7e3176aafd84635e4ef18586", async() => {
#nullable restore
#line 81 "E:\VSprj\AspPrj\HomeKala\ServiceHost\Pages\Shared\Components\ProductCategoriesWithProducts\Default.cshtml"
                                                                                                                                                   Write(product.Category);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 81 "E:\VSprj\AspPrj\HomeKala\ServiceHost\Pages\Shared\Components\ProductCategoriesWithProducts\Default.cshtml"
                                                                                                                     WriteLiteral(product.CategorySlug);

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
            WriteLiteral(@"</span>
                                                            <span class=""rating"">
                                                                <i class=""ion-android-star active""></i>
                                                                <i class=""ion-android-star active""></i>
                                                                <i class=""ion-android-star active""></i>
                                                                <i class=""ion-android-star active""></i>
                                                                <i class=""ion-android-star-outline""></i>
                                                            </span>
                                                        </div>

                                                        <h3 class=""single-grid-product__title"">
                                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4a8d2e20d291f6f3f783a7e3176aafd84635e4ef22091", async() => {
                WriteLiteral("\r\n                                                                ");
#nullable restore
#line 93 "E:\VSprj\AspPrj\HomeKala\ServiceHost\Pages\Shared\Components\ProductCategoriesWithProducts\Default.cshtml"
                                                           Write(product.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 92 "E:\VSprj\AspPrj\HomeKala\ServiceHost\Pages\Shared\Components\ProductCategoriesWithProducts\Default.cshtml"
                                                                                     WriteLiteral(product.Slug);

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
            WriteLiteral("\r\n                                                        </h3>\r\n                                                        <p class=\"single-grid-product__price\">\r\n");
#nullable restore
#line 97 "E:\VSprj\AspPrj\HomeKala\ServiceHost\Pages\Shared\Components\ProductCategoriesWithProducts\Default.cshtml"
                                                             if (product.HasDiscount)
                                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                <span class=\"discounted-price\">");
#nullable restore
#line 99 "E:\VSprj\AspPrj\HomeKala\ServiceHost\Pages\Shared\Components\ProductCategoriesWithProducts\Default.cshtml"
                                                                                          Write(product.UnitPriceWithDiscount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" تومان</span> <span class=\"main-price discounted\">");
#nullable restore
#line 99 "E:\VSprj\AspPrj\HomeKala\ServiceHost\Pages\Shared\Components\ProductCategoriesWithProducts\Default.cshtml"
                                                                                                                                                                          Write(product.UnitPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(" تومان</span>\r\n");
#nullable restore
#line 100 "E:\VSprj\AspPrj\HomeKala\ServiceHost\Pages\Shared\Components\ProductCategoriesWithProducts\Default.cshtml"
                                                            }
                                                            else
                                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                <span class=\"main-price\">");
#nullable restore
#line 103 "E:\VSprj\AspPrj\HomeKala\ServiceHost\Pages\Shared\Components\ProductCategoriesWithProducts\Default.cshtml"
                                                                                    Write(product.UnitPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(" تومان</span>\r\n");
#nullable restore
#line 104 "E:\VSprj\AspPrj\HomeKala\ServiceHost\Pages\Shared\Components\ProductCategoriesWithProducts\Default.cshtml"
                                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                        </p>
                                                    </div>
                                                </div>
                                                <!--=======  End of single grid product  =======-->
                                            </div>
");
#nullable restore
#line 110 "E:\VSprj\AspPrj\HomeKala\ServiceHost\Pages\Shared\Components\ProductCategoriesWithProducts\Default.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 114 "E:\VSprj\AspPrj\HomeKala\ServiceHost\Pages\Shared\Components\ProductCategoriesWithProducts\Default.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                    <!--=======  End of tab product content  =======-->\r\n                </div>\r\n                <!--=======  End of tab slider wrapper  =======-->\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ProductCategoryQueryModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591