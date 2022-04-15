using business.business.Elementos.element;
using business.business.Elementos.imagem;
using System;

namespace business.Join
{
    public class ProdutoImagem
    {
        public Int64? ElementoId { get; set; }
        public Int64? ImagemId { get; set; }
        public Elemento Elemento { get; set; }
        public Imagem Imagem { get; set; }
    }
}
