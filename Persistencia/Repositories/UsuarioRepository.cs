using Microsoft.EntityFrameworkCore;
using TestTecnico.Dominio.IRepositories;
using TestTecnico.Persistencia.Context;
using TestTecnico.Transporte;

namespace TestTecnico.Persistencia.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly ApplicationDbContext _context;

        public UsuarioRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<UsuarioDTO>> ConsultaUsuarios()
        {
            var usuarios = await(from t in _context.Usuario
                                 select new UsuarioDTO
                                 {
                                     Id = t.Id,
                                     Nombre = t.Nombre,
                                     Edad = t.Edad
                                 }).ToListAsync();
            return usuarios;
        }
    }
}
