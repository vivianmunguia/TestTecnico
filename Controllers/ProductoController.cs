using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using TestTecnico.Dominio.IServices;
using TestTecnico.Transporte;

namespace TestTecnico.Controllers
{
    public class ProductoController : Controller
    {
        private readonly IProductoService _IProductoService;
        public ProductoController(IProductoService iProductoService)
        {
            _IProductoService = iProductoService;
        }
        //GET: ProductoController
        public async Task<ActionResult> Index()
        {
            var productos = await _IProductoService.ConsultaProductos();
            return View(productos);
        }
        /*
        //GET: ProductoController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            ProductoDTO producto = await _IProductoService.ConsultaProducto(id);
            return View(producto);
        }
        //GET: ProductoController/Create
        public ActionResult Create()
        {
            return View();
        }
        //POST: ProductoController/Create

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<ActionResult> Create(IFormCollection collection)
        {
            try
            {
                ProductoDTO producto = Formulario(collection);
                var respuesta = await _IProductoService.CrearProducto(producto);

                if (respuesta == false)
                {
                    TempData["Error"] = "Ocurrió un error en la creación";
                }
                else
                {
                    TempData["Exito"] = "Creación exitosa";
                }

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        private ProductoDTO Formulario(IFormCollection collection)
        {
            return new ProductoDTO
            {
                Id = int.Parse(string.IsNullOrEmpty(collection["Id"]) ? "0" : collection["Id"]),
                NombreProducto = collection["NombreProducto"],
                Precio = decimal.Parse(collection["Precio"]),
            };
        }

        // GET: ProductoController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            ProductoDTO producto = await _IProductoService.ConsultaProducto(id);
            return View(producto);
        }

        //POST: ProductoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, IFormCollection collection)
        {
            try
            {
                ProductoDTO producto = Formulario(collection);
                var respuesta = await _IProductoService.EditarProducto(producto);

                if (respuesta == false)
                {
                    TempData["Error"] = "Ocurrió un error en la edición";
                }
                else
                {
                    TempData["Exito"] = "Edición exitosa";
                }

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        //GET: ProductoController/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            ProductoDTO producto = await _IProductoService.ConsultaProducto(id);
            return View(producto);
        }

        //POST: ProductoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int id, IFormCollection collection)
        {
            try
            {
                var respuesta = await _IProductoService.EliminarProducto(id);

                if (respuesta == false)
                {
                    TempData["Error"] = "Ocurrió un error en la eliminación";
                }
                else
                {
                    TempData["Exito"] = "Eliminación exitosa";
                }

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        */
    }
}
