using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace business.Back
{
    public class BackgroundCorContainer : BackgroundContainer
    {
        private string corContainer;
        public string CorContainer
         { 
            get{
                if(backgroundTransparenteContainer) return "transparent";
                else return corContainer;
               }
            set{ corContainer = value;} 
         }
        [Display(Name = "Plano de fundo é transparente?")]
        public bool backgroundTransparenteContainer { get; set; }
        [NotMapped]
        public int CondicaoTransparente
        {
            get { if(backgroundTransparenteContainer) return 1; else return 0; }
        }
    }
}
