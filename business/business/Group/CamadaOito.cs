using System;
using System.Collections.Generic;

namespace business.business.Group
{
    public class CamadaOito : BaseModel
    {
         public string Nome { get; set; }

        public virtual List<Pagina> Pagina { get; set; }
        public virtual List<CamadaNove> CamadaNove { get; set; }

         public Int64 CamadaSeteId { get; set; }
        public virtual CamadaSete CamadaSete { get; set; }
    }
}