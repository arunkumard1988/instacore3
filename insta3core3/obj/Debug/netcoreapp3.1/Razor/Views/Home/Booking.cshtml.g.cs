#pragma checksum "C:\github\insta3core3\insta3core3\Views\Home\Booking.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e2e2957b1a620f956e2289646fa16772dcb77007"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Booking), @"mvc.1.0.view", @"/Views/Home/Booking.cshtml")]
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
#line 1 "C:\github\insta3core3\insta3core3\Views\_ViewImports.cshtml"
using insta3core3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\github\insta3core3\insta3core3\Views\_ViewImports.cshtml"
using insta3core3.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2e2957b1a620f956e2289646fa16772dcb77007", @"/Views/Home/Booking.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c30c8501b5da1ada1e43e34d7db96c62c5c4fd2d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Booking : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<insta3core3.Models.DriverInfoViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("needs-validation"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "TicketConfirmation", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("booking"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\github\insta3core3\insta3core3\Views\Home\Booking.cshtml"
  
    ViewData["Title"] = "Booking";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section class=\"head\">\r\n    <h1>Booking Page</h1>\r\n    <span>Location: <b>");
#nullable restore
#line 9 "C:\github\insta3core3\insta3core3\Views\Home\Booking.cshtml"
                  Write(ViewData["destination"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></span>\r\n</section>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e2e2957b1a620f956e2289646fa16772dcb770074897", async() => {
                WriteLiteral("\r\n    <div class=\"container\">\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e2e2957b1a620f956e2289646fa16772dcb770075196", async() => {
                    WriteLiteral(@"
            <div class=""form-row"">
                <div class=""col-md-4 mb-3"">
                    <label for=""validationCustom01"">Name</label>
                    <input type=""text"" class=""form-control"" id=""validationCustom01"" name=""usernamePassenger"" placeholder=""Name"" required>
                    <div class=""valid-feedback"">
                        Looks good!
                    </div>
                </div>
                <div class=""col-md-4 mb-3"">
                    <label for=""validationCustom02"">Email</label>
                    <input type=""email"" class=""form-control"" id=""validationCustom02"" name=""emailPassenger"" placeholder=""Email"" required>
                    <div class=""valid-feedback"">
                        Looks good!
                    </div>
                </div>
                <div class=""col-md-4 mb-3"">
                    <label for=""validationCustom03"">Mobile No</label>
                    <input type=""text"" class=""form-control"" id=""validationCustom03"" name=""mo");
                    WriteLiteral(@"bilePassenger"" placeholder=""Mobile No"" required>
                    <div class=""valid-feedback"">
                        Looks good!
                    </div>
                </div>
            </div>
            <div class=""form-row"">
                <div class=""col-md-6 mb-3"">
                    <label for=""validationCustom04"">Address</label>
                    <input type=""text"" class=""form-control"" id=""validationCustom04"" name=""addressPassenger"" placeholder=""Address"" required>
                    <div class=""invalid-feedback"">
                        Please provide a valid address.
                    </div>
                </div>

                <div class=""col-md-3 mb-3"">
                    <label>Pick Up Date</label>
                    <input type=""text"" class=""form-control"" name=""traveDatePassenger""");
                    BeginWriteAttribute("value", " value=\"", 2217, "\"", 2248, 1);
#nullable restore
#line 49 "C:\github\insta3core3\insta3core3\Views\Home\Booking.cshtml"
WriteAttributeValue("", 2225, ViewData["travelDate"], 2225, 23, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(@" readonly>

                </div>
                <div class=""col-md-3 mb-3"">
                    <label for=""validationCustom05"">Pick Up Time</label>
                    <input type=""time"" class=""form-control"" id=""validationCustom05"" name=""traveTimePassenger"" required>
                    <div class=""invalid-feedback"">
                        Please provide a valid time.
                    </div>
                </div>
            </div>
            <input type=""hidden"" class=""form-control""   name=""driverDetails""");
                    BeginWriteAttribute("value", " value=\"", 2781, "\"", 2832, 1);
#nullable restore
#line 60 "C:\github\insta3core3\insta3core3\Views\Home\Booking.cshtml"
WriteAttributeValue("", 2789, Html.DisplayFor(model => model.DriverName), 2789, 43, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(">\r\n\r\n            <div class=\"form-group\">\r\n\r\n            </div>\r\n            <button class=\"btn btn-primary\" type=\"submit\">Pay Now (Rs.");
#nullable restore
#line 65 "C:\github\insta3core3\insta3core3\Views\Home\Booking.cshtml"
                                                                 Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
#nullable disable
                    WriteLiteral(")</button>\r\n        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("novalidate", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script>
    // Example starter JavaScript for disabling form submissions if there are invalid fields
    (function () {
        'use strict';
        window.addEventListener('load', function () {
            // Fetch all the forms we want to apply custom Bootstrap validation styles to
            var forms = document.getElementsByClassName('needs-validation');
            // Loop over them and prevent submission
            var validation = Array.prototype.filter.call(forms, function (form) {
                form.addEventListener('submit', function (event) {
                    if (form.checkValidity() === false) {
                        event.preventDefault();
                        event.stopPropagation();
                    }
                    form.classList.add('was-validated');
                }, false);
            });
        }, false);
    })();
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<insta3core3.Models.DriverInfoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
