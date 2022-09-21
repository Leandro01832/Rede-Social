using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace business.Back
{
    public class BackgroundGradienteContainer : BackgroundContainer
    {
        [Display(Name = "Grau do Background Gradiente.")]
        public int GrauContainer { get; set; }
        

    }
}
