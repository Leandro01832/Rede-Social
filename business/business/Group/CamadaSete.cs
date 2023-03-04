using System;
using System.Collections.Generic;

namespace business.business.Group
{
    public class CamadaSete : BaseModel
    {
            public string Nome { get; set; }

        public virtual List<Pagina> Pagina { get; set; }
        public virtual List<CamadaOito> CamadaOito { get; set; }

         public Int64 CamadaSeisId { get; set; }
        public virtual CamadaSeis CamadaSeis { get; set; }
    }

}