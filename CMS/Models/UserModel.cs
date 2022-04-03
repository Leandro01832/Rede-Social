using business.business;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CMS.Models
{
    public class UserModel : IdentityUser
    {
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
