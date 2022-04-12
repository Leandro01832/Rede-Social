namespace business.business
{
    public class MensagemChat : BaseModel
    {
        public ulong Pagina { get; set; }
        public string NomeUsuario { get; set; }
        public string Mensagem { get; set; }
    }
}
