using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace business.Back
{
    public class BackgroundGradiente : BackgroundDiv
    {
        [Display(Name = "Grau do Background Gradiente.")]
        public int Grau { get; set; }
        

    }
}
