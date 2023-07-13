using Microsoft.AspNetCore.DataProtection.KeyManagement;

namespace SistemaClientesWeb.Models
{
    public abstract class Cliente
    {
        public int ID { get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public string? Telefone { get; set; }
        public string? Endereço { get; set; }

    }
}
