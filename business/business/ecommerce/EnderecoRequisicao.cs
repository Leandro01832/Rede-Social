using business.business;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace business.ecommerce
{
    public class EnderecoRequisicao : BaseModel
    {
        [Key, ForeignKey("Requisicao")]
        public new Int64 Id { get; set; }
        public string Cep { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Rua { get; set; }
        [Display(Name ="Numero")]
        public long NumeroCasa { get; set; }


        public virtual Requisicao Requisicao { get; set; }
    }
}