using business.business.Elementos.element;
using business.div;
using System;

namespace business.Join
{
    public class DivElemento
    {
        public Int64? ElementoId { get; set; }
        public Int64? DivId { get; set; }
        public virtual Div Div { get; set; }
        public virtual Elemento Elemento { get; set; }
    }
}
