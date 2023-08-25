using System.Diagnostics;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Session_17_Claim.Models;

namespace Session_17_Claim.Admin.Controllers;

[Area("Admin")]
[Authorize(Roles ="Admin")]
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
   
    public IActionResult Logout()
    {

        HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

          //return
         return RedirectToAction("index","home",new{area=""});

        
    }

}
