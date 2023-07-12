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
        public new void pagarImposto(float valor){ 
            this.valor = valor;
            this.valor_imposto = this.valor * 20/100;
            this.total = this.valor + this.valor_imposto;
        }
    }
    
}