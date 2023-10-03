using TestTecnico.Transporte;

namespace TestTecnico.Dominio.IServices
{
    public interface IUsuarioService
    {
        Task<List<UsuarioDTO>> ConsultaUsuarios();
    }
}
