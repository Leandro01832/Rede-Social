

using System.ComponentModel.DataAnnotations;

namespace business.Back
{
    public class BackgroundCorElemento : BackgroundElemento
    {
        public string CorElemento { get; set; }
        [Display(Name = "Plano de fundo é transparente?")]
        public bool backgroundTransparenteElemento { get; set; }
    }

}