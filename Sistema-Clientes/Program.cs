using Sistema_Clientes.classes;
class Program{
    static void Main(string[] args)
    {
        
        
        Console.WriteLine("Informe o nome: ");
        string nomeCliente = Console.ReadLine() ?? "";
        

        Console.WriteLine("Informe o endereço: ");
        string enderecoCliente = Console.ReadLine() ?? "";
        
        
        Console.WriteLine("O endereço é comrcial? [S/N]: ");
        string enderecoComercialCliente = Console.ReadLine()??"";
        bool enderecoComercialClienteBool;
        if ((enderecoComercialCliente == "n") || (enderecoComercialCliente == "N")){
            enderecoComercialClienteBool = false;
        }else{
            enderecoComercialClienteBool= true;
        }
        

        Console.WriteLine("Pessoa física (F) ou pessoa jurídica(J)? [F/J]: ");
        string tipo = Console.ReadLine()??"";
        if ((tipo == "j") || (enderecoComercialCliente == "J")){
            PessoaJuridica novoCliente = new PessoaJuridica();
            novoCliente.nome = nomeCliente ;
            novoCliente.endereco = enderecoCliente;
            novoCliente.enderecoComercial = enderecoComercialClienteBool;

            Console.WriteLine("Informe o CNPJ: ");
            string cpfCliente = Console.ReadLine() ?? "";
            novoCliente.CNPJ= cpfCliente;

            Console.WriteLine("Informe o IE: ");
            string rgCliente = Console.ReadLine() ?? "";
            novoCliente.IE= rgCliente;

            Console.WriteLine("Informe o valor de compra:");
            float valorCliente = float.Parse(Console.ReadLine());
            novoCliente.pagarImposto(valorCliente);

            Console.WriteLine("---------------Pessoa jurídica---------------");
            Console.WriteLine("nome.................." + novoCliente.nome);
            Console.WriteLine("CNPJ.................." + novoCliente.CNPJ);
            Console.WriteLine("IE...................." + novoCliente.IE);
            Console.WriteLine("Endereço.............." + novoCliente.endereco);
            Console.WriteLine("Endereço é comercial? " + novoCliente.enderecoComercial);
            Console.WriteLine("Valor................." + novoCliente.valor);
            Console.WriteLine("Valor com imposto....." + novoCliente.total);
        }else{
            PessoaFisica novoCliente = new PessoaFisica();
            novoCliente.nome = nomeCliente ;
            novoCliente.endereco = enderecoCliente;
            novoCliente.enderecoComercial = enderecoComercialClienteBool;

            Console.WriteLine("Informe o CPF: ");
            string cpfCliente = Console.ReadLine() ?? "";
            novoCliente.CPF= cpfCliente;

            Console.WriteLine("Informe o RG: ");
            string rgCliente = Console.ReadLine() ?? "";
            novoCliente.RG= rgCliente;

            Console.WriteLine("Informe o valor de compra:");
            float valorCliente = float.Parse(Console.ReadLine());
            novoCliente.pagarImposto(valorCliente);

            Console.WriteLine("---------------Pessoa física---------------");
            Console.WriteLine("nome.................." + novoCliente.nome);
            Console.WriteLine("CPF..................." + novoCliente.CPF);
            Console.WriteLine("RG...................." + novoCliente.RG);
            Console.WriteLine("Endereço.............." + novoCliente.endereco);
            Console.WriteLine("Endereço é comercial? " + novoCliente.enderecoComercial);
            Console.WriteLine("Valor................." + novoCliente.valor);
            Console.WriteLine("Valor com imposto....." + novoCliente.total);
        }
    }
}