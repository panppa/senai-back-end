using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_Clientes.classes
{
    public abstract class Cliente
    {
        public string? nome {get; set;}
        public string? endereco {get; set;}
        public bool enderecoComercial {get; set;}
        public float valor{get; protected set;}
        public float valor_imposto{get; protected set;}
        public float total{get; protected set;}

        public void pagarImposto(float valor){ 
            this.valor = valor;
            this.valor_imposto = this.valor * 10/100;
            this.total = this.valor + this.valor_imposto;
        }
    }

    
}