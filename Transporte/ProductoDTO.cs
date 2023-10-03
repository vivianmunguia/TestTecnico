using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TestTecnico.Transporte
{
    public class ProductoDTO
    {
        public int Id { get; set; }
        [Display(Name = "Nombre del producto")]
        public string NombreProducto { get; set; }
        //[Column(TypeName = "decimal(18, 2)")]
        [Display(Name = "Precio del producto")]
        public decimal Precio { get; set; }
    }
}
