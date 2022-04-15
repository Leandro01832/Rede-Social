using business.Back;
using business.div;
using business.Join;
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
        public Int64 StoryId { get; set; }
        public virtual Story Story { get; set; }

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
        //Para Usuario
        public bool LayoutModelo { get; set; }

        public void IncluiDiv(Div div)
        {
            this.Div.Add(new DivPagina { Div = div });
        }
    }
}
