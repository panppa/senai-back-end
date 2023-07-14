namespace LHPets.Models
{
    public class Pet
    {
        public int ID { get; set; }
        public Cliente Dono { get; set; }

        public string? Nome { get; set; }
        public string? Raca { get; set; }
        public Pet(int ID,Cliente Dono, string Nome, string Raca)
        {
            this.ID = ID;
            this.Nome = Nome;
            this.Raca = Raca;
            this.Dono = Dono;   

        }
    }
    
}
