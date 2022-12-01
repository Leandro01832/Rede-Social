#pragma checksum "C:\Rede-Social-master\clone\Rede-Social\CMS\Views\Home\Perfil.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "247750c5f2067050719a9fb98f1909040b0fa8ec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Perfil), @"mvc.1.0.view", @"/Views/Home/Perfil.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Perfil.cshtml", typeof(AspNetCore.Views_Home_Perfil))]
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
#line 1 "C:\Rede-Social-master\clone\Rede-Social\CMS\Views\_ViewImports.cshtml"
using CMS;

#line default
#line hidden
#line 2 "C:\Rede-Social-master\clone\Rede-Social\CMS\Views\_ViewImports.cshtml"
using CMS.Models;

#line default
#line hidden
#line 1 "C:\Rede-Social-master\clone\Rede-Social\CMS\Views\Home\Perfil.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"247750c5f2067050719a9fb98f1909040b0fa8ec", @"/Views/Home/Perfil.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"600f5e98c0b7ea1830bf7c16785f85b547fc669d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Perfil : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CMS.Models.UserModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Home/Aceitar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(155, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 6 "C:\Rede-Social-master\clone\Rede-Social\CMS\Views\Home\Perfil.cshtml"
  
    ViewData["Title"] = "Perfil";
    List<UserModel> seguidores = ViewBag.seguidores;
    List<UserModel> seguindo = ViewBag.seguindo;
    List<business.business.Group.Story> stories = ViewBag.stories;
    List<UserModel> solicitacoes = ViewBag.solicitacoes;
    var user = await UserManager.GetUserAsync(this.User);

#line default
#line hidden
            BeginContext(479, 57, true);
            WriteLiteral("\n<h2>Perfil</h2>\n\n\n<img class=\"img-circle img-responsive\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 536, "\"", 554, 1);
#line 18 "C:\Rede-Social-master\clone\Rede-Social\CMS\Views\Home\Perfil.cshtml"
WriteAttributeValue("", 542, Model.Image, 542, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(555, 16, true);
            WriteLiteral(" width=\"100\" />\n");
            EndContext();
#line 19 "C:\Rede-Social-master\clone\Rede-Social\CMS\Views\Home\Perfil.cshtml"
 if (SignInManager.IsSignedIn(User) && user.Id == Model.Id)
{

#line default
#line hidden
            BeginContext(633, 70, true);
            WriteLiteral("    <a href=\"/Home/Alterar\" class=\"btn btn-primary\">Alterar dados</a>\n");
            EndContext();
#line 22 "C:\Rede-Social-master\clone\Rede-Social\CMS\Views\Home\Perfil.cshtml"
}

#line default
#line hidden
            BeginContext(705, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 24 "C:\Rede-Social-master\clone\Rede-Social\CMS\Views\Home\Perfil.cshtml"
 if (SignInManager.IsSignedIn(User) && user.Id != Model.Id)
{
    if (seguidores.FirstOrDefault() == null)
    {

#line default
#line hidden
            BeginContext(819, 10, true);
            WriteLiteral("        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 829, "\"", 860, 2);
            WriteAttributeValue("", 836, "/Home/Seguir/", 836, 13, true);
#line 28 "C:\Rede-Social-master\clone\Rede-Social\CMS\Views\Home\Perfil.cshtml"
WriteAttributeValue("", 849, Model.Name, 849, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(861, 43, true);
            WriteLiteral(" class=\"btn btn-primary\">Seguir Perfil</a>\n");
            EndContext();
#line 29 "C:\Rede-Social-master\clone\Rede-Social\CMS\Views\Home\Perfil.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(925, 24, true);
            WriteLiteral("        <p>seguindo</p>\n");
            EndContext();
#line 33 "C:\Rede-Social-master\clone\Rede-Social\CMS\Views\Home\Perfil.cshtml"
    }
}

#line default
#line hidden
            BeginContext(957, 35, true);
            WriteLiteral("\n\n\n<div class=\"jumbotron\">\n    <h4>");
            EndContext();
            BeginContext(993, 10, false);
#line 39 "C:\Rede-Social-master\clone\Rede-Social\CMS\Views\Home\Perfil.cshtml"
   Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1003, 203, true);
            WriteLiteral("</h4>\n    <hr />\n\n    <div style=\"z-index: 2;\">\n        <input type=\"number\" id=\"NumeroPaginaAcesso\" style=\"width:80%; margin-left: 60px;\"\n               placeholder=\"N° do capítulo. Ex: 2, 3, 4, 5, ...\"");
            EndContext();
            BeginWriteAttribute("max", " max=\"", 1206, "\"", 1231, 1);
#line 44 "C:\Rede-Social-master\clone\Rede-Social\CMS\Views\Home\Perfil.cshtml"
WriteAttributeValue("", 1212, ViewBag.quantidade, 1212, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1232, 264, true);
            WriteLiteral(@" />
        <center>
            <button id=""acessoPaginaComInput""  class=""btn btn-primary glyphicon glyphicon-search"">
                Acessar
            </button>
        </center>
    </div>

    <hr />

    <dl class=""dl-horizontal"">
        <dt>
            ");
            EndContext();
            BeginContext(1497, 25, false);
#line 56 "C:\Rede-Social-master\clone\Rede-Social\CMS\Views\Home\Perfil.cshtml"
       Write(Html.DisplayName("Email"));

#line default
#line hidden
            EndContext();
            BeginContext(1522, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(1563, 40, false);
#line 59 "C:\Rede-Social-master\clone\Rede-Social\CMS\Views\Home\Perfil.cshtml"
       Write(Html.DisplayFor(model => model.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(1603, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(1644, 35, false);
#line 62 "C:\Rede-Social-master\clone\Rede-Social\CMS\Views\Home\Perfil.cshtml"
       Write(Html.DisplayName("Nome de usuario"));

#line default
#line hidden
            EndContext();
            BeginContext(1679, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(1720, 36, false);
#line 65 "C:\Rede-Social-master\clone\Rede-Social\CMS\Views\Home\Perfil.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1756, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(1797, 43, false);
#line 68 "C:\Rede-Social-master\clone\Rede-Social\CMS\Views\Home\Perfil.cshtml"
       Write(Html.DisplayNameFor(model => model.Twitter));

#line default
#line hidden
            EndContext();
            BeginContext(1840, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(1881, 39, false);
#line 71 "C:\Rede-Social-master\clone\Rede-Social\CMS\Views\Home\Perfil.cshtml"
       Write(Html.DisplayFor(model => model.Twitter));

#line default
#line hidden
            EndContext();
            BeginContext(1920, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(1961, 45, false);
#line 74 "C:\Rede-Social-master\clone\Rede-Social\CMS\Views\Home\Perfil.cshtml"
       Write(Html.DisplayNameFor(model => model.Instagram));

#line default
#line hidden
            EndContext();
            BeginContext(2006, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(2047, 41, false);
#line 77 "C:\Rede-Social-master\clone\Rede-Social\CMS\Views\Home\Perfil.cshtml"
       Write(Html.DisplayFor(model => model.Instagram));

#line default
#line hidden
            EndContext();
            BeginContext(2088, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(2129, 44, false);
#line 80 "C:\Rede-Social-master\clone\Rede-Social\CMS\Views\Home\Perfil.cshtml"
       Write(Html.DisplayNameFor(model => model.Facebook));

#line default
#line hidden
            EndContext();
            BeginContext(2173, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(2214, 40, false);
#line 83 "C:\Rede-Social-master\clone\Rede-Social\CMS\Views\Home\Perfil.cshtml"
       Write(Html.DisplayFor(model => model.Facebook));

#line default
#line hidden
            EndContext();
            BeginContext(2254, 151, true);
            WriteLiteral("\n        </dd>\n    </dl>\n</div>\n\n<div class=\"row\">\n\n    <div class=\"col-md-6 text-center bg-warning\" style=\"display:grid\">\n        <p>Solicitações</p>\n");
            EndContext();
#line 92 "C:\Rede-Social-master\clone\Rede-Social\CMS\Views\Home\Perfil.cshtml"
          
            foreach (var item in solicitacoes)
            {

#line default
#line hidden
            BeginContext(2477, 54, true);
            WriteLiteral("                <img class=\"img-circle img-responsive\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 2531, "\"", 2548, 1);
#line 95 "C:\Rede-Social-master\clone\Rede-Social\CMS\Views\Home\Perfil.cshtml"
WriteAttributeValue("", 2537, item.Image, 2537, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2549, 34, true);
            WriteLiteral(" width=\"100\" />\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2583, "\"", 2608, 2);
            WriteAttributeValue("", 2590, "/Perfil/", 2590, 8, true);
#line 96 "C:\Rede-Social-master\clone\Rede-Social\CMS\Views\Home\Perfil.cshtml"
WriteAttributeValue("", 2598, item.Name, 2598, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2609, 28, true);
            WriteLiteral(">Perfil</a>\n                ");
            EndContext();
            BeginContext(2637, 338, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "247750c5f2067050719a9fb98f1909040b0fa8ec13379", async() => {
                BeginContext(2680, 41, true);
                WriteLiteral("\n                    <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2721, "\"", 2739, 1);
#line 98 "C:\Rede-Social-master\clone\Rede-Social\CMS\Views\Home\Perfil.cshtml"
WriteAttributeValue("", 2729, item.Name, 2729, 10, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2740, 74, true);
                WriteLiteral(" name=\"Seguidor\" id=\"Seguidor\" />\n                    <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2814, "\"", 2833, 1);
#line 99 "C:\Rede-Social-master\clone\Rede-Social\CMS\Views\Home\Perfil.cshtml"
WriteAttributeValue("", 2822, Model.Name, 2822, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2834, 134, true);
                WriteLiteral(" name=\"Seguindo\" id=\"Seguindo\" />\n                    <input type=\'submit\' value=\'Aceitar\' class=\'btn btn-default\' />\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2975, 24, true);
            WriteLiteral("\n                <hr />\n");
            EndContext();
#line 103 "C:\Rede-Social-master\clone\Rede-Social\CMS\Views\Home\Perfil.cshtml"
            }
        

#line default
#line hidden
            BeginContext(3023, 98, true);
            WriteLiteral("    </div>\n\n    <div class=\"col-md-6 text-center\" style=\"display:grid\">\n        <p>Seguidores</p>\n");
            EndContext();
#line 109 "C:\Rede-Social-master\clone\Rede-Social\CMS\Views\Home\Perfil.cshtml"
          
            foreach (var item in seguidores)
            {

#line default
#line hidden
            BeginContext(3191, 80, true);
            WriteLiteral("                <div>\n                    <img class=\"img-circle img-responsive\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 3271, "\"", 3288, 1);
#line 113 "C:\Rede-Social-master\clone\Rede-Social\CMS\Views\Home\Perfil.cshtml"
WriteAttributeValue("", 3277, item.Image, 3277, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3289, 42, true);
            WriteLiteral(" width=\"100\" />\n                    <span>");
            EndContext();
            BeginContext(3332, 9, false);
#line 114 "C:\Rede-Social-master\clone\Rede-Social\CMS\Views\Home\Perfil.cshtml"
                     Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(3341, 31, true);
            WriteLiteral("</span>\n                </div>\n");
            EndContext();
#line 116 "C:\Rede-Social-master\clone\Rede-Social\CMS\Views\Home\Perfil.cshtml"
            }
        

#line default
#line hidden
            BeginContext(3396, 96, true);
            WriteLiteral("    </div>\n\n    <div class=\"col-md-6 text-center\" style=\"display:grid\">\n        <p>Seguindo</p>\n");
            EndContext();
#line 122 "C:\Rede-Social-master\clone\Rede-Social\CMS\Views\Home\Perfil.cshtml"
          
            foreach (var item in seguindo)
            {

#line default
#line hidden
            BeginContext(3560, 80, true);
            WriteLiteral("                <div>\n                    <img class=\"img-circle img-responsive\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 3640, "\"", 3657, 1);
#line 126 "C:\Rede-Social-master\clone\Rede-Social\CMS\Views\Home\Perfil.cshtml"
WriteAttributeValue("", 3646, item.Image, 3646, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3658, 42, true);
            WriteLiteral(" width=\"100\" />\n                    <span>");
            EndContext();
            BeginContext(3701, 9, false);
#line 127 "C:\Rede-Social-master\clone\Rede-Social\CMS\Views\Home\Perfil.cshtml"
                     Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(3710, 31, true);
            WriteLiteral("</span>\n                </div>\n");
            EndContext();
#line 129 "C:\Rede-Social-master\clone\Rede-Social\CMS\Views\Home\Perfil.cshtml"
            }
        

#line default
#line hidden
            BeginContext(3765, 12, true);
            WriteLiteral("    </div>\n\n");
            EndContext();
#line 133 "C:\Rede-Social-master\clone\Rede-Social\CMS\Views\Home\Perfil.cshtml"
      
        if (stories.Count > 0)
        {

#line default
#line hidden
            BeginContext(3825, 256, true);
            WriteLiteral(@"            <div class=""col-md-6 text-center bg-warning"" style=""display:grid"">
                <p>Sumário</p>
                <table>
                    <thead>
                        <tr>
                            <th>
                                ");
            EndContext();
            BeginContext(4082, 27, false);
#line 142 "C:\Rede-Social-master\clone\Rede-Social\CMS\Views\Home\Perfil.cshtml"
                           Write(Html.DisplayName("Stories"));

#line default
#line hidden
            EndContext();
            BeginContext(4109, 170, true);
            WriteLiteral("\n                            </th>\n                            <th></th>\n                            <th></th>\n                        </tr>\n                    </thead>\n");
            EndContext();
#line 148 "C:\Rede-Social-master\clone\Rede-Social\CMS\Views\Home\Perfil.cshtml"
                      

                        foreach (var item in stories)
                        {

#line default
#line hidden
            BeginContext(4383, 112, true);
            WriteLiteral("                            <tr>\n                                <td>\n                                    Story ");
            EndContext();
            BeginContext(4496, 9, false);
#line 154 "C:\Rede-Social-master\clone\Rede-Social\CMS\Views\Home\Perfil.cshtml"
                                     Write(item.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(4505, 265, true);
            WriteLiteral(@"
                                </td>
                                <td>
                                    .......................................
                                </td>
                                <td>
                                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4770, "\"", 4830, 4);
            WriteAttributeValue("", 4777, "/Renderizar/", 4777, 12, true);
#line 160 "C:\Rede-Social-master\clone\Rede-Social\CMS\Views\Home\Perfil.cshtml"
WriteAttributeValue("", 4789, Model.Name, 4789, 11, false);

#line default
#line hidden
            WriteAttributeValue("", 4800, "/Padrao/", 4800, 8, true);
#line 160 "C:\Rede-Social-master\clone\Rede-Social\CMS\Views\Home\Perfil.cshtml"
WriteAttributeValue("", 4808, item.PaginaPadraoLink, 4808, 22, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4831, 6, true);
            WriteLiteral(">Cap. ");
            EndContext();
            BeginContext(4838, 21, false);
#line 160 "C:\Rede-Social-master\clone\Rede-Social\CMS\Views\Home\Perfil.cshtml"
                                                                                                    Write(item.PaginaPadraoLink);

#line default
#line hidden
            EndContext();
            BeginContext(4859, 77, true);
            WriteLiteral("</a>\n                                </td>\n                            </tr>\n");
            EndContext();
#line 163 "C:\Rede-Social-master\clone\Rede-Social\CMS\Views\Home\Perfil.cshtml"
                        }
                    

#line default
#line hidden
            BeginContext(4984, 44, true);
            WriteLiteral("                </table>\n            </div>\n");
            EndContext();
#line 167 "C:\Rede-Social-master\clone\Rede-Social\CMS\Views\Home\Perfil.cshtml"
        }
    

#line default
#line hidden
            BeginContext(5044, 12, true);
            WriteLiteral("\n\n\n\n</div>\n\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(5074, 302, true);
                WriteLiteral(@"
<script type=""text/javascript"">
        $(document).ready(function () {


            function BuscarStory(valorPaginaPadraoLink) {
        $.ajax({
            type: 'POST',
            url: '/AjaxGet/GetStory',
            dataType: 'json',
            data: { Indice: valorPaginaPadraoLink, User: """);
                EndContext();
                BeginContext(5377, 10, false);
#line 185 "C:\Rede-Social-master\clone\Rede-Social\CMS\Views\Home\Perfil.cshtml"
                                                     Write(Model.Name);

#line default
#line hidden
                EndContext();
                BeginContext(5387, 154, true);
                WriteLiteral("\" }\n        })\n            .done(function(response) {\n\n                if(response[0] == \"Story\")\n                window.location.href = \"/Renderizar/\"+ \"");
                EndContext();
                BeginContext(5542, 10, false);
#line 190 "C:\Rede-Social-master\clone\Rede-Social\CMS\Views\Home\Perfil.cshtml"
                                                   Write(Model.Name);

#line default
#line hidden
                EndContext();
                BeginContext(5552, 140, true);
                WriteLiteral("\"  +  \"/\"  +  response[1] +  \"/1\";\n                else if(response[0] == \"SubStory\")\n                window.location.href = \"/SubStory/\"+ \"");
                EndContext();
                BeginContext(5693, 10, false);
#line 192 "C:\Rede-Social-master\clone\Rede-Social\CMS\Views\Home\Perfil.cshtml"
                                                 Write(Model.Name);

#line default
#line hidden
                EndContext();
                BeginContext(5703, 138, true);
                WriteLiteral("\"    +  \"/\"  +  response[1] +  \"/1/1\";\n                else if(response[0] == \"Grupo\")\n                window.location.href = \"/Grupo/\"+ \"");
                EndContext();
                BeginContext(5842, 10, false);
#line 194 "C:\Rede-Social-master\clone\Rede-Social\CMS\Views\Home\Perfil.cshtml"
                                              Write(Model.Name);

#line default
#line hidden
                EndContext();
                BeginContext(5852, 149, true);
                WriteLiteral("\"       +  \"/\"  +  response[1] +  \"/1/1/1\";\n                else if(response[0] == \"SubGrupo\")\n                window.location.href = \"/SubGrupo/\"+ \"");
                EndContext();
                BeginContext(6002, 10, false);
#line 196 "C:\Rede-Social-master\clone\Rede-Social\CMS\Views\Home\Perfil.cshtml"
                                                 Write(Model.Name);

#line default
#line hidden
                EndContext();
                BeginContext(6012, 154, true);
                WriteLiteral("\"    +  \"/\"  +  response[1] +  \"/1/1/1/1\";\n                else if(response[0] == \"SubSubGrupo\")\n                window.location.href = \"/SubSubGrupo/\"+ \"");
                EndContext();
                BeginContext(6167, 10, false);
#line 198 "C:\Rede-Social-master\clone\Rede-Social\CMS\Views\Home\Perfil.cshtml"
                                                    Write(Model.Name);

#line default
#line hidden
                EndContext();
                BeginContext(6177, 596, true);
                WriteLiteral(@""" +  ""/""  +  response[1] +  ""/1/1/1/1/1"";
            });
            return false;
    }

             function refreshData() 
             {
                $.ajax({
                    type: 'POST',
                    url: '/AjaxGet/refresh',
                    dataType: 'json',
                    data: {  }
                    })
                    .done(function(response) {
                       
                    });
             }

           // $(""#NumeroPaginaAcesso"").change(function () {
               // document.getElementById('acessoPaginaComInput').href = '/Renderizar/");
                EndContext();
                BeginContext(6774, 10, false);
#line 217 "C:\Rede-Social-master\clone\Rede-Social\CMS\Views\Home\Perfil.cshtml"
                                                                                 Write(Model.Name);

#line default
#line hidden
                EndContext();
                BeginContext(6784, 567, true);
                WriteLiteral(@"/0/';
               // document.getElementById(""acessoPaginaComInput"").href +=  $(this).val();

          //  });

            $(""#acessoPaginaComInput"").click(function(){

                if($(""#NumeroPaginaAcesso"").val() != """")
                {
                    var num =  parseInt($(""#NumeroPaginaAcesso"").val());
                    BuscarStory(num - 1);
                }
                else
                alert(""Informe o numero do capitulo!!!"");

            });

            setTimeout(function () { refreshData(); }, 300000);


        });
</script>
");
                EndContext();
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<UserModel> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<UserModel> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CMS.Models.UserModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
