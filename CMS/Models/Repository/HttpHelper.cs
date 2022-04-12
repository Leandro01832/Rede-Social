using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;

namespace CMS.Models.Repository
{
    public class HttpHelper : IHttpHelper
    {
        private readonly IHttpContextAccessor contextAccessor;
        public IConfiguration Configuration { get; }
        public UserManager<UserModel> UserManager { get; }

        public HttpHelper(IHttpContextAccessor contextAccessor
            , IConfiguration configuration, UserManager<UserModel> userManager)
        {
            this.contextAccessor = contextAccessor;
            Configuration = configuration;
            UserManager = userManager;
        }

        public ulong? GetRequisicaoId()
        {
            return (ulong) contextAccessor.HttpContext.Session.GetInt32($"RequisicaoId_{GetClienteId()}");
        }

        public void SetRequisicaoId(ulong RequisicaoId)
        {
            contextAccessor.HttpContext.Session.SetInt32($"RequisicaoId_{GetClienteId()}", (int) RequisicaoId);
        }

        public void ResetRequisicaoId()
        {
            contextAccessor.HttpContext.Session.Remove($"RequisicaoId_{GetClienteId()}");
        }

        public ulong? GetPaginaId()
        {
            return (ulong)contextAccessor.HttpContext.Session.GetInt32($"pedidoId_{GetClienteId()}");
        }

        public void SetPaginaId(ulong paginaId)
        {
            contextAccessor.HttpContext.Session.SetInt32($"pedidoId_{GetClienteId()}", (int) paginaId);
        }

        public void ResetPedidoId()
        {
            contextAccessor.HttpContext.Session.Remove($"pedidoId_{GetClienteId()}");
        }

        private string GetClienteId()
        {
            var claimsPrincipal = contextAccessor.HttpContext.User;
            return UserManager.GetUserId(claimsPrincipal);
        }
    }
}
