using TestTecnico.Dominio.IRepositories;
using TestTecnico.Dominio.IServices;
using TestTecnico.Persistencia.Repositories;
using TestTecnico.Transporte;

namespace TestTecnico.Servicios.Services
{
    public class ProductoService : IProductoService
    {
        private readonly IProductoRepository _IProductoRepository;

        public ProductoService(IProductoRepository iProductoRepository)
        {
            _IProductoRepository = iProductoRepository;
        }

        public async Task<List<ProductoDTO>> ConsultaProductos()
        {
            return await _IProductoRepository.ConsultaProductos();
        }
    }
}
