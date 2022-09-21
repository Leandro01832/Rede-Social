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
    public class BackgroundContainer : Background
    {
        public BackgroundContainer()
        {
        }
        

        [Key, ForeignKey("Container")]
        public new Int64 Id { get; set; }

        public virtual Container Container { get; set; }


    }
}
