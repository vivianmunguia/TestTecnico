using TestTecnico.Transporte;

namespace TestTecnico.Dominio.IRepositories
{
    public interface IUsuarioRepository
    {
        Task<List<UsuarioDTO>> ConsultaUsuarios();
    }
}
