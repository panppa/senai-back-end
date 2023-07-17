using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LHPets.Models
{
    [Table("Fornecedor")]
    public class Fornecedor
    {
        [Column("ID")]
        [Display(Name = "ID")]
        public int ID { get; set; }

        [Column("Nome")]
        [Display(Name = "Nome")]
        public string? Nome { get; set; }

        [Column("Cnpj")]
        [Display(Name = "Cnpj")]
        public string? CNPJ { get; set; }

        [Column("Email")]
        [Display(Name = "Email")]
        public string? Email { get; set; }

        public Fornecedor(int ID, string Nome, string CNPJ, string Email)
        {
            this.ID = ID;
            this.Nome = Nome;
            this.CNPJ = CNPJ;
            this.Email = Email;
        }
        public Fornecedor()
        {

            this.ID = 333;
            this.Nome = "";
            this.CNPJ = "";
            this.Email = "";
        }
    }
}
