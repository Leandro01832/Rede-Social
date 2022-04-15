using business.business;
using business.business.carousel;
using business.business.Elementos.element;
using System;

namespace business.Join
{
    public class PaginaCarouselPagina
    {
        public Int64? ElementoId { get; set; }
        public Int64? PaginaId { get; set; }
        public virtual Elemento Elemento { get; set; }
        public virtual Pagina Pagina { get; set; }
    }
}
