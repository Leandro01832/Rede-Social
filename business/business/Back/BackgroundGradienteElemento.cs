

using System.ComponentModel.DataAnnotations;

namespace business.Back
{
    public class BackgroundGradienteElemento : BackgroundElemento
    {
        [Display(Name = "Grau do Background Gradiente.")]
        public int GrauElemento { get; set; }
    }


}