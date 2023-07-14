namespace LHPets.Models
{
    public class Fornecedor
    {
        public int ID { get; set; }
        public string? Nome { get; set; }    

        public string? CNPJ { get; set; }

        public string? Email { get; set; }

        public Fornecedor(int ID, string Nome, string CNPJ, string Email)
        {
            this.ID = ID;
            this.Nome = Nome;
            this.CNPJ = CNPJ;
            this.Email = Email;
        }
    }
}
