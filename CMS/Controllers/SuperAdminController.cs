using business.Back;
using business.business;
using business.business.div;
using business.div;
using business.Join;
using CMS.Data;
using CMS.Models;
using CMS.Models.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using business.business.Elementos.texto;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using business.business.Group;
using System.Text.RegularExpressions;
using business.business.link;


namespace CMS.Controllers
{
    [Authorize(Roles = "Admin")]
    public class SuperAdminController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UserManager<UserModel> UserManager { get; }
        public IRepositoryPagina epositoryPagina { get; }
        public IHostingEnvironment HostingEnvironment { get; }

        public SuperAdminController(ApplicationDbContext context, UserManager<UserModel> userManager,
            IRepositoryPagina repositoryPagina, IHostingEnvironment hostingEnvironment)
        {
            _context = context;
            UserManager = userManager;
            epositoryPagina = repositoryPagina;
            HostingEnvironment = hostingEnvironment;
        }

              
         public async Task<ActionResult> Admin()
        {
            var user = await UserManager.GetUserAsync(this.User);
            var stories = await _context.Story.Where(str =>  str.Nome != "Padrao" && !str.Comentario).ToListAsync();

            if(stories.Count == 0)
            {
                ViewBag.Error = "Crie seu story primeiro!!!";
                RedirectToAction("Create", "Story");
            }

            ViewBag.UserId = user.Id;
            ViewBag.cap = new SelectList(stories, "Id", "CapituloComNome");

            return View();
        }
         
         public async Task<ActionResult> BaixarHtmlLivroVerso()
        {
            var lista = new List<Story>()
            {new Story{Nome = "Escolha um capitulo de destino", PaginaPadraoLink = 0, Id = 0}};
            var stories = await _context.Story.Where(str =>  str.Nome != "Padrao" && !str.Comentario).ToListAsync();
            lista.AddRange(stories);

            if(stories.Count == 0)
            {
                ViewBag.Error = "Crie seu story primeiro!!!";
                RedirectToAction("Create", "Story");
            }

            ViewBag.cap = new SelectList(lista, "Id", "CapituloComNome");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> BaixarHtmlLivroVerso(string livro, int capitulo, int verso, int cap)
        {          
            var url = livro + "/Renderizar/" + capitulo + "/" + verso + "/1/user";     
               
        
            WebClient client = new WebClient();
            var html = client.DownloadString(url);
            string conteudo = "";            

            if( html.Contains("<h1>Pagina não encontrada</h1>"))
            {
                ModelState.AddModelError("", "Pagina não encontrada!!! Informe corretamente o capitulo e verso!!!");
                 var lista = new List<Story>()
                {new Story{Nome = "Escolha um capitulo de destino", PaginaPadraoLink = 0, Id = 0}};
                var stories = await _context.Story.Where(str =>  str.Nome != "Padrao" && !str.Comentario).ToListAsync();
                lista.AddRange(stories);
                ViewBag.cap = new SelectList(lista, "Id", "CapituloComNome");
                return View();
            } 

         
            var arr = html.Split("<!-- ProdutoContent -->");
            conteudo = arr[1];           

            Pagina pag = null;
            Story story = null;

            if(cap != 0)
            {
             story = await _context.Story
            .Include(str => str.Pagina)
            .ThenInclude(str => str.Produto)
            .Include(str => str.Pagina)
            .ThenInclude(str => str.Div)
            .FirstAsync(str => str.Id == cap);

            pag = story.Pagina.FirstOrDefault(p => p.Div.Count == 0 && p.Produto == null);

            }
            else
            {
               pag = _context.Pagina.FirstOrDefault(p => p.Div.Count == 0 && p.Produto == null); 
                    story = await _context.Story
                .Include(str => str.Pagina)
                .ThenInclude(str => str.Produto)
                .Include(str => str.Pagina)
                .ThenInclude(str => str.Div)
                .FirstAsync(str => str.Id == pag.StoryId);
            }

            if(pag != null)
            {
                pag.Div = new List<PaginaContainer>
                {
                new PaginaContainer{Container = new Container()},
                new PaginaContainer
                {
                     Container = new Container(1){Content = true}
                }

                };
                pag.Div.First(d => d.Container.Content).Container.Div
                .First(d => d.Div.Content).Div.Elemento = new List<DivElemento>();
                pag.Div.First(d => d.Container.Content).Container.Div
                .First(d => d.Div.Content).Div.Elemento.Add(new DivElemento
                {
                    Div = pag.Div.First(d => d.Container.Content).Container.Div
                    .First(d => d.Div.Content).Div,
                    Elemento =  new Texto
                        {
                            Pagina_ = pag.Id,
                            PalavrasTexto = conteudo
                        },
                    
                }); 
                      
                _context.Update(pag);
                 _context.SaveChanges();  

                  var p = story.Pagina.First(pagina => pagina.Id == pag.Id);
                    var vers = story.Pagina.IndexOf(p) + 1;

                return RedirectToAction(nameof(PaginaCriada),
            new { capitulo = story.PaginaPadraoLink, versiculo = vers });
            }
            else if(story.Pagina
                .FirstOrDefault(p => p.Data < DateTime.Now.AddDays(-2) && p.Produto == null) != null)
            {
                pag = story.Pagina
                .First(pa => pa.Data < DateTime.Now.AddDays(-2) && pa.Produto == null);
                pag.Data = DateTime.Now;

                    foreach (var item in pag.Div)                    
                 _context.Remove(item);
                await  _context.SaveChangesAsync();  
                pag.Div = new List<PaginaContainer>
                {
                new PaginaContainer{Container = new Container()},
                new PaginaContainer
                {
                     Container = new Container(1){Content = true}
                }

                };
                 pag.Div.First(d => d.Container.Content).Container.Div
            .First(d => d.Div.Content).Div.Elemento.Add(new DivElemento
            {
                Div = pag.Div.First(d => d.Container.Content).Container.Div
                .First(d => d.Div.Content).Div,
                Elemento =  new Texto
                    {
                        Pagina_ = pag.Id,
                        PalavrasTexto = conteudo
                    },
                
            }); 
             _context.Update(pag);
                await  _context.SaveChangesAsync(); 

                var p = story.Pagina.First(pagina => pagina.Id == pag.Id);
                var vers = story.Pagina.IndexOf(p) + 1;

                return RedirectToAction(nameof(PaginaCriada),
            new { capitulo = story.PaginaPadraoLink, versiculo = vers });
            }
            else
            return View();            
        }
        
         public async Task<ActionResult> BaixarHtmlLivroCapitulo()
        {
            var user = await UserManager.GetUserAsync(this.User);
            ViewBag.UserId = user.Id;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> BaixarHtmlLivroCapitulo(string livro, int capitulo)
        {          
            var url = livro + "/Renderizar/" + capitulo + "/1/1/user";     
        
            WebClient client = new WebClient();
            var html = client.DownloadString(url);                        

            if( html.Contains("<h1>Pagina não encontrada</h1>"))
            {
                ModelState.AddModelError("", "Pagina não encontrada!!! Informe corretamente o capitulo e verso!!!");
                 var lista = new List<Story>()
                {new Story{Nome = "Escolha um capitulo de destino", PaginaPadraoLink = 0, Id = 0}};
                var stories = await _context.Story.Where(stor =>  stor.Nome != "Padrao" && !stor.Comentario).ToListAsync();
                lista.AddRange(stories);
                ViewBag.cap = new SelectList(lista, "Id", "CapituloComNome");
                return View();
            } 
           
               var  verso = 1;
                var codigoHtml = "teste";
                var conteudoHtml = "";
                var lst = await _context.Story.Where(st => st.Nome != "Padrao").ToListAsync();

                var str = new Story();

                 str.PaginaPadraoLink = lst.Count + 1;
                 str.Nome = "Inportados";
                 str.Inportado = true;
                 _context.Add(str);
                 await _context.SaveChangesAsync();

                var Story = await _context.Story.FirstAsync(st => st.Nome == "Padrao");

            var p = new Pagina()
            {
                 Data = DateTime.Now,
                    ArquivoMusic = "",
                    Titulo = "Story - " + str.Nome,
                    CarouselPagina = new List<PaginaCarouselPagina>(),
                    StoryId = Story.Id,
                    Sobreescrita = null,
                    SubStoryId = null,
                    GrupoId = null,
                    SubGrupoId = null,
                    SubSubGrupoId = null,
                    Layout = false,
                    Music = false
            };  
            p.Div = null;              

             _context.Add(p);
             _context.SaveChanges(); 
            
           var  pagin = new Pagina(1);  
            pagin.Div.First(d => d.Container.Content).Container.Div
            .First(d => d.Div.Content).Div.Elemento = new List<DivElemento>();
            pagin.Div.First(d => d.Container.Content).Container.Div
            .First(d => d.Div.Content).Div.Elemento.Add(new DivElemento
            {
                Div = pagin.Div.First(d => d.Container.Content).Container.Div
                .First(d => d.Div.Content).Div,
                Elemento = new LinkBody
                {
                    Pagina_ = p.Id,
                    TextoLink = "#LinkPadrao",
                    Texto = new Texto
                    {
                        Pagina_ = p.Id,
                        PalavrasTexto = "<h1> Story " + str.Nome + "</h1>"
                    },
                }
            });

                p.Div = new List<PaginaContainer>();                
            foreach (var item in pagin.Div)            
                p.IncluiDiv(item.Container);                
                _context.SaveChanges();

                while(!codigoHtml.Contains("<h1>Pagina não encontrada</h1>") )
                {
                    codigoHtml = client.DownloadString(url);
                    var arr2 = html.Split("<!-- ProdutoContent -->");
                    conteudoHtml = arr2[1];


                     var pagina = new Pagina()
            {
                Data = DateTime.Now,
                ArquivoMusic = "",
                Titulo = "Story - " + str.Nome,
                CarouselPagina = new List<PaginaCarouselPagina>(),
                StoryId = str.Id,
                Sobreescrita = null,
                SubStoryId = null,
                GrupoId = null,
                SubGrupoId = null,
                SubSubGrupoId = null,
                Layout = false,
                Music = false
            };
            pagina.Div = null;

            _context.Add(pagina);
            _context.SaveChanges();

            var pagi = new Pagina(1);
            pagi.Div.First(d => d.Container.Content).Container.Div
            .First(d => d.Div.Content).Div.Elemento = new List<DivElemento>();
            pagi.Div.First(d => d.Container.Content).Container.Div
            .First(d => d.Div.Content).Div.Elemento.Add(new DivElemento
            {
                Div = pagi.Div.First(d => d.Container.Content).Container.Div
                .First(d => d.Div.Content).Div,
                Elemento =  new Texto
                    {
                        Pagina_ = pagina.Id,
                        PalavrasTexto = conteudoHtml
                    }
                
            });

            pagina.Div = new List<PaginaContainer>();
            foreach (var item in pagi.Div)
                pagina.IncluiDiv(item.Container);
            _context.SaveChanges();              

                    verso++;
                }

            RepositoryPagina.paginas.Clear();
                return RedirectToAction("Index", "Home");
                    
                       
        }
        
         public async Task<ActionResult> Incorporar()
        {
            var lista = new List<Story>()
            {new Story{Nome = "Escolha um capitulo de destino", PaginaPadraoLink = 0, Id = 0}};
            var stories = await _context.Story.Where(str =>  str.Nome != "Padrao" && !str.Comentario).ToListAsync();
            lista.AddRange(stories);
            var lista2 = await _context.VideoIncorporado.ToListAsync();

            if(stories.Count == 0)
            {
                ViewBag.Error = "Crie seu story primeiro!!!";
                RedirectToAction("Create", "Story");
            }

            ViewBag.cap = new SelectList(lista, "Id", "CapituloComNome");
            ViewBag.cod = new SelectList(lista2, "Id", "Nome");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Incorporar(long cod, long cap)
        {  
            var videos = "";     
            try { videos = await epositoryPagina.retornarVideos(cod); }
            catch (System.Exception) 
            {
                ModelState.AddModelError("",
                 "informe uma lista existente!!!");
                 return View();
            } 

            var arr = videos.Split("</iframe>");

            foreach(var codigo in arr)
            {
            var arr2 = codigo.Split('"');
          
            if(arr2.Length < 6)
            break;

            var result = arr2[5];
            if(!result.Contains('?'))
            result += "?autoplay=1";

            var resultado = codigo.Replace(arr2[5], result);                       

            var  pag = await _context.Pagina.Include(pa => pa.Story)
            .FirstOrDefaultAsync(pa => pa.Div.Count == 0 && pa.Produto == null && pa.StoryId == cap); 
            if(pag == null)
            break;

            pag.Div = new List<PaginaContainer>
                {
                new PaginaContainer{Container = new Container()},
                new PaginaContainer
                {
                     Container = new Container(1){Content = true}
                }

                };
                pag.Div.First(d => d.Container.Content).Container.Div
                .First(d => d.Div.Content).Div.Elemento = new List<DivElemento>();
                pag.Div.First(d => d.Container.Content).Container.Div
                .First(d => d.Div.Content).Div.Elemento.Add(new DivElemento
                {
                    Div = pag.Div.First(d => d.Container.Content).Container.Div
                    .First(d => d.Div.Content).Div,
                    Elemento =  new Texto
                        {
                            Pagina_ = pag.Id,
                            PalavrasTexto = resultado + "</iframe>"
                        },
                    
                }); 
                      
                _context.Update(pag);
                 _context.SaveChanges();  
            }


            RepositoryPagina.paginas.Clear();
            
            
                return RedirectToAction("Index", "Home");                     
        }

         public ActionResult PaginaCriada( int capitulo, int versiculo)
        {     
            RepositoryPagina.paginas.Clear();        
            ViewBag.capitulo = capitulo;
            ViewBag.versiculo = versiculo;
            return View();
        } 
                
           public ActionResult CompartilhaVerso()
           {
             return View();
           }

             [HttpPost]
           public IActionResult CompartilhaVerso(string livro, int capitulo)
           {
                RepositoryPagina.outroLivro = livro;
                RepositoryPagina.outroCapitulo = capitulo;

            return RedirectToAction("Index", "Home");  
           }

    }
}
