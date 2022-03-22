﻿using business.Back;
using business.business;
using business.business.Elementos.element;
using business.div;
using business.Join;
using CMS.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.Extensions.Configuration;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace CMS.Models.Repository
{
    public interface IRepositoryDiv
    {
        Task<string> SalvarBloco(Div div);
        Task<string> EditarBloco(Div div);
        Task ElementosBloco(Div div);
        IIncludableQueryable<Pagina, Pagina> includes();
        IIncludableQueryable<Div, Pagina> includesBloco();
        Task<bool> VerificarExistenciaTable(string id);
    }

    public class RepositoryDiv : BaseRepository<Div>, IRepositoryDiv
    {
        public UserManager<UserModel> UserManager { get; }

        public RepositoryDiv(IConfiguration configuration, ApplicationDbContext contexto,
            UserManager<UserModel> userManager) : base(configuration, contexto)
        {
            UserManager = userManager;
        }

        

        public async Task<string> EditarBloco(Div div)
        {
            contexto.Update(div);
            await contexto.SaveChangesAsync();

            var Div = await contexto.Div
                .Include(d => d.Elemento)
                .ThenInclude(d => d.Div)
                .Include(d => d.Elemento)
                .ThenInclude(d => d.Elemento)
                .FirstAsync(d => d.Id == div.Id);
            Div.Elementos = div.Elementos;

            await ElementosBloco(Div);

            return "";

        }

        public async Task<string> SalvarBloco(Div div)
        {
            try
            {
                await dbSet.AddAsync(div);
                await contexto.SaveChangesAsync();
            }
            catch (Exception)
            {
                return "";
            }

            await ElementosBloco(div);

            return $"Chave do Bloco: {div.Id}";
        }

        public async Task ElementosBloco(Div div)
        {
            var pagina1 = await contexto.Pagina.FirstAsync(p => p.Id == div.Pagina_);
           var cli = await UserManager.Users.FirstAsync(p => p.Id == pagina1.UserId);
            var cliente = cli.Id;

            string elementosGravados = "";
            var array = div.Elementos.Replace(" ", "").Split(',');

            if (div.Elemento != null)
            {

                foreach (var elemento in div.Elemento)
                {
                    elementosGravados += elemento.Elemento.Id + ", ";
                    if (!div.Elementos.Contains(elemento.ElementoId.ToString()))
                    {
                        DivElemento ele;
                        try
                        {
                            ele = await contexto.DivElemento
                            .Include(de => de.Elemento)
                            .Include(de => de.Div)
                            .FirstOrDefaultAsync(e => e.Elemento.Id == elemento.Elemento.Id &&
                            e.Div.Id == elemento.Div.Id);
                        }
                        catch (Exception)
                        {
                            ele = null;
                        }
                        if (ele != null)
                        {
                            contexto.DivElemento.Remove(ele);
                        }
                    }
                }
                await contexto.SaveChangesAsync();
            }

            foreach (var id in array)
            {
                var Div = await contexto.Div.Include(d => d.Elemento).FirstAsync(d => d.Id == div.Id);
                Elemento ele;
                bool MesmoCliente = false;               

                try
                {
                    ele = await contexto.Elemento.FirstOrDefaultAsync(d => d.Id == int.Parse(id));
                    if (ele != null)
                    {
                        var paginaElementoDepe = contexto.Pagina.First(p => p.Id == ele.Pagina_);
                        var site = UserManager.Users.First(p => p.Id == paginaElementoDepe.UserId);
                        if (site.Id == cliente)
                        {
                            MesmoCliente = true;
                        }
                    }
                }
                catch (Exception)
                {
                    ele = null;
                }

                bool VerificaBloco = await VerificaVariosBlocoComTable(Div, ele);

                if (ele != null && MesmoCliente && !elementosGravados.Contains(id) && !VerificaBloco)
                {
                    Div.IncluiElemento(ele);
                    await contexto.SaveChangesAsync();
                }
                    
            }
        }

        private async Task<bool> VerificaVariosBlocoComTable(Div div, Elemento ele)
        {
            var blocos = await contexto.DivPagina.Include(d => d.Div).Where(d => d.DivId == div.Id).ToListAsync();

            if (blocos.Count > 1 && ele.GetType().Name == "Table") return true;
            else
                return false;
        }

        public IIncludableQueryable<Pagina, Pagina> includes()
        {
            var divs = contexto.Pagina
                .Include(p => p.Story)
                .ThenInclude(p => p.Pagina)
                .Include(p => p.Div).ThenInclude(p => p.Div).ThenInclude(p => p.Background).ThenInclude(p => p.Cores)
                
                .Include(p => p.Div).ThenInclude(p => p.Div).ThenInclude(p => p.Background).ThenInclude(p => p.Imagem)
                
                .Include(p => p.Div).ThenInclude(p => p.Div).ThenInclude(p => p.Elemento).ThenInclude(p => p.Elemento)
                .ThenInclude(p => p.Texto)
                
                .Include(p => p.Div).ThenInclude(p => p.Div).ThenInclude(p => p.Elemento).ThenInclude(p => p.Elemento)
                .ThenInclude(p => p.Imagem)
                
                .Include(p => p.Div).ThenInclude(p => p.Div).ThenInclude(p => p.Elemento).ThenInclude(p => p.Elemento)
                .ThenInclude(p => p.Table)
                
                .Include(p => p.Div).ThenInclude(p => p.Div).ThenInclude(p => p.Elemento).ThenInclude(p => p.Elemento)
                .ThenInclude(p => p.Formulario)
                
                .Include(p => p.Div).ThenInclude(p => p.Div).ThenInclude(p => p.Elemento).ThenInclude(p => p.Elemento)
                .ThenInclude(p => p.Dependentes).ThenInclude(p => p.Elemento)
                
                .Include(p => p.Div).ThenInclude(p => p.Div).ThenInclude(p => p.Elemento).ThenInclude(p => p.Elemento)
                .ThenInclude(p => p.Dependentes).ThenInclude(p => p.ElementoDependente)
                
                .Include(p => p.Div).ThenInclude(p => p.Div).ThenInclude(p => p.Elemento).ThenInclude(p => p.Elemento)
                .ThenInclude(p => p.Paginas).ThenInclude(p => p.Elemento)
               
                .Include(p => p.Div).ThenInclude(p => p.Div).ThenInclude(p => p.Elemento).ThenInclude(p => p.Elemento)
                .ThenInclude(p => p.Paginas).ThenInclude(p => p.Pagina);
            return divs;
        }

        public IIncludableQueryable<Div, Pagina> includesBloco()
        {
            var divs = contexto.Div
                .Include(p => p.Background).ThenInclude(p => p.Cores)
                .Include(p => p.Background).ThenInclude(p => p.Imagem)
                
                .Include(p => p.Elemento).ThenInclude(p => p.Elemento)
                .ThenInclude(p => p.Texto)

                .Include(p => p.Elemento).ThenInclude(p => p.Elemento)
                .ThenInclude(p => p.Imagem)

                .Include(p => p.Elemento).ThenInclude(p => p.Elemento)
                .ThenInclude(p => p.Table)

                .Include(p => p.Elemento).ThenInclude(p => p.Elemento)
                .ThenInclude(p => p.Formulario)

                .Include(p => p.Elemento).ThenInclude(p => p.Elemento)
                .ThenInclude(p => p.Dependentes).ThenInclude(p => p.Elemento)

                .Include(p => p.Elemento).ThenInclude(p => p.Elemento)
                .ThenInclude(p => p.Dependentes).ThenInclude(p => p.ElementoDependente)

                .Include(p => p.Elemento).ThenInclude(p => p.Elemento)
                .ThenInclude(p => p.Paginas).ThenInclude(p => p.Elemento)

                .Include(p => p.Elemento).ThenInclude(p => p.Elemento)
                .ThenInclude(p => p.Paginas).ThenInclude(p => p.Pagina);
            return divs;
        }

        public async Task<bool> VerificarExistenciaTable(string id)
        {
            Div div;
            bool condicao = false;
            try
            {
                div = await contexto.Div
                     .Include(d => d.Elemento)
                     .ThenInclude(d => d.Elemento)
                     .FirstOrDefaultAsync(d => d.Id == int.Parse(id));

                if(div != null)
                {
                    foreach(var elemento in div.Elemento)
                    {
                        if(elemento.Elemento.GetType().Name == "Table")
                        {
                            condicao = true;
                        }
                    }
                }


            }
            catch(Exception)
            {
                return true;
            }

                return condicao;
        }
    }
}
