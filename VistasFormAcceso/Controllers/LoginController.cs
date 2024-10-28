using Microsoft.AspNetCore.Mvc;

namespace VistasFormAcceso.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
