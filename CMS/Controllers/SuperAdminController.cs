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
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System.Net.Http.Headers;

namespace CMS.Controllers
{
    [Authorize(Roles = "Admin")]
    public class SuperAdminController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UserManager<UserModel> UserManager { get; }
        public IRepositoryPagina epositoryPagina { get; }
        public IHostingEnvironment HostingEnvironment { get; }
        public IConfiguration Configuration { get; }

        public SuperAdminController(ApplicationDbContext context, UserManager<UserModel> userManager,
            IRepositoryPagina repositoryPagina, IHostingEnvironment hostingEnvironment,
            IConfiguration configuration)
        {
            _context = context;
            UserManager = userManager;
            epositoryPagina = repositoryPagina;
            HostingEnvironment = hostingEnvironment;
            Configuration = configuration;
        }

              
        [Route("SuperAdmin")]
         public IActionResult Index()
        {
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
            var html = RepositoryPagina.Verificar(url);
            string conteudo = "";            

            if(string.IsNullOrEmpty(html))
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
               var str = await _context.Story
               .Include(st => st.Pagina)
            .ThenInclude(st => st.Produto)
            .Include(st => st.Pagina)
            .ThenInclude(st => st.Div)
               .FirstOrDefaultAsync(p => p.PaginaPadraoLink == cap); 
                    pag = str.Pagina
                .FirstOrDefault(st => st.Div.Count == 0 && st.Produto == null);
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
                pag.Data = DateTime.Now;   
                _context.Update(pag);
                 _context.SaveChanges();  

                
                 ViewBag.message = ObterMensagem(pag.StoryId);

                  var p = story.Pagina.First(pagina => pagina.Id == pag.Id);
                    var vers = story.Pagina.IndexOf(p) + 1;

                return RedirectToAction(nameof(PaginaCriada),
            new { capitulo = story.PaginaPadraoLink, versiculo = vers });
            }
            else if(story.Pagina
                .FirstOrDefault(p => Convert.ToDateTime(p.Data.ToString("dd/MM/yyyy"))
                 < Convert.ToDateTime( DateTime.Now.AddDays(-2).ToString("dd/MM/yyyy"))
                  && p.Produto == null) != null)
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
                 
                 ViewBag.message = ObterMensagem(pag.StoryId);
                 
                var p = story.Pagina.First(pagina => pagina.Id == pag.Id);
                var vers = story.Pagina.IndexOf(p) + 1;

                return RedirectToAction(nameof(PaginaCriada),
            new { capitulo = story.PaginaPadraoLink, versiculo = vers });
            }
            else
            {

                ViewBag.message = ObterMensagem(pag.StoryId);

             return View();            
            }
        }
        
         public async Task<ActionResult> BaixarHtmlLivroCapitulo()
        {
            var lista = new List<Story>()
            {new Story{Nome = "Escolha um capitulo de destino", PaginaPadraoLink = 0, Id = 0}};
            var stories = await _context.Story.Where(str =>  str.Nome != "Padrao" && !str.Comentario).ToListAsync();
            lista.AddRange(stories);
            ViewBag.cap = new SelectList(lista, "Id", "CapituloComNome");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> BaixarHtmlLivroCapitulo(string livro, int capitulo, long cap)
        {          
            var url = livro + "/Renderizar/" + capitulo + "/1/1/user";   
        
            WebClient client = new WebClient();
            var html = RepositoryPagina.Verificar(url);                        

            if(string.IsNullOrEmpty(html))
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
                Story destino = null;
                Pagina pagina = null;

                 if(cap != 0)
            {
             destino = await _context.Story
            .Include(dest => dest.Pagina)
            .ThenInclude(dest => dest.Produto)
            .Include(dest => dest.Pagina)
            .ThenInclude(dest => dest.Div)
            .FirstAsync(dest => dest.Id == cap);


            }

                 str.PaginaPadraoLink = lst.Count + 1;
                 str.Nome = "Inportados";
                 str.Inportado = true;
                 _context.Add(str);
                 await _context.SaveChangesAsync();

                var Story = await _context.Story.FirstAsync(st => st.Nome == "Padrao");

            Pagina.entity = true;
            var p = new Pagina()
            {
                Titulo = "Story - " + Story.Nome,
                StoryId = Story.Id,                
                Layout = false
            };
            Pagina.entity = false;             

             _context.Add(p);
             _context.SaveChanges(); 
            
           var  pagin = new Pagina(1);  
            pagin.setarElemento
            (new Texto {Pagina_ = p.Id,
            PalavrasTexto = "<h1> Story " + str.Nome + "</h1>"});

            p.Div = new List<PaginaContainer>();                
            foreach (var item in pagin.Div)            
            p.IncluiDiv(item.Container);                
            _context.SaveChanges();

           

                while(!codigoHtml.Contains("<h1>Pagina não encontrada</h1>") )
                {

                    codigoHtml = client.DownloadString(url);
                    var arr2 = html.Split("<!-- ProdutoContent -->");
                    conteudoHtml = arr2[1];

                    if(destino == null)
                    {
                        Pagina.entity = true;
                        pagina = new Pagina()
                        {
                            Titulo = "Story - " + str.Nome,
                            StoryId = str.Id,                
                            Layout = false
                        };
                        Pagina.entity = false; 

                        _context.Add(pagina);
                        _context.SaveChanges();

                        var pagi = new Pagina(1);
                        pagi
                        .setarElemento( new Texto { Pagina_ = pagina.Id, PalavrasTexto = conteudoHtml });

                        pagina.Div = new List<PaginaContainer>();
                        foreach (var item in pagi.Div)
                        pagina.IncluiDiv(item.Container);
                        _context.SaveChanges();  
                    }
                    else
                    {
                         pagina = await _context.Pagina.Include(pa => pa.Story)
                        .FirstOrDefaultAsync(pa => pa.Div.Count == 0 &&
                         pa.Produto == null && pa.StoryId == cap); 
                        if(pagina == null)
                        break;

                        pagina.Div = new List<PaginaContainer>
                            {
                            new PaginaContainer{Container = new Container()},
                            new PaginaContainer
                            {
                                Container = new Container(1){Content = true}
                            }

                            };
                            pagina.setarElemento
                            ( new Texto { Pagina_ = pagina.Id,
                            PalavrasTexto = conteudoHtml });
                                
                            _context.Update(pagina);
                            _context.SaveChanges();                            
                    }

                    verso++;
                }    

                ViewBag.message = ObterMensagem(pagina.StoryId);            

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
        public async Task<IActionResult> Incorporar( long cap, long cod)
        {  
            var videos = "";     
            try { videos = await epositoryPagina.retornarVideos(cod); }
            catch (System.Exception ex) 
            {
                 var lista = new List<Story>()
                {new Story{Nome = "Escolha um capitulo de destino", PaginaPadraoLink = 0, Id = 0}};
                var stories = await _context.Story.Where(str =>  str.Nome != "Padrao" && !str.Comentario).ToListAsync();
                lista.AddRange(stories);
                var lista2 = await _context.VideoIncorporado.ToListAsync();
                ModelState.AddModelError("",
                 "informe uma lista existente!!!" + ex.Message);
                 ViewBag.cap = new SelectList(lista, "Id", "CapituloComNome");
                 ViewBag.cod = new SelectList(lista2, "Id", "Nome");
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
                pag.setarElemento
                ( new Texto { Pagina_ = pag.Id,
                 PalavrasTexto = resultado + "</iframe>" });
                      
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
                if(livro[livro.Length - 1] == '/')
                livro.Replace(livro[livro.Length - 1].ToString(), "");
                RepositoryPagina.outroLivro = livro;
                RepositoryPagina.outroCapitulo = capitulo;

            return RedirectToAction("Index", "Home");  
           }
          
           public async Task<ActionResult> DefinirLivros(int? pagina)
           {
                int numeroPagina = (pagina ?? 1);

                var applicationDbContext = await _context.Livro  
                .OrderBy(p => p.Id)
                .Skip((numeroPagina - 1) * 10)
                .Take(10).ToListAsync();

                if(applicationDbContext.Count == 10)
                {
                    ViewBag.livro1 = applicationDbContext[0];
                    ViewBag.livro2 = applicationDbContext[1];
                    ViewBag.livro3 = applicationDbContext[2];
                    ViewBag.livro4 = applicationDbContext[3];
                    ViewBag.livro5 = applicationDbContext[4];
                    ViewBag.livro6 = applicationDbContext[5];
                    ViewBag.livro7 = applicationDbContext[6];
                    ViewBag.livro8 = applicationDbContext[7];
                    ViewBag.livro9 = applicationDbContext[8];
                    ViewBag.livro10 = applicationDbContext[9];
                }
                else
                {
                ViewBag.livro1 = RepositoryPagina.livros[0];
                ViewBag.livro2 = RepositoryPagina.livros[1];
                ViewBag.livro3 = RepositoryPagina.livros[2];
                ViewBag.livro4 = RepositoryPagina.livros[3];
                ViewBag.livro5 = RepositoryPagina.livros[4];
                ViewBag.livro6 = RepositoryPagina.livros[5];
                ViewBag.livro7 = RepositoryPagina.livros[6];
                ViewBag.livro8 = RepositoryPagina.livros[7];
                ViewBag.livro9 = RepositoryPagina.livros[8];
                ViewBag.livro10 = RepositoryPagina.livros[9];

                }
                return View();
           }

             [HttpPost]
           public async Task<IActionResult> DefinirLivros(string livro)
           {
                var form = await Request.ReadFormAsync();
                

                foreach(var item in form)
                {
                    if(item.Key.ToString().Contains("livro"))
                    {
                        if(item.Value.ToString()[item.Value.ToString().Length - 1] == '/')
                        item.Value.ToString()
                        .Replace(item.Value.ToString()[item.Value.ToString().Length - 1].ToString(), "");
                        RepositoryPagina.livros[int.Parse(item.Key.ToString().Replace("livro", "")) - 1] =
                        item.Value.ToString();
                    }
                }

            var dia = DateTime.Now.Day;
            if(dia == 31) dia -= 21; else
            if(dia > 20) dia -= 20; else
            if(dia > 10) dia -= 10;

            if(!string.IsNullOrEmpty(RepositoryPagina.livros[dia - 1]))
            RepositoryPagina.outroLivro = RepositoryPagina.livros[dia];
            else
            {
                RepositoryPagina.outroLivro = Configuration.GetConnectionString("Livro");
                var quant = await _context.Story.Where(str => str.Nome != "Padrao").ToListAsync();
                RepositoryPagina.outroCapitulo = RepositoryPagina.randNum
                .Next(1, quant.Count);
            }

            if(!string.IsNullOrEmpty(RepositoryPagina.outroLivro) &&
            RepositoryPagina.outroLivro != Configuration.GetConnectionString("Livro"))
            {
               var capitulos = RepositoryPagina.RetornarCapitulos(RepositoryPagina.outroLivro);
               RepositoryPagina.outroCapitulo = RepositoryPagina.randNum.Next(1, capitulos);
            }


            return RedirectToAction("Index", "Home");  
           }

           public async Task<IActionResult> ImageContent()
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

                ViewBag.stories = new SelectList(lista, "Id", "CapituloComNome");
                return View();
           }

        [HttpPost]
        [RequestFormLimits(MultipartBodyLengthLimit = 409715200)]
        [RequestSizeLimit(409715200)]
        public async Task<IActionResult> ImageContent(IList<IFormFile> files, long StoryId, [FromServices] IHostingEnvironment hostingEnvironment)
        {
            foreach (IFormFile source in files)
            {
                string filename = ContentDispositionHeaderValue.Parse(source.ContentDisposition).FileName.ToString().Trim('"');


                Pagina.entity = true;
            var pagina = new Pagina()
            {
                Titulo = "Imagem",
                StoryId = StoryId,                
                Layout = false
            };
            Pagina.entity = false;           


                using (FileStream output = 
                new FileStream(this.HostingEnvironment.WebRootPath + "\\ImagemContent\\" +
                    filename , FileMode.Create))
                {
                    await source.CopyToAsync(output);
                }

                pagina.ImagemContent = "/ImagemContent/" + filename;

                _context.Add(pagina);
                _context.SaveChanges(); 
                pagina.Div = new List<PaginaContainer>(); 
                var  pagin = new Pagina(1);  
                foreach (var item in pagin.Div)            
                pagina.IncluiDiv(item.Container);             
                _context.SaveChanges();    

                
            }
            return RedirectToAction("Index", "Home");
        }

        [Authorize]
        [Route("SuperAdmin/ChatGpt/{texto}")]
        public async Task<IActionResult> ChatGpt(string texto)
        {
            var lista = new List<Story>()
            {new Story{Nome = "Escolha um capitulo de destino", PaginaPadraoLink = 0, Id = 0}};
            var stories = await _context.Story.Where(str =>  str.Nome != "Padrao" &&
            !str.Comentario).ToListAsync();
            lista.AddRange(stories);

            if(stories.Count == 0)
            {
                ViewBag.Error = "Crie seu story primeiro!!!";
                RedirectToAction("Create", "Story");
            }

            ViewBag.texto = texto;
            ViewBag.cap = new SelectList(lista, "Id", "CapituloComNome");
            return View();
        }

        [HttpPost]
         public async Task<IActionResult> ChatGpt(string Conteudo, long cap)
        { 
            Story Story = null;          
            if(cap != 0)
            {
                Story = await _context.Story
                .Include(str => str.Pagina)
                .FirstAsync(str => str.Id == cap);  

                Pagina.entity = true;
                var pagina = new Pagina()
                {
                    Titulo = "Story - " + Story.Nome,
                    StoryId = Story.Id,                
                    Layout = false
                };
                Pagina.entity = false;

                _context.Add(pagina);
                _context.SaveChanges();

                var pagin = new Pagina(1);
                pagin.setarElemento(new Texto
                {
                Pagina_ = pagina.Id,
                PalavrasTexto = $"{Conteudo}"
                });

                pagina.Div = new List<PaginaContainer>();
                foreach (var item in pagin.Div)
                pagina.IncluiDiv(item.Container);
                _context.SaveChanges();
                RepositoryPagina.paginas.Clear();              
            }  
            else
            {
                var  pag = await  _context.Pagina.Include(pa => pa.Produto)
            .FirstOrDefaultAsync(pa => pa.Div.Count == 0 && pa.Produto == null);
                if(pag != null)
                {
                    Story = await _context.Story
                    .Include(str => str.Pagina)
                    .ThenInclude(str => str.Div)
                    .FirstAsync(str => str.Id == pag.StoryId);                      
                    ViewBag.message = ObterMensagem(pag.StoryId);
               
                    pag.Div = new List<PaginaContainer>
                    {
                    new PaginaContainer{Container = new Container()},
                    new PaginaContainer
                    {
                        Container = new Container(1){Content = true}
                    }

                    };
                    pag.setarElemento
                    ( new Texto { Pagina_ = pag.Id,
                    PalavrasTexto = $"{Conteudo}" });
                        
                    _context.Update(pag);
                    _context.SaveChanges();  
                    RepositoryPagina.paginas.Clear();

                }
            } 

            if(Story != null)
            ViewBag.message += 
             $" Conteudo criado com sucesso!!! Compartilhe!!! \n capitulo {Story.PaginaPadraoLink}" + 
             $" \n verso {Story.Pagina.Where(p => !p.Layout).ToList().Count}";     
            return View("Index", "Home");
        }

       
        public async Task<IActionResult> VideosYoutube()
        {
            var stories = await _context.Story
            .Where(str =>  str.Nome != "Padrao" && !str.Comentario).ToListAsync();

            if(stories.Count == 0)
            {
                ViewBag.Error = "Crie seu story primeiro!!!";
                RedirectToAction("Create", "Story");
            }
            
            ViewBag.cap = new SelectList(stories, "Id", "CapituloComNome");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> VideosYoutube(string usuario, long cap)
        {
            Pagina pag = null;
            if(usuario.Contains("@"))
            usuario.Replace("@", "");

            var url = $"https://www.youtube.com/@{usuario}/shorts";

            var html = RepositoryPagina.Verificar(url);

            var arr = html.Split('"');

            foreach(var texto in arr)
            {
                if(texto.Contains("/shorts/"))
                {
                   var  text =  texto.Replace("shorts", "embed");
                   text += "?autoplay=1"; 
                    if(cap != 0)
                    {
                         pag = await _context.Pagina.Include(pa => pa.Story)
                        .FirstOrDefaultAsync(pa => pa.Div.Count == 0 &&
                        pa.Produto == null && pa.StoryId == cap); 
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
                        pag.setarElemento
                        ( new Texto { Pagina_ = pag.Id,
                        PalavrasTexto = $"<iframe width='320' height='560' src='https://www.youtube.com{text}' " + 
                        "frameborder='0' title='video' allow='accelerometer; autoplay; clipboard-write; encrypted-media; " + 
                        "gyroscope; picture-in-picture; web-share' allowfullscreen ></iframe>" });
                            
                        _context.Update(pag);
                        _context.SaveChanges(); 
                    }
                    else
                    {
                        pag = await _context.Pagina.Include(pa => pa.Story)
                        .FirstOrDefaultAsync(pa => pa.Div.Count == 0 && pa.Produto == null);
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
                        pag.setarElemento
                        ( new Texto { Pagina_ = pag.Id,
                        PalavrasTexto = $"<iframe width='320' height='560' src='https://www.youtube.com{text}' " + 
                        "frameborder='0' title='video' allow='accelerometer; autoplay; clipboard-write; encrypted-media; " + 
                        "gyroscope; picture-in-picture; web-share' allowfullscreen ></iframe>" });
                            
                        _context.Update(pag);
                        _context.SaveChanges(); 
                    }
                }                
            }

            if(pag != null)
            ViewBag.message = ObterMensagem(pag.StoryId);

            return RedirectToAction("Index", "Home");
        }

        private string ObterMensagem(long StoryId)
        {
            var story = _context.Story
            .Include(str => str.Pagina)
            .ThenInclude(str => str.Div)
            .Include(str => str.Pagina)
            .ThenInclude(str => str.Produto)
            .First(str => str.Id == StoryId);

            bool teste = false;
            foreach(var item in story.Pagina)
            if(item.Div.Count == 0 && item.Produto == null)
            teste = true;

            if(teste)
            return $"Existem paginas sem conteudo no capitulo {story.PaginaPadraoLink}";
            else
            return "Story Completo";
        }


    }
}
