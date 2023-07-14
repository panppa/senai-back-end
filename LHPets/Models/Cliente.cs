namespace LHPets.Models
{
    public class Cliente
    {
        public int ID { get; set; }
        public string? Nome { get; set; }

        public string? CPF { get; set; }

        public string? Email { get; set; }

        public Cliente(int ID, string Nome, string CPF, string Email) { 
            this.ID = ID;
            this.Nome = Nome;
            this.CPF = CPF;
            this.Email = Email;
        }
    }
}
