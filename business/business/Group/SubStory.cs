
using System;
using System.Collections.Generic;

namespace business.business.Group
{
        public class SubStory : BaseModel
        {

        public virtual List<Pagina> Pagina { get; set; }
        public virtual List<Grupo> Grupo { get; set; }

        public Int64 StoryId { get; set; }
        public virtual Story Story { get; set; }


        }

}