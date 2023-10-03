using TestTecnico.Dominio.IRepositories;
using TestTecnico.Dominio.IServices;
using TestTecnico.Transporte;

namespace TestTecnico.Servicios.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _IUsuarioRepository;

        public UsuarioService(IUsuarioRepository iUsuarioRepository)
        {
            _IUsuarioRepository = iUsuarioRepository;
        }
        
        public async Task<List<UsuarioDTO>> ConsultaUsuarios()
        {
            return await _IUsuarioRepository.ConsultaUsuarios();
        }
    }
}
