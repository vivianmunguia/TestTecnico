using System.ComponentModel.DataAnnotations;

namespace TestTecnico.Transporte
{
    public class UsuarioProductoDTO
    {
        public int Id { get; set; }
        [Display(Name = "IdUsuario")]
        public int IdUsuario { get; set; }
        [Display(Name = "IdProducto")]
        public int IdProducto { get; set; }
    }
}
