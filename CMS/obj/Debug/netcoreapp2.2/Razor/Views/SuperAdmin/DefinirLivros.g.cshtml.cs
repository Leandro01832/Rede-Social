#pragma checksum "C:\rede-social\CMS\Views\SuperAdmin\DefinirLivros.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "39209fe1f13bf36bcd9bc4a2b594ab4338af221a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SuperAdmin_DefinirLivros), @"mvc.1.0.view", @"/Views/SuperAdmin/DefinirLivros.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/SuperAdmin/DefinirLivros.cshtml", typeof(AspNetCore.Views_SuperAdmin_DefinirLivros))]
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
#line 1 "C:\rede-social\CMS\Views\_ViewImports.cshtml"
using CMS;

#line default
#line hidden
#line 2 "C:\rede-social\CMS\Views\_ViewImports.cshtml"
using CMS.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39209fe1f13bf36bcd9bc4a2b594ab4338af221a", @"/Views/SuperAdmin/DefinirLivros.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0389c18537be78d994187c367b0e0aa311ab30d", @"/Views/_ViewImports.cshtml")]
    public class Views_SuperAdmin_DefinirLivros : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 3 "C:\rede-social\CMS\Views\SuperAdmin\DefinirLivros.cshtml"
  
    ViewBag.Title = "Create";

#line default
#line hidden
            BeginContext(42, 327, true);
            WriteLiteral(@"<div class=""row"">
    <div id=""pesquisar"" class=""col-md-6"">
        <label>Pesquisa</label>
    <input id=""pesquisa"" name=""pesquisa"" type=""url"" >             

    </div>
<div id=""listaUrls"" style=""display:none; z-index:2000;"" class=""jumbotron col-md-2"">

            </div> 
</div>


    <div class=""col-md-4"">

");
            EndContext();
#line 20 "C:\rede-social\CMS\Views\SuperAdmin\DefinirLivros.cshtml"
         using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(412, 23, false);
#line 22 "C:\rede-social\CMS\Views\SuperAdmin\DefinirLivros.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(439, 61, true);
            WriteLiteral("<div class=\"\">\r\n    <h4>Definir livros</h4>\r\n    <hr />\r\n    ");
            EndContext();
            BeginContext(501, 64, false);
#line 27 "C:\rede-social\CMS\Views\SuperAdmin\DefinirLivros.cshtml"
Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(565, 229, true);
            WriteLiteral(" \r\n\r\n\r\n            <div class=\"form-group\">\r\n                <label class=\"control-label\">livro 1 - compartilhando em dia 1, 11 e 21</label>\r\n                <input id=\"livro1\" name=\"livro1\" class=\"form-control livros\" type=\"url\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 794, "\"", 817, 1);
#line 32 "C:\rede-social\CMS\Views\SuperAdmin\DefinirLivros.cshtml"
WriteAttributeValue("", 802, ViewBag.livro1, 802, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(818, 247, true);
            WriteLiteral("  >\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <label class=\"control-label\">livro 2 - compartilhando em dia 2, 12 e 22</label>\r\n                <input id=\"livro2\" name=\"livro2\" class=\"form-control livros\" type=\"url\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1065, "\"", 1088, 1);
#line 36 "C:\rede-social\CMS\Views\SuperAdmin\DefinirLivros.cshtml"
WriteAttributeValue("", 1073, ViewBag.livro2, 1073, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1089, 246, true);
            WriteLiteral(" >\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <label class=\"control-label\">livro 3 - compartilhando em dia 3, 13 e 23</label>\r\n                <input id=\"livro3\" name=\"livro3\" class=\"form-control livros\" type=\"url\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1335, "\"", 1358, 1);
#line 40 "C:\rede-social\CMS\Views\SuperAdmin\DefinirLivros.cshtml"
WriteAttributeValue("", 1343, ViewBag.livro3, 1343, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1359, 246, true);
            WriteLiteral(" >\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <label class=\"control-label\">livro 4 - compartilhando em dia 4, 14 e 24</label>\r\n                <input id=\"livro4\" name=\"livro4\" class=\"form-control livros\" type=\"url\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1605, "\"", 1628, 1);
#line 44 "C:\rede-social\CMS\Views\SuperAdmin\DefinirLivros.cshtml"
WriteAttributeValue("", 1613, ViewBag.livro4, 1613, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1629, 246, true);
            WriteLiteral(" >\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <label class=\"control-label\">livro 5 - compartilhando em dia 5, 15 e 25</label>\r\n                <input id=\"livro5\" name=\"livro5\" class=\"form-control livros\" type=\"url\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1875, "\"", 1898, 1);
#line 48 "C:\rede-social\CMS\Views\SuperAdmin\DefinirLivros.cshtml"
WriteAttributeValue("", 1883, ViewBag.livro5, 1883, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1899, 246, true);
            WriteLiteral(" >\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <label class=\"control-label\">livro 6 - compartilhando em dia 6, 16 e 26</label>\r\n                <input id=\"livro6\" name=\"livro6\" class=\"form-control livros\" type=\"url\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2145, "\"", 2168, 1);
#line 52 "C:\rede-social\CMS\Views\SuperAdmin\DefinirLivros.cshtml"
WriteAttributeValue("", 2153, ViewBag.livro6, 2153, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2169, 246, true);
            WriteLiteral(" >\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <label class=\"control-label\">livro 7 - compartilhando em dia 7, 17 e 27</label>\r\n                <input id=\"livro7\" name=\"livro7\" class=\"form-control livros\" type=\"url\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2415, "\"", 2438, 1);
#line 56 "C:\rede-social\CMS\Views\SuperAdmin\DefinirLivros.cshtml"
WriteAttributeValue("", 2423, ViewBag.livro7, 2423, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2439, 246, true);
            WriteLiteral(" >\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <label class=\"control-label\">livro 8 - compartilhando em dia 8, 18 e 28</label>\r\n                <input id=\"livro8\" name=\"livro8\" class=\"form-control livros\" type=\"url\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2685, "\"", 2708, 1);
#line 60 "C:\rede-social\CMS\Views\SuperAdmin\DefinirLivros.cshtml"
WriteAttributeValue("", 2693, ViewBag.livro8, 2693, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2709, 260, true);
            WriteLiteral(@" >
            </div>
            <div class=""form-group"">
                <label class=""control-label"">livro 9 - compartilhando em dia 9, 19 e possivelmente 29</label>
                <input id=""livro9"" name=""livro9"" class=""form-control livros"" type=""url""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2969, "\"", 2992, 1);
#line 64 "C:\rede-social\CMS\Views\SuperAdmin\DefinirLivros.cshtml"
WriteAttributeValue("", 2977, ViewBag.livro9, 2977, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2993, 264, true);
            WriteLiteral(@" >
            </div>
            <div class=""form-group"">
                <label class=""control-label"">livro 10 - compartilhando em dia 10, 20 e possivelmente 30</label>
                <input id=""livro10"" name=""livro10"" class=""form-control livros"" type=""url""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3257, "\"", 3281, 1);
#line 68 "C:\rede-social\CMS\Views\SuperAdmin\DefinirLivros.cshtml"
WriteAttributeValue("", 3265, ViewBag.livro10, 3265, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3282, 234, true);
            WriteLiteral(" >\r\n            </div>\r\n\r\n            \r\n\r\n    <div class=\"form-group\">\r\n        <div class=\"col-md-offset-2 col-md-10\">\r\n            <input type=\"submit\" value=\"Definir\" class=\"btn btn-default\" />\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            EndContext();
#line 79 "C:\rede-social\CMS\Views\SuperAdmin\DefinirLivros.cshtml"
}

#line default
#line hidden
            BeginContext(3519, 37, true);
            WriteLiteral("\r\n    </div>\r\n\r\n    \r\n\r\n\r\n<div>\r\n    ");
            EndContext();
            BeginContext(3557, 47, false);
#line 87 "C:\rede-social\CMS\Views\SuperAdmin\DefinirLivros.cshtml"
Write(Html.ActionLink("Voltar para a lista", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(3604, 73, true);
            WriteLiteral("\r\n</div>\r\n\r\n<label>Lista:</label>\r\n<input type=\"number\" id=\"numeroAcesso\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3677, "\"", 3700, 1);
#line 91 "C:\rede-social\CMS\Views\SuperAdmin\DefinirLivros.cshtml"
WriteAttributeValue("", 3685, ViewBag.pagina, 3685, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3701, 15, true);
            WriteLiteral(" min=\"1\" />\r\n\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(3733, 2170, true);
                WriteLiteral(@"


<script type=""text/javascript"">
    $(document).ready(function () {

        $(""#numeroAcesso"").change(function () {
            window.location.href = ""/SuperAdmin/DefinirLivros/"" + $(this).val();
        });

});
</script>

<script type=""text/javascript"">

             function buscarLivro(url)
            {
                var lista = $("".livros"");
                for(var i = 0; i < lista.length; i++)
                {
                    if(lista[i].value == """")
                    {
                        lista[i].value = url;
                        break;
                    }
                }
                 $(""#listaUrls"").css(""display"", ""none"");
                 $(""#pesquisa"").val("""");
            }         

</script>
    
<script type=""text/javascript"">
        $(document).ready(function () {

            
            
            $(""#pesquisa"").keyup(function(){   
         

                 $.ajax({
                    type: 'POST',
              ");
                WriteLiteral(@"      url: '/AjaxGet/BuscarLivros',
                    dataType: 'json',
                    data: { valor: $(this).val() },
                    success: function (data) {                       

                        if (data == null)
                            $(""#listaUrls"").css(""display"", ""none"");
                        else
                            $(""#listaUrls"").css(""display"", ""block"");
                        $(""#listaUrls"").empty();
                        $.each(data, function (i) {
                            
                            $(""#listaUrls"").append(""<p>"" +
                             ""<a href='#' onclick="" + ""\""buscarLivro('""+ data[i].url+""');\"" >"" +
                                data[i].url +
                                ""</a></p> <br>"");
                                              
                        });
                        

                    },
                    error: function (ex) {
                        alert('Falha ao buscar u");
                WriteLiteral("rls.\' + ex);\r\n                    }\r\n                });\r\n\r\n            });\r\n\r\n             \r\n\r\n        });\r\n</script>\r\n\r\n");
                EndContext();
            }
            );
            BeginContext(5906, 4, true);
            WriteLiteral("\r\n\r\n");
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
