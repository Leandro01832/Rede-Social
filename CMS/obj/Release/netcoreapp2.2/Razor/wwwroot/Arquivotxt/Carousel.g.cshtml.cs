#pragma checksum "C:\Users\simon\source\repos\C#\rede-social\CMS\wwwroot\Arquivotxt\Carousel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f7f97ea1c6531b9cc80340f23907f7f0c89b5fd1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.wwwroot_Arquivotxt_Carousel), @"mvc.1.0.view", @"/wwwroot/Arquivotxt/Carousel.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/wwwroot/Arquivotxt/Carousel.cshtml", typeof(AspNetCore.wwwroot_Arquivotxt_Carousel))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7f97ea1c6531b9cc80340f23907f7f0c89b5fd1", @"/wwwroot/Arquivotxt/Carousel.cshtml")]
    public class wwwroot_Arquivotxt_Carousel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1007, true);
            WriteLiteral(@"#foreach($bloco in $divs)

#foreach($element in $bloco.Div.Elemento)

#if ($element.Elemento.tipo == ""Carousel"")

<script type='text/javascript'>
    jQuery(function () {
        $('.item:first-child').addClass('active$element.Elemento.IdElemento').show();

        setInterval(slide, 5000);

        function slide() {
            if ($('.active$element.Elemento.IdElemento').next().size()) {
                $('.active$element.Elemento.IdElemento').fadeOut().removeClass('active$element.Elemento.IdElemento')
                    .next().addClass('active$element.Elemento.IdElemento');
                $('.active$element.Elemento.IdElemento').delay(500).fadeIn();
            } else {
                $('.active$element.Elemento.IdElemento').fadeOut().removeClass('active$element.Elemento.IdElemento');

                $('.item:first-child').delay(500).fadeIn().addClass('active$element.Elemento.IdElemento');
            }
        }
    });
</script>

#end



#end


#end");
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
