using Microsoft.AspNetCore.Mvc;
using TestTecnico.Dominio.IServices;
using TestTecnico.Transporte;

namespace TestTecnico.Controllers
{
    public class UsuarioProductoController : Controller
    {
        private readonly IUsuarioProductoService _IUsuarioProductoService;
        public UsuarioProductoController(IUsuarioProductoService iUsuarioProductoService)
        {
            _IUsuarioProductoService = iUsuarioProductoService;
        }
        //GET: ProductoController
        public async Task<ActionResult> Index()
        {
            var usuariosproductos = await _IUsuarioProductoService.ConsultaUsuariosProductos();
            return View(usuariosproductos);
        }
        /*
        //GET: ProductoController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            ProductoDTO usuarioproducto = await _IUsuarioProductoService.ConsultaUsuarioProducto(id);
            return View(usuarioproducto);
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
                UsuarioProductoDTO usuarioproducto = Formulario(collection);
                var respuesta = await _IUsuarioProductoService.CrearUsuarioProducto(usuarioproducto);

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

        private UsuarioProductoDTO Formulario(IFormCollection collection)
        {
            return new UsuarioProductoDTO
            {
                Id = int.Parse(string.IsNullOrEmpty(collection["Id"]) ? "0" : collection["Id"]),
                IdUsuario = int.Parse(collection["IdUsuario"]),
                IdProducto = int.Parse(collection["IdProducto"])
            };
        }

        // GET: ProductoController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            UsuarioProductoDTO usuarioproducto = await _IUsuarioProductoService.ConsultaUsuarioProducto(id);
            return View(usuarioproducto);
        }

        //POST: ProductoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, IFormCollection collection)
        {
            try
            {
                UsuarioProductoDTO usuarioproducto = Formulario(collection);
                var respuesta = await _IUsuarioProductoService.EditarUsuarioProducto(usuarioproducto);

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
            UsuarioProductoDTO usuarioproducto = await _IUsuarioProductoService.ConsultaUsuarioProducto(id);
            return View(usuarioproducto);
        }

        //POST: ProductoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int id, IFormCollection collection)
        {
            try
            {
                var respuesta = await _IUsuarioProductoService.EliminarUsuarioProducto(id);

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
