using System;

namespace business.business
{
    public class MensagemChat : BaseModel
    {
        public Int64 Pagina { get; set; }
        public string NomeUsuario { get; set; }
        public string Mensagem { get; set; }
    }
}
