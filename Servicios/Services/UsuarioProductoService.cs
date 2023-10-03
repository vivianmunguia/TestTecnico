using TestTecnico.Dominio.IRepositories;
using TestTecnico.Dominio.IServices;
using TestTecnico.Persistencia.Repositories;
using TestTecnico.Transporte;

namespace TestTecnico.Servicios.Services
{
    public class UsuarioProductoService : IUsuarioProductoService
    {
        private readonly IUsuarioProductoRepository _IUsuarioProductoRepository;

        public UsuarioProductoService(IUsuarioProductoRepository iUsuarioProductoRepository)
        {
            _IUsuarioProductoRepository = iUsuarioProductoRepository;
        }

        public async Task<List<UsuarioProductoDTO>> ConsultaUsuariosProductos()
        {
            return await _IUsuarioProductoRepository.ConsultaUsuariosProductos();
        }
    }
}
