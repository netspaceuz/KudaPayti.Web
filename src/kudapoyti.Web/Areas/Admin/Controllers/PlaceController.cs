using kudapoyti.Service.Common.Utils;
using kudapoyti.Service.Dtos;
using kudapoyti.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace kudapoyti.Web.Areas.Admin.Controllers
{
    [Area("admin")]
    [Route("admins/place")]
    public class PlaceController : Controller
    {
        private readonly IPlaceService _place;
        private readonly int _pageSize = 10;
        public PlaceController(IPlaceService place)
        {
            this._place = place;
        }

        [HttpGet]
        public async Task<ViewResult> Index(int page = 1)
        {
            var products = await _place.GetAllAsync(new PaginationParams(page, _pageSize));
            return View("Index", products);
        }

        [HttpGet("create")]
        public ViewResult Create()
        {
            return View();
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateAsync(PlaceCreateDto productsDto)
        {
            if (ModelState.IsValid)
            {
                var result = await _place.CreateAsync(productsDto);
                if (result)
                    return RedirectToAction("index", "place", new { area = "admin" });
                return Create();
            }
            return Create();
        }

        [HttpGet("delete")]
        public async Task<ViewResult> Delete(long Id)
        {
            var admin = await _place.GetAsync(Id);
            if (admin != null)
            {
                return View(admin);
            }
            return View();
        }
        [HttpPost("delete")]
        public async Task<IActionResult> DeleteAsync(long Id)
        {
            var admin = await _place.DeleteAsync(Id);
            if (admin) return RedirectToAction("Index", "place", new { area = "admin" });
            return View();
        }
    }
}
