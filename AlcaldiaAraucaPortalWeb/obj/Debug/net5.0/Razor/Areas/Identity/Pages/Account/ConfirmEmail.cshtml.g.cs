#pragma checksum "C:\Mbel\DanielCorregida\AlcaldiaAraucaPortalWeb\AlcaldiaAraucaPortalWeb\Areas\Identity\Pages\Account\ConfirmEmail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "928a3fe7657c8589890bf93f4188018e24c60b99"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages_Account_ConfirmEmail), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/ConfirmEmail.cshtml")]
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
#line 1 "C:\Mbel\DanielCorregida\AlcaldiaAraucaPortalWeb\AlcaldiaAraucaPortalWeb\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Mbel\DanielCorregida\AlcaldiaAraucaPortalWeb\AlcaldiaAraucaPortalWeb\Areas\Identity\Pages\_ViewImports.cshtml"
using AlcaldiaAraucaPortalWeb.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Mbel\DanielCorregida\AlcaldiaAraucaPortalWeb\AlcaldiaAraucaPortalWeb\Areas\Identity\Pages\_ViewImports.cshtml"
using AlcaldiaAraucaPortalWeb.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Mbel\DanielCorregida\AlcaldiaAraucaPortalWeb\AlcaldiaAraucaPortalWeb\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using AlcaldiaAraucaPortalWeb.Areas.Identity.Pages.Account;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"928a3fe7657c8589890bf93f4188018e24c60b99", @"/Areas/Identity/Pages/Account/ConfirmEmail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e23000c4e50ca4c8d2391506ea1e4fc3d4630313", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de088e9dda74cf928611a1a7d9117e917ecbb5bd", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_ConfirmEmail : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Mbel\DanielCorregida\AlcaldiaAraucaPortalWeb\AlcaldiaAraucaPortalWeb\Areas\Identity\Pages\Account\ConfirmEmail.cshtml"
  
    ViewData["Title"] = "Correo electrónico confirmado";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 7 "C:\Mbel\DanielCorregida\AlcaldiaAraucaPortalWeb\AlcaldiaAraucaPortalWeb\Areas\Identity\Pages\Account\ConfirmEmail.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
<h2>""Su registro esta realizado y tiene una cuenta en Araucactiva.com""</h2>
<h2>""Puede modificar su perfil al hacer clic sobre su correo.""</h2>
<h2>""Seleccione Registrarse - menu Gestión - opción Afiliado""</h2>
<h2>""Y actualice sus datos respectivos.""</h2>
<h2>""Ya puede realizar PQRS (Peticiones, Quejas, Reclamos y Sugerencias)""</h2>
<h2>""Asi como Propuestas detalladas""</h2>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ConfirmEmailModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ConfirmEmailModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ConfirmEmailModel>)PageContext?.ViewData;
        public ConfirmEmailModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
