using kudapoyti.Service.Dtos;
using kudapoyti.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace kudapoyti.Web.Areas.Administrator.Controllers
{
    [Area("administrator")]
    [Route("administrator/places")]
    public class PlacesController : Controller
    {
        private readonly IPlaceService _place;

        public IActionResult Index()
        {
            return View();
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
                    return RedirectToAction("index", "Places", new { area = "" });
                return Create();
            }
            return Create();
        }
    }
}
