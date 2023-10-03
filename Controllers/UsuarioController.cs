using Microsoft.AspNetCore.Mvc;
using TestTecnico.Dominio.IServices;
using TestTecnico.Transporte;

namespace TestTecnico.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly IUsuarioService _IUsuarioService;
        public UsuarioController(IUsuarioService iUsuarioService)
        {
            _IUsuarioService = iUsuarioService;
        }
        //GET: UsuarioController
        public async Task<ActionResult> Index()
        {
            var usuarios = await _IUsuarioService.ConsultaUsuarios();
            return View(usuarios);
        }
        /*
        //GET: UsuarioController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            UsuarioDTO usuario = await _IUsuarioService.ConsultaUsuario(id);
            return View(usuario);
        }
        //GET: UsuarioController/Create
        public ActionResult Create()
        {
            return View();
        }
        //POST: UsuarioController/Create

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<ActionResult> Create(IFormCollection collection)
        {
            try
            {
                UsuarioDTO usuario = Formulario(collection);
                var respuesta = await _IUsuarioService.CrearUsuario(usuario);

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

        private UsuarioDTO Formulario(IFormCollection collection)
        {
            return new UsuarioDTO
            {
                Id = int.Parse(string.IsNullOrEmpty(collection["Id"]) ? "0" : collection["Id"]),
                Nombre = collection["Nombre"],
                Edad = int.Parse(collection["Edad"]),
            };
        }

        // GET: UsuarioController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            UsuarioDTO usuario = await _IUsuarioService.ConsultaUsuario(id);
            return View(usuario);
        }

        //POST: UsuarioController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, IFormCollection collection)
        {
            try
            {
                UsuarioDTO usuario = Formulario(collection);
                var respuesta = await _IUsuarioService.EditarUsuario(usuario);

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

        //GET: UsuarioController/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            UsuarioDTO usuario = await _IUsuarioService.ConsultaUsuario(id);
            return View(usuario);
        }

        //POST: UsuarioController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int id, IFormCollection collection)
        {
            try
            {
                var respuesta = await _IUsuarioService.EliminarUsuario(id);

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
