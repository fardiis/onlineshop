#pragma checksum "C:\Drive\Projects\OnlineTour\DigiKala\DigiKala\Views\Admin\ShowSliders.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4e52bd9d12fe9b0fab89798108604ec5e58e92d1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_ShowSliders), @"mvc.1.0.view", @"/Views/Admin/ShowSliders.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e52bd9d12fe9b0fab89798108604ec5e58e92d1", @"/Views/Admin/ShowSliders.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b853c2693020103458b52d8246f923ca3fd89014", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_ShowSliders : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DigiKala.DataAccessLayer.Entities.Slider>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Drive\Projects\OnlineTour\DigiKala\DigiKala\Views\Admin\ShowSliders.cshtml"
  
    ViewData["Title"] = "اسلاید ها";
    Layout = "~/Views/Shared/_Panel.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""col-lg-offset-3 col-lg-8 col-md-offset-3 col-md-8 col-sm-10 col-sm-offset-1 col-xs-10 col-xs-offset-1 panel-back"">

    <div class=""margin-top-50"">

        <h3 class=""pull-right"">
            نمایش اسلاید ها
        </h3>
        <h3 class=""pull-left"">
            <a href=""#"" onclick=""MyCreate()"" class=""btn btn-primary"">جدید</a>
        </h3>

    </div>

    <div class=""margin-top-30"">

        <table class=""table table-bordered table-hover"">

            <thead>

                <tr>

                    <th>
                        ");
#nullable restore
#line 30 "C:\Drive\Projects\OnlineTour\DigiKala\DigiKala\Views\Admin\ShowSliders.cshtml"
                   Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 33 "C:\Drive\Projects\OnlineTour\DigiKala\DigiKala\Views\Admin\ShowSliders.cshtml"
                   Write(Html.DisplayNameFor(model => model.OrderShow));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n\r\n                    <th>\r\n                        عملیات\r\n                    </th>\r\n\r\n                </tr>\r\n\r\n            </thead>\r\n\r\n            <tbody>\r\n\r\n");
#nullable restore
#line 46 "C:\Drive\Projects\OnlineTour\DigiKala\DigiKala\Views\Admin\ShowSliders.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 50 "C:\Drive\Projects\OnlineTour\DigiKala\DigiKala\Views\Admin\ShowSliders.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 53 "C:\Drive\Projects\OnlineTour\DigiKala\DigiKala\Views\Admin\ShowSliders.cshtml"
                   Write(Html.DisplayFor(modelItem => item.OrderShow));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        <a href=\"#\"");
            BeginWriteAttribute("onclick", " onclick=\'", 1482, "\'", 1511, 3);
            WriteAttributeValue("", 1492, "MyDetails(", 1492, 10, true);
#nullable restore
#line 56 "C:\Drive\Projects\OnlineTour\DigiKala\DigiKala\Views\Admin\ShowSliders.cshtml"
WriteAttributeValue("", 1502, item.Id, 1502, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1510, ")", 1510, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn-xs btn-info\">جزئیات</a> |\r\n                        <a href=\"#\"");
            BeginWriteAttribute("onclick", " onclick=\'", 1586, "\'", 1612, 3);
            WriteAttributeValue("", 1596, "MyEdit(", 1596, 7, true);
#nullable restore
#line 57 "C:\Drive\Projects\OnlineTour\DigiKala\DigiKala\Views\Admin\ShowSliders.cshtml"
WriteAttributeValue("", 1603, item.Id, 1603, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1611, ")", 1611, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn-xs btn-warning\">اصلاح</a> |\r\n                        <a href=\"#\"");
            BeginWriteAttribute("onclick", " onclick=\'", 1689, "\'", 1717, 3);
            WriteAttributeValue("", 1699, "MyDelete(", 1699, 9, true);
#nullable restore
#line 58 "C:\Drive\Projects\OnlineTour\DigiKala\DigiKala\Views\Admin\ShowSliders.cshtml"
WriteAttributeValue("", 1708, item.Id, 1708, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1716, ")", 1716, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn-xs btn-danger\">حذف</a>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 61 "C:\Drive\Projects\OnlineTour\DigiKala\DigiKala\Views\Admin\ShowSliders.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </tbody>

        </table>

    </div>

</div>

<div id=""myModal"" class=""modal fade"" tabindex=""-1"" role=""dialog"">

    <div class=""modal-dialog"" role=""document"">

        <div class=""modal-content"">

            <div class=""modal-header"">
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>

            <div id=""bodyModal"" class=""modal-body"">



            </div>

        </div>

    </div>

</div>


");
            DefineSection("mySection", async() => {
                WriteLiteral(@"
    <script>
        function MyCreate() {
            $.ajax({
                url: ""/Admin/AddSlider/"",
                type: ""Get"",
                data: {}
            }).done(function (result) {
                $('#myModal').modal('show');
                $('#bodyModal').html(result);
            });
        }
    </script>

    <script>
        function MyEdit(id) {
            $.ajax({
                url: ""/Admin/EditSlider/"" + id,
                type: ""Get"",
                data: {}
            }).done(function (result) {
                $('#myModal').modal('show');
                $('#bodyModal').html(result);
            });
        }
    </script>

    <script>
        function MyDetails(id) {
            $.ajax({
                url: ""/Admin/DetailsSlider/"" + id,
                type: ""Get"",
                data: {}
            }).done(function (result) {
                $('#myModal').modal('show');
                $('#bodyModal').html(result);
            })");
                WriteLiteral(@";
        }
    </script>

    <script>
        function MyDelete(id) {
            $.ajax({
                url: ""/Admin/DeleteSlider/"" + id,
                type: ""Get"",
                data: {}
            }).done(function (result) {
                $('#myModal').modal('show');
                $('#bodyModal').html(result);
            });
        }
    </script>
");
            }
            );
            WriteLiteral("\r\n");
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
