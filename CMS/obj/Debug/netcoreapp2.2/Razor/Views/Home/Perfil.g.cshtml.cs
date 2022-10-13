#pragma checksum "C:\Users\leand\Downloads\teste\cms\CMS\Views\Home\Perfil.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a99d29d3925ac687fb73ee5a97dc18e683b142bc"
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
#line 1 "C:\Users\leand\Downloads\teste\cms\CMS\Views\_ViewImports.cshtml"
using CMS;

#line default
#line hidden
#line 2 "C:\Users\leand\Downloads\teste\cms\CMS\Views\_ViewImports.cshtml"
using CMS.Models;

#line default
#line hidden
#line 1 "C:\Users\leand\Downloads\teste\cms\CMS\Views\Home\Perfil.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a99d29d3925ac687fb73ee5a97dc18e683b142bc", @"/Views/Home/Perfil.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0389c18537be78d994187c367b0e0aa311ab30d", @"/Views/_ViewImports.cshtml")]
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
            BeginContext(159, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 6 "C:\Users\leand\Downloads\teste\cms\CMS\Views\Home\Perfil.cshtml"
  
    ViewData["Title"] = "Perfil";
    List<UserModel> seguidores = ViewBag.seguidores;
    List<UserModel> seguindo = ViewBag.seguindo;
    List<business.business.Group.Story> stories = ViewBag.stories;
    List<UserModel> solicitacoes = ViewBag.solicitacoes;
    var user = await UserManager.GetUserAsync(this.User);

#line default
#line hidden
            BeginContext(492, 61, true);
            WriteLiteral("\r\n<h2>Perfil</h2>\r\n\r\n\r\n<img class=\"img-circle img-responsive\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 553, "\"", 571, 1);
#line 18 "C:\Users\leand\Downloads\teste\cms\CMS\Views\Home\Perfil.cshtml"
WriteAttributeValue("", 559, Model.Image, 559, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(572, 17, true);
            WriteLiteral(" width=\"100\" />\r\n");
            EndContext();
#line 19 "C:\Users\leand\Downloads\teste\cms\CMS\Views\Home\Perfil.cshtml"
 if (SignInManager.IsSignedIn(User) && user.Id == Model.Id)
{

#line default
#line hidden
            BeginContext(653, 71, true);
            WriteLiteral("    <a href=\"/Home/Alterar\" class=\"btn btn-primary\">Alterar dados</a>\r\n");
            EndContext();
#line 22 "C:\Users\leand\Downloads\teste\cms\CMS\Views\Home\Perfil.cshtml"
}

#line default
#line hidden
            BeginContext(727, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 24 "C:\Users\leand\Downloads\teste\cms\CMS\Views\Home\Perfil.cshtml"
 if (SignInManager.IsSignedIn(User) && user.Id != Model.Id)
{
    if (seguidores.FirstOrDefault() == null)
    {

#line default
#line hidden
            BeginContext(846, 10, true);
            WriteLiteral("        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 856, "\"", 887, 2);
            WriteAttributeValue("", 863, "/Home/Seguir/", 863, 13, true);
#line 28 "C:\Users\leand\Downloads\teste\cms\CMS\Views\Home\Perfil.cshtml"
WriteAttributeValue("", 876, Model.Name, 876, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(888, 44, true);
            WriteLiteral(" class=\"btn btn-primary\">Seguir Perfil</a>\r\n");
            EndContext();
#line 29 "C:\Users\leand\Downloads\teste\cms\CMS\Views\Home\Perfil.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(956, 25, true);
            WriteLiteral("        <p>seguindo</p>\r\n");
            EndContext();
#line 33 "C:\Users\leand\Downloads\teste\cms\CMS\Views\Home\Perfil.cshtml"
    }
}

#line default
#line hidden
            BeginContext(991, 39, true);
            WriteLiteral("\r\n\r\n\r\n<div class=\"jumbotron\">\r\n    <h4>");
            EndContext();
            BeginContext(1031, 10, false);
#line 39 "C:\Users\leand\Downloads\teste\cms\CMS\Views\Home\Perfil.cshtml"
   Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1041, 208, true);
            WriteLiteral("</h4>\r\n    <hr />\r\n\r\n    <div style=\"z-index: 2;\">\r\n        <input type=\"number\" id=\"NumeroPaginaAcesso\" style=\"width:80%; margin-left: 60px;\"\r\n               placeholder=\"N° do capítulo. Ex: 2, 3, 4, 5, ...\"");
            EndContext();
            BeginWriteAttribute("max", " max=\"", 1249, "\"", 1274, 1);
#line 44 "C:\Users\leand\Downloads\teste\cms\CMS\Views\Home\Perfil.cshtml"
WriteAttributeValue("", 1255, ViewBag.quantidade, 1255, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1275, 276, true);
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
            BeginContext(1552, 25, false);
#line 56 "C:\Users\leand\Downloads\teste\cms\CMS\Views\Home\Perfil.cshtml"
       Write(Html.DisplayName("Email"));

#line default
#line hidden
            EndContext();
            BeginContext(1577, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1621, 40, false);
#line 59 "C:\Users\leand\Downloads\teste\cms\CMS\Views\Home\Perfil.cshtml"
       Write(Html.DisplayFor(model => model.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(1661, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1705, 35, false);
#line 62 "C:\Users\leand\Downloads\teste\cms\CMS\Views\Home\Perfil.cshtml"
       Write(Html.DisplayName("Nome de usuario"));

#line default
#line hidden
            EndContext();
            BeginContext(1740, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1784, 36, false);
#line 65 "C:\Users\leand\Downloads\teste\cms\CMS\Views\Home\Perfil.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1820, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1864, 43, false);
#line 68 "C:\Users\leand\Downloads\teste\cms\CMS\Views\Home\Perfil.cshtml"
       Write(Html.DisplayNameFor(model => model.Twitter));

#line default
#line hidden
            EndContext();
            BeginContext(1907, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1951, 39, false);
#line 71 "C:\Users\leand\Downloads\teste\cms\CMS\Views\Home\Perfil.cshtml"
       Write(Html.DisplayFor(model => model.Twitter));

#line default
#line hidden
            EndContext();
            BeginContext(1990, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2034, 45, false);
#line 74 "C:\Users\leand\Downloads\teste\cms\CMS\Views\Home\Perfil.cshtml"
       Write(Html.DisplayNameFor(model => model.Instagram));

#line default
#line hidden
            EndContext();
            BeginContext(2079, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2123, 41, false);
#line 77 "C:\Users\leand\Downloads\teste\cms\CMS\Views\Home\Perfil.cshtml"
       Write(Html.DisplayFor(model => model.Instagram));

#line default
#line hidden
            EndContext();
            BeginContext(2164, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2208, 44, false);
#line 80 "C:\Users\leand\Downloads\teste\cms\CMS\Views\Home\Perfil.cshtml"
       Write(Html.DisplayNameFor(model => model.Facebook));

#line default
#line hidden
            EndContext();
            BeginContext(2252, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2296, 40, false);
#line 83 "C:\Users\leand\Downloads\teste\cms\CMS\Views\Home\Perfil.cshtml"
       Write(Html.DisplayFor(model => model.Facebook));

#line default
#line hidden
            EndContext();
            BeginContext(2336, 160, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n\r\n<div class=\"row\">\r\n\r\n    <div class=\"col-md-6 text-center bg-warning\" style=\"display:grid\">\r\n        <p>Solicitações</p>\r\n");
            EndContext();
#line 92 "C:\Users\leand\Downloads\teste\cms\CMS\Views\Home\Perfil.cshtml"
          
            foreach (var item in solicitacoes)
            {

#line default
#line hidden
            BeginContext(2571, 54, true);
            WriteLiteral("                <img class=\"img-circle img-responsive\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 2625, "\"", 2642, 1);
#line 95 "C:\Users\leand\Downloads\teste\cms\CMS\Views\Home\Perfil.cshtml"
WriteAttributeValue("", 2631, item.Image, 2631, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2643, 35, true);
            WriteLiteral(" width=\"100\" />\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2678, "\"", 2703, 2);
            WriteAttributeValue("", 2685, "/Perfil/", 2685, 8, true);
#line 96 "C:\Users\leand\Downloads\teste\cms\CMS\Views\Home\Perfil.cshtml"
WriteAttributeValue("", 2693, item.Name, 2693, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2704, 29, true);
            WriteLiteral(">Perfil</a>\r\n                ");
            EndContext();
            BeginContext(2733, 342, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a99d29d3925ac687fb73ee5a97dc18e683b142bc13393", async() => {
                BeginContext(2776, 42, true);
                WriteLiteral("\r\n                    <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2818, "\"", 2836, 1);
#line 98 "C:\Users\leand\Downloads\teste\cms\CMS\Views\Home\Perfil.cshtml"
WriteAttributeValue("", 2826, item.Name, 2826, 10, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2837, 75, true);
                WriteLiteral(" name=\"Seguidor\" id=\"Seguidor\" />\r\n                    <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2912, "\"", 2931, 1);
#line 99 "C:\Users\leand\Downloads\teste\cms\CMS\Views\Home\Perfil.cshtml"
WriteAttributeValue("", 2920, Model.Name, 2920, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2932, 136, true);
                WriteLiteral(" name=\"Seguindo\" id=\"Seguindo\" />\r\n                    <input type=\'submit\' value=\'Aceitar\' class=\'btn btn-default\' />\r\n                ");
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
            BeginContext(3075, 26, true);
            WriteLiteral("\r\n                <hr />\r\n");
            EndContext();
#line 103 "C:\Users\leand\Downloads\teste\cms\CMS\Views\Home\Perfil.cshtml"
            }
        

#line default
#line hidden
            BeginContext(3127, 102, true);
            WriteLiteral("    </div>\r\n\r\n    <div class=\"col-md-6 text-center\" style=\"display:grid\">\r\n        <p>Seguidores</p>\r\n");
            EndContext();
#line 109 "C:\Users\leand\Downloads\teste\cms\CMS\Views\Home\Perfil.cshtml"
          
            foreach (var item in seguidores)
            {

#line default
#line hidden
            BeginContext(3302, 81, true);
            WriteLiteral("                <div>\r\n                    <img class=\"img-circle img-responsive\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 3383, "\"", 3400, 1);
#line 113 "C:\Users\leand\Downloads\teste\cms\CMS\Views\Home\Perfil.cshtml"
WriteAttributeValue("", 3389, item.Image, 3389, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3401, 43, true);
            WriteLiteral(" width=\"100\" />\r\n                    <span>");
            EndContext();
            BeginContext(3445, 9, false);
#line 114 "C:\Users\leand\Downloads\teste\cms\CMS\Views\Home\Perfil.cshtml"
                     Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(3454, 33, true);
            WriteLiteral("</span>\r\n                </div>\r\n");
            EndContext();
#line 116 "C:\Users\leand\Downloads\teste\cms\CMS\Views\Home\Perfil.cshtml"
            }
        

#line default
#line hidden
            BeginContext(3513, 100, true);
            WriteLiteral("    </div>\r\n\r\n    <div class=\"col-md-6 text-center\" style=\"display:grid\">\r\n        <p>Seguindo</p>\r\n");
            EndContext();
#line 122 "C:\Users\leand\Downloads\teste\cms\CMS\Views\Home\Perfil.cshtml"
          
            foreach (var item in seguindo)
            {

#line default
#line hidden
            BeginContext(3684, 81, true);
            WriteLiteral("                <div>\r\n                    <img class=\"img-circle img-responsive\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 3765, "\"", 3782, 1);
#line 126 "C:\Users\leand\Downloads\teste\cms\CMS\Views\Home\Perfil.cshtml"
WriteAttributeValue("", 3771, item.Image, 3771, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3783, 43, true);
            WriteLiteral(" width=\"100\" />\r\n                    <span>");
            EndContext();
            BeginContext(3827, 9, false);
#line 127 "C:\Users\leand\Downloads\teste\cms\CMS\Views\Home\Perfil.cshtml"
                     Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(3836, 33, true);
            WriteLiteral("</span>\r\n                </div>\r\n");
            EndContext();
#line 129 "C:\Users\leand\Downloads\teste\cms\CMS\Views\Home\Perfil.cshtml"
            }
        

#line default
#line hidden
            BeginContext(3895, 14, true);
            WriteLiteral("    </div>\r\n\r\n");
            EndContext();
#line 133 "C:\Users\leand\Downloads\teste\cms\CMS\Views\Home\Perfil.cshtml"
      
        if (stories.Count > 0)
        {

#line default
#line hidden
            BeginContext(3960, 262, true);
            WriteLiteral(@"            <div class=""col-md-6 text-center bg-warning"" style=""display:grid"">
                <p>Sumário</p>
                <table>
                    <thead>
                        <tr>
                            <th>
                                ");
            EndContext();
            BeginContext(4223, 27, false);
#line 142 "C:\Users\leand\Downloads\teste\cms\CMS\Views\Home\Perfil.cshtml"
                           Write(Html.DisplayName("Stories"));

#line default
#line hidden
            EndContext();
            BeginContext(4250, 176, true);
            WriteLiteral("\r\n                            </th>\r\n                            <th></th>\r\n                            <th></th>\r\n                        </tr>\r\n                    </thead>\r\n");
            EndContext();
#line 148 "C:\Users\leand\Downloads\teste\cms\CMS\Views\Home\Perfil.cshtml"
                      

                        foreach (var item in stories)
                        {

#line default
#line hidden
            BeginContext(4534, 114, true);
            WriteLiteral("                            <tr>\r\n                                <td>\r\n                                    Story ");
            EndContext();
            BeginContext(4649, 9, false);
#line 154 "C:\Users\leand\Downloads\teste\cms\CMS\Views\Home\Perfil.cshtml"
                                     Write(item.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(4658, 271, true);
            WriteLiteral(@"
                                </td>
                                <td>
                                    .......................................
                                </td>
                                <td>
                                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4929, "\"", 4989, 4);
            WriteAttributeValue("", 4936, "/Renderizar/", 4936, 12, true);
#line 160 "C:\Users\leand\Downloads\teste\cms\CMS\Views\Home\Perfil.cshtml"
WriteAttributeValue("", 4948, Model.Name, 4948, 11, false);

#line default
#line hidden
            WriteAttributeValue("", 4959, "/Padrao/", 4959, 8, true);
#line 160 "C:\Users\leand\Downloads\teste\cms\CMS\Views\Home\Perfil.cshtml"
WriteAttributeValue("", 4967, item.PaginaPadraoLink, 4967, 22, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4990, 6, true);
            WriteLiteral(">Cap. ");
            EndContext();
            BeginContext(4997, 21, false);
#line 160 "C:\Users\leand\Downloads\teste\cms\CMS\Views\Home\Perfil.cshtml"
                                                                                                    Write(item.PaginaPadraoLink);

#line default
#line hidden
            EndContext();
            BeginContext(5018, 80, true);
            WriteLiteral("</a>\r\n                                </td>\r\n                            </tr>\r\n");
            EndContext();
#line 163 "C:\Users\leand\Downloads\teste\cms\CMS\Views\Home\Perfil.cshtml"
                        }
                    

#line default
#line hidden
            BeginContext(5148, 46, true);
            WriteLiteral("                </table>\r\n            </div>\r\n");
            EndContext();
#line 167 "C:\Users\leand\Downloads\teste\cms\CMS\Views\Home\Perfil.cshtml"
        }
    

#line default
#line hidden
            BeginContext(5212, 18, true);
            WriteLiteral("\r\n\r\n\r\n\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(5248, 312, true);
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
                BeginContext(5561, 10, false);
#line 185 "C:\Users\leand\Downloads\teste\cms\CMS\Views\Home\Perfil.cshtml"
                                                     Write(Model.Name);

#line default
#line hidden
                EndContext();
                BeginContext(5571, 159, true);
                WriteLiteral("\" }\r\n        })\r\n            .done(function(response) {\r\n\r\n                if(response[0] == \"Story\")\r\n                window.location.href = \"/Renderizar/\"+ \"");
                EndContext();
                BeginContext(5731, 10, false);
#line 190 "C:\Users\leand\Downloads\teste\cms\CMS\Views\Home\Perfil.cshtml"
                                                   Write(Model.Name);

#line default
#line hidden
                EndContext();
                BeginContext(5741, 142, true);
                WriteLiteral("\"  +  \"/\"  +  response[1] +  \"/1\";\r\n                else if(response[0] == \"SubStory\")\r\n                window.location.href = \"/SubStory/\"+ \"");
                EndContext();
                BeginContext(5884, 10, false);
#line 192 "C:\Users\leand\Downloads\teste\cms\CMS\Views\Home\Perfil.cshtml"
                                                 Write(Model.Name);

#line default
#line hidden
                EndContext();
                BeginContext(5894, 140, true);
                WriteLiteral("\"    +  \"/\"  +  response[1] +  \"/1/1\";\r\n                else if(response[0] == \"Grupo\")\r\n                window.location.href = \"/Grupo/\"+ \"");
                EndContext();
                BeginContext(6035, 10, false);
#line 194 "C:\Users\leand\Downloads\teste\cms\CMS\Views\Home\Perfil.cshtml"
                                              Write(Model.Name);

#line default
#line hidden
                EndContext();
                BeginContext(6045, 151, true);
                WriteLiteral("\"       +  \"/\"  +  response[1] +  \"/1/1/1\";\r\n                else if(response[0] == \"SubGrupo\")\r\n                window.location.href = \"/SubGrupo/\"+ \"");
                EndContext();
                BeginContext(6197, 10, false);
#line 196 "C:\Users\leand\Downloads\teste\cms\CMS\Views\Home\Perfil.cshtml"
                                                 Write(Model.Name);

#line default
#line hidden
                EndContext();
                BeginContext(6207, 156, true);
                WriteLiteral("\"    +  \"/\"  +  response[1] +  \"/1/1/1/1\";\r\n                else if(response[0] == \"SubSubGrupo\")\r\n                window.location.href = \"/SubSubGrupo/\"+ \"");
                EndContext();
                BeginContext(6364, 10, false);
#line 198 "C:\Users\leand\Downloads\teste\cms\CMS\Views\Home\Perfil.cshtml"
                                                    Write(Model.Name);

#line default
#line hidden
                EndContext();
                BeginContext(6374, 615, true);
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
                BeginContext(6990, 10, false);
#line 217 "C:\Users\leand\Downloads\teste\cms\CMS\Views\Home\Perfil.cshtml"
                                                                                 Write(Model.Name);

#line default
#line hidden
                EndContext();
                BeginContext(7000, 589, true);
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