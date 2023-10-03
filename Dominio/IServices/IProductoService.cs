using TestTecnico.Transporte;

namespace TestTecnico.Dominio.IServices
{
    public interface IProductoService
    {
        Task<List<ProductoDTO>> ConsultaProductos();
    }
}
