#pragma checksum "D:\Programiranje za internet\Priprema za kolokvij_2\K2\RegistracijeApp_Marko\RegistracijeApp\Views\Glavni\Azuriranje.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9375a918b98bd12a12c59e2f6892d07c1a114da3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Glavni_Azuriranje), @"mvc.1.0.view", @"/Views/Glavni/Azuriranje.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9375a918b98bd12a12c59e2f6892d07c1a114da3", @"/Views/Glavni/Azuriranje.cshtml")]
    #nullable restore
    public class Views_Glavni_Azuriranje : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\Programiranje za internet\Priprema za kolokvij_2\K2\RegistracijeApp_Marko\RegistracijeApp\Views\Glavni\Azuriranje.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9375a918b98bd12a12c59e2f6892d07c1a114da33096", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Ažuriranje</title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9375a918b98bd12a12c59e2f6892d07c1a114da34160", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 14 "D:\Programiranje za internet\Priprema za kolokvij_2\K2\RegistracijeApp_Marko\RegistracijeApp\Views\Glavni\Azuriranje.cshtml"
Write(Html.ActionLink("Povratak na početnu stranicu", "Ispis", "Glavni"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <br />\r\n    <br />\r\n");
#nullable restore
#line 17 "D:\Programiranje za internet\Priprema za kolokvij_2\K2\RegistracijeApp_Marko\RegistracijeApp\Views\Glavni\Azuriranje.cshtml"
       
        if (ViewBag.uspjenoIzmijenjeno == true)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div>\r\n                Uspješno promijenjeni podaci!\r\n            </div>\r\n            <br/>\r\n");
#nullable restore
#line 24 "D:\Programiranje za internet\Priprema za kolokvij_2\K2\RegistracijeApp_Marko\RegistracijeApp\Views\Glavni\Azuriranje.cshtml"
        }
        else if (ViewBag.uspjenoIzmijenjeno == false)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div>\r\n                Pogreška! Nije uspjelo ažuriranje podataka!\r\n            </div>\r\n            <br/>\r\n");
#nullable restore
#line 31 "D:\Programiranje za internet\Priprema za kolokvij_2\K2\RegistracijeApp_Marko\RegistracijeApp\Views\Glavni\Azuriranje.cshtml"
        }
    

#line default
#line hidden
#nullable disable
                WriteLiteral("    <form");
                BeginWriteAttribute("action", " action=\"", 667, "\"", 743, 1);
                WriteAttributeValue("", 676, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                    PushWriter(__razor_attribute_value_writer);
#nullable restore
#line 33 "D:\Programiranje za internet\Priprema za kolokvij_2\K2\RegistracijeApp_Marko\RegistracijeApp\Views\Glavni\Azuriranje.cshtml"
                    string putanja = "/Glavni/SpremiIzmjene/" + ViewBag.id; 

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "D:\Programiranje za internet\Priprema za kolokvij_2\K2\RegistracijeApp_Marko\RegistracijeApp\Views\Glavni\Azuriranje.cshtml"
                                                                       Write(putanja);

#line default
#line hidden
#nullable disable
                                                                                    
                    PopWriter();
                }
                ), 676, 67, false);
                EndWriteAttribute();
                WriteLiteral(" method=\"post\">\r\n        <table>\r\n            <tr>\r\n                <td>\r\n                    Registarska oznaka:\r\n                </td>\r\n                <td>\r\n                    <input id=\"Text1\" type=\"text\" pattern=\"[A-ZČĆŽŠĐ]{2}\\d{3,4}[A-ZČĆŽŠĐ]{1,2}\"");
                BeginWriteAttribute("value", " value=\"", 999, "\"", 1034, 1);
#nullable restore
#line 40 "D:\Programiranje za internet\Priprema za kolokvij_2\K2\RegistracijeApp_Marko\RegistracijeApp\Views\Glavni\Azuriranje.cshtml"
WriteAttributeValue("", 1007, ViewBag.podaciZaIzmjenu[0], 1007, 27, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"oznaka\" required />\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <td>\r\n                    Datum isteka registracije:\r\n                </td>\r\n                <td>\r\n                    <input id=\"Text2\" type=\"date\"");
                BeginWriteAttribute("value", " value=\"", 1287, "\"", 1359, 1);
#nullable restore
#line 48 "D:\Programiranje za internet\Priprema za kolokvij_2\K2\RegistracijeApp_Marko\RegistracijeApp\Views\Glavni\Azuriranje.cshtml"
WriteAttributeValue("", 1295, ((DateTime)ViewBag.podaciZaIzmjenu[1]).ToString("yyyy-MM-dd"), 1295, 64, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" name=""datum"" required />
                </td>
            </tr>
            <tr>
                <td></td>
                <td>
                    <input id=""Submit1"" type=""submit"" value=""Spremi podatke"" />
                </td>
            </tr>
        </table>
    </form>
");
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
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
