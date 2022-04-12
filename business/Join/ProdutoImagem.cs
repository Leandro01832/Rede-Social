using business.business.Elementos.element;
using business.business.Elementos.imagem;

namespace business.Join
{
    public class ProdutoImagem
    {
        public ulong? ElementoId { get; set; }
        public ulong? ImagemId { get; set; }
        public Elemento Elemento { get; set; }
        public Imagem Imagem { get; set; }
    }
}
