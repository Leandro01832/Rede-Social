using business.business;
using business.div;

namespace business.Join
{
    public class DivPagina
    {
        public ulong? PaginaId { get; set; }
        public ulong? DivId { get; set; }
        public virtual Div Div { get; set; }
        public virtual Pagina Pagina { get; set; }
    }
}
