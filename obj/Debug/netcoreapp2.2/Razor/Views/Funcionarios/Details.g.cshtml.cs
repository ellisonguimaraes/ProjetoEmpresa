#pragma checksum "C:\Users\ellis\Google Drive\UESC\6\Banco de Dados 2\Projeto EMPRESA ORM\BDApplication\Views\Funcionarios\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3c3ba68a80e71f2ec286920a67a355edb4cee47a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Funcionarios_Details), @"mvc.1.0.view", @"/Views/Funcionarios/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Funcionarios/Details.cshtml", typeof(AspNetCore.Views_Funcionarios_Details))]
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
#line 1 "C:\Users\ellis\Google Drive\UESC\6\Banco de Dados 2\Projeto EMPRESA ORM\BDApplication\Views\_ViewImports.cshtml"
using BDApplication;

#line default
#line hidden
#line 2 "C:\Users\ellis\Google Drive\UESC\6\Banco de Dados 2\Projeto EMPRESA ORM\BDApplication\Views\_ViewImports.cshtml"
using BDApplication.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c3ba68a80e71f2ec286920a67a355edb4cee47a", @"/Views/Funcionarios/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fca19c5eb5b585e3fdd81c5237d19e663b81cc5f", @"/Views/_ViewImports.cshtml")]
    public class Views_Funcionarios_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BDApplication.Models.Funcionario>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(41, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\ellis\Google Drive\UESC\6\Banco de Dados 2\Projeto EMPRESA ORM\BDApplication\Views\Funcionarios\Details.cshtml"
  
    ViewData["Title"] = "Detalhes do Funcionario";

#line default
#line hidden
            BeginContext(102, 16, true);
            WriteLiteral("\r\n<h2>Detalhes \"");
            EndContext();
            BeginContext(119, 10, false);
#line 7 "C:\Users\ellis\Google Drive\UESC\6\Banco de Dados 2\Projeto EMPRESA ORM\BDApplication\Views\Funcionarios\Details.cshtml"
         Write(Model.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(129, 94, true);
            WriteLiteral("\"</h2>\r\n\r\n<div>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(224, 42, false);
#line 13 "C:\Users\ellis\Google Drive\UESC\6\Banco de Dados 2\Projeto EMPRESA ORM\BDApplication\Views\Funcionarios\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CodFun));

#line default
#line hidden
            EndContext();
            BeginContext(266, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(328, 38, false);
#line 16 "C:\Users\ellis\Google Drive\UESC\6\Banco de Dados 2\Projeto EMPRESA ORM\BDApplication\Views\Funcionarios\Details.cshtml"
       Write(Html.DisplayFor(model => model.CodFun));

#line default
#line hidden
            EndContext();
            BeginContext(366, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(427, 45, false);
#line 19 "C:\Users\ellis\Google Drive\UESC\6\Banco de Dados 2\Projeto EMPRESA ORM\BDApplication\Views\Funcionarios\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Sobrenome));

#line default
#line hidden
            EndContext();
            BeginContext(472, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(534, 41, false);
#line 22 "C:\Users\ellis\Google Drive\UESC\6\Banco de Dados 2\Projeto EMPRESA ORM\BDApplication\Views\Funcionarios\Details.cshtml"
       Write(Html.DisplayFor(model => model.Sobrenome));

#line default
#line hidden
            EndContext();
            BeginContext(575, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(636, 40, false);
#line 25 "C:\Users\ellis\Google Drive\UESC\6\Banco de Dados 2\Projeto EMPRESA ORM\BDApplication\Views\Funcionarios\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(676, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(738, 36, false);
#line 28 "C:\Users\ellis\Google Drive\UESC\6\Banco de Dados 2\Projeto EMPRESA ORM\BDApplication\Views\Funcionarios\Details.cshtml"
       Write(Html.DisplayFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(774, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(835, 41, false);
#line 31 "C:\Users\ellis\Google Drive\UESC\6\Banco de Dados 2\Projeto EMPRESA ORM\BDApplication\Views\Funcionarios\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Cargo));

#line default
#line hidden
            EndContext();
            BeginContext(876, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(938, 37, false);
#line 34 "C:\Users\ellis\Google Drive\UESC\6\Banco de Dados 2\Projeto EMPRESA ORM\BDApplication\Views\Funcionarios\Details.cshtml"
       Write(Html.DisplayFor(model => model.Cargo));

#line default
#line hidden
            EndContext();
            BeginContext(975, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1036, 44, false);
#line 37 "C:\Users\ellis\Google Drive\UESC\6\Banco de Dados 2\Projeto EMPRESA ORM\BDApplication\Views\Funcionarios\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DataNasc));

#line default
#line hidden
            EndContext();
            BeginContext(1080, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1142, 40, false);
#line 40 "C:\Users\ellis\Google Drive\UESC\6\Banco de Dados 2\Projeto EMPRESA ORM\BDApplication\Views\Funcionarios\Details.cshtml"
       Write(Html.DisplayFor(model => model.DataNasc));

#line default
#line hidden
            EndContext();
            BeginContext(1182, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1243, 44, false);
#line 43 "C:\Users\ellis\Google Drive\UESC\6\Banco de Dados 2\Projeto EMPRESA ORM\BDApplication\Views\Funcionarios\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Endereco));

#line default
#line hidden
            EndContext();
            BeginContext(1287, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1349, 40, false);
#line 46 "C:\Users\ellis\Google Drive\UESC\6\Banco de Dados 2\Projeto EMPRESA ORM\BDApplication\Views\Funcionarios\Details.cshtml"
       Write(Html.DisplayFor(model => model.Endereco));

#line default
#line hidden
            EndContext();
            BeginContext(1389, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1450, 42, false);
#line 49 "C:\Users\ellis\Google Drive\UESC\6\Banco de Dados 2\Projeto EMPRESA ORM\BDApplication\Views\Funcionarios\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Cidade));

#line default
#line hidden
            EndContext();
            BeginContext(1492, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1554, 38, false);
#line 52 "C:\Users\ellis\Google Drive\UESC\6\Banco de Dados 2\Projeto EMPRESA ORM\BDApplication\Views\Funcionarios\Details.cshtml"
       Write(Html.DisplayFor(model => model.Cidade));

#line default
#line hidden
            EndContext();
            BeginContext(1592, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1653, 39, false);
#line 55 "C:\Users\ellis\Google Drive\UESC\6\Banco de Dados 2\Projeto EMPRESA ORM\BDApplication\Views\Funcionarios\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CEP));

#line default
#line hidden
            EndContext();
            BeginContext(1692, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1754, 35, false);
#line 58 "C:\Users\ellis\Google Drive\UESC\6\Banco de Dados 2\Projeto EMPRESA ORM\BDApplication\Views\Funcionarios\Details.cshtml"
       Write(Html.DisplayFor(model => model.CEP));

#line default
#line hidden
            EndContext();
            BeginContext(1789, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1850, 40, false);
#line 61 "C:\Users\ellis\Google Drive\UESC\6\Banco de Dados 2\Projeto EMPRESA ORM\BDApplication\Views\Funcionarios\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Pais));

#line default
#line hidden
            EndContext();
            BeginContext(1890, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1952, 36, false);
#line 64 "C:\Users\ellis\Google Drive\UESC\6\Banco de Dados 2\Projeto EMPRESA ORM\BDApplication\Views\Funcionarios\Details.cshtml"
       Write(Html.DisplayFor(model => model.Pais));

#line default
#line hidden
            EndContext();
            BeginContext(1988, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2049, 40, false);
#line 67 "C:\Users\ellis\Google Drive\UESC\6\Banco de Dados 2\Projeto EMPRESA ORM\BDApplication\Views\Funcionarios\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Fone));

#line default
#line hidden
            EndContext();
            BeginContext(2089, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2151, 36, false);
#line 70 "C:\Users\ellis\Google Drive\UESC\6\Banco de Dados 2\Projeto EMPRESA ORM\BDApplication\Views\Funcionarios\Details.cshtml"
       Write(Html.DisplayFor(model => model.Fone));

#line default
#line hidden
            EndContext();
            BeginContext(2187, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2248, 43, false);
#line 73 "C:\Users\ellis\Google Drive\UESC\6\Banco de Dados 2\Projeto EMPRESA ORM\BDApplication\Views\Funcionarios\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Salario));

#line default
#line hidden
            EndContext();
            BeginContext(2291, 64, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            R$ ");
            EndContext();
            BeginContext(2356, 39, false);
#line 76 "C:\Users\ellis\Google Drive\UESC\6\Banco de Dados 2\Projeto EMPRESA ORM\BDApplication\Views\Funcionarios\Details.cshtml"
          Write(Html.DisplayFor(model => model.Salario));

#line default
#line hidden
            EndContext();
            BeginContext(2395, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2443, 60, false);
#line 81 "C:\Users\ellis\Google Drive\UESC\6\Banco de Dados 2\Projeto EMPRESA ORM\BDApplication\Views\Funcionarios\Details.cshtml"
Write(Html.ActionLink("Editar", "Edit", new { id = Model.CodFun }));

#line default
#line hidden
            EndContext();
            BeginContext(2503, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(2511, 32, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3c3ba68a80e71f2ec286920a67a355edb4cee47a14994", async() => {
                BeginContext(2533, 6, true);
                WriteLiteral("Voltar");
                EndContext();
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
            EndContext();
            BeginContext(2543, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BDApplication.Models.Funcionario> Html { get; private set; }
    }
}
#pragma warning restore 1591
