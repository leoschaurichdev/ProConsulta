using ProConsulta.Models;
using System.ComponentModel.DataAnnotations;

namespace ProConsulta.Components.Pages.Medicos
{
    public class MedicoInputModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo {0} deve ser forncecido!")]
        [MaxLength(50, ErrorMessage = "O campo {0} deve conter no máximo {1} caracteres")]
        public string Nome { get; set; } = null!;

        [Required(ErrorMessage = "O campo {0} deve ser forncecido!")]
        public string Documento { get; set; } = null!;

        [Required(ErrorMessage = "O campo {0} deve ser forncecido!")]
        public string Crm { get; set; } = null!;

        [Required(ErrorMessage = "O campo {0} deve ser forncecido!")]
        public DateTime DataCadastro { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "O campo {0} deve ser forncecido!")]
        public string Celular { get; set; } = null!;

        [Required(ErrorMessage = "O campo {0} deve ser forncecido!")]
        [RegularExpression("([1-9][0-9]*)", ErrorMessage = "O valor selecionado é inválido!")]
        public int EspecialidadeId { get; set; }

        public Especialidade Especialidade { get; set; } = null!;

        public ICollection<Agendamento>? Agendamentos { get; set; }

    }
}