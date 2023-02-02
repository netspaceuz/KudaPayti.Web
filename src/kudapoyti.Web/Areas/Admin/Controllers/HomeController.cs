using Microsoft.AspNetCore.Mvc;

namespace kudapoyti.Web.Areas.Admin.Controllers
{
    [Area("admin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
