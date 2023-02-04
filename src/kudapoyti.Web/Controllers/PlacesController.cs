using kudapoyti.Service.Common.Utils;
using kudapoyti.Service.Dtos.CommentDtos;
using kudapoyti.Service.Interfaces;
using kudapoyti.Service.Interfaces.CommentServices;
using kudapoyti.Service.Services.CommentServices;
using kudapoyti.Service.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace kudapoyti.Web.Controllers;

[Route("places")]
public class PlacesController : Controller
{
    private readonly IPlaceService _place;
    private readonly ICommentService _commentService;
    private readonly int _pageSize = 3;
    public PlacesController(IPlaceService place, ICommentService commentService)
    {
        this._place = place;
        _commentService = commentService;
    }
    public async Task<ViewResult> Index(int page = 1)
    {
        var products = await _place.GetAllAsync(new PaginationParams(page, _pageSize));
        var productsByUrl = (await _place.GetTopPLacesAsync("Party")).ToList();
        var tuple = new Tuple<List<PlaceBaseViewModel>, List<PlaceViewModel>>(products.ToList(), productsByUrl);
        return View("Index", tuple);
    }

    [HttpGet("{placeId}")]
    public async Task<ViewResult> GetAsync(long placeId)
    {
        var place = await _place.GetAsync(placeId);
        var placetype = await _place.GetByTypeAsync(new PaginationParams(1, 3), place.PlaceSiteUrl);
        var tuple = new Tuple<PlaceViewModel, List<PlaceViewModel>>(place, placetype.ToList());
        return View(tuple);
    }
    [HttpGet("comment")]
    public ViewResult Comment()
    {

        return View();
    }

    [HttpPost("comment")]
    public async Task<IActionResult> CreateCommentAsync(CommentCreateDto commentCreateDto)
    {
        await _commentService.CreateAsync(commentCreateDto);
        if (ModelState.IsValid)
        {
            var comments = await _commentService.GetByPlaceId(commentCreateDto.PlaceId, new PaginationParams(1, _pageSize));
            if (comments!=null)
            {
                return RedirectToAction("get", "places", new { area = "" });
            }
            else
            {
                return Comment();
            }
        }
        else return Comment();

    }

}
