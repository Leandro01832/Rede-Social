﻿using Microsoft.AspNetCore.Http;
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

        public int? GetRequisicaoId()
        {
            return contextAccessor.HttpContext.Session.GetInt32($"RequisicaoId_{GetClienteId()}");
        }

        public void SetRequisicaoId(int RequisicaoId)
        {
            contextAccessor.HttpContext.Session.SetInt32($"RequisicaoId_{GetClienteId()}", RequisicaoId);
        }

        public void ResetRequisicaoId()
        {
            contextAccessor.HttpContext.Session.Remove($"RequisicaoId_{GetClienteId()}");
        }

        public int? GetPedidoId()
        {
            return contextAccessor.HttpContext.Session.GetInt32($"pedidoId_{GetClienteId()}");
        }

        public void SetPedidoId(int pedidoId)
        {
            contextAccessor.HttpContext.Session.SetInt32($"pedidoId_{GetClienteId()}", pedidoId);
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
