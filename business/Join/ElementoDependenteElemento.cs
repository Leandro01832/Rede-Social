using business.business.element;

namespace business.business.Elementos.element
{
    public class ElementoDependenteElemento
    {
        public ulong? ElementoDependenteId { get; set; }
        public ulong? ElementoId { get; set; }
        public virtual Elemento Elemento { get; set; }
        public virtual ElementoDependente ElementoDependente { get; set; }
    }
}