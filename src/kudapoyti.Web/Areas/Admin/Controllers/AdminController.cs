using kudapoyti.Service.Common.Utils;
using kudapoyti.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace kudapoyti.Web.Areas.Admin.Controllers
{
    [Area("admin")]
    [Route("admins/admin")]
    public class AdminController : Controller
    {
        private readonly IAdminService _place;
        private readonly int _pageSize = 10;


        public AdminController(IAdminService place)
        {
            this._place = place;
        }

        [HttpGet]
        public async Task<ViewResult> Index(int page = 1)
        {
            var products = await _place.GetAllAysnc(new PaginationParams(page, _pageSize));
            return View("Index", products);
        }

        [HttpGet("delete")]
        public async Task<ViewResult> Delete(long Id)
        {
            var admin = await _place.GetAysnc(Id);
            if (admin != null)
            {
                return View(admin);
            }
            return View();
        }
        [HttpPost("delete")]
        public async Task<IActionResult> DeleteAsync(long Id)
        {
            var admin = await _place.DeleteAysnc(Id);
            if (admin) return RedirectToAction("Index", "admin", new { area = "admin" });
            return View();
        }

    }


}
