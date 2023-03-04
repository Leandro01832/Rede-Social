using business.business.Group;
using System.Linq;
using System;
using System.Collections.Generic;

namespace CMS.Models
{
    public class ObjectArray 
    {
        
        public int[] RetornarArray(Story story, int Indice, int? IndiceSubStory,int? IndiceGrupo,
          int? IndiceSubGrupo, int? IndiceSubSubGrupo, int? IndiceCamadaSeis, int? IndiceCamadaSete,
          int? IndiceCamadaOito, int? IndiceCamadaNove, int? IndiceCamadaDez) 
        {
            int[] result = null;
            bool condicao = false;

            if(IndiceCamadaDez != null)
            {
                long num = long.Parse($"{Indice}{IndiceSubStory}{IndiceGrupo}{IndiceSubGrupo}{IndiceSubSubGrupo}{IndiceCamadaSeis}{IndiceCamadaSete}{IndiceCamadaOito}{IndiceCamadaNove}{IndiceCamadaDez}");
                 foreach (var item in story.SubStory.Where(str => str.Pagina.Count > 0).ToList())
                {
                    foreach (var item2 in item.Grupo.Where(str => str.Pagina.Count > 0).ToList())
                    {
                        foreach (var item3 in item2.SubGrupo.Where(str => str.Pagina.Count > 0).ToList())
                        {
                            foreach (var item4 in item3.SubSubGrupo.Where(str => str.Pagina.Count > 0).ToList())
                            {
                                foreach(var item5 in item4.CamadaSeis.Where(str => str.Pagina.Count > 0).ToList())
                                {
                                    foreach(var item6 in item5.CamadaSete.Where(str => str.Pagina.Count > 0).ToList())
                                    {
                                        foreach(var item7 in item6.CamadaOito.Where(str => str.Pagina.Count > 0).ToList())
                                        {
                                               foreach(var item8 in item7.CamadaNove.Where(str => str.Pagina.Count > 0).ToList())
                                               {
                                                     foreach(var item9 in item8.CamadaDez)
                                                     {
                                                         var var1 = story.SubStory.Where(str => str.Pagina.Count > 0).ToList().IndexOf(item) + 1;
                                                        var var2 = item.Grupo.Where(str => str.Pagina.Count > 0).ToList().IndexOf(item2) + 1;
                                                        var var3 = item2.SubGrupo.Where(str => str.Pagina.Count > 0).ToList().IndexOf(item3) + 1;
                                                        var var4 = item3.SubSubGrupo.Where(str => str.Pagina.Count > 0).ToList().IndexOf(item4) + 1;
                                                        var var5 = item4.CamadaSeis.Where(str => str.Pagina.Count > 0).ToList().IndexOf(item5) + 1;
                                                        var var6 = item5.CamadaSete.Where(str => str.Pagina.Count > 0).ToList().IndexOf(item6) + 1;
                                                        var var7 = item6.CamadaOito.Where(str => str.Pagina.Count > 0).ToList().IndexOf(item7) + 1;
                                                        var var8 = item7.CamadaNove.Where(str => str.Pagina.Count > 0).ToList().IndexOf(item8) + 1;
                                                        var var9 = item8.CamadaDez.Where(str => str.Pagina.Count > 0).ToList().IndexOf(item9) + 1;
                                                        long num2 = long.Parse($"{Indice}{var1}{var2}{var3}{var4}{var5}{var6}{var7}{var8}{var9}");
                                                        if(num2 > num)
                                                        {
                                                            condicao = true;
                                                            result = new int[5];
                                                            result[0] = Indice;                    
                                                            result[1] = var1;                    
                                                            result[2] = var2;                    
                                                            result[3] = var3;                    
                                                            result[4] = var4;                    
                                                            result[5] = var5;                    
                                                            result[6] = var6;                    
                                                            result[7] = var7;                    
                                                            result[8] = var8;                    
                                                            result[9] = var9;                    
                                                            break;
                                                        }
                                                     }
                                               }
                                        }
                                        if(condicao) break;

                                    }
                                    if(condicao) break;
                                }
                                if(condicao) break;
                                
                            }
                            if(condicao) break;

                        }
                        if(condicao) break;

                    }
                    if(condicao) break;
                }
            }
            else
            if(IndiceCamadaNove != null)
            {
                long num = long.Parse($"{Indice}{IndiceSubStory}{IndiceGrupo}{IndiceSubGrupo}{IndiceSubSubGrupo}{IndiceCamadaSeis}{IndiceCamadaSete}{IndiceCamadaOito}{IndiceCamadaNove}");
                 foreach (var item in story.SubStory.Where(str => str.Pagina.Count > 0).ToList())
                {
                    foreach (var item2 in item.Grupo.Where(str => str.Pagina.Count > 0).ToList())
                    {
                        foreach (var item3 in item2.SubGrupo.Where(str => str.Pagina.Count > 0).ToList())
                        {
                            foreach (var item4 in item3.SubSubGrupo.Where(str => str.Pagina.Count > 0).ToList())
                            {
                                foreach(var item5 in item4.CamadaSeis.Where(str => str.Pagina.Count > 0).ToList())
                                {
                                    foreach(var item6 in item5.CamadaSete.Where(str => str.Pagina.Count > 0).ToList())
                                    {
                                        foreach(var item7 in item6.CamadaOito.Where(str => str.Pagina.Count > 0).ToList())
                                        {
                                               foreach(var item8 in item7.CamadaNove.Where(str => str.Pagina.Count > 0).ToList())
                                               {
                                                      var var1 = story.SubStory.Where(str => str.Pagina.Count > 0).ToList().IndexOf(item) + 1;
                                                        var var2 = item.Grupo.Where(str => str.Pagina.Count > 0).ToList().IndexOf(item2) + 1;
                                                        var var3 = item2.SubGrupo.Where(str => str.Pagina.Count > 0).ToList().IndexOf(item3) + 1;
                                                        var var4 = item3.SubSubGrupo.Where(str => str.Pagina.Count > 0).ToList().IndexOf(item4) + 1;
                                                        var var5 = item4.CamadaSeis.Where(str => str.Pagina.Count > 0).ToList().IndexOf(item5) + 1;
                                                        var var6 = item5.CamadaSete.Where(str => str.Pagina.Count > 0).ToList().IndexOf(item6) + 1;
                                                        var var7 = item6.CamadaOito.Where(str => str.Pagina.Count > 0).ToList().IndexOf(item7) + 1;
                                                        var var8 = item7.CamadaNove.Where(str => str.Pagina.Count > 0).ToList().IndexOf(item8) + 1;
                                                        long num2 = long.Parse($"{Indice}{var1}{var2}{var3}{var4}{var5}{var6}{var7}{var8}");
                                                        if(num2 > num)
                                                        {
                                                            condicao = true;
                                                            result = new int[5];
                                                            result[0] = Indice;                    
                                                            result[1] = var1;                    
                                                            result[2] = var2;                    
                                                            result[3] = var3;                    
                                                            result[4] = var4;                    
                                                            result[5] = var5;                    
                                                            result[6] = var6;                    
                                                            result[7] = var7;                    
                                                            result[8] = var8;                    
                                                            break;
                                                        }
                                               }
                                        }
                                        if(condicao) break;

                                    }
                                    if(condicao) break;
                                }
                                if(condicao) break;
                                
                            }
                            if(condicao) break;

                        }
                        if(condicao) break;

                    }
                    if(condicao) break;
                }
            }
            else
            if(IndiceCamadaOito != null)
            {
                long num = long.Parse($"{Indice}{IndiceSubStory}{IndiceGrupo}{IndiceSubGrupo}{IndiceSubSubGrupo}{IndiceCamadaSeis}{IndiceCamadaSete}{IndiceCamadaOito}");
                 foreach (var item in story.SubStory.Where(str => str.Pagina.Count > 0).ToList())
                {
                    foreach (var item2 in item.Grupo.Where(str => str.Pagina.Count > 0).ToList())
                    {
                        foreach (var item3 in item2.SubGrupo.Where(str => str.Pagina.Count > 0).ToList())
                        {
                            foreach (var item4 in item3.SubSubGrupo.Where(str => str.Pagina.Count > 0).ToList())
                            {
                                foreach(var item5 in item4.CamadaSeis.Where(str => str.Pagina.Count > 0).ToList())
                                {
                                    foreach(var item6 in item5.CamadaSete.Where(str => str.Pagina.Count > 0).ToList())
                                    {
                                        foreach(var item7 in item6.CamadaOito.Where(str => str.Pagina.Count > 0).ToList())
                                        {
                                                    var var1 = story.SubStory.Where(str => str.Pagina.Count > 0).ToList().IndexOf(item) + 1;
                                                var var2 = item.Grupo.Where(str => str.Pagina.Count > 0).ToList().IndexOf(item2) + 1;
                                                var var3 = item2.SubGrupo.Where(str => str.Pagina.Count > 0).ToList().IndexOf(item3) + 1;
                                                var var4 = item3.SubSubGrupo.Where(str => str.Pagina.Count > 0).ToList().IndexOf(item4) + 1;
                                                var var5 = item4.CamadaSeis.Where(str => str.Pagina.Count > 0).ToList().IndexOf(item5) + 1;
                                                var var6 = item5.CamadaSete.Where(str => str.Pagina.Count > 0).ToList().IndexOf(item6) + 1;
                                                var var7 = item6.CamadaOito.Where(str => str.Pagina.Count > 0).ToList().IndexOf(item7) + 1;
                                                long num2 = long.Parse($"{Indice}{var1}{var2}{var3}{var4}{var5}{var6}{var7}");
                                                if(num2 > num)
                                                {
                                                    condicao = true;
                                                    result = new int[5];
                                                    result[0] = Indice;                    
                                                    result[1] = var1;                    
                                                    result[2] = var2;                    
                                                    result[3] = var3;                    
                                                    result[4] = var4;                    
                                                    result[5] = var5;                    
                                                    result[6] = var6;                    
                                                    result[7] = var7;                    
                                                    break;
                                                }
                                        }
                                        if(condicao) break;

                                    }
                                    if(condicao) break;
                                }
                                if(condicao) break;
                                
                            }
                            if(condicao) break;

                        }
                        if(condicao) break;

                    }
                    if(condicao) break;
                }
            }
            else
            if(IndiceCamadaSete != null)
            {
                long num = long.Parse($"{Indice}{IndiceSubStory}{IndiceGrupo}{IndiceSubGrupo}{IndiceSubSubGrupo}{IndiceCamadaSeis}{IndiceCamadaSete}");
                 foreach (var item in story.SubStory.Where(str => str.Pagina.Count > 0).ToList())
                {
                    foreach (var item2 in item.Grupo.Where(str => str.Pagina.Count > 0).ToList())
                    {
                        foreach (var item3 in item2.SubGrupo.Where(str => str.Pagina.Count > 0).ToList())
                        {
                            foreach (var item4 in item3.SubSubGrupo.Where(str => str.Pagina.Count > 0).ToList())
                            {
                                foreach(var item5 in item4.CamadaSeis.Where(str => str.Pagina.Count > 0).ToList())
                                {
                                    foreach(var item6 in item5.CamadaSete)
                                    {
                                        var var1 = story.SubStory.Where(str => str.Pagina.Count > 0).ToList().IndexOf(item) + 1;
                                        var var2 = item.Grupo.Where(str => str.Pagina.Count > 0).ToList().IndexOf(item2) + 1;
                                        var var3 = item2.SubGrupo.Where(str => str.Pagina.Count > 0).ToList().IndexOf(item3) + 1;
                                        var var4 = item3.SubSubGrupo.Where(str => str.Pagina.Count > 0).ToList().IndexOf(item4) + 1;
                                        var var5 = item4.CamadaSeis.Where(str => str.Pagina.Count > 0).ToList().IndexOf(item5) + 1;
                                        var var6 = item5.CamadaSete.Where(str => str.Pagina.Count > 0).ToList().IndexOf(item6) + 1;
                                        long num2 = long.Parse($"{Indice}{var1}{var2}{var3}{var4}{var5}{var6}");
                                        if(num2 > num)
                                        {
                                            condicao = true;
                                            result = new int[5];
                                            result[0] = Indice;                    
                                            result[1] = var1;                    
                                            result[2] = var2;                    
                                            result[3] = var3;                    
                                            result[4] = var4;                    
                                            result[5] = var5;                    
                                            result[6] = var6;                    
                                            break;
                                        }

                                    }
                                    if(condicao) break;
                                }
                                if(condicao) break;
                                
                            }
                            if(condicao) break;

                        }
                            if(condicao) break;

                    }
                    if(condicao) break;
                }
            }
            else
            if(IndiceCamadaSeis != null)
            {
                long num = long.Parse($"{Indice}{IndiceSubStory}{IndiceGrupo}{IndiceSubGrupo}{IndiceSubSubGrupo}{IndiceCamadaSeis}");
                 foreach (var item in story.SubStory.Where(str => str.Pagina.Count > 0).ToList())
                {
                    foreach (var item2 in item.Grupo.Where(str => str.Pagina.Count > 0).ToList())
                    {
                        foreach (var item3 in item2.SubGrupo.Where(str => str.Pagina.Count > 0).ToList())
                        {
                            foreach (var item4 in item3.SubSubGrupo.Where(str => str.Pagina.Count > 0).ToList())
                            {
                                foreach(var item5 in item4.CamadaSeis.Where(str => str.Pagina.Count > 0).ToList())
                                {
                                    var var1 = story.SubStory.Where(str => str.Pagina.Count > 0).ToList().IndexOf(item) + 1;
                                    var var2 = item.Grupo.Where(str => str.Pagina.Count > 0).ToList().IndexOf(item2) + 1;
                                    var var3 = item2.SubGrupo.Where(str => str.Pagina.Count > 0).ToList().IndexOf(item3) + 1;
                                    var var4 = item3.SubSubGrupo.Where(str => str.Pagina.Count > 0).ToList().IndexOf(item4) + 1;
                                    var var5 = item4.CamadaSeis.Where(str => str.Pagina.Count > 0).ToList().IndexOf(item5) + 1;
                                    long num2 = long.Parse($"{Indice}{var1}{var2}{var3}{var4}{var5}");
                                    if(num2 > num)
                                    {
                                        condicao = true;
                                        result = new int[5];
                                        result[0] = Indice;                    
                                        result[1] = var1;                    
                                        result[2] = var2;                    
                                        result[3] = var3;                    
                                        result[4] = var4;                    
                                        result[5] = var5;                    
                                        break;
                                    }
                                }
                                if(condicao) break;
                                
                            }
                            if(condicao) break;

                        }
                            if(condicao) break;

                    }
                    if(condicao) break;
                }
            }
            else
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