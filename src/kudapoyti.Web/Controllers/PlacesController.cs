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
    
    private readonly int _pageSize = 1;
    public PlacesController(IPlaceService place, ICommentService commentService)
    {
        this._place = place;
        _commentService = commentService;
    }
    
    public async Task<ViewResult> Index(int page = 1)
    {
        var products = await _place.GetAllAsync(new PaginationParams(page, _pageSize));
        return View("Index", products);
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
    public async Task<ViewResult> Comment(long PlaceId,CommentCreateDto commentCreateDto)
    {
        commentCreateDto.PlaceId = PlaceId;
        return View("Comment",commentCreateDto);
    }

    [HttpPost("comment")]
    public async Task<IActionResult> CreateCommentAsync( CommentCreateDto commentCreateDto)
    {
        
        if (ModelState.IsValid)
        {
            var comments = await _commentService.CreateAsync(commentCreateDto);
            if (comments)
            {
                return RedirectToAction("index", "places", new { area = "" });
            }
            else return RedirectToAction("comment", "places", new { area = "" });

        }
        else return RedirectToAction("comment", "places", new { area = "" });
            
    }
    [HttpGet("region")]
    public async Task<ViewResult> GetRegion(string SityName)
    {

        var region = (await _place.GetByCityAsync(SityName));
        return View("regionType",region);

    }

}
