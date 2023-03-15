using business.business;
using business.business.Elementos.texto;
using business.business.Group;
using business.business.link;
using business.Join;
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

        public JsonResult GetStories2()
        {
            var stories = db.Story.Where(b => b.Nome != "Padrao" && !b.Comentario);
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
        
        public JsonResult GetCamadaSeis(Int64 SubSubGrupoId)
        {
            var camadas = db.CamadaSeis.Where(b => b.SubSubGrupoId == SubSubGrupoId);
            return Json(camadas);
        }
       
        public JsonResult GetCamadaSete(Int64 CamadaSeisId)
        {
            var camadas = db.CamadaSete.Where(b => b.CamadaSeisId == CamadaSeisId);
            return Json(camadas);
        }
        
        public JsonResult GetCamadaOito(Int64 CamadaSeteId)
        {
            var camadas = db.CamadaOito.Where(b => b.CamadaSeteId == CamadaSeteId);
            return Json(camadas);
        }
        
        public JsonResult GetCamadaNove(Int64 CamadaOitoId)
        {
            var camadas = db.CamadaNove.Where(b => b.CamadaOitoId == CamadaOitoId);
            return Json(camadas);
        }
        
        public JsonResult GetCamadaDez(Int64 CamadaNoveId)
        {
            var camadas = db.CamadaDez.Where(b => b.CamadaNoveId == CamadaNoveId);
            return Json(camadas);
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
                    var stories =  RetornarStories(false);
                    var lista =  stories.Where(s => s.Nome.ToLower().Contains(valor.ToLower())).OrderBy(p => p.Nome).ToList(); 
                    var listaSubStory = new List<Grup>();
                    var listaGrupo = new List<Grup>();
                    var listaSubGrupo = new List<Grup>();
                    var listaSubSubGrupo = new List<Grup>();
                    var listaSeis = new List<Grup>();
                    var listaSete = new List<Grup>();
                    var listaOito = new List<Grup>();
                    var listaNove = new List<Grup>();
                    var listaDez = new List<Grup>();

                        int[] resultDez = new int[10];
                        for (int i = 0; i < resultDez.Length; i++)
                        resultDez[i] = 1;
                        int[] resultNove = new int[9];
                        for (int i = 0; i < resultNove.Length; i++)
                        resultNove[i] = 1;
                        int[] resultOito = new int[8];
                        for (int i = 0; i < resultOito.Length; i++)
                        resultOito[i] = 1;
                        int[] resultSete = new int[7];
                        for (int i = 0; i < resultSete.Length; i++)
                        resultSete[i] = 1;
                        int[] resultSeis = new int[6];
                        for (int i = 0; i < resultSeis.Length; i++)
                        resultSeis[i] = 1;
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
                         while (resultDez != null)
                         {
                            resultDez = Arr.RetornarArray(item, resultDez[0], resultDez[1],
                             resultDez[2], resultDez[3], resultDez[4], resultDez[5],
                              resultDez[6], resultDez[7], resultDez[8], resultDez[9]);
                            if(resultDez != null)
                            {
                                var story = stories[resultDez[0]];
                                var name =  
                                story.SubStory.Where(str => str.Pagina.Count > 0).ToList()[resultDez[1]]
                                .Grupo.Where(str => str.Pagina.Count > 0).ToList()[resultDez[2]]
                                .SubGrupo.Where(str => str.Pagina.Count > 0).ToList()[resultDez[3]]
                                .SubSubGrupo.Where(str => str.Pagina.Count > 0).ToList()[resultDez[4]]
                                .CamadaSeis.Where(str => str.Pagina.Count > 0).ToList()[resultDez[5]]
                                .CamadaSete.Where(str => str.Pagina.Count > 0).ToList()[resultDez[6]]
                                .CamadaOito.Where(str => str.Pagina.Count > 0).ToList()[resultDez[7]]
                                .CamadaNove.Where(str => str.Pagina.Count > 0).ToList()[resultDez[8]]
                                .CamadaDez.Where(str => str.Pagina.Count > 0).ToList()[resultDez[9]].Nome;
                                if(name.ToLower().Contains(valor.ToLower()))
                                listaDez.Add(new Grup()
                                {
                                capitulo = resultDez[0],
                                url = $"/CamadaDez/{resultDez[0]}/{resultDez[1]}/{resultDez[2]}/{resultDez[3]}/{resultDez[4]}/{resultDez[5]}/{resultDez[6]}/{resultDez[7]}/{resultDez[8]}/{resultDez[9]}/1",
                                nome = name
                                });
                            }                            
                         }
                        
                         while (resultNove != null)
                         {
                            resultNove = Arr.RetornarArray(item, resultNove[0], resultNove[1],
                             resultNove[2], resultNove[3], resultNove[4], resultNove[5], resultNove[6], resultNove[7], resultNove[8], null);
                            if(resultNove != null)
                            {
                                var story = stories[resultNove[0]];
                                var name =  story.SubStory.Where(str => str.Pagina.Count > 0).ToList()[resultNove[1]]
                                .Grupo.Where(str => str.Pagina.Count > 0).ToList()[resultNove[2]]
                                .SubGrupo.Where(str => str.Pagina.Count > 0).ToList()[resultNove[3]]
                                .SubSubGrupo.Where(str => str.Pagina.Count > 0).ToList()[resultNove[4]]
                                .CamadaSeis.Where(str => str.Pagina.Count > 0).ToList()[resultNove[5]]
                                .CamadaSete.Where(str => str.Pagina.Count > 0).ToList()[resultNove[6]]
                                .CamadaOito.Where(str => str.Pagina.Count > 0).ToList()[resultNove[7]]
                                .CamadaNove.Where(str => str.Pagina.Count > 0).ToList()[resultNove[8]].Nome;
                                if(name.ToLower().Contains(valor.ToLower()))
                                listaNove.Add(new Grup()
                                {
                                capitulo = resultNove[0],
                                url = $"/CamadaNove/{resultNove[0]}/{resultNove[1]}/{resultNove[2]}/{resultNove[3]}/{resultNove[4]}/{resultNove[5]}/{resultNove[6]}/{resultNove[7]}/{resultNove[8]}/1",
                                nome = name
                                });
                            }                            
                         }
                         
                         while (resultOito != null)
                         {
                            resultOito = Arr.RetornarArray(item, resultOito[0], resultOito[1],
                             resultOito[2], resultOito[3], resultOito[4], resultOito[5], resultOito[6], resultOito[7], null, null);
                            if(resultOito != null)
                            {
                                var story = stories[resultOito[0]];
                                var name =  story.SubStory.Where(str => str.Pagina.Count > 0).ToList()[resultOito[1]]
                                .Grupo.Where(str => str.Pagina.Count > 0).ToList()[resultOito[2]]
                                .SubGrupo.Where(str => str.Pagina.Count > 0).ToList()[resultOito[3]]
                                .SubSubGrupo.Where(str => str.Pagina.Count > 0).ToList()[resultOito[4]]
                                .CamadaSeis.Where(str => str.Pagina.Count > 0).ToList()[resultOito[5]]
                                .CamadaSete.Where(str => str.Pagina.Count > 0).ToList()[resultOito[6]]
                                .CamadaOito.Where(str => str.Pagina.Count > 0).ToList()[resultOito[7]].Nome;
                                if(name.ToLower().Contains(valor.ToLower()))
                                listaOito.Add(new Grup()
                                {
                                capitulo = resultOito[0],
                                url = $"/CamadaOito/{resultOito[0]}/{resultOito[1]}/{resultOito[2]}/{resultOito[3]}/{resultOito[4]}/{resultOito[5]}/{resultOito[6]}/{resultOito[7]}/1",
                                nome = name
                                });
                            }                            
                         }
                        
                         while (resultSete != null)
                         {
                            resultSete = Arr.RetornarArray(item, resultSete[0], resultSete[1],
                             resultSete[2], resultSete[3], resultSete[4], resultSete[5], resultSete[6], null, null, null);
                            if(resultSete != null)
                            {
                                var story = stories[resultSete[0]];
                                var name =  story.SubStory.Where(str => str.Pagina.Count > 0).ToList()[resultSete[1]]
                                .Grupo.Where(str => str.Pagina.Count > 0).ToList()[resultSete[2]]
                                .SubGrupo.Where(str => str.Pagina.Count > 0).ToList()[resultSete[3]]
                                .SubSubGrupo.Where(str => str.Pagina.Count > 0).ToList()[resultSete[4]]
                                .CamadaSeis.Where(str => str.Pagina.Count > 0).ToList()[resultSete[5]]
                                .CamadaSete.Where(str => str.Pagina.Count > 0).ToList()[resultSete[6]].Nome;
                                if(name.ToLower().Contains(valor.ToLower()))
                                listaSete.Add(new Grup()
                                {
                                capitulo = resultSete[0],
                                url = $"/CamadaSete/{resultSete[0]}/{resultSete[1]}/{resultSete[2]}/{resultSete[3]}/{resultSete[4]}/{resultSete[5]}/{resultSete[6]}/1",
                                nome = name
                                });
                            }                            
                         }
                        
                        
                        
                         while (resultSeis != null)
                         {
                            resultSeis = Arr.RetornarArray(item, resultSeis[0], resultSeis[1],
                             resultSeis[2], resultSeis[3], resultSeis[4], resultSeis[5], null, null, null, null);
                            if(resultSeis != null)
                            {
                                var story = stories[resultSeis[0]];
                                var name =  story.SubStory.Where(str => str.Pagina.Count > 0).ToList()[resultSeis[1]]
                                .Grupo.Where(str => str.Pagina.Count > 0).ToList()[resultSeis[2]]
                                .SubGrupo.Where(str => str.Pagina.Count > 0).ToList()[resultSeis[3]]
                                .SubSubGrupo.Where(str => str.Pagina.Count > 0).ToList()[resultSeis[4]]
                                .CamadaSeis.Where(str => str.Pagina.Count > 0).ToList()[resultSeis[5]].Nome;
                                if(name.ToLower().Contains(valor.ToLower()))
                                listaSeis.Add(new Grup()
                                {
                                capitulo = resultSeis[0],
                                url = $"/CamadaSeis/{resultSeis[0]}/{resultSeis[1]}/{resultSeis[2]}/{resultSeis[3]}/{resultSeis[4]}/{resultSeis[5]}/1",
                                nome = name
                                });
                            }                            
                         }
                         
                         while (resultSubSubGrupo != null)
                         {
                            resultSubSubGrupo = Arr.RetornarArray(item, resultSubSubGrupo[0], resultSubSubGrupo[1],
                             resultSubSubGrupo[2], resultSubSubGrupo[3], resultSubSubGrupo[4], null, null, null, null, null);
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
                         resultSubGrupo = Arr.RetornarArray(item, resultSubGrupo[0], resultSubGrupo[1], resultSubGrupo[2], resultSubGrupo[3],
                          null, null, null, null, null, null);
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
                         resultGrupo = Arr.RetornarArray(item, resultGrupo[0], resultGrupo[1], resultGrupo[2],
                          null, null, null, null, null, null, null);
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
                         resultSubStory = Arr.RetornarArray(item, resultSubStory[0], resultSubStory[1],
                          null, null, null, null, null, null, null, null);
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
                        subsubgrupo = listaSubSubGrupo,
                        camadaseis = listaSeis,
                        camadasete = listaSete,
                        camadaoito = listaOito,
                        camadanove = listaNove,
                        camadadez = listaDez
                    };

                return Json(Modelo);              
            }
            else
            return Json(null);
        }

         public JsonResult BuscarLivros(string valor)
        {
            if (valor != null)
            {
                var lista = db.Livro.Where(b => b.url.ToLower().Contains(valor.ToLower()));
                return Json(lista);              
            }
            else
            return Json(null);
        }



        public JsonResult GetPastas(string Pagina)
        {
              var  pastas = db.PastaImagem.Where(b => b.Id > 0);

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

        public JsonResult GetPaginas(Int64 Pagina)
        {
           
             var paginas = db.Pagina.Where(m => m.Id > 0); 
             return Json(paginas);         
           
        }

        public JsonResult GetPaginasDoSite(string Pagina)
        {
            var paginas = db.Pagina.Where(m => m.Id > 0); 
             return Json(paginas);    
        }

        public JsonResult Elementos(Int64 Pagina, string Tipo)
        {
            var els = db.Elemento.Where(ele => ele.GetType().Name == Tipo && ele.Pagina_ == Pagina);
            return Json(els);
        }

        

        public JsonResult GetStory(int Indice)
        {
            List<Story> stories =  RetornarStories(true);
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
                var stories =  RetornarStories(false);                            
                int[] result = new int[2];
                var story = stories[Indice];

                result = Arr.RetornarArray(story, Indice, IndiceSubStory,
                 null, null, null, null, null, null, null, null);

                
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
                var stories =  RetornarStories(false);                               
                var story = stories[Indice];
                int[] result = Arr.RetornarArray(story, Indice, IndiceSubStory,
                 IndiceGrupo, null, null, null, null, null, null, null);
                
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
            var stories =  RetornarStories(false);            
            var story = stories[Indice];
            int[] result = Arr.RetornarArray(story, Indice, IndiceSubStory,
             IndiceGrupo, IndiceSubGrupo, null, null, null, null, null, null);

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
            var stories =  RetornarStories(false);            
            var story = stories[Indice];
            int[] result = Arr.RetornarArray(story, Indice, IndiceSubStory, IndiceGrupo,
             IndiceSubGrupo, IndiceSubSubGrupo, null, null, null, null, null); 
                
                if(result != null)
                return Json(result);
                else
                {
                    for(var i = 0; i < result.Length; i++)
                    result[i] = 0;
                    return Json(result);     
                }        
        }
         
         public JsonResult GetCamadaSeis(int Indice, int IndiceSubStory,
          int IndiceGrupo, int IndiceSubGrupo, int IndiceSubSubGrupo, int IndiceCamadaSeis)
        {            
            var stories =  RetornarStories(false);            
            var story = stories[Indice];
            int[] result = Arr.RetornarArray(story, Indice, IndiceSubStory,
             IndiceGrupo, IndiceSubGrupo, IndiceSubSubGrupo,
              IndiceCamadaSeis, null, null, null, null); 
                
                if(result != null)
                return Json(result);
                else
                {
                    for(var i = 0; i < result.Length; i++)
                    result[i] = 0;
                    return Json(result);     
                }        
        }
         
         public JsonResult GetCamadaSete(int Indice, int IndiceSubStory,
          int IndiceGrupo, int IndiceSubGrupo, int IndiceSubSubGrupo, int IndiceCamadaSeis, int IndiceCamadaSete)
        {            
            var stories =  RetornarStories(false);            
            var story = stories[Indice];
            int[] result = Arr.RetornarArray(story, Indice, IndiceSubStory,
             IndiceGrupo, IndiceSubGrupo, IndiceSubSubGrupo, IndiceCamadaSeis,
              IndiceCamadaSete, null, null, null); 
                
                if(result != null)
                return Json(result);
                else
                {
                    for(var i = 0; i < result.Length; i++)
                    result[i] = 0;
                    return Json(result);     
                }        
        }
         
         public JsonResult GetCamadaOito(int Indice, int IndiceSubStory, int IndiceGrupo,
           int IndiceSubGrupo, int IndiceSubSubGrupo, int IndiceCamadaSeis,
            int IndiceCamadaSete, int IndiceCamadaOito)
        {            
            var stories =  RetornarStories(false);            
            var story = stories[Indice];
            int[] result = Arr.RetornarArray(story, Indice, IndiceSubStory, IndiceGrupo,
             IndiceSubGrupo, IndiceSubSubGrupo, IndiceCamadaSeis, IndiceCamadaSete,
              IndiceCamadaOito, null, null); 
                
                if(result != null)
                return Json(result);
                else
                {
                    for(var i = 0; i < result.Length; i++)
                    result[i] = 0;
                    return Json(result);     
                }        
        }
        
         public JsonResult GetCamadaNove(int Indice, int IndiceSubStory, int IndiceGrupo,
           int IndiceSubGrupo, int IndiceSubSubGrupo, int IndiceCamadaSeis,
            int IndiceCamadaSete, int IndiceCamadaOito, int IndiceCamadaNove)
        {            
            var stories =  RetornarStories(false);            
            var story = stories[Indice];
            int[] result = Arr.RetornarArray(story, Indice, IndiceSubStory, IndiceGrupo,
             IndiceSubGrupo, IndiceSubSubGrupo, IndiceCamadaSeis, IndiceCamadaSete,
              IndiceCamadaOito, IndiceCamadaNove, null); 
                
                if(result != null)
                return Json(result);
                else
                {
                    for(var i = 0; i < result.Length; i++)
                    result[i] = 0;
                    return Json(result);     
                }        
        }
        
         public JsonResult GetCamadaDez(int Indice, int IndiceSubStory, int IndiceGrupo,
           int IndiceSubGrupo, int IndiceSubSubGrupo, int IndiceCamadaSeis,
            int IndiceCamadaSete, int IndiceCamadaOito, int IndiceCamadaNove, int IndiceCamadaDez)
        {            
            var stories =  RetornarStories(false);            
            var story = stories[Indice];
            int[] result = Arr.RetornarArray(story, Indice, IndiceSubStory, IndiceGrupo,
             IndiceSubGrupo, IndiceSubSubGrupo, IndiceCamadaSeis, IndiceCamadaSete,
              IndiceCamadaOito, IndiceCamadaNove, IndiceCamadaDez); 
                
                if(result != null)
                return Json(result);
                else
                {
                    for(var i = 0; i < result.Length; i++)
                    result[i] = 0;
                    return Json(result);     
                }        
        }        

         private  List<Story> RetornarStories(bool comentario)
        {     
            List<Story> stories = null;
            if(!comentario)                   
            stories = db.Story
            .Include(str => str.SubStory).ThenInclude(l => l.Pagina)
            .Include(str => str.SubStory).ThenInclude(str => str.Grupo).ThenInclude(l => l.Pagina)
            .Include(str => str.SubStory).ThenInclude(str => str.Grupo).ThenInclude(str => str.SubGrupo).ThenInclude(l => l.Pagina)
            .Include(str => str.SubStory).ThenInclude(str => str.Grupo).ThenInclude(str => str.SubGrupo).ThenInclude(str => str.SubSubGrupo).ThenInclude(l => l.Pagina)
            .Where(b => b.Nome != "Padrao" && !b.Comentario).ToList();
            else
            {
                stories = db.Story
            .Include(str => str.SubStory).ThenInclude(l => l.Pagina)
            .Include(str => str.SubStory).ThenInclude(str => str.Grupo).ThenInclude(l => l.Pagina)
            .Include(str => str.SubStory).ThenInclude(str => str.Grupo).ThenInclude(str => str.SubGrupo).ThenInclude(l => l.Pagina)
            .Include(str => str.SubStory).ThenInclude(str => str.Grupo).ThenInclude(str => str.SubGrupo).ThenInclude(str => str.SubSubGrupo).ThenInclude(l => l.Pagina)
            .Where(b => b.Nome != "Padrao").ToList();
            }
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