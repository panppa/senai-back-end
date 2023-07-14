using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LHPets.Models
{
    [Table("Cliente")]
    public class Cliente
    {
        [Column ("ID")]
        [Display (Name = "ID")]
        public int ID { get; set; }
        [Column("Nome")]
        [Display(Name = "Nome")]
        public string? Nome { get; set; }
        [Column("CPF")]
        [Display(Name = "Cpf")]
        public string? CPF { get; set; }
        [Column("Email")]
        [Display(Name = "Email")]
        public string? Email { get; set; }

        public Cliente(int ID, string Nome, string CPF, string Email) { 
            this.ID = ID;
            this.Nome = Nome;
            this.CPF = CPF;
            this.Email = Email;
        }
    }
}
