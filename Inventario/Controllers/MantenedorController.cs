using Microsoft.AspNetCore.Mvc;
using Inventario.Datos;
using Inventario.Models;

namespace Inventario.Controllers
{
    public class MantenedorController : Controller
    {
        ContactoDatos _ContactoDatos = new ContactoDatos();
        public IActionResult Listar()
        {
            // Mostrara una Lista de Productos
            var oLista = _ContactoDatos.Listar();

            return View(oLista);
        }

        public IActionResult Guardar()
        {
            //Metodo Solo devuelve vista
            return View();
        }

        [HttpPost]
        public IActionResult Guardar(ContactoModel oContacto)
        {
            //Metodo Recibe el objeto para guardarlo en BD
            if (!ModelState.IsValid)
                return View();

            var respuesta = _ContactoDatos.Guardar(oContacto);

            if(respuesta)
                return RedirectToAction("Listar");
            else
                return View();
        }

        public IActionResult Editar(int IdProducto)
        {
            //Metodo Solo devuelve vista
            var ocontacto = _ContactoDatos.Obtener(IdProducto);
            return View(ocontacto);
        }
        [HttpPost]
        public IActionResult Editar(ContactoModel oContacto)
        {
            if (!ModelState.IsValid)
                return View();

            var respuesta = _ContactoDatos.Editar(oContacto);

            if (respuesta)
                return RedirectToAction("Listar");
            else
                return View();
        }

        public IActionResult Eliminar(int IdProducto)
        {
            //Metodo Solo devuelve vista
            var ocontacto = _ContactoDatos.Obtener(IdProducto);
            return View(ocontacto);
        }
        [HttpPost]
        public IActionResult Eliminar(ContactoModel oContacto)
        {
           
            var respuesta = _ContactoDatos.Eliminar(oContacto.IdProducto);

            if (respuesta)
                return RedirectToAction("Listar");
            else
                return View();
        }
    }
}
