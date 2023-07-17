using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LHPets.Models
{
    [Table("Pet")]
    public class Pet
    {

            [Column("ID")]
            [Display(Name = "ID")]
            public int ID { get; set; }

            [ForeignKey("Dono")]
            [Column("DonoID")]
            [Display(Name = "DonoID")]
            public int DonoID { get; set; }
            [Column("Nome")]
            [Display(Name = "Nome")]
            public string Nome { get; set; }
            [Column("Especie")]
            [Display(Name = "Especie")]
            public string Especie { get; set; }

            [Column("DonoNome")]
            [Display(Name = "DonoNome")]
            public string? DonoNome { get; set; }
        public Pet(int ID,int DonoID, string Nome, string Especie)
            {
                this.ID = ID;
                this.Nome = Nome;
                this.Especie = Especie;
                this.DonoID = DonoID;   

            }
        //todo: consertar isso aqui
        public Pet()
        {
            this.ID = 333;
            this.Nome = "nome";
            this.Especie = "Especie";
            this.DonoID = 333;

        }
    }
    
}
