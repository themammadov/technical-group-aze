#pragma checksum "C:\Users\User\source\repos\TechnicalGroup\TechnicalGroup\Areas\TechnicalGroupAdmin\Views\Projects\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4564a23ab7c537f4551f507ecc409ad39f625a56"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_TechnicalGroupAdmin_Views_Projects_Details), @"mvc.1.0.view", @"/Areas/TechnicalGroupAdmin/Views/Projects/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/TechnicalGroupAdmin/Views/Projects/Details.cshtml", typeof(AspNetCore.Areas_TechnicalGroupAdmin_Views_Projects_Details))]
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
#line 1 "C:\Users\User\source\repos\TechnicalGroup\TechnicalGroup\Areas\TechnicalGroupAdmin\Views\_ViewImports.cshtml"
using TechnicalGroup;

#line default
#line hidden
#line 2 "C:\Users\User\source\repos\TechnicalGroup\TechnicalGroup\Areas\TechnicalGroupAdmin\Views\_ViewImports.cshtml"
using TechnicalGroup.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4564a23ab7c537f4551f507ecc409ad39f625a56", @"/Areas/TechnicalGroupAdmin/Views/Projects/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a704437deccfb2078969bdb65c3683a80aff18c", @"/Areas/TechnicalGroupAdmin/Views/_ViewImports.cshtml")]
    public class Areas_TechnicalGroupAdmin_Views_Projects_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TechnicalGroup.Areas.TechnicalGroupAdmin.Models.AdminVM.VMProjectPhotos>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-thumbnail img-shadow multi-image-img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:250px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-block btn-lg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin: 30px 0;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(80, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\User\source\repos\TechnicalGroup\TechnicalGroup\Areas\TechnicalGroupAdmin\Views\Projects\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Areas/TechnicalGroupAdmin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
            BeginContext(203, 393, true);
            WriteLiteral(@"<div id=""kt_content"" class=""kt-content  kt-grid__item kt-grid__item--fluid kt-grid kt-grid--hor"" style=""background:white !important"">
    <h3 class=""text-center text-danger"">Proyektlər haqqında detallı</h3>
    <hr />
    <div class=""container-fluid"">
        <div class=""col-12 image-col"">
            <h3><b>Proyektin şəkli :</b></h3>
            <ul class=""d-flex multi-image-ul"">

");
            EndContext();
#line 15 "C:\Users\User\source\repos\TechnicalGroup\TechnicalGroup\Areas\TechnicalGroupAdmin\Views\Projects\Details.cshtml"
                 foreach (var photos in Model.Photos)
                {

#line default
#line hidden
            BeginContext(670, 73, true);
            WriteLiteral("                    <li class=\"multi-image-li\">\r\n                        ");
            EndContext();
            BeginContext(743, 116, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4564a23ab7c537f4551f507ecc409ad39f625a566656", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 802, "~/images/Projects/", 802, 18, true);
#line 18 "C:\Users\User\source\repos\TechnicalGroup\TechnicalGroup\Areas\TechnicalGroupAdmin\Views\Projects\Details.cshtml"
AddHtmlAttributeValue("", 820, photos.Photo, 820, 15, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(859, 31, true);
            WriteLiteral("\r\n\r\n                    </li>\r\n");
            EndContext();
#line 21 "C:\Users\User\source\repos\TechnicalGroup\TechnicalGroup\Areas\TechnicalGroupAdmin\Views\Projects\Details.cshtml"
                }

#line default
#line hidden
            BeginContext(909, 108, true);
            WriteLiteral("            </ul>\r\n        </div>\r\n        <div class=\"col-12\">\r\n            <p><b>Kiçik məzmun (AZE)</b> - ");
            EndContext();
            BeginContext(1018, 30, false);
#line 25 "C:\Users\User\source\repos\TechnicalGroup\TechnicalGroup\Areas\TechnicalGroupAdmin\Views\Projects\Details.cshtml"
                                      Write(Model.Project.LittleContent_Az);

#line default
#line hidden
            EndContext();
            BeginContext(1048, 95, true);
            WriteLiteral("</p>\r\n        </div>\r\n        <div class=\"col-12\">\r\n            <p><b>Kiçik məzmun (RUS)</b> - ");
            EndContext();
            BeginContext(1144, 30, false);
#line 28 "C:\Users\User\source\repos\TechnicalGroup\TechnicalGroup\Areas\TechnicalGroupAdmin\Views\Projects\Details.cshtml"
                                      Write(Model.Project.LittleContent_Ru);

#line default
#line hidden
            EndContext();
            BeginContext(1174, 95, true);
            WriteLiteral("</p>\r\n        </div>\r\n        <div class=\"col-12\">\r\n            <p><b>Kiçik məzmun (ENG)</b> - ");
            EndContext();
            BeginContext(1270, 27, false);
#line 31 "C:\Users\User\source\repos\TechnicalGroup\TechnicalGroup\Areas\TechnicalGroupAdmin\Views\Projects\Details.cshtml"
                                      Write(Model.Project.LittleContent);

#line default
#line hidden
            EndContext();
            BeginContext(1297, 90, true);
            WriteLiteral("</p>\r\n        </div>\r\n        <div class=\"col-12\">\r\n            <p><b>Ətraflı (AZE)</b> - ");
            EndContext();
            BeginContext(1388, 38, false);
#line 34 "C:\Users\User\source\repos\TechnicalGroup\TechnicalGroup\Areas\TechnicalGroupAdmin\Views\Projects\Details.cshtml"
                                 Write(Html.Raw(Model.Project.Description_Az));

#line default
#line hidden
            EndContext();
            BeginContext(1426, 90, true);
            WriteLiteral("</p>\r\n        </div>\r\n        <div class=\"col-12\">\r\n            <p><b>Ətraflı (RUS)</b> - ");
            EndContext();
            BeginContext(1517, 38, false);
#line 37 "C:\Users\User\source\repos\TechnicalGroup\TechnicalGroup\Areas\TechnicalGroupAdmin\Views\Projects\Details.cshtml"
                                 Write(Html.Raw(Model.Project.Description_Ru));

#line default
#line hidden
            EndContext();
            BeginContext(1555, 90, true);
            WriteLiteral("</p>\r\n        </div>\r\n        <div class=\"col-12\">\r\n            <p><b>Ətraflı (ENG)</b> - ");
            EndContext();
            BeginContext(1646, 35, false);
#line 40 "C:\Users\User\source\repos\TechnicalGroup\TechnicalGroup\Areas\TechnicalGroupAdmin\Views\Projects\Details.cshtml"
                                 Write(Html.Raw(Model.Project.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1681, 80, true);
            WriteLiteral("</p>\r\n        </div>\r\n    </div>\r\n    <hr />\r\n</div>\r\n<div class=\"col-12\">\r\n    ");
            EndContext();
            BeginContext(1761, 162, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4564a23ab7c537f4551f507ecc409ad39f625a5611903", async() => {
                BeginContext(1848, 71, true);
                WriteLiteral("\r\n        <i class=\"fas fa-long-arrow-alt-left\"></i> Geriyə qayıt\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1923, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TechnicalGroup.Areas.TechnicalGroupAdmin.Models.AdminVM.VMProjectPhotos> Html { get; private set; }
    }
}
#pragma warning restore 1591