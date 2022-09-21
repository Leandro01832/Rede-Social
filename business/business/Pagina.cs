using business.Back;
using business.business.div;
using business.Join;
using business.business.Group;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace business.business
{
    public class Pagina : BaseModel
    {

        public Pagina()
        {
            if(Pagina.entity)
            Div = new List<PaginaContainer>
            {
                new PaginaContainer{Container = new Container()},              
                new PaginaContainer
                {
                     Container = new Container(){Content = true}
                }

            };
        }
        
        public Pagina(int quant)
        {
            Div = new List<PaginaContainer>
            {
                new PaginaContainer{Container = new Container()}, 
                new PaginaContainer
                {
                     Container = new Container(quant){Content = true}
                }

            };
        }
       
        public Pagina(int quant, int quantContainers)
        {
            Div = new List<PaginaContainer>
            {
                new PaginaContainer{Container = new Container()},
                new PaginaContainer
                {
                     Container = new Container(quant){Content = true}
                }

            };
            for (int i = 0; i < quantContainers; i++)
            Div.Add(new PaginaContainer());

        }

        private int mostrarDados = 0;
        private DateTime data = DateTime.Now;
        private Int64? subSubGrupoId = 0;
        private Int64? subGrupoId = 0;
        private Int64? grupoId = 0;
         private Int64? subStoryId = 0;
         private string flexDirection = "flex-start";
         private string alignItems = "row";

        public DateTime Data { get { return data; } set { data = value; } }

        [Display(Name ="Story")]
        public Int64 StoryId { get; set; }
        public virtual Story Story { get; set; }

        [Display(Name ="Sub-Story")]
        public Int64? SubStoryId 
        {
            get
            {
                if (subStoryId == 0) return null;                
                return subStoryId;
            }
            set
            {   
                subStoryId = value;
            }
        }

        public virtual SubStory SubStory { get; set; }

        [Display(Name ="Grupo")]
        public Int64? GrupoId 
        {
            get
            {
                if (grupoId == 0) return null;                
                return grupoId;
            }
            set
            {   
                grupoId = value;
            }
        }
        public virtual Grupo Grupo { get; set; }

         [Display(Name ="Sub-Grupo")]
        public Int64? SubGrupoId
        {
            get
            {
                if (subGrupoId == 0) return null;                
                return subGrupoId;
            }
            set
            {   
                subGrupoId = value;
            }
        }
        public virtual SubGrupo SubGrupo{get; set;}
        

         [Display(Name ="Sub-Sub-Grupo")]
        public Int64? SubSubGrupoId
        {
            get
            {
                if (subSubGrupoId == 0) return null;                
                return subSubGrupoId;
            }
            set
            {   
                subSubGrupoId = value;
            }
        }
        public virtual SubSubGrupo SubSubGrupo { get; set; }

        [Required(ErrorMessage = "O titulo é necessário")]
        [Display(Name = "Titulo da pagina")]
        public string Titulo { get; set; }      

        public string Sobreescrita { get; set; }      

        [Display(Name = "Arquivo")]
        public string ArquivoMusic { get; set; }       

        public bool Music { get; set; }

        public bool Pular { get; set; }        
        
        [JsonIgnore]
        public virtual List<PaginaContainer> Div { get; set; }
        [JsonIgnore]
        public virtual List<PaginaCarouselPagina> CarouselPagina { get; set; }
                       
        public string UserId { get; set; } 

        [NotMapped]
        public int MostrarDados { get { return mostrarDados; } set { mostrarDados = value; } }

        [NotMapped]
        public string NomeComId { get { return Titulo + " chave - " + Id.ToString(); } }

        //Para Programador
        public bool Layout { get; set; }

        public string FlexDirection { get { return flexDirection; } set { flexDirection = value; } }
        
        public string AlignItems { get { return alignItems; } set { alignItems = value; } }        

        [NotMapped]
        public string Html { get; set; }

        public void IncluiDiv(Container container)
        {
            this.Div.Add(new PaginaContainer { Container = container });
        }
    }
}
