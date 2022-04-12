using business.business;
using business.business.carousel;
using business.business.Elementos.element;

namespace business.Join
{
    public class PaginaCarouselPagina
    {
        public ulong? ElementoId { get; set; }
        public ulong? PaginaId { get; set; }
        public virtual Elemento Elemento { get; set; }
        public virtual Pagina Pagina { get; set; }
    }
}
