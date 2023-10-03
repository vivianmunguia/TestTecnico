using TestTecnico.Transporte;

namespace TestTecnico.Dominio.IRepositories
{
    public interface IProductoRepository
    {
        Task<List<ProductoDTO>> ConsultaProductos();
    }
}
