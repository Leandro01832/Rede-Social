using System;
using System.Collections.Generic;

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

    }
}
