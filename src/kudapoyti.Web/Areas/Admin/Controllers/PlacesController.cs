using Microsoft.AspNetCore.Mvc;

namespace kudapoyti.Web.Areas.Admin.Controllers
{
    public class PlacesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
