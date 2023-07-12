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

        public void pagarImposto(){ 
        
        }
    }

    
}