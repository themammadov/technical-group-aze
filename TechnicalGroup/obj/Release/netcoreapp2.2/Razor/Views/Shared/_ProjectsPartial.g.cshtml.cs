#pragma checksum "C:\Users\User\source\repos\TechnicalGroup\TechnicalGroup\Views\Shared\_ProjectsPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f0834a1209fad7c3745a753ab92d1f42c81224a4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ProjectsPartial), @"mvc.1.0.view", @"/Views/Shared/_ProjectsPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_ProjectsPartial.cshtml", typeof(AspNetCore.Views_Shared__ProjectsPartial))]
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
#line 1 "C:\Users\User\source\repos\TechnicalGroup\TechnicalGroup\Views\_ViewImports.cshtml"
using TechnicalGroup;

#line default
#line hidden
#line 2 "C:\Users\User\source\repos\TechnicalGroup\TechnicalGroup\Views\_ViewImports.cshtml"
using TechnicalGroup.Models;

#line default
#line hidden
#line 3 "C:\Users\User\source\repos\TechnicalGroup\TechnicalGroup\Views\_ViewImports.cshtml"
using TechnicalGroup.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0834a1209fad7c3745a753ab92d1f42c81224a4", @"/Views/Shared/_ProjectsPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89107b455137d54c0b49ef167d43fcaa32a4a628", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ProjectsPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Projects>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ProjectDetail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\User\source\repos\TechnicalGroup\TechnicalGroup\Views\Shared\_ProjectsPartial.cshtml"
 foreach (var project in Model)
{

#line default
#line hidden
            BeginContext(68, 73, true);
            WriteLiteral("    <div class=\"col-lg-4 col-md-6\">\r\n        <div class=\"single-works\">\r\n");
            EndContext();
#line 7 "C:\Users\User\source\repos\TechnicalGroup\TechnicalGroup\Views\Shared\_ProjectsPartial.cshtml"
             if (project.ProjectPhotos != null && project.ProjectPhotos.Count > 0)
            {

#line default
#line hidden
            BeginContext(240, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(256, 157, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f0834a1209fad7c3745a753ab92d1f42c81224a44921", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 266, "~/images/Projects/", 266, 18, true);
#line 9 "C:\Users\User\source\repos\TechnicalGroup\TechnicalGroup\Views\Shared\_ProjectsPartial.cshtml"
AddHtmlAttributeValue("", 284, project.ProjectPhotos.FirstOrDefault()!=null?project.ProjectPhotos.FirstOrDefault().Photo:"", 284, 95, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 9 "C:\Users\User\source\repos\TechnicalGroup\TechnicalGroup\Views\Shared\_ProjectsPartial.cshtml"
AddHtmlAttributeValue("", 386, project.LittleContent_Az, 386, 25, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(413, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 10 "C:\Users\User\source\repos\TechnicalGroup\TechnicalGroup\Views\Shared\_ProjectsPartial.cshtml"
            }

#line default
#line hidden
            BeginContext(430, 85, true);
            WriteLiteral("\r\n            <div class=\"works-content\">\r\n                <h3>\r\n                    ");
            EndContext();
            BeginContext(515, 567, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f0834a1209fad7c3745a753ab92d1f42c81224a47393", async() => {
                BeginContext(594, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 15 "C:\Users\User\source\repos\TechnicalGroup\TechnicalGroup\Views\Shared\_ProjectsPartial.cshtml"
                         if (ViewBag.lang == "az")
                        {
                            

#line default
#line hidden
                BeginContext(704, 24, false);
#line 17 "C:\Users\User\source\repos\TechnicalGroup\TechnicalGroup\Views\Shared\_ProjectsPartial.cshtml"
                       Write(project.LittleContent_Az);

#line default
#line hidden
                EndContext();
#line 17 "C:\Users\User\source\repos\TechnicalGroup\TechnicalGroup\Views\Shared\_ProjectsPartial.cshtml"
                                                     
                        }
                        else if (ViewBag.lang == "ru")
                        {
                            

#line default
#line hidden
                BeginContext(869, 24, false);
#line 21 "C:\Users\User\source\repos\TechnicalGroup\TechnicalGroup\Views\Shared\_ProjectsPartial.cshtml"
                       Write(project.LittleContent_Ru);

#line default
#line hidden
                EndContext();
#line 21 "C:\Users\User\source\repos\TechnicalGroup\TechnicalGroup\Views\Shared\_ProjectsPartial.cshtml"
                                                     
                        }
                        else
                        {
                            

#line default
#line hidden
                BeginContext(1008, 21, false);
#line 25 "C:\Users\User\source\repos\TechnicalGroup\TechnicalGroup\Views\Shared\_ProjectsPartial.cshtml"
                       Write(project.LittleContent);

#line default
#line hidden
                EndContext();
#line 25 "C:\Users\User\source\repos\TechnicalGroup\TechnicalGroup\Views\Shared\_ProjectsPartial.cshtml"
                                                  
                        }

#line default
#line hidden
                BeginContext(1058, 20, true);
                WriteLiteral("                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 14 "C:\Users\User\source\repos\TechnicalGroup\TechnicalGroup\Views\Shared\_ProjectsPartial.cshtml"
                                                                          WriteLiteral(project.ID);

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
            BeginContext(1082, 46, true);
            WriteLiteral("\r\n                </h3>\r\n                <p>\r\n");
            EndContext();
#line 30 "C:\Users\User\source\repos\TechnicalGroup\TechnicalGroup\Views\Shared\_ProjectsPartial.cshtml"
                     if (ViewBag.lang == "az")
                    {
                        

#line default
#line hidden
            BeginContext(1224, 32, false);
#line 32 "C:\Users\User\source\repos\TechnicalGroup\TechnicalGroup\Views\Shared\_ProjectsPartial.cshtml"
                   Write(Html.Raw(project.Description_Az));

#line default
#line hidden
            EndContext();
#line 32 "C:\Users\User\source\repos\TechnicalGroup\TechnicalGroup\Views\Shared\_ProjectsPartial.cshtml"
                                                         
                    }
                    else if (ViewBag.lang == "ru")
                    {
                        

#line default
#line hidden
            BeginContext(1381, 32, false);
#line 36 "C:\Users\User\source\repos\TechnicalGroup\TechnicalGroup\Views\Shared\_ProjectsPartial.cshtml"
                   Write(Html.Raw(project.Description_Ru));

#line default
#line hidden
            EndContext();
#line 36 "C:\Users\User\source\repos\TechnicalGroup\TechnicalGroup\Views\Shared\_ProjectsPartial.cshtml"
                                                         
                    }
                    else
                    {
                        

#line default
#line hidden
            BeginContext(1512, 29, false);
#line 40 "C:\Users\User\source\repos\TechnicalGroup\TechnicalGroup\Views\Shared\_ProjectsPartial.cshtml"
                   Write(Html.Raw(project.Description));

#line default
#line hidden
            EndContext();
#line 40 "C:\Users\User\source\repos\TechnicalGroup\TechnicalGroup\Views\Shared\_ProjectsPartial.cshtml"
                                                      
                    }

#line default
#line hidden
            BeginContext(1566, 70, true);
            WriteLiteral("                </p>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 46 "C:\Users\User\source\repos\TechnicalGroup\TechnicalGroup\Views\Shared\_ProjectsPartial.cshtml"

}

#line default
#line hidden
            BeginContext(1641, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Projects>> Html { get; private set; }
    }
}
#pragma warning restore 1591
