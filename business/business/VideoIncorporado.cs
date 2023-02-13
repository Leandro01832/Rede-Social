using System.ComponentModel.DataAnnotations;

namespace business.business
{
   public class VideoIncorporado : BaseModel
   {
        public int? Tamanho { get; set; }

        [Display(Name = "Arquivo")]
        public string ArquivoVideoIncorporado { get; set; }

        public string Nome { get{ return "videos - " + Id.ToString(); } }
   }
}