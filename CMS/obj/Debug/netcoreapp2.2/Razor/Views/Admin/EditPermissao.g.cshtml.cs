#pragma checksum "C:\Users\simon\source\repos\C#\rede-social\CMS\Views\Admin\EditPermissao.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "276ada395b8ba2b36e9bf9d80a62df73b433a0dc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_EditPermissao), @"mvc.1.0.view", @"/Views/Admin/EditPermissao.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/EditPermissao.cshtml", typeof(AspNetCore.Views_Admin_EditPermissao))]
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
#line 1 "C:\Users\simon\source\repos\C#\rede-social\CMS\Views\_ViewImports.cshtml"
using CMS;

#line default
#line hidden
#line 2 "C:\Users\simon\source\repos\C#\rede-social\CMS\Views\_ViewImports.cshtml"
using CMS.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"276ada395b8ba2b36e9bf9d80a62df73b433a0dc", @"/Views/Admin/EditPermissao.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0389c18537be78d994187c367b0e0aa311ab30d", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_EditPermissao : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 57, true);
            WriteLiteral("  \r\n\r\n  <br />\r\n<h1>Permissões para usuarios</h1>\r\n\r\n\r\n\r\n");
            EndContext();
#line 8 "C:\Users\simon\source\repos\C#\rede-social\CMS\Views\Admin\EditPermissao.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(92, 23, false);
#line 10 "C:\Users\simon\source\repos\C#\rede-social\CMS\Views\Admin\EditPermissao.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(119, 50, true);
            WriteLiteral("<div class=\"row marginEspaco\">\r\n\r\n    <hr />\r\n    ");
            EndContext();
            BeginContext(170, 64, false);
#line 15 "C:\Users\simon\source\repos\C#\rede-social\CMS\Views\Admin\EditPermissao.cshtml"
Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(234, 180, true);
            WriteLiteral("\r\n\r\n\r\n    <div class=\"col-md-12\">\r\n        <label class=\"control-label\">\r\n            Separar por virgula todos os usuarios que vão trabalhar com videos\r\n        </label>\r\n        ");
            EndContext();
            BeginContext(415, 106, false);
#line 22 "C:\Users\simon\source\repos\C#\rede-social\CMS\Views\Admin\EditPermissao.cshtml"
   Write(Html.TextArea("Videos", new { htmlAttributes = new { @class = "form-control", @Value = ViewBag.Videos } }));

#line default
#line hidden
            EndContext();
            BeginContext(521, 196, true);
            WriteLiteral("\r\n    </div>\r\n    \r\n\r\n    <div class=\"col-md-12\">\r\n        <label class=\"control-label\">\r\n            Separar por virgula todos os usuarios que vão trabalhar com textos\r\n        </label>\r\n        ");
            EndContext();
            BeginContext(718, 104, false);
#line 30 "C:\Users\simon\source\repos\C#\rede-social\CMS\Views\Admin\EditPermissao.cshtml"
   Write(Html.TextArea("Texto", new { htmlAttributes = new { @class = "form-control", @Value = ViewBag.Texto } }));

#line default
#line hidden
            EndContext();
            BeginContext(822, 197, true);
            WriteLiteral("\r\n    </div>\r\n    \r\n\r\n    <div class=\"col-md-12\">\r\n        <label class=\"control-label\">\r\n            Separar por virgula todos os usuarios que vão trabalhar com imagens\r\n        </label>\r\n        ");
            EndContext();
            BeginContext(1020, 106, false);
#line 38 "C:\Users\simon\source\repos\C#\rede-social\CMS\Views\Admin\EditPermissao.cshtml"
   Write(Html.TextArea("Imagem", new { htmlAttributes = new { @class = "form-control", @Value = ViewBag.Imagem } }));

#line default
#line hidden
            EndContext();
            BeginContext(1126, 197, true);
            WriteLiteral("\r\n    </div>\r\n    \r\n\r\n    <div class=\"col-md-12\">\r\n        <label class=\"control-label\">\r\n            Separar por virgula todos os usuarios que vão trabalhar com musicas\r\n        </label>\r\n        ");
            EndContext();
            BeginContext(1324, 104, false);
#line 46 "C:\Users\simon\source\repos\C#\rede-social\CMS\Views\Admin\EditPermissao.cshtml"
   Write(Html.TextArea("Music", new { htmlAttributes = new { @class = "form-control", @Value = ViewBag.Music } }));

#line default
#line hidden
            EndContext();
            BeginContext(1428, 205, true);
            WriteLiteral("\r\n    </div>\r\n    \r\n\r\n    <div class=\"col-md-12\">\r\n        <label class=\"control-label\">\r\n            Separar por virgula todos os usuarios que vão trabalhar com planos de fundo\r\n        </label>\r\n        ");
            EndContext();
            BeginContext(1634, 114, false);
#line 54 "C:\Users\simon\source\repos\C#\rede-social\CMS\Views\Admin\EditPermissao.cshtml"
   Write(Html.TextArea("Background", new { htmlAttributes = new { @class = "form-control", @Value = ViewBag.Background } }));

#line default
#line hidden
            EndContext();
            BeginContext(1748, 199, true);
            WriteLiteral("\r\n    </div>\r\n    \r\n\r\n    <div class=\"col-md-12\">\r\n        <label class=\"control-label\">\r\n            Separar por virgula todos os usuarios que vão trabalhar com carrossel\r\n        </label>\r\n        ");
            EndContext();
            BeginContext(1948, 110, false);
#line 62 "C:\Users\simon\source\repos\C#\rede-social\CMS\Views\Admin\EditPermissao.cshtml"
   Write(Html.TextArea("Carousel", new { htmlAttributes = new { @class = "form-control", @Value = ViewBag.Carousel } }));

#line default
#line hidden
            EndContext();
            BeginContext(2058, 195, true);
            WriteLiteral("\r\n    </div>\r\n    \r\n\r\n    <div class=\"col-md-12\">\r\n        <label class=\"control-label\">\r\n            Separar por virgula todos os usuarios que vão trabalhar com links\r\n        </label>\r\n        ");
            EndContext();
            BeginContext(2254, 102, false);
#line 70 "C:\Users\simon\source\repos\C#\rede-social\CMS\Views\Admin\EditPermissao.cshtml"
   Write(Html.TextArea("Link", new { htmlAttributes = new { @class = "form-control", @Value = ViewBag.Link } }));

#line default
#line hidden
            EndContext();
            BeginContext(2356, 196, true);
            WriteLiteral("\r\n    </div>\r\n    \r\n\r\n    <div class=\"col-md-12\">\r\n        <label class=\"control-label\">\r\n            Separar por virgula todos os usuarios que vão trabalhar com blocos\r\n        </label>\r\n        ");
            EndContext();
            BeginContext(2553, 100, false);
#line 78 "C:\Users\simon\source\repos\C#\rede-social\CMS\Views\Admin\EditPermissao.cshtml"
   Write(Html.TextArea("Div", new { htmlAttributes = new { @class = "form-control", @Value = ViewBag.Div } }));

#line default
#line hidden
            EndContext();
            BeginContext(2653, 199, true);
            WriteLiteral("\r\n    </div>\r\n    \r\n\r\n    <div class=\"col-md-12\">\r\n        <label class=\"control-label\">\r\n            Separar por virgula todos os usuarios que vão trabalhar com elementos\r\n        </label>\r\n        ");
            EndContext();
            BeginContext(2853, 110, false);
#line 86 "C:\Users\simon\source\repos\C#\rede-social\CMS\Views\Admin\EditPermissao.cshtml"
   Write(Html.TextArea("Elemento", new { htmlAttributes = new { @class = "form-control", @Value = ViewBag.Elemento } }));

#line default
#line hidden
            EndContext();
            BeginContext(2963, 213, true);
            WriteLiteral("\r\n    </div>\r\n    \r\n\r\n    <div class=\"col-md-12\">\r\n        <label class=\"control-label\">\r\n            Separar por virgula todos os usuarios que vão trabalhar com configurações de pagina\r\n        </label>\r\n        ");
            EndContext();
            BeginContext(3177, 106, false);
#line 94 "C:\Users\simon\source\repos\C#\rede-social\CMS\Views\Admin\EditPermissao.cshtml"
   Write(Html.TextArea("Pagina", new { htmlAttributes = new { @class = "form-control", @Value = ViewBag.Pagina } }));

#line default
#line hidden
            EndContext();
            BeginContext(3283, 200, true);
            WriteLiteral("\r\n    </div>\r\n    \r\n\r\n    <div class=\"col-md-12\">\r\n        <label class=\"control-label\">\r\n            Separar por virgula todos os usuarios que vão trabalhar com produtos\r\n        </label>  \r\n        ");
            EndContext();
            BeginContext(3484, 112, false);
#line 102 "C:\Users\simon\source\repos\C#\rede-social\CMS\Views\Admin\EditPermissao.cshtml"
   Write(Html.TextArea("Ecommerce", new { htmlAttributes = new { @class = "form-control", @Value = ViewBag.Ecommerce } }));

#line default
#line hidden
            EndContext();
            BeginContext(3596, 220, true);
            WriteLiteral("\r\n    </div> \r\n\r\n    <div class=\"col-md-12\">\r\n        <input type=\"button\" value=\"Salvar\" class=\"btn btn-TextoEditar\" />\r\n        <a id=\"btnFecharPermissoes\" class=\"btn btn-success\">Fechar</a>\r\n    </div>\r\n\r\n\r\n\r\n</div>\r\n");
            EndContext();
#line 113 "C:\Users\simon\source\repos\C#\rede-social\CMS\Views\Admin\EditPermissao.cshtml"
}

#line default
#line hidden
            BeginContext(3819, 838, true);
            WriteLiteral(@"
<div>
    <script type=""text/javascript"">
        $(document).ready(function () {

            $(""#btnFecharPermissoes"").click(function () {
                $(""#FormTexto, #estrutura, #Permissao"").fadeOut(""slow"");
                $(""#estrutura"").fadeIn(""slow"");
            });

            var numero = $("".bloco"")[0].baseURI.replace(/[^0-9]/g, '');
            numero = numero.replace('44311', '');

            let token = $('[name=__RequestVerificationToken]').val();
            let headers = {};
            headers['RequestVerificationToken'] = token;

            $("".btn-TextoEditar"").click(function () {
                $.ajax({
                    type: 'POST',
                    url: '/Admin/SalvarDados',
                    dataType: 'json',
                    data: {
                        Id: ");
            EndContext();
            BeginContext(4658, 12, false);
#line 137 "C:\Users\simon\source\repos\C#\rede-social\CMS\Views\Admin\EditPermissao.cshtml"
                       Write(ViewBag.site);

#line default
#line hidden
            EndContext();
            BeginContext(4670, 1324, true);
            WriteLiteral(@",
                        Videos: $(""#Videos"").val(),
                        Texto: $(""#Texto"").val(),
                        Imagem: $(""#Imagem"").val(),
                        Carousel: $(""#Carousel"").val(),
                        Background: $(""#Background"").val(),
                        Music: $(""#Music"").val(),
                        Link: $(""#Link"").val(),
                        Div: $(""#Div"").val(),
                        Elemento: $(""#Elemento"").val(),
                        Pagina: $(""#Pagina"").val(),
                        Ecommerce: $(""#Ecommerce"").val()
                    },
                    headers: headers,
                    success: function (data) {

                        if (data != """")
                        {
                            $(""#Hidden1"").val(true);
                            $("".content"").load(""/Pagina/getview"",
                                { id: numero });
                        }
                        else { alert('Erro: Preencha");
            WriteLiteral(@" o formulario corretamente'); }
                    },
                    error: function (ex) {
                        alert('Falha ao alterar elemento.' + ex);
                    }
                });
                return false;
            });



        });
    </script>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
