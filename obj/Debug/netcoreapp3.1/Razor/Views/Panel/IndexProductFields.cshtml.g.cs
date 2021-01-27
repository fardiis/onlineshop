#pragma checksum "C:\Drive\Projects\OnlineTour\DigiKala\DigiKala\Views\Panel\IndexProductFields.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f42b145e0df363763197fddcb6ed4e5d083cb368"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Panel_IndexProductFields), @"mvc.1.0.view", @"/Views/Panel/IndexProductFields.cshtml")]
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
#line 3 "C:\Drive\Projects\OnlineTour\DigiKala\DigiKala\Views\Panel\IndexProductFields.cshtml"
using DigiKala.Core.Classes;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f42b145e0df363763197fddcb6ed4e5d083cb368", @"/Views/Panel/IndexProductFields.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b853c2693020103458b52d8246f923ca3fd89014", @"/Views/_ViewImports.cshtml")]
    public class Views_Panel_IndexProductFields : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DigiKala.DataAccessLayer.Entities.FieldCategory>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Drive\Projects\OnlineTour\DigiKala\DigiKala\Views\Panel\IndexProductFields.cshtml"
  
    ViewData["Title"] = "مشخصه های محصول";
    Layout = "~/Views/Shared/_Panel.cshtml";

    int productID = ViewBag.MyId;
    int i = 1;
    int myCount = Model.Count();

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""col-lg-offset-3 col-lg-8 col-md-offset-3 col-md-8 col-sm-10 col-sm-offset-1 col-xs-10 col-xs-offset-1 panel-back"">

    <div class=""margin-top-50"">

        <h3 class=""pull-right"">
            مشخصه های محصول
        </h3>
        <h3 class=""pull-left"">
            <a href=""/Panel/ShowProducts/"" class=""btn btn-danger"">بازگشت</a>
        </h3>
        <h3 class=""pull-left"">
            <a href=""#"" onclick=""myfunction()"" class=""btn btn-success"" style=""margin-left: 5px"">ذخیره</a>
        </h3>

    </div>
    <div class=""clearfix""></div>
    <div class=""margin-top-30"">

");
#nullable restore
#line 34 "C:\Drive\Projects\OnlineTour\DigiKala\DigiKala\Views\Panel\IndexProductFields.cshtml"
         foreach (var item in Model)
        {
            string value = "ندارد";

            var productFiled = scope.GetProductField(item.FieldId, productID);

            if (productFiled != null)
            {
                value = productFiled.Value;
            }


#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"form-group\">\r\n                <label>");
#nullable restore
#line 46 "C:\Drive\Projects\OnlineTour\DigiKala\DigiKala\Views\Panel\IndexProductFields.cshtml"
                  Write(item.Field.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                <input");
            BeginWriteAttribute("id", " id=\"", 1322, "\"", 1329, 1);
#nullable restore
#line 47 "C:\Drive\Projects\OnlineTour\DigiKala\DigiKala\Views\Panel\IndexProductFields.cshtml"
WriteAttributeValue("", 1327, i, 1327, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=\"", 1330, "\"", 1339, 1);
#nullable restore
#line 47 "C:\Drive\Projects\OnlineTour\DigiKala\DigiKala\Views\Panel\IndexProductFields.cshtml"
WriteAttributeValue("", 1337, i, 1337, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 1340, "\"", 1354, 1);
#nullable restore
#line 47 "C:\Drive\Projects\OnlineTour\DigiKala\DigiKala\Views\Panel\IndexProductFields.cshtml"
WriteAttributeValue("", 1348, value, 1348, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control\"  />                \r\n            </div>\r\n");
#nullable restore
#line 49 "C:\Drive\Projects\OnlineTour\DigiKala\DigiKala\Views\Panel\IndexProductFields.cshtml"

            i += 1;
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n\r\n</div>\r\n\r\n");
            DefineSection("mySection", async() => {
                WriteLiteral("\r\n    <script type=\"text/javascript\">\r\n\r\n        var mycount = ");
#nullable restore
#line 61 "C:\Drive\Projects\OnlineTour\DigiKala\DigiKala\Views\Panel\IndexProductFields.cshtml"
                 Write(myCount);

#line default
#line hidden
#nullable disable
                WriteLiteral(@";
        var checker;

        var result = """";

        function myfunction() {
            checker = 1;

            for (var i = 0; i < mycount; i++) {
                if (result == """") {
                    result = document.getElementById(checker).value;
                }
                else {
                    result = result + ""-"" + document.getElementById(checker).value;
                }

                checker = checker + 1;
            }

            window.open(""/Panel/UpdateProductFileds/"" + ");
#nullable restore
#line 80 "C:\Drive\Projects\OnlineTour\DigiKala\DigiKala\Views\Panel\IndexProductFields.cshtml"
                                                   Write(productID);

#line default
#line hidden
#nullable disable
                WriteLiteral(" + \"?result=\" + result, \"_parent\");\r\n        }\r\n\r\n    </script>\r\n");
            }
            );
            WriteLiteral("\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public PanelLayoutScope scope { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DigiKala.DataAccessLayer.Entities.FieldCategory>> Html { get; private set; }
    }
}
#pragma warning restore 1591