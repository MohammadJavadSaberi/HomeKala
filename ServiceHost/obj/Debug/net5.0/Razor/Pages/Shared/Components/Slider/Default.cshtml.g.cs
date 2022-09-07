#pragma checksum "E:\VSprj\AspPrj\HomeKala\ServiceHost\Pages\Shared\Components\Slider\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "78d77e5dcd02aa265d9bc4b9274ef79cee1b0a85"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ServiceHost.Pages.Shared.Components.Slider.Pages_Shared_Components_Slider_Default), @"mvc.1.0.view", @"/Pages/Shared/Components/Slider/Default.cshtml")]
namespace ServiceHost.Pages.Shared.Components.Slider
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78d77e5dcd02aa265d9bc4b9274ef79cee1b0a85", @"/Pages/Shared/Components/Slider/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84733754fed1b4329eb046000a475b9f457c43c4", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared_Components_Slider_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SlideQueryModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""hero-slider-area section-space"">
    <div class=""container wide"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <!--=======  hero slider wrapper  =======-->

                <div class=""hero-slider-wrapper"">
                    <div class=""ht-slick-slider"" data-slick-setting='{
                        ""slidesToShow"": 1,
                        ""slidesToScroll"": 1,
                        ""arrows"": true,
                        ""dots"": true,
                        ""autoplay"": true,
                        ""autoplaySpeed"": 5000,
                        ""speed"": 1000,
                        ""fade"": true,
                        ""infinite"": true,
                        ""prevArrow"": {""buttonClass"": ""slick-prev"", ""iconClass"": ""ion-chevron-left"" },
                        ""nextArrow"": {""buttonClass"": ""slick-next"", ""iconClass"": ""ion-chevron-right"" }
                    }' data-slick-responsive='[
                        {""breakpoint"":1501, ""settings");
            WriteLiteral(@""": {""slidesToShow"": 1} },
                        {""breakpoint"":1199, ""settings"": {""slidesToShow"": 1, ""arrows"": false} },
                        {""breakpoint"":991, ""settings"": {""slidesToShow"": 1, ""arrows"": false} },
                        {""breakpoint"":767, ""settings"": {""slidesToShow"": 1, ""arrows"": false} },
                        {""breakpoint"":575, ""settings"": {""slidesToShow"": 1, ""arrows"": false} },
                        {""breakpoint"":479, ""settings"": {""slidesToShow"": 1, ""arrows"": false} }
                    ]'>

");
#nullable restore
#line 31 "E:\VSprj\AspPrj\HomeKala\ServiceHost\Pages\Shared\Components\Slider\Default.cshtml"
                         foreach (var slide in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <div class=""single-slider-item"">
                                <div class=""hero-slider-item-wrapper"">
                                    <div class=""container"">
                                        <img class=""fixing-slider-rtl""");
            BeginWriteAttribute("src", " src=\"", 1935, "\"", 1955, 1);
#nullable restore
#line 36 "E:\VSprj\AspPrj\HomeKala\ServiceHost\Pages\Shared\Components\Slider\Default.cshtml"
WriteAttributeValue("", 1941, slide.Picture, 1941, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1956, "\"", 1979, 1);
#nullable restore
#line 36 "E:\VSprj\AspPrj\HomeKala\ServiceHost\Pages\Shared\Components\Slider\Default.cshtml"
WriteAttributeValue("", 1962, slide.PictureAlt, 1962, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 1980, "\"", 2007, 1);
#nullable restore
#line 36 "E:\VSprj\AspPrj\HomeKala\ServiceHost\Pages\Shared\Components\Slider\Default.cshtml"
WriteAttributeValue("", 1988, slide.PictureTitle, 1988, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                                        <div class=""row"">
                                            <div class=""col-lg-12"">
                                                <div class=""hero-slider-content hero-slider-content--left-space"">
                                                    <p class=""slider-title slider-title--big-light"">");
#nullable restore
#line 40 "E:\VSprj\AspPrj\HomeKala\ServiceHost\Pages\Shared\Components\Slider\Default.cshtml"
                                                                                               Write(slide.Heading);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                                    <p class=\"slider-title slider-title--big-bold\">");
#nullable restore
#line 41 "E:\VSprj\AspPrj\HomeKala\ServiceHost\Pages\Shared\Components\Slider\Default.cshtml"
                                                                                              Write(slide.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                                    <p class=\"slider-title slider-title--small\">\r\n                                                        ");
#nullable restore
#line 43 "E:\VSprj\AspPrj\HomeKala\ServiceHost\Pages\Shared\Components\Slider\Default.cshtml"
                                                   Write(slide.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    </p>\r\n                                                    <a class=\"hero-slider-button\"");
            BeginWriteAttribute("href", " href=\"", 2799, "\"", 2817, 1);
#nullable restore
#line 45 "E:\VSprj\AspPrj\HomeKala\ServiceHost\Pages\Shared\Components\Slider\Default.cshtml"
WriteAttributeValue("", 2806, slide.Link, 2806, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                        ");
#nullable restore
#line 46 "E:\VSprj\AspPrj\HomeKala\ServiceHost\Pages\Shared\Components\Slider\Default.cshtml"
                                                   Write(slide.BtnText);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" <i class=""ion-ios-plus-empty""></i>
                                                    </a>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
");
#nullable restore
#line 54 "E:\VSprj\AspPrj\HomeKala\ServiceHost\Pages\Shared\Components\Slider\Default.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SlideQueryModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591