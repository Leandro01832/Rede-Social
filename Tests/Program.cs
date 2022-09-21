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

            RetornarDados();
            DropTable();
           

            Console.Read();
        }

        public static void metodo1(){

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

        }

        public static void RetornarDados()
        {
            var lista = BaseModel.listTypesSon(typeof(BaseModel));

            foreach (var item in lista)
                foreach (var item2 in item.GetProperties())
                    if (item2.PropertyType == typeof(DateTime) || item2.PropertyType == typeof(DateTime?))
                    {
                        Console.WriteLine("------------------------ || Dados de data || -------------------------------");
                        Console.WriteLine(item2.Name);
                        Console.WriteLine(item2.ReflectedType.Name);
                    }
                    else
                    if (item2.PropertyType == typeof(TimeSpan) || item2.PropertyType == typeof(TimeSpan?))
                    {
                        Console.WriteLine("------------------------ || Dados de hora || -------------------------------");
                        Console.WriteLine(item2.Name);
                        Console.WriteLine(item2.ReflectedType.Name);
                    }
                    else
                    if (item2.PropertyType == typeof(decimal) || item2.PropertyType == typeof(decimal?))
                    {
                        Console.WriteLine("------------------------ || Dados monetários || -------------------------------");
                        Console.WriteLine(item2.Name);
                        Console.WriteLine(item2.ReflectedType.Name);
                    }
        }
        
        public static void RetornarClasses()
        {
            var lista = BaseModel.listTypesSon(typeof(BaseModel));

            foreach (var item in lista)
                        Console.WriteLine(item.Name);
                
        }

        public static void DropTable()
        {
            var lista = BaseModel.listTypesSon(typeof(BaseModel));

            foreach (var item in lista)
                        Console.WriteLine("Drop table " + item.Name + "\n");
                
        }


        

        
    }
}
