#pragma checksum "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Pagina\ApagarElemento.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "29441b7c36a82a876869a6870b6207d313602753"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pagina_ApagarElemento), @"mvc.1.0.view", @"/Views/Pagina/ApagarElemento.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pagina/ApagarElemento.cshtml", typeof(AspNetCore.Views_Pagina_ApagarElemento))]
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
#line 1 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\_ViewImports.cshtml"
using CMS;

#line default
#line hidden
#line 2 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\_ViewImports.cshtml"
using CMS.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29441b7c36a82a876869a6870b6207d313602753", @"/Views/Pagina/ApagarElemento.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"600f5e98c0b7ea1830bf7c16785f85b547fc669d", @"/Views/_ViewImports.cshtml")]
    public class Views_Pagina_ApagarElemento : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<business.business.Elementos.element.Elemento>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(52, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Pagina\ApagarElemento.cshtml"
  
    ViewBag.Title = "Delete";

#line default
#line hidden
            BeginContext(88, 95, true);
            WriteLiteral("\n<h2>Delete</h2>\n\n<h3>Deseja realmente apagar este elemento?</h3>\n<div>\n    <h4>Elemento</h4>\n\n");
            EndContext();
#line 13 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Pagina\ApagarElemento.cshtml"
     using (Html.BeginForm("", "", FormMethod.Post))
    {
        

#line default
#line hidden
            BeginContext(251, 23, false);
#line 15 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Pagina\ApagarElemento.cshtml"
   Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(276, 131, true);
            WriteLiteral("        <div class=\"form-actions no-color\">\n            <input type=\"button\" value=\"Deletar\" id=\"ApagarElemento\" />\n        </div>\n");
            EndContext();
#line 20 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Pagina\ApagarElemento.cshtml"
    }

#line default
#line hidden
            BeginContext(413, 461, true);
            WriteLiteral(@"</div>

<div>
    
    <script type=""text/javascript"">   

        let token = $('[name=__RequestVerificationToken]').val();
        let headers = {};
        headers['RequestVerificationToken'] = token;
             
            jQuery(""#ApagarElemento"").click(function () { 
                $.ajax({
                    type: 'POST',
                    url: '/AjaxDelete/ApagarElemento',
                    dataType: 'json',
                    data: { id: ");
            EndContext();
            BeginContext(875, 8, false);
#line 36 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Pagina\ApagarElemento.cshtml"
                           Write(Model.Id);

#line default
#line hidden
            EndContext();
            BeginContext(883, 863, true);
            WriteLiteral(@" },
                    headers: headers,
                    success: function (data) {
                        if (data != """")
                        {
                            var numero = $("".Topo"")[0].baseURI.replace(/[^0-9]/g, '');
                            numero = numero.replace('5001', '');
                            $(""#Hidden1"").val(true);
                            $("".content"").load(""/Pagina/getview"", { id: numero });
                            alert(""Elemento apagado com sucesso"");
                        }
                        else { alert('Erro: Preencha o formulario corretamente'); }
                    },
                    error: function (ex) {
                        alert('Falha ao alterar elemento.' + ex);
                    }
                });
                return false;
            });
    </script>
</div>


");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<business.business.Elementos.element.Elemento> Html { get; private set; }
    }
}
#pragma warning restore 1591
