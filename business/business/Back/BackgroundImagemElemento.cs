
using System.ComponentModel.DataAnnotations;

namespace business.Back
{
    public class BackgroundImagemElemento : BackgroundElemento
    {
        [Display(Name = "Tipo de repetição do plano de fundo")]
        public string Background_RepeatElemento { get; set; }

        [Display(Name = "Posição do plano de fundo")]
        public string Background_PositionElemento { get; set; }
    }
}