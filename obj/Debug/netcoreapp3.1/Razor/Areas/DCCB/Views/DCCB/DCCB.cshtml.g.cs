#pragma checksum "D:\Subhaneel Agarwalla\PACS_WEB_VERSION_ENGLISH\Areas\DCCB\Views\DCCB\DCCB.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d8f74246e49c419e99889009d1d46f6b0e11aa81"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_DCCB_Views_DCCB_DCCB), @"mvc.1.0.view", @"/Areas/DCCB/Views/DCCB/DCCB.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8f74246e49c419e99889009d1d46f6b0e11aa81", @"/Areas/DCCB/Views/DCCB/DCCB.cshtml")]
    public class Areas_DCCB_Views_DCCB_DCCB : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebPACS.Areas.DCCB.Models.DCCB>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Subhaneel Agarwalla\PACS_WEB_VERSION_ENGLISH\Areas\DCCB\Views\DCCB\DCCB.cshtml"
  
    ViewData["Title"] = "DCCB";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<center>
    <h2>
        DCCB Details
    </h2>
</center>


<div class=""row"" style=""margin-left: 300px;"">
    <div class=""col-lg-12"">
        <div class=""row"">
            <form asp-action=""DCCB"">
                <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
                <div class=""row"">
                    <div class=""form-group"">
                        <label class=""control-label col-md-2"">DCCBName:</label>
                        <div class=""col-md-12"">
                            <input class=""form-control  "" />
                        </div>
                    </div>
                    &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp;
                    <div class=""form-group"">
                        <label class=""control-label col-md-2"">Branch:</label>
                        <div class=""col-md-12"">
                            <input class=""form-control"" />
                        </div>
                    </div>
                </div>
              ");
            WriteLiteral(@"  <div class=""row"">
                    <div class=""form-group"">
                        <label class=""control-label col-md-2"">Contact:</label><br />
                        <div class=""col-md-12"">
                            <input class=""form-control"" />
                        </div>
                    </div>
                    &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp;

                    <div class=""form-group"">
                        <label class=""control-label col-md-2"">StreetAddress:</label>
                        <div class=""col-md-12"">
                            <input class=""form-control"" />
                        </div>
                    </div>
                </div>

                <div class=""row"">
                    <div class=""form-group"">
                        <label class=""control-label col-md-2"">StreetAddress2:</label>
                        <div class=""col-md-12"">
                            <input class=""form-control"" />
                        </div>
  ");
            WriteLiteral(@"                  </div>
                    &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp;
                    <div class=""form-group"">
                        <label class=""control-label col-md-2"">City:</label>
                        <div class=""col-md-12"">
                            <input class=""form-control"" />
                        </div>
                    </div>
                </div>

                <div class=""row"">
                    <div class=""form-group"">
                        <label class=""control-label col-md-2"">State:</label>
                        <div class=""col-md-12"">
                            <input class=""form-control"" />
                        </div>
                    </div>
                    &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp;
                    <div class=""form-group"">
                        <label class=""control-label col-md-2"">PostalCode:</label>
                        <div class=""col-md-12"">
                            <input class=""form-con");
            WriteLiteral(@"trol"" />
                        </div>
                    </div>
                </div>
                <div class=""row"">
                    <div class=""form-group"">
                        <label class=""control-label col-md-2"">Country:</label>
                        <div class=""col-md-12"">
                            <input class=""form-control"" />
                        </div>
                    </div>

                    &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp;

                    <div class=""form-group"">
                        <label class=""control-label col-md-2"">Email:</label>
                        <div class=""col-md-12"">
                            <input class=""form-control"" />
                        </div>
                    </div>
                </div>
                <div class=""row"">
                    <div class=""form-group"">
                        <label class=""control-label col-md-2"">Website:</label>
                        <div class=""col-md-12"">
       ");
            WriteLiteral(@"                     <input class=""form-control"" />
                        </div>
                    </div>
                    &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp;
                    <div class=""form-group"">
                        <label class=""control-label col-md-2"">DCCBBaseIFSCCode</label>
                        <div class=""col-md-12"">
                            <input class=""form-control"" />
                        </div>
                    </div>
                </div>
                <br>
                <div class=""form-group"" style=""margin-bottom:100px"">
                    <input type=""submit"" value=""Create"" class=""btn btn-primary"" />
                </div>

            </form>

        </div>

    </div>
</div>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebPACS.Areas.DCCB.Models.DCCB> Html { get; private set; }
    }
}
#pragma warning restore 1591
