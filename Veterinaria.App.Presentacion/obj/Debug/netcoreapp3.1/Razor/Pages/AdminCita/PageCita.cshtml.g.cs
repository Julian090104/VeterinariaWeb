#pragma checksum "C:\Users\julia\OneDrive\Documentos\GitHub\ProyectoVeterinaria\VeterinariaWeb\Veterinaria.App.Presentacion\Pages\AdminCita\PageCita.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0de440322c01ece9e3b91ba94801633f116f5aa1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Veterinaria.App.Presentacion.Pages.AdminCita.Pages_AdminCita_PageCita), @"mvc.1.0.razor-page", @"/Pages/AdminCita/PageCita.cshtml")]
namespace Veterinaria.App.Presentacion.Pages.AdminCita
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
#line 1 "C:\Users\julia\OneDrive\Documentos\GitHub\ProyectoVeterinaria\VeterinariaWeb\Veterinaria.App.Presentacion\Pages\_ViewImports.cshtml"
using Veterinaria.App.Presentacion;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0de440322c01ece9e3b91ba94801633f116f5aa1", @"/Pages/AdminCita/PageCita.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e0b5ca209e941241f3a7d6f6fefe42ca98442af", @"/Pages/_ViewImports.cshtml")]
    public class Pages_AdminCita_PageCita : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "volvo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "saab", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<h3>Administra Información sobre tus Citas! <span class=""badge badge-secondary""></span></h3>
<div class=""accordion"" id=""accordionExample"">
    <div class=""card"">
        <div class=""card-header"" id=""headingOne"">
            <h2 class=""mb-0"">
                <button class=""btn btn-link"" type=""button"" data-toggle=""collapse"" data-target=""#id-collapse-admin-cita""
                    aria-expanded=""true"" aria-controls=""id-collapse-admin-cita"">
                    Administrador de Citas
                </button>
            </h2>
        </div>

        <div id=""id-collapse-admin-cita"" class=""collapse"" aria-labelledby=""headingOne"" data-parent=""#accordionExample"">
            <div class=""card-body"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0de440322c01ece9e3b91ba94801633f116f5aa14738", async() => {
                WriteLiteral(@"
                    <div class=""form-row"">
                        <fieldset disabled>
                            <div class=""form-group col-md-6"">
                                <label for=""disabledTextInput"">IdCita</label>
                                <input type=""text"" id=""disabledTextInput"" class=""form-control"" placeholder=""IdVacuna"">
                            </div>
                        </fieldset>
                        <div class=""form-group col-md-2 mx-3"">
                            <label for=""exampleFormControlSelect1"">Fecha: <input type=""date""></label>
                        </div>
                        <div class=""form-group col-md-2 mx-3"">
                            <label");
                BeginWriteAttribute("for", " for=\"", 1532, "\"", 1538, 0);
                EndWriteAttribute();
                WriteLiteral(">Tipo Consulta: </label> <select id=\"citas\"\r\n                                name=\"citas\">\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0de440322c01ece9e3b91ba94801633f116f5aa16020", async() => {
                    WriteLiteral("Externa-Ambulatoria");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0de440322c01ece9e3b91ba94801633f116f5aa17288", async() => {
                    WriteLiteral("Emergencia");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                            </select>
                        </div>
                        <div class=""form-group col-md-2 mx-3"">
                            <label for=""exampleFormControlSelect1"">Motivo Consulta: <input type=""text""></label>
                        </div>
                        <div class=""form-group col-md-4"">
                            <label for=""exampleFormControlSelect1"">Id Dueño: <input type=""number""></label>
                        </div>
                        <div class=""form-group col-md-8"">
                            <label for=""exampleFormControlSelect1"">Id Veterinario: <input type=""number""></label>
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
                    data-target=""#id-collapse-listar-cita"" aria-expanded=""false""
                    aria-controls=""id-collapse-listar-cita"">
                    Listar Mascotas
                </button>
            </h2>
        </div>
        <div id=""id-collapse-listar-cita"" class=""collapse"" aria-labelledby=""headingTwo"" data-parent=""#accordionExample"">
            <div class=""card-body"">
                <table class=""table table-hover"">
                    <thead>
                        <tr>
                            <th scope=""col"">#</th>
                            <th scope=""col"">FechaCita</th>
                            <th scope=""col"">TipoConsulta</th>
                            <th scope=""col"">MotivoConsulta</th>
                       ");
            WriteLiteral("     <th scope=\"col\">IdDueño</th>\r\n                            <th scope=\"col\">IdVeterinario</th>\r\n                        </tr>\r\n                    </thead>\r\n                    <tbody>\r\n\r\n");
#nullable restore
#line 80 "C:\Users\julia\OneDrive\Documentos\GitHub\ProyectoVeterinaria\VeterinariaWeb\Veterinaria.App.Presentacion\Pages\AdminCita\PageCita.cshtml"
                         foreach (var c in Model.listaCitas)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n\r\n                                <th scope=\"row\">1</th>\r\n                                <td>");
#nullable restore
#line 85 "C:\Users\julia\OneDrive\Documentos\GitHub\ProyectoVeterinaria\VeterinariaWeb\Veterinaria.App.Presentacion\Pages\AdminCita\PageCita.cshtml"
                               Write(c.FechaCita);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 86 "C:\Users\julia\OneDrive\Documentos\GitHub\ProyectoVeterinaria\VeterinariaWeb\Veterinaria.App.Presentacion\Pages\AdminCita\PageCita.cshtml"
                               Write(c.TipoConsulta);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 87 "C:\Users\julia\OneDrive\Documentos\GitHub\ProyectoVeterinaria\VeterinariaWeb\Veterinaria.App.Presentacion\Pages\AdminCita\PageCita.cshtml"
                               Write(c.MotivoConsulta);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 88 "C:\Users\julia\OneDrive\Documentos\GitHub\ProyectoVeterinaria\VeterinariaWeb\Veterinaria.App.Presentacion\Pages\AdminCita\PageCita.cshtml"
                               Write(c.IdDueno);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 89 "C:\Users\julia\OneDrive\Documentos\GitHub\ProyectoVeterinaria\VeterinariaWeb\Veterinaria.App.Presentacion\Pages\AdminCita\PageCita.cshtml"
                               Write(c.IdVeterinario);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                            </tr>\r\n");
#nullable restore
#line 92 "C:\Users\julia\OneDrive\Documentos\GitHub\ProyectoVeterinaria\VeterinariaWeb\Veterinaria.App.Presentacion\Pages\AdminCita\PageCita.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Veterinaria.App.Presentacion.Pages.PageCitaModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Veterinaria.App.Presentacion.Pages.PageCitaModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Veterinaria.App.Presentacion.Pages.PageCitaModel>)PageContext?.ViewData;
        public Veterinaria.App.Presentacion.Pages.PageCitaModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
