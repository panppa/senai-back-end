namespace SistemaClientesWeb.Models
{
    public class PessoaJuridica:Cliente
    {
        public string? CNPJ { get; set; }
        public string? IE { get; set; }
    }
}
