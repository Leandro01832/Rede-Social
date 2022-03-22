using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CMS.Models;
using CMS.Models.Repository;
using business.business;
using Microsoft.AspNetCore.Identity;
using CMS.Data;
using Microsoft.EntityFrameworkCore;

namespace CMS.Controllers
{
    public class HomeController : Controller
    {
        public UserManager<UserModel> UserManager { get; }
        public IRepositoryPagina RepositoryPagina { get; }

        public HomeController(UserManager<UserModel> userManager, IRepositoryPagina repositoryPagina)
        {
            UserManager = userManager;
            RepositoryPagina = repositoryPagina;
        }

        [Route("Carousel")]
        [Route("Carrossel")]
        [Route("Pages")]
        [Route("Paginas")]
        [Route("Index")]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("{Name}")]
        public IActionResult Perfil(string Name)
        {
           var user = UserManager.Users.FirstOrDefault(u => u.Name.ToLower() == Name.Trim().ToLower());

                return View(user);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
