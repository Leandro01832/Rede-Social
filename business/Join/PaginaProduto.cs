using System;
using business.business;

namespace business.Join
{
    public class PaginaProduto
    {
        public Int64? PaginaId { get; set; }
        public Int64? ProdutoId { get; set; }
        public Pagina Pagina { get; set; }
        public Produto Produto { get; set; }
    }
}