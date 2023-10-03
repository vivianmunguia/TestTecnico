using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TestTecnico.Dominio.IRepositories;
using TestTecnico.Dominio.IServices;
using TestTecnico.Persistencia.Context;
using TestTecnico.Transporte;

namespace TestTecnico.Persistencia.Repositories
{
    public class ProductoRepository : IProductoRepository
    {
        private readonly ApplicationDbContext _context;

        public ProductoRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<ProductoDTO>> ConsultaProductos()
        {
            var productos = await(from t in _context.Producto
                                 select new ProductoDTO
                                 {
                                     Id = t.Id,
                                     NombreProducto = t.NombreProducto,
                                     Precio = t.Precio
                                 }).ToListAsync();
            return productos;
        }
    }
}
