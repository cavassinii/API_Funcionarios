using System.ComponentModel.DataAnnotations;

namespace API_Funcionarios.Models
{
    public class Funcionario
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; } = string.Empty;

        [Required]
        public string Cargo { get; set; } = string.Empty;

        public decimal Salario { get; set; }
    }
}