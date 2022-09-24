

using business.business.Elementos.element;
using business.business.Elementos.imagem;
using business.business.Elementos;
using business.business;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace business.Back 
{
    public class BackgroundElemento : BaseModel
    {
         [Key, ForeignKey("Elemento")]
        public new Int64 Id { get; set; }        

        public virtual Elemento Elemento { get; set; }

        public Int64? ImagemId { get; set; }
        public virtual Imagem Imagem { get; set; }

        public Int64? VideoId { get; set; }
        public virtual Video Video { get; set; }

        public virtual List<Cor> Cores { get; set; }
    }
}