using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TestTecnico.Transporte
{
    public class UsuarioDTO
    {
        public int Id { get; set; }

        [Display(Name = "Nombre del usuario")]
        public string Nombre { get; set; }
        [Display(Name = "Edad del usuario")]
        public int Edad { get; set; }
    }
}
