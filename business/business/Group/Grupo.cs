using System;
using System.Collections.Generic;

namespace business.business.Group
{

    public class Grupo : BaseModel
    {

            public string Nome { get; set; }
            public virtual List<Pagina> Pagina { get; set; }
             public virtual List<SubGrupo> SubGrupo { get; set; }

            public Int64 SubStoryId { get; set; }
            public virtual SubStory SubStory { get; set; }

    }

}