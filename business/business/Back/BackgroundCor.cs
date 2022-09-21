using System.ComponentModel.DataAnnotations;

namespace business.Back
{
    public class BackgroundCor : BackgroundDiv
    {
        public string Cor { get; set; }
        [Display(Name = "Plano de fundo é transparente?")]
        public bool backgroundTransparente { get; set; }
    }
}
