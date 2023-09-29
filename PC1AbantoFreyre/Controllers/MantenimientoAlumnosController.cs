using Microsoft.AspNetCore.Mvc;
namespace PC1AbantoFreyre.Controllers
{
    public class MantenimientoAlumnosController : Controller
    {
        public IActionResult Listado()
        {
            return View();
        }

        public IActionResult Editar(int ID)
        {
            return View();
        }

        public IActionResult Agregar()
        {
            return View();
        }
    }
}
