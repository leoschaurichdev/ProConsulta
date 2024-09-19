using ProConsulta.Data;

namespace ProConsulta.Models
{
    public class Atendente : ApplicationUser // login de usuarios
    {
        public string Nome { get; set; } = null!;
    }
}
