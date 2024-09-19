using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace ProConsulta.Components.Pages.Pacientes
{
    public class PacienteInputModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "O Nome deve ser fornecido!")]
        [MaxLength(50, ErrorMessage = "O {0} deve ter no máximo {1} caracteres!")]

        public string Nome { get; set; }
        [Required(ErrorMessage = "O Documento deve ser fornecido!")]
        public string Documento { get; set; }

        [Required(ErrorMessage = "O Email deve ser fornecido!")]
        [EmailAddress(ErrorMessage = "O Email inválido!")]
        [MaxLength(50, ErrorMessage = "O {0} deve ter no máximo {1} caracteres!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O Celular deve ser fornecido!")]
        public string Celular { get; set; }

        [Required(ErrorMessage = "Data de Nascimento deve ser fornecida!")]
        public DateTime DataNascimento { get; set; } = DateTime.Today;
    }
}
