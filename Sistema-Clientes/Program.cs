using Sistema_Clientes.classes;
class Program{
    static void Main(string[] args)
    {
        PessoaFisica novoCliente = new PessoaFisica();
        novoCliente.nome="Sergio Fonseca do Zapzap";
        novoCliente.endereco = "Rua Sem Saída, 444";
        novoCliente.enderecoComercial = false;
        novoCliente.CPF="99999999999";
        novoCliente.RG="11111111";
        Console.WriteLine(novoCliente.nome);
        Console.WriteLine(novoCliente.endereco);
        Console.WriteLine(novoCliente.enderecoComercial);
        Console.WriteLine(novoCliente.CPF);
        Console.WriteLine(novoCliente.RG);
    }
}