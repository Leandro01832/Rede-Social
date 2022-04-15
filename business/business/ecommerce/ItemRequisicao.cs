using business.business;
using business.business.Elementos.element;
using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;

namespace business.ecommerce
{
    public class ItemRequisicao : BaseModel
    {
        public int Quantidade { get; set; }
        public Int64 RequisicaoId { get; set; }
        [Required]
        public Int64 PrecoUnitario { get; private set; }
        [JsonIgnore]
        public virtual Requisicao Requisicao { get; set; }
        public Int64 ElementoId { get; set; }
        [JsonIgnore]
        public virtual Elemento Elemento { get; set; }

        public void AtualizaQuantidade(int quantidade)
        {
            Quantidade = quantidade;
        }
    }
}