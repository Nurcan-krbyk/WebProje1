#pragma checksum "C:\Users\Nur\Desktop\Yeni klasör (3)\vizeProje\vizeProje\Views\kutuphane\listele.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a9243d5c576a464741e73e64a8d261afdc203ceb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_kutuphane_listele), @"mvc.1.0.view", @"/Views/kutuphane/listele.cshtml")]
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
#line 1 "C:\Users\Nur\Desktop\Yeni klasör (3)\vizeProje\vizeProje\Views\_ViewImports.cshtml"
using vizeProje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Nur\Desktop\Yeni klasör (3)\vizeProje\vizeProje\Views\_ViewImports.cshtml"
using vizeProje.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9243d5c576a464741e73e64a8d261afdc203ceb", @"/Views/kutuphane/listele.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e76a95c001e53e69c7184ce2d0f7d7af708558e7", @"/Views/_ViewImports.cshtml")]
    public class Views_kutuphane_listele : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<vizeProje.Models.kutuphane>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "yeni", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Nur\Desktop\Yeni klasör (3)\vizeProje\vizeProje\Views\kutuphane\listele.cshtml"
  
    ViewData["Title"] = "listele";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Kütüphane Listeleri</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a9243d5c576a464741e73e64a8d261afdc203ceb3771", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</p>
<table class=""table"">
    <thead>
        <tr>
            <th>
                Kitap Numarası
            </th>
            <th>
                Kitap Adı
            </th>
            <th>
                Kitap Yazarı
            </th>
            <th>
                Sayfa Sayısı
            </th>
            <th>
                Öğrenci Adı
            </th>
            <th>
                Öğrenci Soyadı
            </th>
            <th>
                Kitabı Alış Tarihi
            </th>
            <th>
                Kitap Teslim Tarihi
            </th>
            <th>
                Kitabın Konusu
            </th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 47 "C:\Users\Nur\Desktop\Yeni klasör (3)\vizeProje\vizeProje\Views\kutuphane\listele.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 50 "C:\Users\Nur\Desktop\Yeni klasör (3)\vizeProje\vizeProje\Views\kutuphane\listele.cshtml"
           Write(Html.DisplayFor(modelItem => item.kitapNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 53 "C:\Users\Nur\Desktop\Yeni klasör (3)\vizeProje\vizeProje\Views\kutuphane\listele.cshtml"
           Write(Html.DisplayFor(modelItem => item.kitapAdi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 56 "C:\Users\Nur\Desktop\Yeni klasör (3)\vizeProje\vizeProje\Views\kutuphane\listele.cshtml"
           Write(Html.DisplayFor(modelItem => item.kitapYazari));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 59 "C:\Users\Nur\Desktop\Yeni klasör (3)\vizeProje\vizeProje\Views\kutuphane\listele.cshtml"
           Write(Html.DisplayFor(modelItem => item.kitapSayfaSayi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 62 "C:\Users\Nur\Desktop\Yeni klasör (3)\vizeProje\vizeProje\Views\kutuphane\listele.cshtml"
           Write(Html.DisplayFor(modelItem => item.ogrAdi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 65 "C:\Users\Nur\Desktop\Yeni klasör (3)\vizeProje\vizeProje\Views\kutuphane\listele.cshtml"
           Write(Html.DisplayFor(modelItem => item.ogrSoyad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 68 "C:\Users\Nur\Desktop\Yeni klasör (3)\vizeProje\vizeProje\Views\kutuphane\listele.cshtml"
           Write(Html.DisplayFor(modelItem => item.alisTarihi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 71 "C:\Users\Nur\Desktop\Yeni klasör (3)\vizeProje\vizeProje\Views\kutuphane\listele.cshtml"
           Write(Html.DisplayFor(modelItem => item.teslimTarihi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 74 "C:\Users\Nur\Desktop\Yeni klasör (3)\vizeProje\vizeProje\Views\kutuphane\listele.cshtml"
           Write(Html.DisplayFor(modelItem => item.kitapKonusu));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 77 "C:\Users\Nur\Desktop\Yeni klasör (3)\vizeProje\vizeProje\Views\kutuphane\listele.cshtml"
           Write(Html.ActionLink("Güncelle", "guncelle", new { kitapNo = item.kitapNo }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 78 "C:\Users\Nur\Desktop\Yeni klasör (3)\vizeProje\vizeProje\Views\kutuphane\listele.cshtml"
           Write(Html.ActionLink("Detay", "detay", new { kitapNo = item.kitapNo }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 79 "C:\Users\Nur\Desktop\Yeni klasör (3)\vizeProje\vizeProje\Views\kutuphane\listele.cshtml"
           Write(Html.ActionLink("Sil", "sil", new { kitapNo = item.kitapNo }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 82 "C:\Users\Nur\Desktop\Yeni klasör (3)\vizeProje\vizeProje\Views\kutuphane\listele.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<vizeProje.Models.kutuphane>> Html { get; private set; }
    }
}
#pragma warning restore 1591
