using System.Collections.Generic;
using business.Join;

namespace business.business
{
    public class Produto : BaseModel
    {
            public string Descricao { get; set; }     
            public string Nome { get; set; }     
            public decimal Preco { get; set; }
            public int QuantEstoque { get; set; }
             public virtual List<ItemPedido> Itens { get; set; }   
             public virtual List<PaginaProduto> Pagina { get; set; }   
    }
}