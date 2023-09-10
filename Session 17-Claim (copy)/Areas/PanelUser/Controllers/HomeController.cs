using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Session_17_Claim.Models;

namespace Session_17_Claim.PanelUser.Controllers;

public class HomeController : BaseController
{
    
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
}
