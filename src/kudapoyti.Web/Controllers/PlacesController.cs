using kudapoyti.Service.Common.Utils;
using kudapoyti.Service.Interfaces;
using kudapoyti.Service.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace kudapoyti.Web.Controllers;


[Route("places")]

public class PlacesController : Controller
{
    private readonly IPlaceService _place;
    private readonly int _pageSize = 3;
    public PlacesController(IPlaceService place)
    {
        this._place = place;
    }
    public async Task<ViewResult> Index(int page=1)
    {
       
        var products = await _place.GetAllAsync(new PaginationParams(page, _pageSize));
        return View("Index",products);
    }

    [HttpGet("{placeId}")]
    public async Task<ViewResult> GetAsync(long placeId)
    {
        var place = await _place.GetAsync(placeId);
        var placetype= await _place.GetByTypeAsync(new PaginationParams(1,3),place.PlaceSiteUrl);
        var tuple = new Tuple<PlaceViewModel, List<PlaceViewModel>>(place, placetype.ToList());
        return View(tuple);
    }
}
  