using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestTecnico.Dominio.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "varchar(80)")]
        public string Nombre { get; set; }
        [Required]
        [Column(TypeName = "int")]
        public string Edad { get; set; }
    }
}
