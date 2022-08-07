using business.business;
using business.business.Group;
using CMS.Data;
using CMS.Models;
using CMS.Models.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace CMS.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class RegisterModel : PageModel
    {
        private readonly SignInManager<UserModel> _signInManager;
        private readonly UserManager<UserModel> _userManager;
        private readonly ILogger<RegisterModel> _logger;
        private readonly IEmailSender _emailSender;
        public ApplicationDbContext Context { get; }
        public IUserHelper UserHelper { get; }

        public RegisterModel(
            UserManager<UserModel> userManager,
            SignInManager<UserModel> signInManager,
            ILogger<RegisterModel> logger,
            IEmailSender emailSender,
            ApplicationDbContext context,
            IUserHelper userHelper)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _emailSender = emailSender;
            Context = context;
            UserHelper = userHelper;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public string ReturnUrl { get; set; }
        

        public class InputModel
        {
            [Required]
            [EmailAddress]
            [Display(Name = "Email")]
            public string Email { get; set; }
            [DataType(DataType.Url)]
            public string Facebook { get; set; }

            [Display(Name = "Twitter")]
            [DataType(DataType.Url)]
            public string Twiter { get; set; }

            [DataType(DataType.Url)]
            public string Instagram { get; set; }


            [Display(Name = "Nome de Usuario")]
            public string Name { get; set; }

            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 8)]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirm password")]
            [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }
        }

        public void OnGet(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/");

            if(_userManager.Users.FirstOrDefault(u => u.Name.ToLower() == Input.Name.Trim().ToLower()) != null)
            {
                ModelState.AddModelError(string.Empty, "Nome de usuario já existente!!!");
            }

            else
            if (ModelState.IsValid)
            {
                var user = new UserModel
                {
                    UserName = Input.Email,
                    Email = Input.Email,
                    Name = Input.Name.Trim().ToLower().Replace(" ", "-"),
                    Image = "/ImagensGaleria/Padrao.jpg",
                    Twitter = Input.Twiter,
                    Instagram = Input.Instagram,
                    Facebook = Input.Facebook
                };
                var result = await _userManager.CreateAsync(user, Input.Password);
                if (result.Succeeded)
                {
                    var story = new Story
                    {
                        Nome = "Padrao",
                        UserId = user.Id
                    };
                    await Context.AddAsync(story);


                    await UserHelper.CreateUserASPAsync(user.UserName, "Video");
                    await UserHelper.CreateUserASPAsync(user.UserName, "Texto");
                    await UserHelper.CreateUserASPAsync(user.UserName, "Imagem");
                    await UserHelper.CreateUserASPAsync(user.UserName, "Carousel");
                    await UserHelper.CreateUserASPAsync(user.UserName, "Background");
                    await UserHelper.CreateUserASPAsync(user.UserName, "Music");
                    await UserHelper.CreateUserASPAsync(user.UserName, "Link");
                    await UserHelper.CreateUserASPAsync(user.UserName, "Div");
                    await UserHelper.CreateUserASPAsync(user.UserName, "Elemento");
                    await UserHelper.CreateUserASPAsync(user.UserName, "Pagina");
                    await UserHelper.CreateUserASPAsync(user.UserName, "Ecommerce");
                    await UserHelper.CreateUserASPAsync(user.UserName, "Formulario");
                    await UserHelper.CreateUserASPAsync(user.UserName, "Admin");

                    await Context.Permissao.AddAsync(new Permissao
                    { NomePermissao = "Video", UserId = user.Id, UserName = user.UserName });
                    await Context.Permissao.AddAsync(new Permissao
                    { NomePermissao = "Texto", UserId = user.Id, UserName = user.UserName });
                    await Context.Permissao.AddAsync(new Permissao
                    { NomePermissao = "Imagem", UserId = user.Id, UserName = user.UserName });
                    await Context.Permissao.AddAsync(new Permissao
                    { NomePermissao = "Carousel", UserId = user.Id, UserName = user.UserName });
                    await Context.Permissao.AddAsync(new Permissao
                    { NomePermissao = "Background", UserId = user.Id, UserName = user.UserName });
                    await Context.Permissao.AddAsync(new Permissao
                    { NomePermissao = "Music", UserId = user.Id, UserName = user.UserName });
                    await Context.Permissao.AddAsync(new Permissao
                    { NomePermissao = "Link", UserId = user.Id, UserName = user.UserName });
                    await Context.Permissao.AddAsync(new Permissao
                    { NomePermissao = "Div", UserId = user.Id, UserName = user.UserName });
                    await Context.Permissao.AddAsync(new Permissao
                    { NomePermissao = "Elemento", UserId = user.Id, UserName = user.UserName });
                    await Context.Permissao.AddAsync(new Permissao
                    { NomePermissao = "Pagina", UserId = user.Id, UserName = user.UserName });
                    await Context.Permissao.AddAsync(new Permissao
                    { NomePermissao = "Ecommerce", UserId = user.Id, UserName = user.UserName });
                    await Context.Permissao.AddAsync(new Permissao
                    { NomePermissao = "Formulario", UserId = user.Id, UserName = user.UserName });
                    await Context.Permissao.AddAsync(new Permissao
                    { NomePermissao = "Admin", UserId = user.Id, UserName = user.UserName });

                    await Context.SaveChangesAsync();

                    _logger.LogInformation("User created a new account with password.");

                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    var callbackUrl = Url.Page(
                        "/Account/ConfirmEmail",
                        pageHandler: null,
                        values: new { userId = user.Id, code = code },
                        protocol: Request.Scheme);

                    await _emailSender.SendEmailAsync(Input.Email, "Confirme seu email",
                        $"Por favor confirme sua conta <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicando aqui</a>.");

                    await _signInManager.SignInAsync(user, isPersistent: false);
                    return LocalRedirect(returnUrl);
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }
    }
}
