using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TestTecnico.Dominio.IRepositories;
using TestTecnico.Dominio.IServices;
using TestTecnico.Persistencia.Context;
using TestTecnico.Transporte;

namespace TestTecnico.Persistencia.Repositories
{  
    public class UsuarioProductoRepository : IUsuarioProductoRepository
    {
        private readonly ApplicationDbContext _context;

        public UsuarioProductoRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<UsuarioProductoDTO>> ConsultaUsuariosProductos()
        {
            var usuariosproductos = await(from t in _context.UsuarioProducto
                                          select new UsuarioProductoDTO
                                          {
                                              Id = t.Id,
                                              IdUsuario = t.IdUsuario,
                                              IdProducto = t.IdProducto
                                          }).ToListAsync();
            return usuariosproductos;
        }
    }
}
