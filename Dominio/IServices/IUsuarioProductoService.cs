using TestTecnico.Transporte;

namespace TestTecnico.Dominio.IServices
{
    public interface IUsuarioProductoService
    {
        Task<List<UsuarioProductoDTO>> ConsultaUsuariosProductos();
    }
}
