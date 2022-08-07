using business.Back;
using business.div;
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
        private bool margem = true;
        private int mostrarDados = 0;
        private DateTime data = DateTime.Now;

        public DateTime Data { get { return data; } set { data = value; } }

        [Display(Name ="Story")]
        public Int64 StoryId { get; set; }
        public virtual Story Story { get; set; }

        [Display(Name ="Sub-Story")]
        public Int64? SubStoryId { get; set; }
        public virtual SubStory SubStory { get; set; }

        [Display(Name ="Grupo")]
        public Int64? GrupoId { get; set; }
        public virtual Grupo Grupo { get; set; }

         [Display(Name ="Sub-Grupo")]
        public Int64? SubGrupoId { get; set; }
        public virtual SubGrupo SubGrupo { get; set; }

         [Display(Name ="Sub-Sub-Grupo")]
        public Int64? SubSubGrupoId { get; set; }
        public virtual SubSubGrupo SubSubGrupo { get; set; }

        [Required(ErrorMessage = "O titulo é necessário")]
        [Display(Name = "Titulo da pagina")]
        public string Titulo { get; set; }        

        [Display(Name = "Arquivo")]
        public string ArquivoMusic { get; set; }       

        public bool Music { get; set; }

        [Display(Name ="Manter a margem Direita e esquerda")]
        public bool Margem { get { return margem; } set { margem = value; } }

        public bool Topo { get; set; }

        public bool Menu { get; set; }
        
        
        [JsonIgnore]
        public virtual List<DivPagina> Div { get; set; }
        [JsonIgnore]
        public virtual List<PaginaCarouselPagina> CarouselPagina { get; set; }
                       
        public string UserId { get; set; }        

        [NotMapped]
        public string Blocos { get; set; }

        [NotMapped]
        public int MostrarDados { get { return mostrarDados; } set { mostrarDados = value; } }

        [NotMapped]
        public string NomeComId { get { return Titulo + " chave - " + Id.ToString(); } }

        //Para Programador
        public bool Layout { get; set; }
        

        [NotMapped]
        public string Html { get; set; }

        public void IncluiDiv(Div div)
        {
            this.Div.Add(new DivPagina { Div = div });
        }
    }
}
