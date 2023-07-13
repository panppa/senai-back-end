using Microsoft.AspNetCore.DataProtection.KeyManagement;
using System.Security.Cryptography.Xml;

namespace SistemaClientesWeb.Models
{
    public class Vendas
    {
        public int ID { get; set; }
        public Cliente? Comprador { get; set; }
        public float ValorCompra { get; set; }
        public float ValorImposto { get; set; }
        public float ValorTotal { get; set; }
    }
}
