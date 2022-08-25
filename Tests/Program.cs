using business.Back;
using business.business;
using business.business.carousel;
using business.business.element;
using business.business.Elementos;
using business.business.Elementos.element;
using business.business.Elementos.imagem;
using business.business.Elementos.texto;
using business.business.link;
using business.div;
using business.Join;
using CMS.Models.Repository;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Tests
{
    class Program
    {

        

        static void Main(string[] args)
        {
           Random rnd = new Random();
           int aleatorio = rnd.Next(1, 999999);
           string escolhidos = "";
                
            
            for (int i = 0; i < RepositoryPagina.paginas.Length; i++)
             {
                if(i == aleatorio)
                {

                 RepositoryPagina.paginas[i] = new List<business.business.Pagina>();
                 RepositoryPagina.paginas[i].Add(new Pagina());
                 aleatorio = rnd.Next(i, 99999999);
                 escolhidos += i + ", ";
               
                }
                
             }           

              for (int i = 0; i < RepositoryPagina.paginas.Length; i++)
             {
                if(RepositoryPagina.paginas[i] == null)               
                continue;
                
                Console.Write(i + ", ");  
             }
                Console.WriteLine("\n"); 

            Console.WriteLine(escolhidos); 
            Console.WriteLine(RepositoryPagina.paginas.Length); 
            Console.WriteLine("Executado!!!");  
            Console.Read();
        }

        
    }
}
