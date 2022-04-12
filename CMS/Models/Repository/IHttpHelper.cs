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
        ulong? GetPaginaId();
        ulong? GetRequisicaoId();
        void SetPaginaId(ulong paginaId);
        void SetRequisicaoId(ulong pedidoId);
        void ResetPedidoId();
        void ResetRequisicaoId();
    }
}
