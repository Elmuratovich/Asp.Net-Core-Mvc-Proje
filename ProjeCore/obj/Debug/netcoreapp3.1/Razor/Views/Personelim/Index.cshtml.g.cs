#pragma checksum "D:\NewProje\ProjeCore\ProjeCore\Views\Personelim\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cfd550176050d74513edbc38c03ad86e97d476b3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Personelim_Index), @"mvc.1.0.view", @"/Views/Personelim/Index.cshtml")]
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
#line 1 "D:\NewProje\ProjeCore\ProjeCore\Views\_ViewImports.cshtml"
using ProjeCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\NewProje\ProjeCore\ProjeCore\Views\Personelim\Index.cshtml"
using ProjeCore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cfd550176050d74513edbc38c03ad86e97d476b3", @"/Views/Personelim/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f6887fc2a081498e457a98abd035f4ecf5faaf7", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Personelim_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Personel>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\NewProje\ProjeCore\ProjeCore\Views\Personelim\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_TestLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<br />\r\n\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>ID</th>\r\n        <th>Ad</th>\r\n        <th>SoyAd</th>\r\n        <th>Sehir</th>\r\n        <th>Birim</th>\r\n        <th>Sil</th>\r\n        <th>Guncelle</th>\r\n    </tr>\r\n");
#nullable restore
#line 22 "D:\NewProje\ProjeCore\ProjeCore\Views\Personelim\Index.cshtml"
     foreach(var x in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 25 "D:\NewProje\ProjeCore\ProjeCore\Views\Personelim\Index.cshtml"
           Write(x.PersonelID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 26 "D:\NewProje\ProjeCore\ProjeCore\Views\Personelim\Index.cshtml"
           Write(x.Ad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 27 "D:\NewProje\ProjeCore\ProjeCore\Views\Personelim\Index.cshtml"
           Write(x.Soyad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 28 "D:\NewProje\ProjeCore\ProjeCore\Views\Personelim\Index.cshtml"
           Write(x.Sehir);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>    \r\n            <td>");
#nullable restore
#line 29 "D:\NewProje\ProjeCore\ProjeCore\Views\Personelim\Index.cshtml"
           Write(x.Birim.BirimAd);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>    \r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 620, "\"", 664, 2);
            WriteAttributeValue("", 627, "/Personalim/PersonelSil/", 627, 24, true);
#nullable restore
#line 30 "D:\NewProje\ProjeCore\ProjeCore\Views\Personelim\Index.cshtml"
WriteAttributeValue("", 651, x.PersonelID, 651, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Delete</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 724, "\"", 770, 2);
            WriteAttributeValue("", 731, "/Personelim/PersonelGetir/", 731, 26, true);
#nullable restore
#line 31 "D:\NewProje\ProjeCore\ProjeCore\Views\Personelim\Index.cshtml"
WriteAttributeValue("", 757, x.PersonelID, 757, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Update</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 33 "D:\NewProje\ProjeCore\ProjeCore\Views\Personelim\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n<a href=\"/Personelim/YeniPersonel\" class=\"btn btn-primary\">Yeni Personal</a>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Personel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
