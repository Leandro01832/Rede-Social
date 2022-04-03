using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS.Models.Repository
{
   public interface IHttpHelper
    {
        IConfiguration Configuration { get; }
        int? GetPaginaId();
        int? GetRequisicaoId();
        void SetPaginaId(int paginaId);
        void SetRequisicaoId(int pedidoId);
        void ResetPedidoId();
        void ResetRequisicaoId();
    }
}
