#pragma checksum "C:\Users\ellis\Google Drive\UESC\6\Banco de Dados 2\Projeto EMPRESA ORM\BDApplication\Views\Detalhesped\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3217efb34bce43c3753629a543a88867cf6d72f1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Detalhesped_Delete), @"mvc.1.0.view", @"/Views/Detalhesped/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Detalhesped/Delete.cshtml", typeof(AspNetCore.Views_Detalhesped_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3217efb34bce43c3753629a543a88867cf6d72f1", @"/Views/Detalhesped/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fca19c5eb5b585e3fdd81c5237d19e663b81cc5f", @"/Views/_ViewImports.cshtml")]
    public class Views_Detalhesped_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BDApplication.ViewModel.DetalhesPedViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(53, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\ellis\Google Drive\UESC\6\Banco de Dados 2\Projeto EMPRESA ORM\BDApplication\Views\Detalhesped\Delete.cshtml"
  
    ViewData["Title"] = "Deletar DetalhesPed";

#line default
#line hidden
            BeginContext(110, 142, true);
            WriteLiteral("\r\n<h3>Certeza que deseja excluir este DetalhePed?</h3>\r\n\r\n<div>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(253, 42, false);
#line 13 "C:\Users\ellis\Google Drive\UESC\6\Banco de Dados 2\Projeto EMPRESA ORM\BDApplication\Views\Detalhesped\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.NumPed));

#line default
#line hidden
            EndContext();
            BeginContext(295, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(357, 38, false);
#line 16 "C:\Users\ellis\Google Drive\UESC\6\Banco de Dados 2\Projeto EMPRESA ORM\BDApplication\Views\Detalhesped\Delete.cshtml"
       Write(Html.DisplayFor(model => model.NumPed));

#line default
#line hidden
            EndContext();
            BeginContext(395, 128, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Produto\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(524, 36, false);
#line 22 "C:\Users\ellis\Google Drive\UESC\6\Banco de Dados 2\Projeto EMPRESA ORM\BDApplication\Views\Detalhesped\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Prod));

#line default
#line hidden
            EndContext();
            BeginContext(560, 6, true);
            WriteLiteral(" (ID: ");
            EndContext();
            BeginContext(567, 39, false);
#line 22 "C:\Users\ellis\Google Drive\UESC\6\Banco de Dados 2\Projeto EMPRESA ORM\BDApplication\Views\Detalhesped\Delete.cshtml"
                                                  Write(Html.DisplayFor(model => model.CodProd));

#line default
#line hidden
            EndContext();
            BeginContext(606, 130, true);
            WriteLiteral(")\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Preço\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            R$ ");
            EndContext();
            BeginContext(737, 37, false);
#line 28 "C:\Users\ellis\Google Drive\UESC\6\Banco de Dados 2\Projeto EMPRESA ORM\BDApplication\Views\Detalhesped\Delete.cshtml"
          Write(Html.DisplayFor(model => model.Preco));

#line default
#line hidden
            EndContext();
            BeginContext(774, 131, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Quantidade\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(906, 36, false);
#line 34 "C:\Users\ellis\Google Drive\UESC\6\Banco de Dados 2\Projeto EMPRESA ORM\BDApplication\Views\Detalhesped\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Qtde));

#line default
#line hidden
            EndContext();
            BeginContext(942, 129, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Desconto\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1072, 40, false);
#line 40 "C:\Users\ellis\Google Drive\UESC\6\Banco de Dados 2\Projeto EMPRESA ORM\BDApplication\Views\Detalhesped\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Desconto));

#line default
#line hidden
            EndContext();
            BeginContext(1112, 34, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n\r\n    ");
            EndContext();
            BeginContext(1146, 223, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3217efb34bce43c3753629a543a88867cf6d72f18174", async() => {
                BeginContext(1240, 84, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Excluir\" class=\"btn btn-danger\" /> |\r\n        ");
                EndContext();
                BeginContext(1324, 32, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3217efb34bce43c3753629a543a88867cf6d72f18648", async() => {
                    BeginContext(1346, 6, true);
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
                BeginContext(1356, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-NumPed", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 44 "C:\Users\ellis\Google Drive\UESC\6\Banco de Dados 2\Projeto EMPRESA ORM\BDApplication\Views\Detalhesped\Delete.cshtml"
                                    WriteLiteral(Model.NumPed);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["NumPed"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-NumPed", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["NumPed"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 44 "C:\Users\ellis\Google Drive\UESC\6\Banco de Dados 2\Projeto EMPRESA ORM\BDApplication\Views\Detalhesped\Delete.cshtml"
                                                                      WriteLiteral(Model.CodProd);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["CodProd"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-CodProd", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["CodProd"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1369, 10, true);
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
