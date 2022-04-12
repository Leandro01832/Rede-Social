using business.business.Elementos.element;
using business.div;

namespace business.Join
{
    public class DivElemento
    {
        public ulong? ElementoId { get; set; }
        public ulong? DivId { get; set; }
        public virtual Div Div { get; set; }
        public virtual Elemento Elemento { get; set; }
    }
}
