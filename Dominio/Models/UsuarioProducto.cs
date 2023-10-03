using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestTecnico.Dominio.Models
{
    public class UsuarioProducto
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "int")]
        public int IdUsuario { get; set; }
        [Required]
        [Column(TypeName = "int")]
        public int IdProducto { get; set; }
    }
}
