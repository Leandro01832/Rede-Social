using business.business;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace business.Back
{
    public class Cor : BaseModel
    {
        public string CorBackground { get; set; }
        public int Position { get; set; }
        public double Transparencia { get; set; }
        [Display(Name="Para qual plano de fundo?")]
        public Int64? BackgroundContainerId { get; set; }        
        public virtual BackgroundContainer BackgroundContainer { get; set; }
        [Display(Name="Para qual plano de fundo?")]
        public Int64? BackgroundDivId { get; set; }        
        public virtual BackgroundDiv BackgroundDiv { get; set; }
        [Display(Name="Para qual plano de fundo?")]
        public Int64? BackgroundElementoId { get; set; }        
        public virtual BackgroundElemento BackgroundElemento { get; set; }



        public static string HexToColor(string hexString)
        {
            if(hexString != null)
            {
                //replace # occurences
                if (hexString.IndexOf('#') != -1)
                    hexString = hexString.Replace("#", "");

                int r, g, b = 0;

                r = int.Parse(hexString.Substring(0, 2), NumberStyles.AllowHexSpecifier);
                g = int.Parse(hexString.Substring(2, 2), NumberStyles.AllowHexSpecifier);
                b = int.Parse(hexString.Substring(4, 2), NumberStyles.AllowHexSpecifier);

                //rgb(9,231,24)
                return $"{r},{g},{b}";
            }
            return "";
        }
    }
}