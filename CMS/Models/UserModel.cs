using business.business;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CMS.Models
{
    public class UserModel : IdentityUser
    {
        private string capa;
        public string Capa 
        {
             get{ 
                if(capa == null || capa == "")
                 return "<br /> <br /> <br />  <center> <h1> "+ Name +
                 "</h1> <br /> <img src='" + Image +
                 "' width='300' class='img-circle img-responsive' /> </center> <br />  <br /> <br /> ";
                 else
                 return capa;
             }
              set{ capa = value; }
        }
        public string Name { get; set; }
        public string Image { get; set; }

        [DataType(DataType.Url)]
        public string Facebook { get; set; }

        [DataType(DataType.Url)]
        public string Twitter { get; set; }

        [DataType(DataType.Url)]
        public string Instagram { get; set; }

        public List<Seguidor> Seguidores { get; set; }
        public List<Seguindo> Seguindo { get; set; }
    }
}
