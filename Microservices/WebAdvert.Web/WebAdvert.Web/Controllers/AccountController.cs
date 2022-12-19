using Microsoft.AspNetCore.Mvc;

namespace WebAdvert.Web.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
