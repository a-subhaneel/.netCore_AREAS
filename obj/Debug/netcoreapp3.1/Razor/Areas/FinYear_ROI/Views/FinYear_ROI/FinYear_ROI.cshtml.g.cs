#pragma checksum "D:\Subhaneel Agarwalla\PACS_WEB_VERSION_ENGLISH\Areas\FinYear_ROI\Views\FinYear_ROI\FinYear_ROI.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8ddbdc2a46f2c56dbcc7959cb39d013de99d7534"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_FinYear_ROI_Views_FinYear_ROI_FinYear_ROI), @"mvc.1.0.view", @"/Areas/FinYear_ROI/Views/FinYear_ROI/FinYear_ROI.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ddbdc2a46f2c56dbcc7959cb39d013de99d7534", @"/Areas/FinYear_ROI/Views/FinYear_ROI/FinYear_ROI.cshtml")]
    public class Areas_FinYear_ROI_Views_FinYear_ROI_FinYear_ROI : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebPACS.Areas.FinYear_ROI.Models.FinYear_ROI>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Subhaneel Agarwalla\PACS_WEB_VERSION_ENGLISH\Areas\FinYear_ROI\Views\FinYear_ROI\FinYear_ROI.cshtml"
  
    ViewData["Title"] = "FinYear_ROI";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<center>
    <h2>
        Financial Year
    </h2>
</center>


<div class=""row"">

        <form asp-action=""FinYear_ROI"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""row"">
                <div class=""form-group"">
                    <label class=""control-label col-md-12"">Last Calender Year:</label>
                    <div class=""col-md-12"">
                        <input class=""form-control"" />
                    </div>
                </div>
            </div>
            <div class=""row"">
                <div class=""form-group"">
                    <label class=""control-label col-md-12"">New Calender Year:</label>
                    <div class=""col-md-12"">
                        <input class=""form-control"" />
                    </div>
                </div>
            </div>
            <div class=""row"">
                <div class=""form-group"">
                    <label class=""control-label col-md-12"">Start Dat");
            WriteLiteral(@"e</label>
                    <div class=""col-md-12"">
                        <input class=""form-control datepicker"" , placeholder=""DD/MM/YYYY"" maxlength=""50"" />
                    </div>
                </div>
            </div>
            <div class=""row"">
                <div class=""form-group"">
                    <label class=""control-label col-md-6"">End Date</label>
                    <div class=""col-md-12"">
                        <input class=""form-control datepicker"" , placeholder=""DD/MM/YYYY"" maxlength=""50"" />
                    </div>
                </div>
            </div>

            <sup>
                In This Process All The Accounts of Previous Calender Year will be Available in Current Calender Year. Also Last Year's
                Closing Balance will be Current Year's Opening Balance.

            </sup>
            <p style=""margin-bottom:15px""/>
            <div class=""form-group"">
                <input type=""submit"" value=""Create New Calender Year"" class=");
            WriteLiteral("\"btn btn-primary\" />\r\n            </div>\r\n        </form>\r\n    </div>\r\n\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 68 "D:\Subhaneel Agarwalla\PACS_WEB_VERSION_ENGLISH\Areas\FinYear_ROI\Views\FinYear_ROI\FinYear_ROI.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebPACS.Areas.FinYear_ROI.Models.FinYear_ROI> Html { get; private set; }
    }
}
#pragma warning restore 1591
