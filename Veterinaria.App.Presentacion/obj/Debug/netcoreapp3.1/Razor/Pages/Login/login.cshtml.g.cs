#pragma checksum "C:\Users\julia\Downloads\ProyectoVeterinariaWeb\Veterinaria.App\Veterinaria.App.Presentacion\Pages\Login\login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1ba89fd5a23b1bd0a845346ba4fa0b37c217fa76"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Veterinaria.App.Presentacion.Pages.Login.Pages_Login_login), @"mvc.1.0.razor-page", @"/Pages/Login/login.cshtml")]
namespace Veterinaria.App.Presentacion.Pages.Login
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
#line 1 "C:\Users\julia\Downloads\ProyectoVeterinariaWeb\Veterinaria.App\Veterinaria.App.Presentacion\Pages\_ViewImports.cshtml"
using Veterinaria.App.Presentacion;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ba89fd5a23b1bd0a845346ba4fa0b37c217fa76", @"/Pages/Login/login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e0b5ca209e941241f3a7d6f6fefe42ca98442af", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Login_login : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<link
      href=""https://unpkg.com/tailwindcss/dist/tailwind.min.css""
      rel=""stylesheet""
    />

<div class=""fixed inset-0 flex items-center justify-center"" style=""background-color: rgba(0,0,0,0.3);"">
        <div class=""bg-gray-300 max-w-lg p-8 sm:pb-4 rounded shadow-lg text-center sm:text-left"">

            <h3 class=""text-xl sm:text-2xl font-semibold mb-6 flex flex-col sm:flex-row items-center"">
                <div class=""bg-green-200 p-2 rounded-full flex items-center mb-4 sm:mb-0 sm:mr-2"">
                    <svg class=""text-green-800 inline-block w-5 h-5"" fill=""none"" stroke-linecap=""round"" stroke-linejoin=""round"" stroke-width=""2"" stroke=""currentColor"" viewBox=""0 0 24 24"">
                        <path d=""M11 5.882V19.24a1.76 1.76 0 01-3.417.592l-2.147-6.15M18 13a3 3 0 100-6M5.436 13.683A4.001 4.001 0 017 6h1.832c4.1 0 7.625-1.234 9.168-3v14c-1.543-1.766-5.067-3-9.168-3H7a3.988 3.988 0 01-1.564-.317z""></path>
                    </svg>
                </div>
                <span id");
            WriteLiteral("=\"title\">Inicio de sesión</span>\r\n            </h3>\r\n\r\n            <section id=\"content\">\r\n                <label  class=\"my-1 p-2\"");
            BeginWriteAttribute("for", " for=\"", 1223, "\"", 1229, 0);
            EndWriteAttribute();
            WriteLiteral(">User: <select name=\"user\" id=\"user\" class=\"rounded-lg\"></select>\'\r\n                <br>\r\n                <label class=\"my-1 p-2 \"");
            BeginWriteAttribute("for", " for=\"", 1360, "\"", 1366, 0);
            EndWriteAttribute();
            WriteLiteral(@">Password: <input id=""password"" class=""shadow-sm rounded-lg mx-2 w-14 text-center"" type=""text"" placeholder=""*****""></label>
            </section>

            <div class=""mt-8 pt-8 sm:pt-4 border-t -mx-8 px-8 flex flex-col sm:flex-row justify-end leading-relaxed"">
                <button id=""close"" class=""px-8 py-3 sm:py-2 rounded border border-gray-400 hover:bg-gray-200 transition duration-300"">Cerrar</button>
                <button id=""accept"" class=""font-bold mt-4 sm:mt-0 sm:ml-4 px-8 py-3 sm:py-2 rounded bg-purple-700 text-gray-100 hover:bg-purple-900 transition duration-300 text-center"">Enviar</button>
            </div>
        </div>
    </div>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Veterinaria.App.Presentacions.Page.loginModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Veterinaria.App.Presentacions.Page.loginModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Veterinaria.App.Presentacions.Page.loginModel>)PageContext?.ViewData;
        public Veterinaria.App.Presentacions.Page.loginModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
