using kudapoyti.Service.Common.Utils;
using kudapoyti.Service.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KudaPayti.Web.Controllers;


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
}
