using business.business.element;
using System;

namespace business.business.Elementos.element
{
    public class ElementoDependenteElemento
    {
        public Int64? ElementoDependenteId { get; set; }
        public Int64? ElementoId { get; set; }
        public virtual Elemento Elemento { get; set; }
        public virtual ElementoDependente ElementoDependente { get; set; }
    }
}