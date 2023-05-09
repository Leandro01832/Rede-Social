using business.business.Group;
using System;

namespace business.business
{
    public  class Filtro : BaseModel
    {
        public Int64 StoryId { get; set; }
        public virtual Story Story { get; set; }
        public long? SubStory { get; set; }
        public long? Grupo { get; set; }
        public long? SubGrupo { get; set; }
        public long? SubSubGrupo { get; set; }
        public long? CamadaSeis { get; set; }
        public long? CamadaSete { get; set; }
        public long? CamadaOito { get; set; }
        public long? CamadaNove { get; set; }
        public long? CamadaDez { get; set; }
    }
}