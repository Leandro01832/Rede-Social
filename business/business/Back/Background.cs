using business.business;
using business.business.Elementos.imagem;
using business.contrato;
using business.div;
using business.implementacao;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace business.Back
{
    public abstract class Background : BaseModel, IMudancaEstado
    {
        public Background()
        {
            mudanca = new MudancaEstado();
        }
        

        [Key, ForeignKey("Div")]
        public new ulong Id { get; set; }

        public ulong? ImagemId { get; set; }
        public virtual Imagem Imagem { get; set; }

        public virtual List<Cor> Cores { get; set; }

        public virtual Div Div { get; set; }

        private MudancaEstado mudanca;

        public BaseModel MudarEstado(BaseModel VelhoEstado, BaseModel m)
        {
           return mudanca.MudarEstado(VelhoEstado, m);
        }
    }
}
