using System;
using System.Collections.Generic;

namespace business.business.Group
{
    public class CamadaDez : BaseModel
    {
         public string Nome { get; set; }

        public virtual List<Pagina> Pagina { get; set; }

         public Int64 CamadaNoveId { get; set; }
        public virtual CamadaNove CamadaNove { get; set; }
    }
}