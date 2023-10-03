using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestTecnico.Dominio.Models
{
    public class Producto
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "varchar(80)")]
        public string NombreProducto { get; set; }
        [Required]
        [Column(TypeName = "double")]
        public string Precio { get; set; }
    }
}
