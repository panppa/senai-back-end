using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_Clientes.classes
{
    public class PessoaFisica:Cliente
    {
        public string? RG { get; set; }
        public string? CPF { get; set; }
    }
}