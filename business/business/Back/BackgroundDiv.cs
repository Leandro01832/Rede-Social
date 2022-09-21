using business.business;
using business.business.Elementos;
using business.business.Elementos.imagem;
using business.contrato;
using business.div;
using business.implementacao;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace business.Back
{
    public abstract class BackgroundDiv : Background
    {
        public BackgroundDiv()
        {
        }
        

        [Key, ForeignKey("Div")]
        public new Int64 Id { get; set; }        

        public virtual Div Div { get; set; }


        
    }
}
