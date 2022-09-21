using business.business.Elementos.imagem;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace business.Back
{
    public class BackgroundImagemContainer : BackgroundContainer
    {
        [Display(Name = "Tipo de repetição do plano de fundo")]
        public string Background_RepeatContainer { get; set; }

        [Display(Name = "Posição do plano de fundo")]
        public string Background_PositionContainer { get; set; }
        
    }
}
