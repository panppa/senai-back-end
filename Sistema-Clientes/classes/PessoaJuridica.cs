using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_Clientes.classes
{
    public class PessoaJuridica:Cliente
    {
        public string? CNPJ {get; set;}
        public string? IE {get; set;}
    }
}