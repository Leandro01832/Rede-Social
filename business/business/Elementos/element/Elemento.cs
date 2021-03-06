using business.business.element;
using business.business.Elementos.imagem;
using business.business.Elementos.texto;
using business.Join;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace business.business.Elementos.element
{
    public abstract class  Elemento : BaseModel
    {
        private string nome = "elemento";
        private string elementosDependentes = "";
        private Int64? textoId = null;
        private Int64? imagemId = null;
        private Int64? tableId = null;
        private Int64? formularioId = null;
        private Int64? paginaEscolhida = null;

        public Int64? PaginaEscolhida
        {
            get { if (paginaEscolhida == 0) return null; return paginaEscolhida; }
            set { paginaEscolhida = value; }
        }

        [NotMapped]
        public int VerificarPagina
        {
            get { if (PaginaEscolhida == null) return 0; else return 1; }
        }
        public string Nome { get { return nome; } set { nome = value; } }
        public int Ordem { get; set; }

        [JsonIgnore]
        public virtual List<DivElemento> div { get; set; }

        public Int64 Pagina_ { get; set; }
        
        public bool Renderizar;
        [NotMapped]
        public string NomeComId { get { return Nome + " chave - " + Id.ToString(); } }

        [Display(Name = "Qual é o texto do Link?")]
        public Int64? TextoId
        {
            get { if (textoId == 0) return null; return textoId; }
            set { textoId = value; }
        }
        public virtual Texto Texto { get; set; }

        [Display(Name = "Qual é a Imagem do Link?")]
        public Int64? ImagemId
        {
            get { if (imagemId == 0) return null; return imagemId; }
            set { imagemId = value; }
        }
        [JsonIgnore]
        public virtual Imagem Imagem { get; set; }
        [NotMapped]
        public int VerificarNuloImagem
        {
            get { if (Imagem == null) return 0; else return 1; }
            
        }

        [Display(Name = "Tabela do produto")]
        public Int64? TableId
        {
            get { if (tableId == 0) return null; return tableId; }
            set { tableId = value; }
        }
        public Table Table { get; set; }

        [Display(Name = "Formulario do campo")]
        public Int64? FormularioId
        {
            get { if (formularioId == 0) return null; return formularioId; }
            set { formularioId = value; }
        }
        public virtual Formulario Formulario { get; set; }

        public virtual List<ElementoDependenteElemento> Dependentes { get; set; }
        [NotMapped]
        public string ElementosDependentes { get { return elementosDependentes; } set { elementosDependentes = value; } }

        public void IncluiElemento(Elemento elemento)
        {
            this.Dependentes.Add(new ElementoDependenteElemento { ElementoDependente = (ElementoDependente) elemento });
        }

        public virtual List<PaginaCarouselPagina> Paginas { get; set; }

        public void IncluiPagina(Pagina pagina)
        {
            this.Paginas.Add(new PaginaCarouselPagina { Pagina = pagina });
        }


    }
}
