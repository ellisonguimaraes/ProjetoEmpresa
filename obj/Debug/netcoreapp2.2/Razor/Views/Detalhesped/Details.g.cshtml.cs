#pragma checksum "C:\Users\ellis\Google Drive\UESC\6\Banco de Dados 2\Projeto EMPRESA ORM\BDApplication\Views\Detalhesped\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d1d50e9c4ca73c7cafe8dda06aa1c81ed046e636"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Detalhesped_Details), @"mvc.1.0.view", @"/Views/Detalhesped/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Detalhesped/Details.cshtml", typeof(AspNetCore.Views_Detalhesped_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1d50e9c4ca73c7cafe8dda06aa1c81ed046e636", @"/Views/Detalhesped/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fca19c5eb5b585e3fdd81c5237d19e663b81cc5f", @"/Views/_ViewImports.cshtml")]
    public class Views_Detalhesped_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BDApplication.ViewModel.DetalhesPedViewModel>
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
            BeginContext(53, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\ellis\Google Drive\UESC\6\Banco de Dados 2\Projeto EMPRESA ORM\BDApplication\Views\Detalhesped\Details.cshtml"
  
    ViewData["Title"] = "Detalhes";

#line default
#line hidden
            BeginContext(99, 109, true);
            WriteLiteral("\r\n<h2>Detalhes</h2>\r\n\r\n<div>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(209, 42, false);
#line 13 "C:\Users\ellis\Google Drive\UESC\6\Banco de Dados 2\Projeto EMPRESA ORM\BDApplication\Views\Detalhesped\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NumPed));

#line default
#line hidden
            EndContext();
            BeginContext(251, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(315, 38, false);
#line 16 "C:\Users\ellis\Google Drive\UESC\6\Banco de Dados 2\Projeto EMPRESA ORM\BDApplication\Views\Detalhesped\Details.cshtml"
       Write(Html.DisplayFor(model => model.NumPed));

#line default
#line hidden
            EndContext();
            BeginContext(353, 130, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            Produto\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(484, 36, false);
#line 22 "C:\Users\ellis\Google Drive\UESC\6\Banco de Dados 2\Projeto EMPRESA ORM\BDApplication\Views\Detalhesped\Details.cshtml"
       Write(Html.DisplayFor(model => model.Prod));

#line default
#line hidden
            EndContext();
            BeginContext(520, 6, true);
            WriteLiteral(" (ID: ");
            EndContext();
            BeginContext(527, 39, false);
#line 22 "C:\Users\ellis\Google Drive\UESC\6\Banco de Dados 2\Projeto EMPRESA ORM\BDApplication\Views\Detalhesped\Details.cshtml"
                                                  Write(Html.DisplayFor(model => model.CodProd));

#line default
#line hidden
            EndContext();
            BeginContext(566, 134, true);
            WriteLiteral(")\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            Preço\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            R$ ");
            EndContext();
            BeginContext(701, 37, false);
#line 28 "C:\Users\ellis\Google Drive\UESC\6\Banco de Dados 2\Projeto EMPRESA ORM\BDApplication\Views\Detalhesped\Details.cshtml"
          Write(Html.DisplayFor(model => model.Preco));

#line default
#line hidden
            EndContext();
            BeginContext(738, 135, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            Quantidade\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(874, 36, false);
#line 34 "C:\Users\ellis\Google Drive\UESC\6\Banco de Dados 2\Projeto EMPRESA ORM\BDApplication\Views\Detalhesped\Details.cshtml"
       Write(Html.DisplayFor(model => model.Qtde));

#line default
#line hidden
            EndContext();
            BeginContext(910, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(973, 44, false);
#line 37 "C:\Users\ellis\Google Drive\UESC\6\Banco de Dados 2\Projeto EMPRESA ORM\BDApplication\Views\Detalhesped\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Desconto));

#line default
#line hidden
            EndContext();
            BeginContext(1017, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1081, 40, false);
#line 40 "C:\Users\ellis\Google Drive\UESC\6\Banco de Dados 2\Projeto EMPRESA ORM\BDApplication\Views\Detalhesped\Details.cshtml"
       Write(Html.DisplayFor(model => model.Desconto));

#line default
#line hidden
            EndContext();
            BeginContext(1121, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1169, 89, false);
#line 45 "C:\Users\ellis\Google Drive\UESC\6\Banco de Dados 2\Projeto EMPRESA ORM\BDApplication\Views\Detalhesped\Details.cshtml"
Write(Html.ActionLink("Editar", "Edit", new { NumPed = Model.NumPed, CodProd = Model.CodProd }));

#line default
#line hidden
            EndContext();
            BeginContext(1258, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1266, 32, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d1d50e9c4ca73c7cafe8dda06aa1c81ed046e6368418", async() => {
                BeginContext(1288, 6, true);
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
            BeginContext(1298, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BDApplication.ViewModel.DetalhesPedViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
