#pragma checksum "C:\Users\User\source\repos\TechnicalGroup\TechnicalGroup\Areas\TechnicalGroupAdmin\Views\Settings\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0401df559354364bab614a2b3d0c77f63b3d40a4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_TechnicalGroupAdmin_Views_Settings_Index), @"mvc.1.0.view", @"/Areas/TechnicalGroupAdmin/Views/Settings/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/TechnicalGroupAdmin/Views/Settings/Index.cshtml", typeof(AspNetCore.Areas_TechnicalGroupAdmin_Views_Settings_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0401df559354364bab614a2b3d0c77f63b3d40a4", @"/Areas/TechnicalGroupAdmin/Views/Settings/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a704437deccfb2078969bdb65c3683a80aff18c", @"/Areas/TechnicalGroupAdmin/Views/_ViewImports.cshtml")]
    public class Areas_TechnicalGroupAdmin_Views_Settings_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TechnicalGroup.Models.Settings>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Alternate Text"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:150px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("alert alert-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Dəyişdir"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(52, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\User\source\repos\TechnicalGroup\TechnicalGroup\Areas\TechnicalGroupAdmin\Views\Settings\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/TechnicalGroupAdmin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
            BeginContext(173, 3700, true);
            WriteLiteral(@"
<style>
    .sorting {
        font-weight: 600 !important;
    }
</style>
<div class=""kt-content  kt-grid__item kt-grid__item--fluid kt-grid kt-grid--hor"" id=""kt_content"">
    <div class=""kt-container  kt-container--fluid  kt-grid__item kt-grid__item--fluid"">
        <div class=""alert alert-light alert-elevate"" role=""alert"">
            <div class=""alert-icon""><i class=""flaticon-warning kt-font-brand""></i></div>
            <div class=""alert-text"">
                <strong>Qeyd :</strong>  Saytın statik hissələri dedikdə saytda sadəcə redaktə oluna bilən hissələrdir , yəni yenisi yaradılmır .
            </div>
        </div>
        <hr />
        <div class=""kt-portlet kt-portlet--mobile"">

            <div class=""kt-portlet__head kt-portlet__head--lg"">
                <div class=""kt-portlet__head-label"">
                    <span class=""kt-portlet__head-icon"">
                        <i class=""fa fa-cog""></i>
                    </span>
                    <h3 class=""kt-portlet__head");
            WriteLiteral(@"-title"">
                        Statik hissələr
                    </h3>
                </div>
               
            </div>
            <div class=""kt-portlet__body"" style=""overflow-x:scroll"">
                <div id=""kt_table_1_wrapper"" class=""dataTables_wrapper dt-bootstrap4 no-footer"">
                    <div class=""row"">
                        <div class=""col-sm-12"">
                            <div class=""table-responsive-"">
                                <table class=""table table-striped table-bordered table-hover table-checkable dataTable no-footer dtr-inline collapsed"" id=""kt_table_1"" role=""grid"" aria-describedby=""kt_table_1_info"" style=""width: 982px;"">
                                    <thead>
                                        <tr role=""row"">
                                            <th class=""sorting"" tabindex=""0"" aria-controls=""kt_table_1"" rowspan=""1"" colspan=""1"">ID</th>
                                            <th class=""sorting"" tabindex=""0"" aria-controls=");
            WriteLiteral(@"""kt_table_1"" rowspan=""1"" colspan=""1"">Logo</th>
                                            <th class=""sorting"" tabindex=""0"" aria-controls=""kt_table_1"" rowspan=""1"" colspan=""1"">E-poçt</th>
                                            <th class=""sorting"" tabindex=""0"" aria-controls=""kt_table_1"" rowspan=""1"" colspan=""1"">Əlaqə №</th>

                                            <th class=""sorting"" tabindex=""0"" aria-controls=""kt_table_1"" rowspan=""1"" colspan=""1"">Adres</th>
                                            <th class=""sorting"" tabindex=""0"" aria-controls=""kt_table_1"" rowspan=""1"" colspan=""1"">Haqqımızda (AZE)</th>
                                            <th class=""sorting"" tabindex=""0"" aria-controls=""kt_table_1"" rowspan=""1"" colspan=""1"">Haqqımızda (RUS)</th>
                                            <th class=""sorting"" tabindex=""0"" aria-controls=""kt_table_1"" rowspan=""1"" colspan=""1"">Haqqımızda (ENG)</th>
                                            <th class=""sorting"" tabindex=""0"" aria-controls=""kt_tab");
            WriteLiteral(@"le_1"" rowspan=""1"" colspan=""1"">Pankart (AZE)</th>
                                            <th class=""sorting"" tabindex=""0"" aria-controls=""kt_table_1"" rowspan=""1"" colspan=""1"">Pankart (RUS)</th>
                                            <th class=""sorting"" tabindex=""0"" aria-controls=""kt_table_1"" rowspan=""1"" colspan=""1"">Pankart (ENG)</th>
                                            <th class=""sorting"" tabindex=""0"" aria-controls=""kt_table_1"" rowspan=""1"" colspan=""1"">Dəyiş/Sil</th>
                                        </tr>
                                    </thead>
                                    <tbody>
");
            EndContext();
#line 59 "C:\Users\User\source\repos\TechnicalGroup\TechnicalGroup\Areas\TechnicalGroupAdmin\Views\Settings\Index.cshtml"
                                         foreach (var setting in Model)
                                        {

#line default
#line hidden
            BeginContext(3989, 125, true);
            WriteLiteral("                                        <tr role=\"row\" class=\"odd admintr\">\r\n                                            <td>");
            EndContext();
            BeginContext(4115, 10, false);
#line 62 "C:\Users\User\source\repos\TechnicalGroup\TechnicalGroup\Areas\TechnicalGroupAdmin\Views\Settings\Index.cshtml"
                                           Write(setting.ID);

#line default
#line hidden
            EndContext();
            BeginContext(4125, 105, true);
            WriteLiteral("</td>\r\n                                            <td>\r\n                                                ");
            EndContext();
            BeginContext(4230, 82, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0401df559354364bab614a2b3d0c77f63b3d40a410716", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4240, "~/images/", 4240, 9, true);
#line 64 "C:\Users\User\source\repos\TechnicalGroup\TechnicalGroup\Areas\TechnicalGroupAdmin\Views\Settings\Index.cshtml"
AddHtmlAttributeValue("", 4249, setting.SiteLogo, 4249, 17, false);

#line default
#line hidden
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
            EndContext();
            BeginContext(4312, 101, true);
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>");
            EndContext();
            BeginContext(4414, 20, false);
#line 66 "C:\Users\User\source\repos\TechnicalGroup\TechnicalGroup\Areas\TechnicalGroupAdmin\Views\Settings\Index.cshtml"
                                           Write(setting.ContactEmail);

#line default
#line hidden
            EndContext();
            BeginContext(4434, 55, true);
            WriteLiteral("</td>\r\n                                            <td>");
            EndContext();
            BeginContext(4490, 20, false);
#line 67 "C:\Users\User\source\repos\TechnicalGroup\TechnicalGroup\Areas\TechnicalGroupAdmin\Views\Settings\Index.cshtml"
                                           Write(setting.ContactPhone);

#line default
#line hidden
            EndContext();
            BeginContext(4510, 55, true);
            WriteLiteral("</td>\r\n                                            <td>");
            EndContext();
            BeginContext(4566, 22, false);
#line 68 "C:\Users\User\source\repos\TechnicalGroup\TechnicalGroup\Areas\TechnicalGroupAdmin\Views\Settings\Index.cshtml"
                                           Write(setting.ContactAddress);

#line default
#line hidden
            EndContext();
            BeginContext(4588, 55, true);
            WriteLiteral("</td>\r\n                                            <td>");
            EndContext();
            BeginContext(4644, 38, false);
#line 69 "C:\Users\User\source\repos\TechnicalGroup\TechnicalGroup\Areas\TechnicalGroupAdmin\Views\Settings\Index.cshtml"
                                           Write(setting.AboutDesc_Az.Substring(0, 145));

#line default
#line hidden
            EndContext();
            BeginContext(4682, 58, true);
            WriteLiteral("...</td>\r\n                                            <td>");
            EndContext();
            BeginContext(4741, 38, false);
#line 70 "C:\Users\User\source\repos\TechnicalGroup\TechnicalGroup\Areas\TechnicalGroupAdmin\Views\Settings\Index.cshtml"
                                           Write(setting.AboutDesc_Ru.Substring(0, 145));

#line default
#line hidden
            EndContext();
            BeginContext(4779, 58, true);
            WriteLiteral("...</td>\r\n                                            <td>");
            EndContext();
            BeginContext(4838, 35, false);
#line 71 "C:\Users\User\source\repos\TechnicalGroup\TechnicalGroup\Areas\TechnicalGroupAdmin\Views\Settings\Index.cshtml"
                                           Write(setting.AboutDesc.Substring(0, 145));

#line default
#line hidden
            EndContext();
            BeginContext(4873, 58, true);
            WriteLiteral("...</td>\r\n                                            <td>");
            EndContext();
            BeginContext(4932, 26, false);
#line 72 "C:\Users\User\source\repos\TechnicalGroup\TechnicalGroup\Areas\TechnicalGroupAdmin\Views\Settings\Index.cshtml"
                                           Write(setting.MainBannerTitle_Az);

#line default
#line hidden
            EndContext();
            BeginContext(4958, 55, true);
            WriteLiteral("</td>\r\n                                            <td>");
            EndContext();
            BeginContext(5014, 26, false);
#line 73 "C:\Users\User\source\repos\TechnicalGroup\TechnicalGroup\Areas\TechnicalGroupAdmin\Views\Settings\Index.cshtml"
                                           Write(setting.MainBannerTitle_Ru);

#line default
#line hidden
            EndContext();
            BeginContext(5040, 55, true);
            WriteLiteral("</td>\r\n                                            <td>");
            EndContext();
            BeginContext(5096, 23, false);
#line 74 "C:\Users\User\source\repos\TechnicalGroup\TechnicalGroup\Areas\TechnicalGroupAdmin\Views\Settings\Index.cshtml"
                                           Write(setting.MainBannerTitle);

#line default
#line hidden
            EndContext();
            BeginContext(5119, 105, true);
            WriteLiteral("</td>\r\n                                            <td>\r\n                                                ");
            EndContext();
            BeginContext(5224, 221, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0401df559354364bab614a2b3d0c77f63b3d40a416839", async() => {
                BeginContext(5312, 129, true);
                WriteLiteral("\r\n                                                    <i class=\"fa fa-pen\"></i>\r\n                                                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 76 "C:\Users\User\source\repos\TechnicalGroup\TechnicalGroup\Areas\TechnicalGroupAdmin\Views\Settings\Index.cshtml"
                                                                       WriteLiteral(setting.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(5445, 102, true);
            WriteLiteral("\r\n                                            </td>\r\n\r\n                                        </tr>\r\n");
            EndContext();
#line 82 "C:\Users\User\source\repos\TechnicalGroup\TechnicalGroup\Areas\TechnicalGroupAdmin\Views\Settings\Index.cshtml"
                                        }

#line default
#line hidden
            BeginContext(5590, 293, true);
            WriteLiteral(@"                                    </tbody>

                                </table>
    
                            </div>
                        </div>
                    </div>

                </div>
              
            </div>
        </div>
    </div>
   
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TechnicalGroup.Models.Settings>> Html { get; private set; }
    }
}
#pragma warning restore 1591
