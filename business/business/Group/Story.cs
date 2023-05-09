﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace business.business.Group
{
    public class Story : BaseModel
    {
        private int paginaPadraoLink = 0;
        private int quantidade = 0;
        private int quantComentario = 0;

        public virtual List<Filtro> Filtro { get; set; }
        public virtual List<SubStory> SubStory { get; set; }

        public bool Comentario { get; set; }
        public bool Inportado { get; set; }

        public string Nome { get; set; }
        public virtual List<Pagina> Pagina { get; set; }
        public int PaginaPadraoLink
        {
            get
            {
                if (Nome == "Padrao") return 0;                
                return paginaPadraoLink;
            }
            set
            {   
                paginaPadraoLink = value;
            }
        }

        [NotMapped]
        public string CapituloComNome
        {
            get { return "Capitulo " + this.paginaPadraoLink + " - " + this.Nome; }
        } 

        [NotMapped]
        public int Quantidade
        {
            get { return quantidade; }
            set { quantidade = value; }
        }
       
        [NotMapped]
        public int QuantComentario
        {
            get { return quantComentario; }
            set { quantComentario = value; }
        }

    }
}
