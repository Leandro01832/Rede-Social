﻿using business.Back;
using business.business;
using business.business.Elementos;
using business.business.Elementos.imagem;
using business.div;
using business.Join;
using CMS.Data;
using CMS.Models;
using CMS.Models.Repository;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS
{
    public class DataService : IDataService
    {
        public IRepositoryPagina epositoryPagina { get; }
        public UserManager<UserModel> UserManager { get; }

        public DataService(IRepositoryPagina repositoryPagina, UserManager<UserModel> userManager)
        {
            epositoryPagina = repositoryPagina;
            UserManager = userManager;
        }


        public async Task InicializaDBAsync(IServiceProvider provider)
        {
            var contexto = provider.GetService<ApplicationDbContext>();

            //  await contexto.Database.MigrateAsync();           

            if (RepositoryPagina.paginas.Count == 0)
            {
                var listaPagina = await epositoryPagina.MostrarPageModels();
                if (listaPagina.Count > 0)
                    RepositoryPagina.paginas.AddRange(listaPagina.Where(l => ! l.Layout).ToList());
            }

            var quant = await contexto.Story.ToListAsync();

            if (quant.Count == 0)
            {
                var str = new Story
                {
                    Nome = "Padrao"
                };
                await contexto.AddAsync(str);
                await contexto.SaveChangesAsync();
            }

            if (await contexto.Set<Imagem>().AnyAsync())
            {
                return;
            }

            var lista = await ListaImagens(provider);
            

        }

        private async Task<List<Imagem>> ListaImagens(IServiceProvider provider)
        {
            var contexto = provider.GetService<ApplicationDbContext>();

          var user =  await UserManager.Users.FirstAsync();

            var pagina = new Pagina
            {
                ArquivoMusic = "",
                Html = "",
                Margem = false,
                Music = false,
                Rotas = "",
                Titulo = "Default",
                UserId = user.Id,
                Exibicao = false,
                StoryId = contexto.Story.ToList().First().Id
            };


            var listaImagens = new List<Imagem>()
            {
                new Imagem
                {
                     ArquivoImagem = "/ImagensGaleria/1.jpg",
                       Nome = "Default",
                        Width = 100
                },
                new Imagem
                {
                     ArquivoImagem = "/ImagensGaleria/2.jpg",
                       Nome = "Default",
                        Width = 100
                },
                new Imagem
                {
                     ArquivoImagem = "/ImagensGaleria/3.jpg",
                       Nome = "Default",
                        Width = 100
                }
            };            

            var Background = new BackgroundImagem
            {
                Background_Position = "",
                Background_Repeat = "",
                 Imagem = listaImagens[0],
                  Div = new DivComum
                  {
                      Background = null,
                      BorderRadius = 0,
                      Colunas = "auto",
                      Desenhado = 1,
                      Divisao = "",
                      Height = 200,
                      Nome = "Default",
                      Ordem = 0,
                      Padding = 5
                  }
            };

            await contexto.Background.AddAsync(Background);
            await contexto.SaveChangesAsync();


            var Div = new DivComum
            {
                Background = new BackgroundImagem
                {
                    Background_Position = "",
                    Background_Repeat = "",
                    Imagem = listaImagens[0],
                    Div = new DivComum
                    {
                        Background = null,
                        BorderRadius = 0,
                        Colunas = "auto",
                        Desenhado = 1,
                        Divisao = "",
                        Height = 200,
                        Nome = "Default",
                        Ordem = 0,
                        Padding = 5
                    }

                },
            BorderRadius = 0,
                Colunas = "auto",
                Desenhado = 1,
                Divisao = "",
                Height = 200,
                Nome = "Default",
                Ordem = 0,
                Padding = 5
            };

            await contexto.Div.AddAsync(Div);
            await contexto.SaveChangesAsync();            

            await contexto.Imagem.AddAsync(listaImagens[1]);
            await contexto.Imagem.AddAsync(listaImagens[2]);
            await contexto.Pagina.AddAsync(pagina);
            await contexto.SaveChangesAsync();
            return listaImagens;
        }
    }
}
