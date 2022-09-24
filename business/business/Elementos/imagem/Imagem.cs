using business.Back;
using business.business.element;
using business.business.Elementos.element;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace business.business.Elementos.imagem
{

    public class Imagem : ElementoDependente
    {
        [Display(Name = "Arquivo")]
        public string ArquivoImagem { get; set; }

        public int Width { get; set; }

        [JsonIgnore]
        public virtual List<BackgroundDiv> BackgroundDiv { get; set; }
        [JsonIgnore]
        public virtual List<BackgroundContainer> BackgroundContainer { get; set; }
        [JsonIgnore]
        public virtual List<BackgroundElemento> BackgroundElemento { get; set; }
        [JsonIgnore]
        public virtual List<Elemento> Elemento { get; set; }

        public Int64? PastaImagemId { get; set; }
        [JsonIgnore]
        public virtual PastaImagem PastaImagem { get; set; }

        
    }
}
