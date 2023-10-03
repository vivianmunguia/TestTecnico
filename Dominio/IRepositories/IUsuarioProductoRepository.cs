using TestTecnico.Transporte;

namespace TestTecnico.Dominio.IRepositories
{
    public interface IUsuarioProductoRepository
    {
        Task<List<UsuarioProductoDTO>> ConsultaUsuariosProductos();
    }
}
