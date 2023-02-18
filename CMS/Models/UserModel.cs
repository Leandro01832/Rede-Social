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
        public string Livro { get; set; }

    }
}
