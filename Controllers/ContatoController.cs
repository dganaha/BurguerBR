using Microsoft.AspNetCore.Mvc;

namespace BurguerBR.Controllers
{
    public class ContatoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
