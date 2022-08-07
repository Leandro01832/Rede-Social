using System;
using System.Collections.Generic;

namespace business.business.Group
{
    public class SubSubGrupo : BaseModel
    {

        public virtual List<Pagina> Pagina { get; set; }

         public Int64 SubGrupoId { get; set; }
        public virtual SubGrupo SubGrupo { get; set; }

    }
}