using business.Back;
using business.business;
using business.business.Elementos.element;
using business.contrato;
using business.implementacao;
using business.Join;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace business.div
{
    public abstract class Div : BaseModel, IMudancaEstado
    {
        private bool content;
        private string nome = "bloco";
        private string elementos = "";
        private string flexWrap = "wrap";
        private string justifyContent = "center";
        private string alignItems = "flex-start";
        private string alignSelf = "auto";
        private string flexDirection = "row";
        private string classesModificadoras = "";
        private int padding = 0;
        private int height = 200;
        private int width = 100;
        private int borderRadius = 0;
        
        private MudancaEstado mudanca;

        public Div()
        {
            mudanca = new MudancaEstado();
            Elemento = new List<DivElemento>();
            Content = true;
            Background = 
            new BackgroundCor{ backgroundTransparente = true, Cor = "transparent"};
        }

        public int Ordem { get; set; }

        [Required(ErrorMessage = "O nome do bloco é necessário")]
        [Display(Name ="Nome do bloco")]
        public string Nome { get { return nome; } set { nome = value; } }

        [Display(Name = "Conteudo centralizado")]
        public int Padding { get { return padding; } set { padding = value; } }

        [Display(Name = "Altura")]
        public int Height { get { return height; } set { height = value; } }

        [Display(Name = "Largura")]
        public int Width { get { return width; } set { width = value; } }

        public bool Content 
        { 
          get { return content; } 
          set 
          { 
            content = value;
          } 
        }     
       

        [Display(Name = "Borda arredondada")]
        public int BorderRadius { get { return borderRadius; } set { borderRadius = value; } }    
        
        [JsonIgnore]
        public virtual BackgroundDiv Background{ get; set; }
        [JsonIgnore]
        public virtual List<DivElemento> Elemento { get; set; }
        [JsonIgnore]
        public virtual List<DivContainer> Container { get; set; }

        public Int64 Pagina_ { get; set; }

        [NotMapped]
        public string Elementos { get { return elementos; } set { elementos = value; } }
        public string FlexWrap { get { return flexWrap; } set { flexWrap = value; } }
        public string JustifyContent { get { return justifyContent; } set { justifyContent = value; } }
         public string FlexDirection { get { return flexDirection; } set { flexDirection = value; } }
        
        public string AlignItems { get { return alignItems; } set { alignItems = value; } }
        public string AlignSelf { get { return alignSelf; } set { alignSelf = value; } }
        public string ClassesModificadoras 
        { 
            get { return classesModificadoras; } 
            set 
            { 
              if(value != "")
              classesModificadoras = value + " ";
              else
              classesModificadoras = value;
            } 
        }

        public void IncluiElemento(Elemento elemento)
        {
            this.Elemento.Add(new DivElemento { Elemento = elemento });
        }

        public BaseModel MudarEstado(BaseModel VelhoEstado, BaseModel m)
        {
            return mudanca.MudarEstado(VelhoEstado, m);
        }
    }
}
