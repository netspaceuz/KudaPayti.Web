using kudapoyti.Service.Dtos.AdminAccountDtos;
using kudapoyti.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace KudaPayti.Web.Controllers;
[Route("accounts")]
public class AccountsController : Controller
{
    private readonly IAdminRegistrService _service;
    private readonly IAdminAccountService _accountService;
    public AccountsController(IAdminRegistrService service, IAdminAccountService accountService)
    {
        _service = service;
        _accountService = accountService;
    }

    [HttpGet("login")]
    public ViewResult Login()
    {
        return View("Login");
    }

    [HttpGet("register")]
    public ViewResult Register()
    {
        return View("Register");
    }

    [HttpPost("register")]
    public async Task<IActionResult> RegisterAsync(AdminRegisterDto accountRegisterDto)
    {
        if (ModelState.IsValid)
        {
            bool result = await _service.RegisterAsync(accountRegisterDto);
            if (result)
            {
                return RedirectToAction("login", "accounts", new { area = "" });
            }
            else
            {
                return Register();
            }
        }
        else return Register();
    }
}
