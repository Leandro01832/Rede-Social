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

        public AjaxGetController(ApplicationDbContext context, IRepositoryPagina repositoryPagina,
            IHttpHelper httpHelper, UserManager<UserModel> userManager)
        {
            db = context;
            epositoryPagina = repositoryPagina;
            HttpHelper = httpHelper;
            UserManager = userManager;
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

        public JsonResult refresh()
        {
            var p = RepositoryPagina.paginas[0].FirstOrDefault();
            return Json("");
        }

        public JsonResult GetStory(int Indice, string User)
        {
            List<Story> stories =  RetornarStories(User);
            string[] result = new string[2];

            try
            {
                var story = stories[Indice + 1];
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

       

        public JsonResult GetSubStory(int Indice, string User, int IndiceSubStory)
        {
                var stories =  RetornarStories(User);
            
                long num = long.Parse($"{Indice}{IndiceSubStory}");
                bool condicao = false;
                int[] result = new int[2];
                var story = stories[Indice];

                foreach (var item in story.SubStory.Where(str => str.Pagina.Count > 0).ToList())
                {
                    var var1 = story.SubStory.Where(str => str.Pagina.Count > 0).ToList().IndexOf(item) + 1;
                    long num2 = long.Parse($"{Indice}{var1}");
                    if(num2 > num){
                        condicao = true;
                        result[0] = Indice;                    
                        result[1] = var1;                    
                        break;
                    }
                }

                if(condicao)
                return Json(result);
                else
                {
                    result[0] = 0;
                    result[1] = 0;
                    return Json(result);     
                }
                       
        }

        public JsonResult GetGrupo(int Indice, string User, int IndiceSubStory, int IndiceGrupo)
        {            
             var stories =  RetornarStories(User);
            
                long num = long.Parse($"{Indice}{IndiceSubStory}{IndiceGrupo}");
                bool condicao = false;
                int[] result = new int[3];
                var story = stories[Indice];

                foreach (var item in story.SubStory.Where(str => str.Pagina.Count > 0).ToList())
                {
                    if(item.Grupo.FirstOrDefault() == null) continue;
                    foreach (var item2 in item.Grupo.Where(str => str.Pagina.Count > 0).ToList())
                    {
                        var var1 = story.SubStory.Where(str => str.Pagina.Count > 0).ToList().IndexOf(item) + 1;
                        var var2 = item.Grupo.Where(str => str.Pagina.Count > 0).ToList().IndexOf(item2) + 1;
                        long num2 = long.Parse($"{Indice}{var1}{var2}");
                        if(num2 > num){
                            condicao = true;
                            result[0] = Indice;                    
                            result[1] = var1;                    
                            result[2] = var2;                    
                            break;
                        }
                    }
                    if(condicao) break;
                }

                if(condicao)
                return Json(result);
                else
                {
                    result[0] = 0;
                    result[1] = 0;
                    result[2] = 0;
                    return Json(result);     
                }          
        }

        public JsonResult GetSubGrupo(int Indice, string User, int IndiceSubStory, int IndiceGrupo, int IndiceSubGrupo)
        {            
             var stories =  RetornarStories(User);
            long num = long.Parse($"{Indice}{IndiceSubStory}{IndiceGrupo}{IndiceSubGrupo}");
            bool condicao = false;
                int[] result = new int[4];
                var story = stories[Indice];

                foreach (var item in story.SubStory.Where(str => str.Pagina.Count > 0).ToList())
                {
                    foreach (var item2 in item.Grupo.Where(str => str.Pagina.Count > 0).ToList())
                    {
                        foreach (var item3 in item2.SubGrupo.Where(str => str.Pagina.Count > 0).ToList())
                        {
                            var var1 = story.SubStory.Where(str => str.Pagina.Count > 0).ToList().IndexOf(item) + 1;
                            var var2 = item.Grupo.Where(str => str.Pagina.Count > 0).ToList().IndexOf(item2) + 1;
                            var var3 = item2.SubGrupo.Where(str => str.Pagina.Count > 0).ToList().IndexOf(item3) + 1;
                            long num2 = long.Parse($"{Indice}{var1}{var2}{var3}");
                            if(num2 > num){
                                condicao = true;
                                result[0] = Indice;                    
                                result[1] = var1;                    
                                result[2] = var2;                    
                                result[3] = var3;                    
                                break;
                            }
                        }
                            if(condicao) break;

                    }
                    if(condicao) break;
                }

                if(condicao)
                return Json(result);
                else
                {
                    result[0] = 0;
                    result[1] = 0;
                    result[2] = 0;
                    result[3] = 0;
                    return Json(result);     
                }         
        }

         public JsonResult GetSubSubGrupo(int Indice, string User, int IndiceSubStory, int IndiceGrupo, int IndiceSubGrupo, int IndiceSubSubGrupo)
        {            
            var stories =  RetornarStories(User);
            long num = long.Parse($"{Indice}{IndiceSubStory}{IndiceGrupo}{IndiceSubGrupo}{IndiceSubSubGrupo}");
            bool condicao = false;
                int[] result = new int[5];
                var story = stories[Indice];

                foreach (var item in story.SubStory.Where(str => str.Pagina.Count > 0).ToList())
                {
                    foreach (var item2 in item.Grupo.Where(str => str.Pagina.Count > 0).ToList())
                    {
                        foreach (var item3 in item2.SubGrupo.Where(str => str.Pagina.Count > 0).ToList())
                        {
                            foreach (var item4 in item3.SubSubGrupo.Where(str => str.Pagina.Count > 0).ToList())
                            {
                                var var1 = story.SubStory.Where(str => str.Pagina.Count > 0).ToList().IndexOf(item) + 1;
                                var var2 = item.Grupo.Where(str => str.Pagina.Count > 0).ToList().IndexOf(item2) + 1;
                                var var3 = item2.SubGrupo.Where(str => str.Pagina.Count > 0).ToList().IndexOf(item3) + 1;
                                var var4 = item3.SubSubGrupo.Where(str => str.Pagina.Count > 0).ToList().IndexOf(item4) + 1;
                                long num2 = long.Parse($"{Indice}{var1}{var2}{var3}{var4}");
                                if(num2 > num){
                                    condicao = true;
                                    result[0] = Indice;                    
                                    result[1] = var1;                    
                                    result[2] = var2;                    
                                    result[3] = var3;                    
                                    result[4] = var4;                    
                                    break;
                                }
                                
                            }
                            if(condicao) break;

                        }
                            if(condicao) break;

                    }
                    if(condicao) break;
                }

                if(condicao)
                return Json(result);
                else
                {
                    result[0] = 0;
                    result[1] = 0;
                    result[2] = 0;
                    result[3] = 0;
                    result[4] = 0;
                    return Json(result);     
                }        
        }

        public JsonResult GetStories(string valor)
        {
            var stories = db.Story.Where(s => s.Id >= 1);

            return Json(stories);
        }

        public async Task<JsonResult> GetUser(string valor)
        {

            IQueryable users;
            var lista = new List<UserModel>();
            if (valor != null)
            {
                lista = await UserManager.Users.Where(s => s.Name.ToLower().Contains(valor.ToLower())).ToListAsync();
                foreach(var item in lista)
                {
                    var user = UserHelper.Users.FirstOrDefault(u => u.Name.ToLower() == item.Name.Trim().ToLower());
                    if (user == null)
                    UserHelper.Users.Add(item);                    
                }
            }
            else
                lista = new List<UserModel>();

            users = lista.AsQueryable();

            return Json(users);
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
            var cores = db.Cor.Where(b => b.BackgroundId == Background);

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


         private  List<Story> RetornarStories(string User)
        {
            var user = UserHelper.Users.FirstOrDefault(u => u.Name.ToLower() == User.Trim().ToLower());
            if (user == null)
            {
                user =  UserManager.Users.FirstOrDefault(u => u.Name.ToLower() == User.Trim().ToLower());
                UserHelper.Users.Add(user);
            }
            var paginas = new List<Pagina>();
            foreach (var item in RepositoryPagina.paginas)
            {
                if (item == null || item.FirstOrDefault(i => i.UserId == user.Id) == null)
                    continue;
                paginas.AddRange(item.Where(s => s.UserId == user.Id).ToList());
            }
            var stories = new List<Story>();

            foreach (var item in paginas)
                if (stories.FirstOrDefault(str => str.Nome == item.Story.Nome) == null)
                    stories.Add(item.Story);

            stories = stories.OrderBy(s => s.PaginaPadraoLink).ToList();
            return stories;
        }
    }
}