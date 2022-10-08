using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace business.Back
{
    public class BackgroundCor : BackgroundDiv
    {
        private string cor;

        public string Cor
         { 
            get{
                if(backgroundTransparente) return "transparent";
                else return cor;
               }
            set{ cor = value;} 
         }
        [Display(Name = "Plano de fundo é transparente?")]
        public bool backgroundTransparente { get; set; }
        [NotMapped]
        public int CondicaoTransparente
        {
            get { if(backgroundTransparente) return 1; else return 0; }
        }
    }
}
