using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace business.business
{
    public class Story : BaseModel
    {
        private int paginaPadraoLink = 0;

        public string Nome { get; set; }
        public virtual List<Pagina> Pagina { get; set; }
        public string UserId { get; set; }
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

    }
}
