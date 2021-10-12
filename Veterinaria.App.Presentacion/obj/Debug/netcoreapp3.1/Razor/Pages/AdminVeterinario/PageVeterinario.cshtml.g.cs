#pragma checksum "C:\Users\julia\OneDrive\Documentos\GitHub\ProyectoVeterinaria\VeterinariaWeb\Veterinaria.App.Presentacion\Pages\AdminVeterinario\PageVeterinario.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea0849572ae5299029808a98ba3d2841cbde2743"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Veterinaria.App.Presentacion.Pages.AdminVeterinario.Pages_AdminVeterinario_PageVeterinario), @"mvc.1.0.razor-page", @"/Pages/AdminVeterinario/PageVeterinario.cshtml")]
namespace Veterinaria.App.Presentacion.Pages.AdminVeterinario
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea0849572ae5299029808a98ba3d2841cbde2743", @"/Pages/AdminVeterinario/PageVeterinario.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e0b5ca209e941241f3a7d6f6fefe42ca98442af", @"/Pages/_ViewImports.cshtml")]
    public class Pages_AdminVeterinario_PageVeterinario : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary bg-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "Del", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "Add", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h3>Administra Información sobre Veterinarios! <span class=\"badge badge-secondary\"></span></h3>\r\n");
            WriteLiteral(@"
<div class=""accordion"" id=""accordionExample"">
    <div class=""card"">
        <div class=""card-header"" id=""headingTwo"">
            <h2 class=""mb-0"">
                <button class=""btn btn-link collapsed"" type=""button"" data-toggle=""collapse""
                    data-target=""#id-collapse-listar-veterinario"" aria-expanded=""false""
                    aria-controls=""id-collapse-listar-veterinario"">
                    Listar Veterinarios
                </button>
            </h2>
        </div>
        <div id=""id-collapse-listar-veterinario"" class=""collapse show"" aria-labelledby=""headingTwo""
            data-parent=""#accordionExample"">
            <div class=""card-body"">
                <table class=""table table-hover"">
                    <thead>
                        <tr>
");
            WriteLiteral(@"                            <th scope=""col"">Id</th>
                            <th scope=""col"">Nombre</th>
                            <th scope=""col"">Teléfono</th>
                            <th scope=""col"">Edad</th>
                            <th scope=""col"">Dirección</th>
                            <th scope=""col"">FechaNacimiento</th>
                            <th scope=""col"">Correo</th>
                            <th scope=""col"">Contraseña</th>
                        </tr>
                    </thead>
                    <tbody>
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ea0849572ae5299029808a98ba3d2841cbde27437044", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 38 "C:\Users\julia\OneDrive\Documentos\GitHub\ProyectoVeterinaria\VeterinariaWeb\Veterinaria.App.Presentacion\Pages\AdminVeterinario\PageVeterinario.cshtml"
                             foreach (var ad in Model.listaVeterinario)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 41 "C:\Users\julia\OneDrive\Documentos\GitHub\ProyectoVeterinaria\VeterinariaWeb\Veterinaria.App.Presentacion\Pages\AdminVeterinario\PageVeterinario.cshtml"
                               Write(ad.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 42 "C:\Users\julia\OneDrive\Documentos\GitHub\ProyectoVeterinaria\VeterinariaWeb\Veterinaria.App.Presentacion\Pages\AdminVeterinario\PageVeterinario.cshtml"
                               Write(ad.Nombre);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 43 "C:\Users\julia\OneDrive\Documentos\GitHub\ProyectoVeterinaria\VeterinariaWeb\Veterinaria.App.Presentacion\Pages\AdminVeterinario\PageVeterinario.cshtml"
                               Write(ad.Telefono);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 44 "C:\Users\julia\OneDrive\Documentos\GitHub\ProyectoVeterinaria\VeterinariaWeb\Veterinaria.App.Presentacion\Pages\AdminVeterinario\PageVeterinario.cshtml"
                               Write(ad.Edad);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 45 "C:\Users\julia\OneDrive\Documentos\GitHub\ProyectoVeterinaria\VeterinariaWeb\Veterinaria.App.Presentacion\Pages\AdminVeterinario\PageVeterinario.cshtml"
                               Write(ad.Direccion);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 46 "C:\Users\julia\OneDrive\Documentos\GitHub\ProyectoVeterinaria\VeterinariaWeb\Veterinaria.App.Presentacion\Pages\AdminVeterinario\PageVeterinario.cshtml"
                               Write(ad.FechaNacimiento);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 47 "C:\Users\julia\OneDrive\Documentos\GitHub\ProyectoVeterinaria\VeterinariaWeb\Veterinaria.App.Presentacion\Pages\AdminVeterinario\PageVeterinario.cshtml"
                               Write(ad.Correo);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</td>
                                <td>
                                        <button type=""submit"" class=""btn btn-primary bg-success""
                                        style=""margin-right: 20px"">Editar</button>
                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ea0849572ae5299029808a98ba3d2841cbde274310524", async() => {
                    WriteLiteral("Eliminar");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.PageHandler = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-idVeterinario", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 52 "C:\Users\julia\OneDrive\Documentos\GitHub\ProyectoVeterinaria\VeterinariaWeb\Veterinaria.App.Presentacion\Pages\AdminVeterinario\PageVeterinario.cshtml"
                                                     WriteLiteral(ad.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["idVeterinario"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-idVeterinario", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["idVeterinario"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 55 "C:\Users\julia\OneDrive\Documentos\GitHub\ProyectoVeterinaria\VeterinariaWeb\Veterinaria.App.Presentacion\Pages\AdminVeterinario\PageVeterinario.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </tbody>
                </table>
            </div>
        </div>
    </div>
    <div class=""card"">
        <div class=""card-header"" id=""headingOne"">
            <h2 class=""mb-0"">
                <button class=""btn btn-link"" type=""button"" data-toggle=""collapse""
                    data-target=""#id-collapse-admin-veterinario"" aria-expanded=""true""
                    aria-controls=""id-collapse-admin-veterinario"">
                    Veterinario Veterinarioes
                </button>
            </h2>
        </div>
        <div id=""id-collapse-admin-veterinario"" class=""collapse"" aria-labelledby=""headingOne""
            data-parent=""#accordionExample"">
            <div class=""card-body"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ea0849572ae5299029808a98ba3d2841cbde274315470", async() => {
                WriteLiteral(@"
                    <div class=""form-row"">
                        <fieldset disabled>
                            <div class=""form-group col-md-8"">
                                <label for=""id-veterinario"">IdVeterinario</label>
                                <input type=""text"" id=""id-veterinario"" class=""form-control"" placeholder=""IdVeterinario"" name=""Id"">
                            </div>
                        </fieldset>
                        <div class=""form-group col-md-6"">
                            <label for=""id-nombred"">Nombre del Veterinario</label>
                            <input type=""text"" id=""id-nombred"" class=""form-control"" placeholder=""Digita Nombre del Dueño"" name=""Nombre"">
                        </div>
                        <div class=""form-group col-md-3"">
                            <label for=""id-fechanac"">Fecha de Nacimiento</label>
                            <input type=""Date"" class=""form-control"" id=""id-fechanac"" placeholder=""Selecciona Fecha Nacimiento"" n");
                WriteLiteral(@"ame=""FechaNacimiento"">
                        </div>
                        <div class=""form-group col-md-2"">
                            <label for=""id-edad"">Edad</label>
                            <input type=""text"" id=""id-edad"" class=""form-control"" placeholder=""Digita la Edad"" name=""Edad"">
                        </div>
                        <div class=""form-group col-md-6"">
                            <label for=""id-direccion"">Dirección</label>
                            <input id=""id-direccion"" type=""text"" class=""form-control"" placeholder=""Digita la dirección"" name=""Direccion"">
                        </div>
                        <div class=""form-group col-md-3"">
                            <label for=""id-telefono"">Teléfono</label>
                            <input type=""text"" id=""id-telefono"" class=""form-control"" placeholder=""Digita Número de Teléfono"" name=""Telefono"">
                        </div>
                        <div class=""form-group col-md-3"">
                       ");
                WriteLiteral(@"     <label for=""id-correo"">Correo Electrónico</label>
                            <input id=""id-correo"" type=""email"" class=""form-control"" placeholder=""Digita el correo"" name=""Correo"">
                        </div>
                        <div class=""form-group col-md-3"">
                            <label for=""id-contra"">Contraseña</label>
                            <input id=""id-contra"" type=""password"" class=""form-control"" placeholder=""Digita la contraseña"" name=""Contrasena"">
                        </div>
                        <div class=""form-group col-md-3"">
                            <label for=""id-Especializacion"">Especializacion</label>
                            <input id=""id-Especializacion"" type=""text"" class=""form-control"" placeholder=""Digita la Especializacion"" name=""Especializacion"">
                        </div>  
                        <div class=""form-group col-md-3"">
                            <label for=""id-Tarjeta"">Tarjeta profesional</label>
                          ");
                WriteLiteral("  <input id=\"id-Tarjeta\" type=\"text\" class=\"form-control\" placeholder=\"Digita tu numero de TF\" name=\"Tarjeta\">\r\n                        </div>                              \r\n                    </div>\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ea0849572ae5299029808a98ba3d2841cbde274319275", async() => {
                    WriteLiteral("Agregar");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.PageHandler = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(" \r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Veterinaria.App.Presentacion.Pages.PageVeterinarioModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Veterinaria.App.Presentacion.Pages.PageVeterinarioModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Veterinaria.App.Presentacion.Pages.PageVeterinarioModel>)PageContext?.ViewData;
        public Veterinaria.App.Presentacion.Pages.PageVeterinarioModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591