#pragma checksum "C:\Users\julia\Downloads\ProyectoVeterinariaWeb\Veterinaria.App\Veterinaria.App.Presentacion\Pages\AdminAnimal\PageAnimal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "682f30527dafdd8b385f4796f529ed8bc827f314"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Veterinaria.App.Presentacion.Pages.AdminAnimal.Pages_AdminAnimal_PageAnimal), @"mvc.1.0.razor-page", @"/Pages/AdminAnimal/PageAnimal.cshtml")]
namespace Veterinaria.App.Presentacion.Pages.AdminAnimal
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"682f30527dafdd8b385f4796f529ed8bc827f314", @"/Pages/AdminAnimal/PageAnimal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e0b5ca209e941241f3a7d6f6fefe42ca98442af", @"/Pages/_ViewImports.cshtml")]
    public class Pages_AdminAnimal_PageAnimal : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<h3>Administra Información sobre tus Máscotas! <span class=""badge badge-secondary""></span></h3>
<div class=""accordion"" id=""accordionExample"">
    <div class=""card"">
        <div class=""card-header"" id=""headingOne"">
            <h2 class=""mb-0"">
                <button class=""btn btn-link"" type=""button"" data-toggle=""collapse""
                    data-target=""#id-collapse-admin-animal"" aria-expanded=""true""
                    aria-controls=""id-collapse-admin-animal"">
                    Administrador de Mascotas
                </button>
            </h2>
        </div>

        <div id=""id-collapse-admin-animal"" class=""collapse"" aria-labelledby=""headingOne""
            data-parent=""#accordionExample"">
            <div class=""card-body"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "682f30527dafdd8b385f4796f529ed8bc827f3144061", async() => {
                WriteLiteral(@"
                    <div class=""form-row"">
                        <fieldset disabled>
                            <div class=""form-group col-md-6"">
                                <label for=""disabledTextInput"">IdMascota</label>
                                <input type=""text"" id=""disabledTextInput"" class=""form-control"" placeholder=""IdVacuna"">
                            </div>
                        </fieldset>
                        <div class=""form-group col-md-2 mx-3"">
                            <label for=""exampleFormControlSelect1"">Nombre: <input type=""text""></label>
                        </div>
                        <div class=""form-group col-md-2 mx-3"">
                            <label for=""exampleFormControlSelect1"">Edad: <input type=""number""></label>
                        </div>
                        <div class=""form-group col-md-2 mx-3"">
                            <label for=""exampleFormControlSelect1"">Id Plan Vacunación: <input type=""number""></label>
             ");
                WriteLiteral(@"           </div>
                        <div class=""form-group col-md-4"">
                            <label for=""exampleFormControlSelect1"">Id Dueño: <input type=""number""></label>
                        </div>
                        <div class=""form-group col-md-4"">
                            <label for=""exampleFormControlSelect1"">Id Veterinario: <input type=""number""></label>
                        </div>
                        <div class=""form-group col-md-4"">
                            <label for=""exampleFormControlSelect1"">Id Vacuna: <input type=""number"" width=""5""></label>
                        </div>
                       
                    <button type=""button"" class=""btn btn-secondary mx-1"">Agregar</button>
                    <button type=""submit"" class=""btn btn-success mx-1"">Editar</button>
                    <button type=""submit"" class=""btn btn-danger mx-1"">Eliminar</button>
                    
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
        </div>
    </div>
    <div class=""card"">
        <div class=""card-header"" id=""headingTwo"">
            <h2 class=""mb-0"">
                <button class=""btn btn-link collapsed"" type=""button"" data-toggle=""collapse""
                    data-target=""#id-collapse-listar-animal"" aria-expanded=""false""
                    aria-controls=""id-collapse-listar-animal"">
                    Listar Mascotas
                </button>
            </h2>
        </div>
        <div id=""id-collapse-listar-animal"" class=""collapse"" aria-labelledby=""headingTwo""
            data-parent=""#accordionExample"">
            <div class=""card-body"">
                <table class=""table table-hover"">
                    <thead>
                        <tr>
                            <th scope=""col"">#</th>
                            <th scope=""col"">Nombre</th>
                            <th scope=""col"">Edad</th>
                            <th scope=""col"">IdPlanVacunacion</th>
             ");
            WriteLiteral(@"               <th scope=""col"">IdDueño</th>
                            <th scope=""col"">IdVeterinario</th>
                            <th scope=""col"">IdVacuna</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 82 "C:\Users\julia\Downloads\ProyectoVeterinariaWeb\Veterinaria.App\Veterinaria.App.Presentacion\Pages\AdminAnimal\PageAnimal.cshtml"
                        foreach (var m in Model.listaMascotas)
                       {

#line default
#line hidden
#nullable disable
            WriteLiteral("                           <tr>\r\n\r\n                               <th scope=\"row\">1</th>\r\n                               <td>");
#nullable restore
#line 87 "C:\Users\julia\Downloads\ProyectoVeterinariaWeb\Veterinaria.App\Veterinaria.App.Presentacion\Pages\AdminAnimal\PageAnimal.cshtml"
                              Write(m.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                               <td>");
#nullable restore
#line 88 "C:\Users\julia\Downloads\ProyectoVeterinariaWeb\Veterinaria.App\Veterinaria.App.Presentacion\Pages\AdminAnimal\PageAnimal.cshtml"
                              Write(m.Edad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                               <td>");
#nullable restore
#line 89 "C:\Users\julia\Downloads\ProyectoVeterinariaWeb\Veterinaria.App\Veterinaria.App.Presentacion\Pages\AdminAnimal\PageAnimal.cshtml"
                              Write(m.IdPlanVacunacion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                               <td>");
#nullable restore
#line 90 "C:\Users\julia\Downloads\ProyectoVeterinariaWeb\Veterinaria.App\Veterinaria.App.Presentacion\Pages\AdminAnimal\PageAnimal.cshtml"
                              Write(m.IdDueno);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                               <td>");
#nullable restore
#line 91 "C:\Users\julia\Downloads\ProyectoVeterinariaWeb\Veterinaria.App\Veterinaria.App.Presentacion\Pages\AdminAnimal\PageAnimal.cshtml"
                              Write(m.IdVeterinario);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                               <td>");
#nullable restore
#line 92 "C:\Users\julia\Downloads\ProyectoVeterinariaWeb\Veterinaria.App\Veterinaria.App.Presentacion\Pages\AdminAnimal\PageAnimal.cshtml"
                              Write(m.IdVacuna);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                           </tr>\r\n");
#nullable restore
#line 95 "C:\Users\julia\Downloads\ProyectoVeterinariaWeb\Veterinaria.App\Veterinaria.App.Presentacion\Pages\AdminAnimal\PageAnimal.cshtml"
                       }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Veterinaria.App.Presentacion.Pages.PageAnimalModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Veterinaria.App.Presentacion.Pages.PageAnimalModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Veterinaria.App.Presentacion.Pages.PageAnimalModel>)PageContext?.ViewData;
        public Veterinaria.App.Presentacion.Pages.PageAnimalModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
