using kudapoyti.Service.Common.Exceptions;
using kudapoyti.Service.Dtos.Accounts;
using kudapoyti.Service.Dtos.AdminAccountDtos;
using kudapoyti.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace kudapoyti.Web.Areas.Admin.Controllers
{
    [Area("admin")]
    public class AccountsController : Controller
    {
        private readonly IAdminRegistrService _service;
        private readonly IAdminAccountService _accountService;
        public AccountsController(IAdminRegistrService service, IAdminAccountService accountService)
        {
            _service = service;
            _accountService = accountService;
        }

        [HttpGet]
        public ViewResult Login()
        {
            return View("Login");
        }

        [HttpPost]
        public async Task<IActionResult> LoginAsync(AdminAccountLoginDto adminAccountLogin)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    string token = await _accountService.LoginAsync(adminAccountLogin);
                    HttpContext.Response.Cookies.Append("X-Access-Token", token, new CookieOptions()
                    {
                        HttpOnly = true,
                        SameSite = SameSiteMode.Strict
                    });
                    return RedirectToAction("Index", "Home", new { area = "admin" });
                }
                catch (ModelErrorException modelError)
                {
                    ModelState.AddModelError(modelError.Property, modelError.Message);
                    return Login();
                }
                catch
                {
                    return Login();
                }
            }
            else return Login();

        }

        [HttpGet]
        public ViewResult Register()
        {
            return View("Register");
        }

        [HttpPost]
        public async Task<IActionResult> RegisterAsync(AdminRegisterDto accountRegisterDto)
        {
            if (ModelState.IsValid)
            {
                bool result = await _service.RegisterAsync(accountRegisterDto);
                if (result)
                {
                    return RedirectToAction("login", "accounts", new { area = "admin" });
                }
                else
                {
                    return Register();
                }
            }
            else return Register();
        }

    }
}
