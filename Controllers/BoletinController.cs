using Microsoft.AspNetCore.Mvc;

namespace SistGestNotas.Controllers
{
    public class BoletinController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
