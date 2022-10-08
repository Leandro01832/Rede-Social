

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace business.Back
{
    public class BackgroundCorElemento : BackgroundElemento
    {
        private string corElemento;
        public string CorElemento
         { 
            get{
                if(backgroundTransparenteElemento) return "transparent";
                else return corElemento;
               }
            set{ corElemento = value;} 
         }
        [Display(Name = "Plano de fundo é transparente?")]
        public bool backgroundTransparenteElemento { get; set; }
        [NotMapped]
        public int CondicaoTransparente
        {
            get { if(backgroundTransparenteElemento) return 1; else return 0; }
        }
    }

}