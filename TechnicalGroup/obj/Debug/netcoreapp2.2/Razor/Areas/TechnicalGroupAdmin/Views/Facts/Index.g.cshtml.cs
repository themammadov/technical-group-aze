#pragma checksum "C:\Users\User\source\repos\TechnicalGroup\TechnicalGroup\Areas\TechnicalGroupAdmin\Views\Facts\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ab6537572b61ddec26653768b0fc521078417c0a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_TechnicalGroupAdmin_Views_Facts_Index), @"mvc.1.0.view", @"/Areas/TechnicalGroupAdmin/Views/Facts/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/TechnicalGroupAdmin/Views/Facts/Index.cshtml", typeof(AspNetCore.Areas_TechnicalGroupAdmin_Views_Facts_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab6537572b61ddec26653768b0fc521078417c0a", @"/Areas/TechnicalGroupAdmin/Views/Facts/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a704437deccfb2078969bdb65c3683a80aff18c", @"/Areas/TechnicalGroupAdmin/Views/_ViewImports.cshtml")]
    public class Areas_TechnicalGroupAdmin_Views_Facts_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TechnicalGroup.Models.Facts>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/Screenshots/facts-ss.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Facts"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("w-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Facts", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-brand btn-elevate btn-icon-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("alert alert-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Dəyişdir"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("alert alert-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(49, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\User\source\repos\TechnicalGroup\TechnicalGroup\Areas\TechnicalGroupAdmin\Views\Facts\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/TechnicalGroupAdmin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
            BeginContext(170, 609, true);
            WriteLiteral(@"
<div class=""kt-content  kt-grid__item kt-grid__item--fluid kt-grid kt-grid--hor"" id=""kt_content"">
    <div class=""kt-container  kt-container--fluid  kt-grid__item kt-grid__item--fluid"">
        <div class=""alert alert-light alert-elevate"" role=""alert"">
            <div class=""alert-icon""><i class=""flaticon-warning kt-font-brand""></i></div>
            <div class=""alert-text"">
                Faktlar bölməsinin bəndlərinə misal olaraq aşağıda göstərilmiş şəkilə baxa bilərsiniz :
            </div>
        </div>
        <div class=""alert alert-light alert-elevate"" role=""alert"">

            ");
            EndContext();
            BeginContext(779, 73, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ab6537572b61ddec26653768b0fc521078417c0a8341", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(852, 760, true);
            WriteLiteral(@"
        </div>
        <hr />
        <div class=""kt-portlet kt-portlet--mobile"">

            <div class=""kt-portlet__head kt-portlet__head--lg"">
                <div class=""kt-portlet__head-label"">
                    <span class=""kt-portlet__head-icon"">
                        <i class=""fa fa-check-circle""></i>
                    </span>
                    <h3 class=""kt-portlet__head-title"">
                        Faktlar bölməsinin bəndləri
                    </h3>
                </div>
                <div class=""kt-portlet__head-toolbar"">
                    <div class=""kt-portlet__head-wrapper"">
                        <div class=""kt-portlet__head-actions"">
                            &nbsp;
                            ");
            EndContext();
            BeginContext(1612, 225, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ab6537572b61ddec26653768b0fc521078417c0a10454", async() => {
                BeginContext(1704, 129, true);
                WriteLiteral("\r\n                                <i class=\"la la-plus\"></i>\r\n                                Yarat\r\n                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1837, 2199, true);
            WriteLiteral(@"
                        </div>
                    </div>
                </div>
            </div>
            <div class=""kt-portlet__body"">
                <!--begin: Datatable -->
                <div id=""kt_table_1_wrapper"" class=""dataTables_wrapper dt-bootstrap4 no-footer"">
                    <div class=""row"">
                        <div class=""col-sm-12"">
                            <table class=""table table-striped- table-bordered table-hover table-checkable dataTable no-footer dtr-inline collapsed"" id=""kt_table_1"" role=""grid"" aria-describedby=""kt_table_1_info"" style=""width: 982px;"">
                                <thead>
                                    <tr role=""row"">
                                        <th class=""sorting"" tabindex=""0"" aria-controls=""kt_table_1"" rowspan=""1"" colspan=""1"" style=""width: 38.25px;"" aria-sort=""descending"" aria-label=""Order ID: activate to sort column ascending"">ID</th>
                                        <th class=""sorting"" tabindex=""0"" aria-co");
            WriteLiteral(@"ntrols=""kt_table_1"" rowspan=""1"" colspan=""1"" style=""width: 58.25px;"" aria-label=""Country: activate to sort column ascending"">Dəyər</th>
                                        <th class=""sorting"" tabindex=""0"" aria-controls=""kt_table_1"" rowspan=""1"" colspan=""1"" style=""width: 72.25px;"" aria-label=""Ship City: activate to sort column ascending"">Açar söz(AZE)</th>
                                        <th class=""sorting"" tabindex=""0"" aria-controls=""kt_table_1"" rowspan=""1"" colspan=""1"" style=""width: 90.25px;"" aria-label=""Ship Address: activate to sort column ascending"">Açar söz(RUS)</th>
                                        <th class=""sorting"" tabindex=""0"" aria-controls=""kt_table_1"" rowspan=""1"" colspan=""1"" style=""width: 75.25px;"" aria-label=""Company Agent: activate to sort column ascending"">Açar söz(ENG)</th>
                                        <th class=""sorting"" tabindex=""0"" aria-controls=""kt_table_1"" rowspan=""1"" colspan=""1"" style=""width: 75.25px;"" aria-label=""Company Agent: activate to sort column asce");
            WriteLiteral("nding\">Dəyiş/Sil</th>\r\n\r\n                                    </tr>\r\n                                </thead>\r\n                                <tbody>\r\n");
            EndContext();
#line 62 "C:\Users\User\source\repos\TechnicalGroup\TechnicalGroup\Areas\TechnicalGroupAdmin\Views\Facts\Index.cshtml"
                                     foreach (var fact in Model)
                                    {

#line default
#line hidden
            BeginContext(4141, 125, true);
            WriteLiteral("                                        <tr role=\"row\" class=\"odd admintr\">\r\n                                            <td>");
            EndContext();
            BeginContext(4267, 7, false);
#line 65 "C:\Users\User\source\repos\TechnicalGroup\TechnicalGroup\Areas\TechnicalGroupAdmin\Views\Facts\Index.cshtml"
                                           Write(fact.ID);

#line default
#line hidden
            EndContext();
            BeginContext(4274, 55, true);
            WriteLiteral("</td>\r\n                                            <td>");
            EndContext();
            BeginContext(4330, 8, false);
#line 66 "C:\Users\User\source\repos\TechnicalGroup\TechnicalGroup\Areas\TechnicalGroupAdmin\Views\Facts\Index.cshtml"
                                           Write(fact.Key);

#line default
#line hidden
            EndContext();
            BeginContext(4338, 55, true);
            WriteLiteral("</td>\r\n                                            <td>");
            EndContext();
            BeginContext(4394, 13, false);
#line 67 "C:\Users\User\source\repos\TechnicalGroup\TechnicalGroup\Areas\TechnicalGroupAdmin\Views\Facts\Index.cshtml"
                                           Write(fact.Value_Az);

#line default
#line hidden
            EndContext();
            BeginContext(4407, 55, true);
            WriteLiteral("</td>\r\n                                            <td>");
            EndContext();
            BeginContext(4463, 13, false);
#line 68 "C:\Users\User\source\repos\TechnicalGroup\TechnicalGroup\Areas\TechnicalGroupAdmin\Views\Facts\Index.cshtml"
                                           Write(fact.Value_Ru);

#line default
#line hidden
            EndContext();
            BeginContext(4476, 55, true);
            WriteLiteral("</td>\r\n                                            <td>");
            EndContext();
            BeginContext(4532, 10, false);
#line 69 "C:\Users\User\source\repos\TechnicalGroup\TechnicalGroup\Areas\TechnicalGroupAdmin\Views\Facts\Index.cshtml"
                                           Write(fact.Value);

#line default
#line hidden
            EndContext();
            BeginContext(4542, 105, true);
            WriteLiteral("</td>\r\n                                            <td>\r\n                                                ");
            EndContext();
            BeginContext(4647, 218, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ab6537572b61ddec26653768b0fc521078417c0a17386", async() => {
                BeginContext(4732, 129, true);
                WriteLiteral("\r\n                                                    <i class=\"fa fa-pen\"></i>\r\n                                                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 71 "C:\Users\User\source\repos\TechnicalGroup\TechnicalGroup\Areas\TechnicalGroupAdmin\Views\Facts\Index.cshtml"
                                                                       WriteLiteral(fact.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4865, 50, true);
            WriteLiteral("\r\n                                                ");
            EndContext();
            BeginContext(4915, 209, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ab6537572b61ddec26653768b0fc521078417c0a20122", async() => {
                BeginContext(4989, 131, true);
                WriteLiteral("\r\n                                                    <i class=\"fa fa-trash\"></i>\r\n                                                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 74 "C:\Users\User\source\repos\TechnicalGroup\TechnicalGroup\Areas\TechnicalGroupAdmin\Views\Facts\Index.cshtml"
                                                                         WriteLiteral(fact.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5124, 102, true);
            WriteLiteral("\r\n                                            </td>\r\n\r\n                                        </tr>\r\n");
            EndContext();
#line 80 "C:\Users\User\source\repos\TechnicalGroup\TechnicalGroup\Areas\TechnicalGroupAdmin\Views\Facts\Index.cshtml"
                                    }

#line default
#line hidden
            BeginContext(5265, 292, true);
            WriteLiteral(@"                                </tbody>

                            </table>
                        </div>
                    </div>

                </div>
                <!--end: Datatable -->
            </div>
        </div>
    </div>
    <!-- end:: Content -->
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TechnicalGroup.Models.Facts>> Html { get; private set; }
    }
}
#pragma warning restore 1591
