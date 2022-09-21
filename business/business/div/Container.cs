using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using business.Back;
using business.Join;
using Newtonsoft.Json;
using business.div;
using business.business.div;
using System.Linq;

namespace business.business
{

public class Container : BaseModel
        {

          private bool content;

          public Container()
          {
                      if(BaseModel.entity)
                        Div = new List<DivContainer>
                        {
                            new DivContainer{Div = new DivComum()}
                        };
                        Background = new BackgroundCorContainer
                        {
                           CorContainer = "transparent",
                           backgroundTransparenteContainer = false
                        };
          }
          public Container(int quant)
          {
            Div = new List<DivContainer>();
            for (int i = 0; i < quant; i++)
            Div.Add(new DivContainer{Div = new DivComum()});
            Background = new BackgroundCorContainer
                        {
                           CorContainer = "transparent",
                           backgroundTransparenteContainer = false
                        };
            
          }

           
            private int borderRadius = 0;
            private int height = 200;
            private int width = 100;
            private int desenhado = 0;
            private int padding = 0;
            private string flexWrap = "wrap";
          private string justifyContent = "center";
          private string alignItems = "flex-start";
          private string flexDirection = "row";
            

             [JsonIgnore]
             public virtual List<DivContainer> Div { get; set; }

             [JsonIgnore]
             public virtual List<PaginaContainer> PaginaContainer { get; set; }

              [JsonIgnore]
             public virtual BackgroundContainer Background{ get; set; }

             public int Ordem { get; set; }

             [Display(Name = "Borda arredondada")]
        public int BorderRadius { get { return borderRadius; } set { borderRadius = value; } } 

          [Display(Name = "Altura")]
        public int Height { get { return height; } set { height = value; } }
        public int Width { get { return width; } set { width = value; } }

         public string FlexWrap { get { return flexWrap; } set { flexWrap = value; } }
        public string JustifyContent { get { return justifyContent; } set { justifyContent = value; } }
         public string FlexDirection { get { return flexDirection; } set { flexDirection = value; } }
        
        public string AlignItems { get { return alignItems; } set { alignItems = value; } }

        [NotMapped]
        public int Desenhado { get { return desenhado; } set { desenhado = value; } }

        [Display(Name = "Conteudo centralizado")]
        public int Padding { get { return padding; } set { padding = value; } }

        public bool Content 
        { 
          get { return content; } 
          set 
          { 
            if(PaginaContainer != null && PaginaContainer.FirstOrDefault( pc => pc.Pagina.Div.Count == 3) != null)
            content = true;
            else
            content = value;
          } 
        }  

         public void IncluiDiv(Div div)
        {
            this.Div.Add(new DivContainer { Div = div });
        }

        }

}