#pragma checksum "G:\Meu Drive\Faculdade\CursoTecnico\uc8\uc8ativ5-Robinson\Views\Recados\ListarRecados.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "594b6911aa0e379c8a5f1ed5fc32dea46a19a98c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Recados_ListarRecados), @"mvc.1.0.view", @"/Views/Recados/ListarRecados.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"594b6911aa0e379c8a5f1ed5fc32dea46a19a98c", @"/Views/Recados/ListarRecados.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c7387b87b59f270f55e4f61d1a501ceb9b0b516", @"/Views/_ViewImports.cshtml")]
    public class Views_Recados_ListarRecados : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<RecadoOBJ>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/site.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-cad-users"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "G:\Meu Drive\Faculdade\CursoTecnico\uc8\uc8ativ5-Robinson\Views\Recados\ListarRecados.cshtml"
  
    ViewData["Title"] = "Consulta Turmas";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "594b6911aa0e379c8a5f1ed5fc32dea46a19a98c4744", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<main class=\"type-user\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "594b6911aa0e379c8a5f1ed5fc32dea46a19a98c5904", async() => {
                WriteLiteral("\r\n        <div");
                BeginWriteAttribute("class", " class=\"", 220, "\"", 228, 0);
                EndWriteAttribute();
                WriteLiteral(@">

            <label class=""labels"" for=""consulta"">Consulta</label>
            <input type=""text"" class=""inputs"" placeholder=""Digite uma turma, série, ano letivo ou turno"" id=""pesquisa"" onkeyup=""searchInTables('pesquisa','myTableListaRecados')"" />
            
            <table id=""myTable"">
                <thead>
                    <tr>
                        <th>Sequencia</th>
                        <th>Assunto</th>
                        <th>Data da Publicação</th>
                        <th>Ativo</th>
                        <th>Ação</th>
                    </tr>
                </thead>
            
                <tbody id=""myTableListaRecados"">
");
#nullable restore
#line 27 "G:\Meu Drive\Faculdade\CursoTecnico\uc8\uc8ativ5-Robinson\Views\Recados\ListarRecados.cshtml"
                     foreach (RecadoOBJ recado in Model)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <tr>\r\n                            <td style=\"text-align: center;\">");
#nullable restore
#line 30 "G:\Meu Drive\Faculdade\CursoTecnico\uc8\uc8ativ5-Robinson\Views\Recados\ListarRecados.cshtml"
                                                       Write(recado.Sequencia);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            <td style=\"text-align: center;\">");
#nullable restore
#line 31 "G:\Meu Drive\Faculdade\CursoTecnico\uc8\uc8ativ5-Robinson\Views\Recados\ListarRecados.cshtml"
                                                       Write(recado.Assunto);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            <td style=\"text-align: center;\">");
#nullable restore
#line 32 "G:\Meu Drive\Faculdade\CursoTecnico\uc8\uc8ativ5-Robinson\Views\Recados\ListarRecados.cshtml"
                                                       Write(recado.DataPublicacao);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n");
#nullable restore
#line 33 "G:\Meu Drive\Faculdade\CursoTecnico\uc8\uc8ativ5-Robinson\Views\Recados\ListarRecados.cshtml"
                             if (recado.Ativo)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <td style=\"text-align: center;\">Ativa</td>\r\n");
#nullable restore
#line 36 "G:\Meu Drive\Faculdade\CursoTecnico\uc8\uc8ativ5-Robinson\Views\Recados\ListarRecados.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <td style=\"text-align: center;\">Desativada</td>\r\n");
#nullable restore
#line 40 "G:\Meu Drive\Faculdade\CursoTecnico\uc8\uc8ativ5-Robinson\Views\Recados\ListarRecados.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <td style=\"text-align: center;\">\r\n                                <a");
                BeginWriteAttribute("href", " href=\"", 1742, "\"", 1785, 2);
                WriteAttributeValue("", 1749, "/Recados/EditarRecados?Id=", 1749, 26, true);
#nullable restore
#line 42 "G:\Meu Drive\Faculdade\CursoTecnico\uc8\uc8ativ5-Robinson\Views\Recados\ListarRecados.cshtml"
WriteAttributeValue("", 1775, recado.Id, 1775, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><i class=\"bi bi-pencil\"></i></a>\r\n                                <a");
                BeginWriteAttribute("href", " href=\"", 1855, "\"", 1899, 2);
                WriteAttributeValue("", 1862, "/Recados/RemoverRecados?Id=", 1862, 27, true);
#nullable restore
#line 43 "G:\Meu Drive\Faculdade\CursoTecnico\uc8\uc8ativ5-Robinson\Views\Recados\ListarRecados.cshtml"
WriteAttributeValue("", 1889, recado.Id, 1889, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><i class=\"bi bi-trash3\"></i></a>\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 46 "G:\Meu Drive\Faculdade\CursoTecnico\uc8\uc8ativ5-Robinson\Views\Recados\ListarRecados.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </tbody>\r\n            </table>\r\n\r\n        </div>\r\n\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</main>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<RecadoOBJ>> Html { get; private set; }
    }
}
#pragma warning restore 1591
