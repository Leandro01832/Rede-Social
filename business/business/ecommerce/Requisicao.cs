using business.business;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace business.ecommerce
{
    public class Requisicao : BaseModel
    {
        public Requisicao(string clienteId)
        {
            ClienteId = clienteId;
            Cadastro = new Cadastro();
        }

        [Key, ForeignKey("Cadastro")]
        public new ulong Id { get; set; }
        public string Status { get; set; }
        [Display(Name = "Data do pedido")]
        public DateTime DataPedidoCompra { get; set; }
        [Display(Name = "Valor do pedido")]
        public string ValorPedido { get; set; }
        [NotMapped]
        public string Erro { get; set; }
        [JsonIgnore]
        public virtual List<ItemRequisicao> ItemRequisicao { get; set; }        
        public virtual Cadastro Cadastro { get; set; }
        [Required]
        public virtual string ClienteId { get; set; }
    }
}