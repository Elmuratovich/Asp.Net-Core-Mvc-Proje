#pragma checksum "D:\NewProje\Asp.Net-Core-Mvc-Proje\ProjeCore\Views\Personelim\PersonelGetir.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "95a1df86c2183434351efc5d196a2b217d40052a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Personelim_PersonelGetir), @"mvc.1.0.view", @"/Views/Personelim/PersonelGetir.cshtml")]
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
#line 1 "D:\NewProje\Asp.Net-Core-Mvc-Proje\ProjeCore\Views\_ViewImports.cshtml"
using ProjeCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\NewProje\Asp.Net-Core-Mvc-Proje\ProjeCore\Views\_ViewImports.cshtml"
using ProjeCore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95a1df86c2183434351efc5d196a2b217d40052a", @"/Views/Personelim/PersonelGetir.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f6887fc2a081498e457a98abd035f4ecf5faaf7", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Personelim_PersonelGetir : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjeCore.Models.Personel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\NewProje\Asp.Net-Core-Mvc-Proje\ProjeCore\Views\Personelim\PersonelGetir.cshtml"
  
    ViewData["Title"] = "PersonelGetir";
    Layout = "~/Views/Shared/_TestLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Мугалимди өзгөртүү</h2>\r\n\r\n\r\n");
#nullable restore
#line 11 "D:\NewProje\Asp.Net-Core-Mvc-Proje\ProjeCore\Views\Personelim\PersonelGetir.cshtml"
 using (Html.BeginForm("PersonelGetir", "Personelim", FormMethod.Post)){

#line default
#line hidden
#nullable disable
            WriteLiteral("    <b>Мугалим ID</b>\r\n");
#nullable restore
#line 13 "D:\NewProje\Asp.Net-Core-Mvc-Proje\ProjeCore\Views\Personelim\PersonelGetir.cshtml"
Write(Html.TextBoxFor(x => x.PersonelID, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br>\r\n    <b>Мугалимдин аты</b>\r\n");
#nullable restore
#line 16 "D:\NewProje\Asp.Net-Core-Mvc-Proje\ProjeCore\Views\Personelim\PersonelGetir.cshtml"
Write(Html.TextBoxFor(x => x.Ad, new { @class="form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <b>Мугалимдин фамилясы</b>\r\n");
#nullable restore
#line 19 "D:\NewProje\Asp.Net-Core-Mvc-Proje\ProjeCore\Views\Personelim\PersonelGetir.cshtml"
Write(Html.TextBoxFor(x => x.Soyad, new { @class="form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <b>Мугалимдин шаары</b>\r\n");
#nullable restore
#line 22 "D:\NewProje\Asp.Net-Core-Mvc-Proje\ProjeCore\Views\Personelim\PersonelGetir.cshtml"
Write(Html.TextBoxFor(x => x.Sehir, new { @class="form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <b>Сабакты өзгөртүү</b>\r\n");
#nullable restore
#line 25 "D:\NewProje\Asp.Net-Core-Mvc-Proje\ProjeCore\Views\Personelim\PersonelGetir.cshtml"
Write(Html.DropDownListFor(x => x.Birim.BirimID, (List<SelectListItem>)ViewBag.dgr, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <button class=\"btn btn-default\" style=\"background-color: #ebdede; color: black;\">Өзгөртүүнү кошуу</button>\r\n");
#nullable restore
#line 28 "D:\NewProje\Asp.Net-Core-Mvc-Proje\ProjeCore\Views\Personelim\PersonelGetir.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjeCore.Models.Personel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
