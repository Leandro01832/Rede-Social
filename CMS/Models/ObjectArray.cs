using business.business.Group;
using System.Linq;
using System;
using System.Collections.Generic;

namespace CMS.Models
{
    public class ObjectArray 
    {
        
        public int[] RetornarArray(Story story, int Indice, int? IndiceSubStory, int? IndiceGrupo, int? IndiceSubGrupo, int? IndiceSubSubGrupo) 
        {
            int[] result = null;
            bool condicao = false;

            if(IndiceSubSubGrupo != null)
            {
                long num = long.Parse($"{Indice}{IndiceSubStory}{IndiceGrupo}{IndiceSubGrupo}{IndiceSubSubGrupo}");
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
                                if(num2 > num)
                                {
                                    condicao = true;
                                    result = new int[5];
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
            }
            else if(IndiceSubGrupo != null)
            {
                long num = long.Parse($"{Indice}{IndiceSubStory}{IndiceGrupo}{IndiceSubGrupo}");
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
                                result = new int[4];
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
            }
             else if(IndiceGrupo != null)
            {
                long num = long.Parse($"{Indice}{IndiceSubStory}{IndiceGrupo}");   
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
                            result = new int[3];
                            result[0] = Indice;                    
                            result[1] = var1;                    
                            result[2] = var2;                    
                            break;
                        }
                    }
                    if(condicao) break;
                }                
            }
             else if(IndiceSubStory != null)
            {
                long num = long.Parse($"{Indice}{IndiceSubStory}");   
                foreach (var item in story.SubStory.Where(str => str.Pagina.Count > 0).ToList())
                {
                    var var1 = story.SubStory.Where(str => str.Pagina.Count > 0).ToList().IndexOf(item) + 1;
                    long num2 = long.Parse($"{Indice}{var1}");
                    if(num2 > num){
                        condicao = true;
                        result = new int[2];
                        result[0] = Indice;                    
                        result[1] = var1;                    
                        break;
                    }
                }                
            }
            return result;             
        }
        
    }
}