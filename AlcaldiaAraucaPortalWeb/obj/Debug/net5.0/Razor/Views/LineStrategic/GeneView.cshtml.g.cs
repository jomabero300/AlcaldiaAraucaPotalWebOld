#pragma checksum "C:\Mbel\AlcaldiaAraucaPortalWeb\AlcaldiaAraucaPortalWeb\Views\LineStrategic\GeneView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef8c7a1209dc00afd24347b7f83b91af78b55cc2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LineStrategic_GeneView), @"mvc.1.0.view", @"/Views/LineStrategic/GeneView.cshtml")]
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
#line 1 "C:\Mbel\AlcaldiaAraucaPortalWeb\AlcaldiaAraucaPortalWeb\Views\_ViewImports.cshtml"
using AlcaldiaAraucaPortalWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Mbel\AlcaldiaAraucaPortalWeb\AlcaldiaAraucaPortalWeb\Views\_ViewImports.cshtml"
using AlcaldiaAraucaPortalWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef8c7a1209dc00afd24347b7f83b91af78b55cc2", @"/Views/LineStrategic/GeneView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f21565cfdda8f56a5e6e3a1e6d89d5ce40c98a3", @"/Views/_ViewImports.cshtml")]
    public class Views_LineStrategic_GeneView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AlcaldiaAraucaPortalWeb.Models.ModelsViewCont.ContentGeneViewModels>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GeneViewHorizontalDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-outline-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Mbel\AlcaldiaAraucaPortalWeb\AlcaldiaAraucaPortalWeb\Views\LineStrategic\GeneView.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ef8c7a1209dc00afd24347b7f83b91af78b55cc24257", async() => {
                WriteLiteral("\r\n    <section>\r\n        <h1>");
#nullable restore
#line 9 "C:\Mbel\AlcaldiaAraucaPortalWeb\AlcaldiaAraucaPortalWeb\Views\LineStrategic\GeneView.cshtml"
       Write(ViewBag.TituloHead);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1>\r\n        <p>");
#nullable restore
#line 10 "C:\Mbel\AlcaldiaAraucaPortalWeb\AlcaldiaAraucaPortalWeb\Views\LineStrategic\GeneView.cshtml"
      Write(ViewBag.SubTituloHead);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n\r\n    </section>\r\n    <section>\r\n");
#nullable restore
#line 14 "C:\Mbel\AlcaldiaAraucaPortalWeb\AlcaldiaAraucaPortalWeb\Views\LineStrategic\GeneView.cshtml"
         foreach (var item in Model.ContentOds)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div class=\"row text-center\">\r\n");
                WriteLiteral("                <div class=\"col-2 justify-content-start\">\r\n                    <a");
                BeginWriteAttribute("href", " href=\"", 816, "\"", 842, 1);
#nullable restore
#line 24 "C:\Mbel\AlcaldiaAraucaPortalWeb\AlcaldiaAraucaPortalWeb\Views\LineStrategic\GeneView.cshtml"
WriteAttributeValue("", 823, item.ContentOdsUrl, 823, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("title", " title=\"", 843, "\"", 851, 0);
                EndWriteAttribute();
                WriteLiteral(" target=\"_blank\"><img");
                BeginWriteAttribute("src", " src=\"", 873, "\"", 911, 1);
#nullable restore
#line 24 "C:\Mbel\AlcaldiaAraucaPortalWeb\AlcaldiaAraucaPortalWeb\Views\LineStrategic\GeneView.cshtml"
WriteAttributeValue("", 879, Url.Content(item.ContentOdsImg), 879, 32, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" width=\"100\" height=\"100\" class=\"img-fluid\" /></a>\r\n                </div>\r\n                <div class=\"col-8\">\r\n                    <p>");
#nullable restore
#line 27 "C:\Mbel\AlcaldiaAraucaPortalWeb\AlcaldiaAraucaPortalWeb\Views\LineStrategic\GeneView.cshtml"
                  Write(item.ContentOdsText);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                </div>\r\n\r\n            </div>\r\n");
#nullable restore
#line 31 "C:\Mbel\AlcaldiaAraucaPortalWeb\AlcaldiaAraucaPortalWeb\Views\LineStrategic\GeneView.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </section>\r\n    <section>\r\n        <div class=\"row d-flex justify-content-center text-center g-0\">\r\n");
#nullable restore
#line 35 "C:\Mbel\AlcaldiaAraucaPortalWeb\AlcaldiaAraucaPortalWeb\Views\LineStrategic\GeneView.cshtml"
             foreach (var item in Model.Contents)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <div class=\"card\" style=\"width:20em;margin:10px;\">\r\n                    <img");
                BeginWriteAttribute("src", " src=\"", 1393, "\"", 1408, 1);
#nullable restore
#line 38 "C:\Mbel\AlcaldiaAraucaPortalWeb\AlcaldiaAraucaPortalWeb\Views\LineStrategic\GeneView.cshtml"
WriteAttributeValue("", 1399, item.img, 1399, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"card-img-top\" />\r\n                    <div class=\"card-body\">\r\n                        <h4 class=\"card-title\">");
#nullable restore
#line 40 "C:\Mbel\AlcaldiaAraucaPortalWeb\AlcaldiaAraucaPortalWeb\Views\LineStrategic\GeneView.cshtml"
                                          Write(item.title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>\r\n                        <p class=\"card-text text-justify\">");
#nullable restore
#line 41 "C:\Mbel\AlcaldiaAraucaPortalWeb\AlcaldiaAraucaPortalWeb\Views\LineStrategic\GeneView.cshtml"
                                                     Write(item.text);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ef8c7a1209dc00afd24347b7f83b91af78b55cc28792", async() => {
                    WriteLiteral("Ver..");
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
#nullable restore
#line 42 "C:\Mbel\AlcaldiaAraucaPortalWeb\AlcaldiaAraucaPortalWeb\Views\LineStrategic\GeneView.cshtml"
                                                                    WriteLiteral(item.url);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 45 "C:\Mbel\AlcaldiaAraucaPortalWeb\AlcaldiaAraucaPortalWeb\Views\LineStrategic\GeneView.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </div>\r\n    </section>\r\n    <footer>\r\n        <h4 style=\"color:white;\">Avisos legales</h4>\r\n        <a href=\"#\">Política de cookies</a>\r\n    </footer>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AlcaldiaAraucaPortalWeb.Models.ModelsViewCont.ContentGeneViewModels> Html { get; private set; }
    }
}
#pragma warning restore 1591
