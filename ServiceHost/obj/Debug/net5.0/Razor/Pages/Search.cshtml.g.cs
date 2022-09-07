#pragma checksum "E:\VSprj\AspPrj\HomeKala\ServiceHost\Pages\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "644815814867ed6818c01189ee2d9691a6330d45"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ServiceHost.Pages.Pages_Search), @"mvc.1.0.razor-page", @"/Pages/Search.cshtml")]
namespace ServiceHost.Pages
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"644815814867ed6818c01189ee2d9691a6330d45", @"/Pages/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84733754fed1b4329eb046000a475b9f457c43c4", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Search : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./ProductCategory", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/ProductDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 3 "E:\VSprj\AspPrj\HomeKala\ServiceHost\Pages\Search.cshtml"
  
    ViewData["Title"] = "جستجو";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""breadcrumb-area section-space--half"">
    <div class=""container wide"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""breadcrumb-wrapper breadcrumb-bg"">
                    <div class=""breadcrumb-content"">
                        <h1 class=""breadcrumb-content__title"">نتیجه جستجو برای ");
#nullable restore
#line 13 "E:\VSprj\AspPrj\HomeKala\ServiceHost\Pages\Search.cshtml"
                                                                          Write(TempData["Value"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<div class=""page-content-area"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""page-wrapper"">
                    <div class=""page-content-wrapper"">
                        <div class=""row"">
                            <div class=""col-lg-12"">
                                <div class=""shop-page-content"">
                                    <div class=""row shop-product-wrap grid three-column"">
");
#nullable restore
#line 30 "E:\VSprj\AspPrj\HomeKala\ServiceHost\Pages\Search.cshtml"
                                         foreach (var product in Model.Products)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                            <div class=""col-12 col-lg-4 col-md-4 col-sm-6"">
                                                <div class=""single-grid-product grid-view-product"">
                                                    <div class=""single-grid-product__image"">
                                                        <div class=""single-grid-product__label"">
");
#nullable restore
#line 36 "E:\VSprj\AspPrj\HomeKala\ServiceHost\Pages\Search.cshtml"
                                                             if (product.HasDiscount)
                                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                <span class=\"sale\">");
#nullable restore
#line 38 "E:\VSprj\AspPrj\HomeKala\ServiceHost\Pages\Search.cshtml"
                                                                              Write(product.DiscountRate);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</span>\r\n");
#nullable restore
#line 39 "E:\VSprj\AspPrj\HomeKala\ServiceHost\Pages\Search.cshtml"
                                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                            <span class=""new"">جدید</span>
                                                        </div>
                                                        <a href=""single-product.html"">
                                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "644815814867ed6818c01189ee2d9691a6330d457670", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2196, "~/Images/ProductCategory/", 2196, 25, true);
#nullable restore
#line 43 "E:\VSprj\AspPrj\HomeKala\ServiceHost\Pages\Search.cshtml"
AddHtmlAttributeValue("", 2221, product.Picture, 2221, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 44 "E:\VSprj\AspPrj\HomeKala\ServiceHost\Pages\Search.cshtml"
AddHtmlAttributeValue("", 2328, product.PictureAlt, 2328, 19, false);

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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "644815814867ed6818c01189ee2d9691a6330d459735", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2421, "~/Images/ProductCategory/", 2421, 25, true);
#nullable restore
#line 45 "E:\VSprj\AspPrj\HomeKala\ServiceHost\Pages\Search.cshtml"
AddHtmlAttributeValue("", 2446, product.Picture, 2446, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 46 "E:\VSprj\AspPrj\HomeKala\ServiceHost\Pages\Search.cshtml"
AddHtmlAttributeValue("", 2553, product.PictureAlt, 2553, 19, false);

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
                                                            <span class=""category"">
                                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "644815814867ed6818c01189ee2d9691a6330d4512220", async() => {
#nullable restore
#line 52 "E:\VSprj\AspPrj\HomeKala\ServiceHost\Pages\Search.cshtml"
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
#line 52 "E:\VSprj\AspPrj\HomeKala\ServiceHost\Pages\Search.cshtml"
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
            WriteLiteral(@"
                                                            </span>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "644815814867ed6818c01189ee2d9691a6330d4515651", async() => {
                WriteLiteral("\r\n                                                                ");
#nullable restore
#line 65 "E:\VSprj\AspPrj\HomeKala\ServiceHost\Pages\Search.cshtml"
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
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                        </h3>\r\n                                                        <p class=\"single-grid-product__price\">\r\n");
#nullable restore
#line 69 "E:\VSprj\AspPrj\HomeKala\ServiceHost\Pages\Search.cshtml"
                                                             if (product.HasDiscount)
                                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                <span class=\"discounted-price\">");
#nullable restore
#line 71 "E:\VSprj\AspPrj\HomeKala\ServiceHost\Pages\Search.cshtml"
                                                                                          Write(product.UnitPriceWithDiscount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" تومان</span> <span class=\"main-price discounted\">");
#nullable restore
#line 71 "E:\VSprj\AspPrj\HomeKala\ServiceHost\Pages\Search.cshtml"
                                                                                                                                                                          Write(product.UnitPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(" تومان</span>\r\n");
#nullable restore
#line 72 "E:\VSprj\AspPrj\HomeKala\ServiceHost\Pages\Search.cshtml"
                                                            }
                                                            else
                                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                <span class=\"main-price\">");
#nullable restore
#line 75 "E:\VSprj\AspPrj\HomeKala\ServiceHost\Pages\Search.cshtml"
                                                                                    Write(product.UnitPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(" تومان</span>\r\n");
#nullable restore
#line 76 "E:\VSprj\AspPrj\HomeKala\ServiceHost\Pages\Search.cshtml"
                                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        </p>\r\n");
#nullable restore
#line 78 "E:\VSprj\AspPrj\HomeKala\ServiceHost\Pages\Search.cshtml"
                                                         if (product.HasDiscount)
                                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                            <div class=\"product-countdown\" data-countdown=\"");
#nullable restore
#line 80 "E:\VSprj\AspPrj\HomeKala\ServiceHost\Pages\Search.cshtml"
                                                                                                      Write(product.DiscountEndDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"></div>\r\n");
#nullable restore
#line 81 "E:\VSprj\AspPrj\HomeKala\ServiceHost\Pages\Search.cshtml"
                                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    </div>\r\n                                                </div>\r\n                                            </div>\r\n");
#nullable restore
#line 85 "E:\VSprj\AspPrj\HomeKala\ServiceHost\Pages\Search.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    </div>
                                </div>
                                <div class=""pagination-area"">
                                    <div class=""pagination-area__left"">
                                        Showing 1 to 9 of 11 (2 Pages)
                                    </div>
                                    <div class=""pagination-area__right"">
                                        <ul class=""pagination-section"">
                                            <li>
                                                <a class=""active"" href=""#"">1</a>
                                            </li>
                                            <li>
                                                <a href=""#"">2</a>
                                            </li>
                                        </ul>
                                    </div>
                                </div>
                            </div>
                       ");
            WriteLiteral(" </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ServiceHost.Pages.SearchModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ServiceHost.Pages.SearchModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ServiceHost.Pages.SearchModel>)PageContext?.ViewData;
        public ServiceHost.Pages.SearchModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591