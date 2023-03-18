#pragma checksum "G:\Meu Drive\Faculdade\CursoTecnico\uc8\uc8ativ5-Robinson\Views\Usuario\ListarUsuarios.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bfc89467e68415a18099c57f2d44ba602a407933"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_ListarUsuarios), @"mvc.1.0.view", @"/Views/Usuario/ListarUsuarios.cshtml")]
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
#line 1 "G:\Meu Drive\Faculdade\CursoTecnico\uc8\uc8ativ5-Robinson\Views\_ViewImports.cshtml"
using uc8ativ5_Robinson;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\Meu Drive\Faculdade\CursoTecnico\uc8\uc8ativ5-Robinson\Views\_ViewImports.cshtml"
using uc8ativ5_Robinson.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bfc89467e68415a18099c57f2d44ba602a407933", @"/Views/Usuario/ListarUsuarios.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c7387b87b59f270f55e4f61d1a501ceb9b0b516", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_ListarUsuarios : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<UsuarioOBJ>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-cad-users"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "G:\Meu Drive\Faculdade\CursoTecnico\uc8\uc8ativ5-Robinson\Views\Usuario\ListarUsuarios.cshtml"
  
    ViewData["Title"] = "Usuário";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<main class=\"type-user\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bfc89467e68415a18099c57f2d44ba602a4079333954", async() => {
                WriteLiteral("\r\n            <div");
                BeginWriteAttribute("class", " class=\"", 160, "\"", 168, 0);
                EndWriteAttribute();
                WriteLiteral(@">

                <label class=""labels"" for=""consulta"">Consulta</label>
                <input type=""text"" class=""inputs"" placeholder=""Digite um nome, matrícula, responsável ou turma"" id=""consultaUsuario"" onkeyup=""searchInTables('consultaUsuario','myTbodyListaUsuarios')"" />
                
                <table id=""table"">
                        <thead>
                            <th>Nome</th>
                            <th>Matrícula</th>
                            <th>Responsável</th>
                            <th>Turma</th>
                            <th>Editar</th>
                        </thead>
                
                        <tbody id=""myTbodyListaUsuarios"">
");
#nullable restore
#line 24 "G:\Meu Drive\Faculdade\CursoTecnico\uc8\uc8ativ5-Robinson\Views\Usuario\ListarUsuarios.cshtml"
                             foreach(UsuarioOBJ usuario in Model){

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <tr>\r\n                                <td style=\"text-align: center;\">");
#nullable restore
#line 26 "G:\Meu Drive\Faculdade\CursoTecnico\uc8\uc8ativ5-Robinson\Views\Usuario\ListarUsuarios.cshtml"
                                                           Write(usuario.Nome);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td style=\"text-align: center;\">");
#nullable restore
#line 27 "G:\Meu Drive\Faculdade\CursoTecnico\uc8\uc8ativ5-Robinson\Views\Usuario\ListarUsuarios.cshtml"
                                                           Write(usuario.Matricula);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td style=\"text-align: center;\">");
#nullable restore
#line 28 "G:\Meu Drive\Faculdade\CursoTecnico\uc8\uc8ativ5-Robinson\Views\Usuario\ListarUsuarios.cshtml"
                                                           Write(usuario.ResponsavelNome);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td style=\"text-align: center;\">");
#nullable restore
#line 29 "G:\Meu Drive\Faculdade\CursoTecnico\uc8\uc8ativ5-Robinson\Views\Usuario\ListarUsuarios.cshtml"
                                                           Write(usuario.TurmaNome);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td style=\"text-align: center;\"><a");
                BeginWriteAttribute("href", " href=\"", 1402, "\"", 1447, 2);
                WriteAttributeValue("", 1409, "/Usuario/EditarUsuarios?Id=", 1409, 27, true);
#nullable restore
#line 30 "G:\Meu Drive\Faculdade\CursoTecnico\uc8\uc8ativ5-Robinson\Views\Usuario\ListarUsuarios.cshtml"
WriteAttributeValue("", 1436, usuario.Id, 1436, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><i class=\"bi bi-pencil\"></i></a> </td>\r\n                            </tr>\r\n");
#nullable restore
#line 32 "G:\Meu Drive\Faculdade\CursoTecnico\uc8\uc8ativ5-Robinson\Views\Usuario\ListarUsuarios.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </tbody>\r\n                </table>\r\n\r\n            </div>\r\n\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<UsuarioOBJ>> Html { get; private set; }
    }
}
#pragma warning restore 1591
