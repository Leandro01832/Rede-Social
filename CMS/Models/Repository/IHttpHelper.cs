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
        Int64? GetPaginaId();
        Int64? GetRequisicaoId();
        void SetPaginaId(Int64 paginaId);
        void SetRequisicaoId(Int64 pedidoId);
        void ResetPedidoId();
        void ResetRequisicaoId();
    }
}
