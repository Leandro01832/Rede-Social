using System;
using System.Collections.Generic;

namespace business.business.Group
{
    public class CamadaNove : BaseModel
    {
        public string Nome { get; set; }

        public virtual List<Pagina> Pagina { get; set; }
        public virtual List<CamadaDez> CamadaDez { get; set; }

         public Int64 CamadaOitoId { get; set; }
        public virtual CamadaOito CamadaOito { get; set; }
    }
}