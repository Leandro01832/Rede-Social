using business.business;
using business.business.Group;
using CMS.Data;
using CMS.Models;
using CMS.Models.Repository;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS.Controllers
{
    public class AjaxGetController : Controller
    {
        private readonly ApplicationDbContext db;
        public IRepositoryPagina epositoryPagina { get; }
        public IHttpHelper HttpHelper { get; }
        public UserManager<UserModel> UserManager { get; }
        public ObjectArray Arr;

        public AjaxGetController(ApplicationDbContext context, IRepositoryPagina repositoryPagina,
            IHttpHelper httpHelper, UserManager<UserModel> userManager)
        {
            db = context;
            epositoryPagina = repositoryPagina;
            HttpHelper = httpHelper;
            UserManager = userManager;
            Arr = new ObjectArray();
        }

        public JsonResult GetStories2(string User)
        {
            var stories = db.Story.Where(b => b.UserId == User && b.Nome != "Padrao");
            return Json(stories);
        }

        public JsonResult GetSubStories(Int64 StoryId)
        {
            var substories = db.SubStory.Where(b => b.StoryId == StoryId);
            return Json(substories);
        }

        public JsonResult GetGrupos(Int64 SubStoryId)
        {
            var grupos = db.Grupo.Where(b => b.SubStoryId == SubStoryId);
            return Json(grupos);
        }

        public JsonResult GetSubGrupos(Int64 GrupoId)
        {
            var subgrupos = db.SubGrupo.Where(b => b.GrupoId == GrupoId);
            return Json(subgrupos);
        }

        public JsonResult GetSubSubGrupos(Int64 SubGrupoId)
        {
            var subsubgrupos = db.SubSubGrupo.Where(b => b.SubGrupoId == SubGrupoId);
            return Json(subsubgrupos);
        }

          public JsonResult GetStories(string valor)
        {
            var stories = db.Story.Where(s => s.Id >= 1);

            return Json(stories);
        }
          
          public JsonResult BuscarStories(string valor)
        {
            if (valor != null)
            {
                    var stories =  RetornarStories();
                    var lista =  stories.Where(s => s.Nome.ToLower().Contains(valor.ToLower())).OrderBy(p => p.Nome).ToList(); 
                    var listaSubStory = new List<Grup>();
                    var listaGrupo = new List<Grup>();
                    var listaSubGrupo = new List<Grup>();
                    var listaSubSubGrupo = new List<Grup>();

                        int[] resultSubSubGrupo = new int[5];
                        for (int i = 0; i < resultSubSubGrupo.Length; i++)
                        resultSubSubGrupo[i] = 1;
                        int[] resultSubGrupo = new int[4];
                        for (int i = 0; i < resultSubGrupo.Length; i++)
                        resultSubGrupo[i] = 1;
                        int[] resultGrupo = new int[3];
                        for (int i = 0; i < resultGrupo.Length; i++)
                        resultGrupo[i] = 1;
                        int[] resultSubStory = new int[2];
                        for (int i = 0; i < resultSubStory.Length; i++)
                        resultSubStory[i] = 1;

                    foreach (var item in stories)
                    {                       
                         while (resultSubSubGrupo != null)
                         {
                            resultSubSubGrupo = Arr.RetornarArray(item, resultSubSubGrupo[0], resultSubSubGrupo[1], resultSubSubGrupo[2], resultSubSubGrupo[3], resultSubSubGrupo[4]);
                            if(resultSubSubGrupo != null)
                            {
                                var story = stories[resultSubSubGrupo[0]];
                                var name =  story.SubStory.Where(str => str.Pagina.Count > 0).ToList()[resultSubSubGrupo[1]]
                                .Grupo.Where(str => str.Pagina.Count > 0).ToList()[resultSubSubGrupo[2]]
                                .SubGrupo.Where(str => str.Pagina.Count > 0).ToList()[resultSubSubGrupo[3]]
                                .SubSubGrupo.Where(str => str.Pagina.Count > 0).ToList()[resultSubSubGrupo[4]].Nome;
                                if(name.ToLower().Contains(valor.ToLower()))
                                listaSubSubGrupo.Add(new Grup()
                                {
                                capitulo = resultSubSubGrupo[0],
                                url = $"/SubSubGrupo/{resultSubSubGrupo[0]}/{resultSubSubGrupo[1]}/{resultSubSubGrupo[2]}/{resultSubSubGrupo[3]}/{resultSubSubGrupo[4]}/1",
                                nome = name
                                });
                            }                            
                         }
                        
                         while (resultSubGrupo != null)
                         {
                         resultSubGrupo = Arr.RetornarArray(item, resultSubGrupo[0], resultSubGrupo[1], resultSubGrupo[2], resultSubGrupo[3], null);
                          if(resultSubGrupo != null)
                            {
                                var story = stories[resultSubGrupo[0]];
                                var name =  story.SubStory.Where(str => str.Pagina.Count > 0).ToList()[resultSubGrupo[1]]
                                .Grupo.Where(str => str.Pagina.Count > 0).ToList()[resultSubGrupo[2]]
                                .SubGrupo.Where(str => str.Pagina.Count > 0).ToList()[resultSubGrupo[3]].Nome;
                                 if(name.ToLower().Contains(valor.ToLower()))
                                listaSubGrupo.Add(new Grup()
                                {
                                capitulo = resultSubGrupo[0],
                                url = $"/SubGrupo/{resultSubGrupo[0]}/{resultSubGrupo[1]}/{resultSubGrupo[2]}/{resultSubGrupo[3]}/1",
                                nome = name
                                });
                            } 
                            
                         }

                         while (resultGrupo != null)
                         {
                         resultGrupo = Arr.RetornarArray(item, resultGrupo[0], resultGrupo[1], resultGrupo[2], null, null);
                         if(resultGrupo != null)
                            {
                                var story = stories[resultGrupo[0]];
                                var name =  story.SubStory.Where(str => str.Pagina.Count > 0).ToList()[resultGrupo[1]]
                                .Grupo.Where(str => str.Pagina.Count > 0).ToList()[resultGrupo[2]].Nome;
                                 if(name.ToLower().Contains(valor.ToLower()))
                                listaGrupo.Add(new Grup()
                                {
                                capitulo = resultGrupo[0],
                                url = $"/Grupo/{resultGrupo[0]}/{resultGrupo[1]}/{resultGrupo[2]}/1",
                                nome = name
                                });
                            } 
                            
                         }

                         while (resultSubStory != null)
                         {
                         resultSubStory = Arr.RetornarArray(item, resultSubStory[0], resultSubStory[1], null, null, null);
                            if(resultSubStory != null)
                            {
                                var story = stories[resultSubStory[0]];
                                var name =  story.SubStory.Where(str => str.Pagina.Count > 0).ToList()[resultSubStory[1]].Nome;
                                 if(name.ToLower().Contains(valor.ToLower()))
                                listaSubStory.Add(new Grup()
                                {
                                capitulo = resultSubStory[0],
                                url = $"/SubStory/{resultSubStory[0]}/{resultSubStory[1]}/1",
                                nome = name
                                });
                            }                             
                         }                         
                    }

                    var Modelo = new
                    {
                        story = lista,
                        substory = listaSubStory,
                        grupo = listaGrupo,
                        subgrupo = listaSubGrupo,
                        subsubgrupo = listaSubSubGrupo
                    };

                return Json(Modelo);              
            }
            else
            return Json(null);
        }


        public JsonResult GetPastas(string Pagina)
        {
            IQueryable pastas;
            var page = db.Pagina.FirstOrDefault(b => b.UserId == Pagina);
            if (page != null)
                pastas = db.PastaImagem.Where(b => b.UserId == page.UserId);
            else
                pastas = db.PastaImagem.Where(b => b.UserId == "");

            return Json(pastas);
        }

        public JsonResult GetImagens(Int64 PastaImagemId)
        {
              var  pastas = db.Imagem.Where(b => b.PastaImagemId == PastaImagemId);

            return Json(pastas);
        }

        public JsonResult GetCores(Int64 Background)
        {
            var cores = db.Cor.Where(b => b.BackgroundDivId == Background);

            return Json(cores);
        }

        public JsonResult Mensagens(Int64 Pagina)
        {
            var pastas = db.MensagemChat.Where(b => b.Pagina == Pagina);

            return Json(pastas);
        }

        public async Task<JsonResult> GetPaginas(Int64 Pagina)
        {
           
           
             var pagina = await db.Pagina.FirstAsync(p => p.Id == Pagina);
             var PedidoId = pagina.UserId;
             var paginas = db.Pagina.Where(m => m.UserId == PedidoId);
 
             return Json(paginas);
           
           
        }

        public JsonResult GetPaginasDoSite(string Pagina)
        {
            var page = db.Pagina.First(b => b.UserId == Pagina);
            var paginas = db.Pagina.Where(m => m.UserId == page.UserId);

            return Json(paginas);
        }

        public JsonResult Elementos(Int64 Pagina, string Tipo)
        {
            var els = db.Elemento.Where(ele => ele.GetType().Name == Tipo && ele.Pagina_ == Pagina);
            return Json(els);
        }

        

        public JsonResult GetStory(int Indice)
        {
            List<Story> stories =  RetornarStories();
            string[] result = new string[2];

            try
            {
                var story = stories[Indice];
                bool subsubgroup = false;
                bool subgroup = false;
                bool grupo = false;
                bool substory = false;

                foreach (var item in story.SubStory.Where(str => str.Pagina.Count > 0).ToList())
                {
                    substory = true;
                    foreach (var item2 in item.Grupo.Where(str => str.Pagina.Count > 0).ToList())
                    {
                        grupo = true;
                        foreach (var item3 in item2.SubGrupo.Where(str => str.Pagina.Count > 0).ToList())
                        {
                            subgroup = true;
                            foreach (var item4 in item3.SubSubGrupo.Where(str => str.Pagina.Count > 0).ToList())
                            {
                                subsubgroup = true;
                                break;
                            }
                            if(subsubgroup) break;
                        }
                        if(subsubgroup) break;
                    }
                    if(subsubgroup) break;
                }

                result[1] = story.PaginaPadraoLink.ToString();

                RepositoryPagina.paginas.Clear();
                RepositoryPagina.paginas.AddRange(epositoryPagina.includes()
                .Where(p => p.Story.PaginaPadraoLink == story.PaginaPadraoLink).OrderBy(p => p.Id).ToList());

                if(substory) result[0] = "SubStory";
                if(grupo) result[0] = "Grupo";
                if(subgroup) result[0] = "SubGrupo";
                if(subsubgroup) result[0] = "SubSubGrupo";
                if(!subsubgroup && !subgroup && !grupo && !substory)
                    result[0] = "Story";               

                return Json(result);
            }
            catch (Exception)
            {
                result[0] = "Story";  
                result[1] = "1"; 
                return Json(result);
            }
        }

       

        public JsonResult GetSubStory(int Indice, int IndiceSubStory)
        {
                var stories =  RetornarStories();                            
                int[] result = new int[2];
                var story = stories[Indice];

                result = Arr.RetornarArray(story, Indice, IndiceSubStory, null, null, null);

                
                if(result != null)
                return Json(result);
                else
                {
                    for(var i = 0; i < result.Length; i++)
                    result[i] = 0;
                    return Json(result);     
                }
                       
        }

        public JsonResult GetGrupo(int Indice, int IndiceSubStory, int IndiceGrupo)
        {            
                var stories =  RetornarStories();                               
                var story = stories[Indice];
                int[] result = Arr.RetornarArray(story, Indice, IndiceSubStory, IndiceGrupo, null, null);
                
                if(result != null)
                return Json(result);
                else
                {
                    for(var i = 0; i < result.Length; i++)
                    result[i] = 0;
                    return Json(result);     
                }          
        }

        public JsonResult GetSubGrupo(int Indice, int IndiceSubStory, int IndiceGrupo, int IndiceSubGrupo)
        {            
            var stories =  RetornarStories();            
            var story = stories[Indice];
            int[] result = Arr.RetornarArray(story, Indice, IndiceSubStory, IndiceGrupo, IndiceSubGrupo, null);

                if(result != null)
                return Json(result);
                else
                {
                    for(var i = 0; i < result.Length; i++)
                    result[i] = 0;
                    return Json(result);     
                }         
        }

         public JsonResult GetSubSubGrupo(int Indice, int IndiceSubStory, int IndiceGrupo, int IndiceSubGrupo, int IndiceSubSubGrupo)
        {            
            var stories =  RetornarStories();            
            var story = stories[Indice];
            int[] result = Arr.RetornarArray(story, Indice, IndiceSubStory, IndiceGrupo, IndiceSubGrupo, IndiceSubSubGrupo); 
                
                if(result != null)
                return Json(result);
                else
                {
                    for(var i = 0; i < result.Length; i++)
                    result[i] = 0;
                    return Json(result);     
                }        
        }

         private  List<Story> RetornarStories()
        {                        
            var stories = db.Story
            .Include(str => str.SubStory).ThenInclude(l => l.Pagina)
            .Include(str => str.SubStory).ThenInclude(str => str.Grupo).ThenInclude(l => l.Pagina)
            .Include(str => str.SubStory).ThenInclude(str => str.Grupo).ThenInclude(str => str.SubGrupo).ThenInclude(l => l.Pagina)
            .Include(str => str.SubStory).ThenInclude(str => str.Grupo).ThenInclude(str => str.SubGrupo).ThenInclude(str => str.SubSubGrupo).ThenInclude(l => l.Pagina)
            .Where(b => b.Nome != "Padrao" && !b.Comentario).ToList();
            stories = stories.OrderBy(s => s.PaginaPadraoLink).ToList();
            return stories;
        }
    }

    public class Grup
    {
        public string nome { get; set; }
        public string url { get; set; }
        public int capitulo { get; set; }
    }
}