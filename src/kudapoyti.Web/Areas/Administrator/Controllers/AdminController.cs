using kudapoyti.Service.Common.Utils;
using kudapoyti.Service.Dtos;
using kudapoyti.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace kudapoyti.Web.Areas.Administrator.Controllers
{
    [Area("administrator")]
 
    public class AdminController : Controller
    {
        private readonly IAdminService _place;
        private readonly int _pageSize = 10;

        public AdminController(IAdminService place)
        {
            this._place = place;
        }

        public async Task<ViewResult> Index(int page = 1)
        {
            var products = await _place.GetAllAysnc(new PaginationParams(page, _pageSize));
            return View("Index", products);
        }

        [HttpGet("delete")]
        public async Task<ViewResult> Delete(long Id)
        {
            var product = await _place.GetAysnc(Id);
            if (product != null)
            {

                return View(product);
            }
            return View();
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeleteAsync(long Id)
        {
            var res = await _place.DeleteAysnc(Id);
            if (res)
                return RedirectToAction("Index", "Home", new { area = "" });
            return View();
        }
    }
}
