#pragma checksum "D:\Graeme\Downloads\gfraser4_College_Strike\gfraser4_College_Strike\Views\Members\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5fd678db70b2563ea4b8efbf6507ce014a15e473"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Members_Details), @"mvc.1.0.view", @"/Views/Members/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Members/Details.cshtml", typeof(AspNetCore.Views_Members_Details))]
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
#line 1 "D:\Graeme\Downloads\gfraser4_College_Strike\gfraser4_College_Strike\Views\_ViewImports.cshtml"
using gfraser4_College_Strike;

#line default
#line hidden
#line 2 "D:\Graeme\Downloads\gfraser4_College_Strike\gfraser4_College_Strike\Views\_ViewImports.cshtml"
using gfraser4_College_Strike.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5fd678db70b2563ea4b8efbf6507ce014a15e473", @"/Views/Members/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"045690afbccc0dd8297627e041b4961c8afc8dd7", @"/Views/_ViewImports.cshtml")]
    public class Views_Members_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<gfraser4_College_Strike.Models.Member>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Graeme\Downloads\gfraser4_College_Strike\gfraser4_College_Strike\Views\Members\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(91, 61, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Member</h4>\r\n    <div>\r\n");
            EndContext();
#line 12 "D:\Graeme\Downloads\gfraser4_College_Strike\gfraser4_College_Strike\Views\Members\Details.cshtml"
          
            if (Model.imageContent != null && Model.imageMimeType.Contains("image"))
            {
                string imageBase64 = Convert.ToBase64String(Model.imageContent);
                string imageSrc = string.Format("data:" + Model.imageMimeType + ";base64,{0}", imageBase64);

#line default
#line hidden
            BeginContext(457, 20, true);
            WriteLiteral("                <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 477, "\"", 492, 1);
#line 17 "D:\Graeme\Downloads\gfraser4_College_Strike\gfraser4_College_Strike\Views\Members\Details.cshtml"
WriteAttributeValue("", 483, imageSrc, 483, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(493, 66, true);
            WriteLiteral(" style=\"max-height: 500px\" class=\"img-responsive img-rounded\" />\r\n");
            EndContext();
#line 18 "D:\Graeme\Downloads\gfraser4_College_Strike\gfraser4_College_Strike\Views\Members\Details.cshtml"
            }
        

#line default
#line hidden
            BeginContext(585, 82, true);
            WriteLiteral("    </div>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(668, 45, false);
#line 24 "D:\Graeme\Downloads\gfraser4_College_Strike\gfraser4_College_Strike\Views\Members\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(713, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(757, 41, false);
#line 27 "D:\Graeme\Downloads\gfraser4_College_Strike\gfraser4_College_Strike\Views\Members\Details.cshtml"
       Write(Html.DisplayFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(798, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(842, 44, false);
#line 30 "D:\Graeme\Downloads\gfraser4_College_Strike\gfraser4_College_Strike\Views\Members\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(886, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(930, 40, false);
#line 33 "D:\Graeme\Downloads\gfraser4_College_Strike\gfraser4_College_Strike\Views\Members\Details.cshtml"
       Write(Html.DisplayFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(970, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1014, 41, false);
#line 36 "D:\Graeme\Downloads\gfraser4_College_Strike\gfraser4_College_Strike\Views\Members\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(1055, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1099, 37, false);
#line 39 "D:\Graeme\Downloads\gfraser4_College_Strike\gfraser4_College_Strike\Views\Members\Details.cshtml"
       Write(Html.DisplayFor(model => model.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(1136, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1180, 41, false);
#line 42 "D:\Graeme\Downloads\gfraser4_College_Strike\gfraser4_College_Strike\Views\Members\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.eMail));

#line default
#line hidden
            EndContext();
            BeginContext(1221, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1265, 37, false);
#line 45 "D:\Graeme\Downloads\gfraser4_College_Strike\gfraser4_College_Strike\Views\Members\Details.cshtml"
       Write(Html.DisplayFor(model => model.eMail));

#line default
#line hidden
            EndContext();
            BeginContext(1302, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1346, 46, false);
#line 48 "D:\Graeme\Downloads\gfraser4_College_Strike\gfraser4_College_Strike\Views\Members\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Assignment));

#line default
#line hidden
            EndContext();
            BeginContext(1392, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1436, 57, false);
#line 51 "D:\Graeme\Downloads\gfraser4_College_Strike\gfraser4_College_Strike\Views\Members\Details.cshtml"
       Write(Html.DisplayFor(model => model.Assignment.AssignmentName));

#line default
#line hidden
            EndContext();
            BeginContext(1493, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1540, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5e4a7b9344d14d35a64c37f4f0666280", async() => {
                BeginContext(1586, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 56 "D:\Graeme\Downloads\gfraser4_College_Strike\gfraser4_College_Strike\Views\Members\Details.cshtml"
                           WriteLiteral(Model.ID);

#line default
#line hidden
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
            EndContext();
            BeginContext(1594, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1602, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e7412807360148ff87ee8d887807281f", async() => {
                BeginContext(1624, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1640, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<gfraser4_College_Strike.Models.Member> Html { get; private set; }
    }
}
#pragma warning restore 1591