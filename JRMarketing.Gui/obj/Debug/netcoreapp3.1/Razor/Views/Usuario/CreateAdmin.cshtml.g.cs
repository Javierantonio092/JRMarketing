#pragma checksum "C:\Users\Javier Hernández\Documents\Universidad\4° Cuatrimestre\Proyecto Integrador\JRMarketing\JRMarketing.Gui\Views\Usuario\CreateAdmin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "824185c3335e70ade2db455ff2b3e17670e8910b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_CreateAdmin), @"mvc.1.0.view", @"/Views/Usuario/CreateAdmin.cshtml")]
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
#line 1 "C:\Users\Javier Hernández\Documents\Universidad\4° Cuatrimestre\Proyecto Integrador\JRMarketing\JRMarketing.Gui\Views\_ViewImports.cshtml"
using JRMarketing.Gui;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Javier Hernández\Documents\Universidad\4° Cuatrimestre\Proyecto Integrador\JRMarketing\JRMarketing.Gui\Views\_ViewImports.cshtml"
using JRMarketing.Gui.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"824185c3335e70ade2db455ff2b3e17670e8910b", @"/Views/Usuario/CreateAdmin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c94c9ee24af97ab588ea9a66c9618d6badbea139", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_CreateAdmin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<JRMarketing.Gui.Models.UsuarioRequestDto>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "IndexAdmin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-secondary text-center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-top: 25px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateAdmin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Javier Hernández\Documents\Universidad\4° Cuatrimestre\Proyecto Integrador\JRMarketing\JRMarketing.Gui\Views\Usuario\CreateAdmin.cshtml"
   Layout = "AdminLayout"; ViewBag.Title = "Agregar Administrador";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"container-xl table-wrapper\">\r\n    <hr />\r\n    <h2 class=\"text-center\">Agregar Usuario ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "824185c3335e70ade2db455ff2b3e17670e8910b5656", async() => {
                WriteLiteral("Cancelar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</h2>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "824185c3335e70ade2db455ff2b3e17670e8910b7111", async() => {
                WriteLiteral(@"
        <div class=""form-group form-row"">
            <div class=""col-md-4 mt-md-2"">
                <label for=""Name"" class=""control-label col-md-8"">Nombre de Usuario:</label>
                <div class=""col-md-12"">
                    <input class=""form-control"" name=""NombreUsuario"" />
                </div>
            </div>
            <div class=""col-md-4 mt-md-2"">
                <label for=""StartLocation"" class=""control-label col-md-2"">Contraseña:</label>
                <div class=""col-md-12"">
                    <input type=""password"" class=""form-control"" name=""Contrasenia"" />
                </div>
            </div>
            <div class=""col-md-4 mt-md-2"">
                <label for=""EndLocation"" class=""control-label col-md-2"">Nombre:</label>
                <div class=""col-md-12"">
                    <input class=""form-control"" name=""Nombre"" />
                </div>
            </div>
            <div class=""col-md-4 mt-md-3"">
                <label for=""Name"" class=""cont");
                WriteLiteral(@"rol-label col-md-2"">Apellidos:</label>
                <div class=""col-md-12"">
                    <input class=""form-control"" name=""Apellidos"" />
                </div>

            </div>
            <div class=""col-md-4 mt-md-3"">
                <label for=""StartLocation"" class=""control-label col-md-2"">Direccion:</label>
                <div class=""col-md-12"">
                    <input class=""form-control"" name=""Direccion"" />
                </div>
            </div>
            <div class=""col-md-4 mt-md-3"">
                <label for=""EndLocation"" class=""control-label col-md-2"">Colonia:</label>
                <div class=""col-md-12"">
                    <input class=""form-control"" name=""Colonia"" />
                </div>
            </div>
            <div class=""col-md-4 mt-md-3"">
                <label for=""Name"" class=""control-label col-md-2"">Estado:</label>
                <div class=""col-md-12"">
                    <input class=""form-control"" name=""Estado"" />
                <");
                WriteLiteral(@"/div>
            </div>
            <div class=""col-md-4 mt-md-3"">
                <label for=""StartLocation"" class=""control-label col-md-2"">Ciudad:</label>
                <div class=""col-md-12"">
                    <input class=""form-control"" name=""Ciudad"" />
                </div>
            </div>
            <div class=""col-md-4 mt-md-3"">
                <label for=""EndLocation"" class=""control-label col-md-10"">Código Postal:</label>
                <div class=""col-md-12"">
                    <input class=""form-control"" name=""CoidgoPostal"" />
                </div>
            </div>
            <div class=""col-md-4 mt-md-3"">
                <label for=""EndLocation"" class=""control-label col-md-10"">Fecha de Nacimiento:</label>
                <div class=""col-md-12"">
                    <input type=""date"" class=""form-control"" name=""FechaNacimiento"" />
                </div>
            </div>
            <div class=""col-md-4 mt-md-3"">
                <label for=""StartLocation"" class=""");
                WriteLiteral(@"control-label col-md-2"">Correo:</label>
                <div class=""col-md-12"">
                    <input class=""form-control"" name=""Correo"" />
                </div>
            </div>
            <div class=""col-md-4 mt-md-3"">
                <label for=""EndLocation"" class=""control-label col-md-2"">Telefono:</label>
                <div class=""col-md-12"">
                    <input class=""form-control"" name=""TelefonoUsuario"" />
                </div>
            </div>
            <input type=""hidden"" class=""form-control"" value=""Admin"" name=""Tipo"" />
        </div>
        <div class=""form-group"">
            <input type=""submit"" value=""Guardar Datos"" class=""btn btn-primary btn-lg btn-block mt-md-3"" style=""margin:10px"" />
        </div>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>       ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<JRMarketing.Gui.Models.UsuarioRequestDto> Html { get; private set; }
    }
}
#pragma warning restore 1591