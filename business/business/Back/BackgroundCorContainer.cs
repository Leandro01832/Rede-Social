using System.ComponentModel.DataAnnotations;

namespace business.Back
{
    public class BackgroundCorContainer : BackgroundContainer
    {
        public string CorContainer { get; set; }
        [Display(Name = "Plano de fundo é transparente?")]
        public bool backgroundTransparenteContainer { get; set; }
    }
}
