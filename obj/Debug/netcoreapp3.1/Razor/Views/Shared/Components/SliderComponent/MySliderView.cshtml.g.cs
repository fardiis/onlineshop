#pragma checksum "C:\Drive\Projects\OnlineTour\DigiKala\DigiKala\Views\Shared\Components\SliderComponent\MySliderView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b025f65fdf5783ea363f6787e4fdbb238489ffb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_SliderComponent_MySliderView), @"mvc.1.0.view", @"/Views/Shared/Components/SliderComponent/MySliderView.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b025f65fdf5783ea363f6787e4fdbb238489ffb", @"/Views/Shared/Components/SliderComponent/MySliderView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b853c2693020103458b52d8246f923ca3fd89014", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_SliderComponent_MySliderView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DigiKala.DataAccessLayer.Entities.Slider>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("دیجی کالا"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-responsive"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Drive\Projects\OnlineTour\DigiKala\DigiKala\Views\Shared\Components\SliderComponent\MySliderView.cshtml"
   
    bool active = true;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div id=\"carousel-example-generic\" class=\"carousel slide\" data-ride=\"carousel\">\r\n    <!-- Indicators -->\r\n    <ol class=\"carousel-indicators\">\r\n\r\n");
#nullable restore
#line 11 "C:\Drive\Projects\OnlineTour\DigiKala\DigiKala\Views\Shared\Components\SliderComponent\MySliderView.cshtml"
         for (int i = 0; i < Model.Count(); i++)
        {
            if (i == 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li data-target=\"#carousel-example-generic\" data-slide-to=\"");
#nullable restore
#line 15 "C:\Drive\Projects\OnlineTour\DigiKala\DigiKala\Views\Shared\Components\SliderComponent\MySliderView.cshtml"
                                                                      Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"active\"></li>\r\n");
#nullable restore
#line 16 "C:\Drive\Projects\OnlineTour\DigiKala\DigiKala\Views\Shared\Components\SliderComponent\MySliderView.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li data-target=\"#carousel-example-generic\" data-slide-to=\"");
#nullable restore
#line 19 "C:\Drive\Projects\OnlineTour\DigiKala\DigiKala\Views\Shared\Components\SliderComponent\MySliderView.cshtml"
                                                                      Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"></li>\r\n");
#nullable restore
#line 20 "C:\Drive\Projects\OnlineTour\DigiKala\DigiKala\Views\Shared\Components\SliderComponent\MySliderView.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </ol>\r\n\r\n    <!-- Wrapper for slides -->\r\n    <div class=\"carousel-inner\" role=\"listbox\">\r\n\r\n");
#nullable restore
#line 28 "C:\Drive\Projects\OnlineTour\DigiKala\DigiKala\Views\Shared\Components\SliderComponent\MySliderView.cshtml"
         foreach (var item in Model)
        {
            if (active)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"item active\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9b025f65fdf5783ea363f6787e4fdbb238489ffb6175", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 868, "~/images/sliders/", 868, 17, true);
#nullable restore
#line 33 "C:\Drive\Projects\OnlineTour\DigiKala\DigiKala\Views\Shared\Components\SliderComponent\MySliderView.cshtml"
AddHtmlAttributeValue("", 885, item.Img, 885, 9, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            WriteLiteral("                </div>\r\n");
#nullable restore
#line 38 "C:\Drive\Projects\OnlineTour\DigiKala\DigiKala\Views\Shared\Components\SliderComponent\MySliderView.cshtml"

                active = false;
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"item\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9b025f65fdf5783ea363f6787e4fdbb238489ffb8269", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1223, "~/images/sliders/", 1223, 17, true);
#nullable restore
#line 44 "C:\Drive\Projects\OnlineTour\DigiKala\DigiKala\Views\Shared\Components\SliderComponent\MySliderView.cshtml"
AddHtmlAttributeValue("", 1240, item.Img, 1240, 9, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            WriteLiteral("                </div>\r\n");
#nullable restore
#line 49 "C:\Drive\Projects\OnlineTour\DigiKala\DigiKala\Views\Shared\Components\SliderComponent\MySliderView.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DigiKala.DataAccessLayer.Entities.Slider>> Html { get; private set; }
    }
}
#pragma warning restore 1591
