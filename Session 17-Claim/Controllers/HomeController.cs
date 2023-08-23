using System.Diagnostics;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Session_17_Claim.Models;

namespace Session_17_Claim.Controllers;

public class HomeController : Controller
{
    
    public IActionResult Index()
    {
        return View();
    }
    
//AccesDenied
    public IActionResult AccesDenied()
    {
        return View();
    }

    public IActionResult Login()
    {
        return View();
    }

    [HttpPost]
    public IActionResult check(string username,string password){
        if(username=="admin" && password=="123")
        {
            var claims=new List<Claim>
            {
                new Claim(ClaimTypes.Name,"Ali"),
                new Claim(ClaimTypes.Role,"Admin"),
                new Claim(ClaimTypes.NameIdentifier,"1"),
            };


         var identity=new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
         
         var principal=new ClaimsPrincipal(identity);

         //sign in
         HttpContext.SignInAsync(principal);


    
            return RedirectToAction("Index","Home",new { area="Admin"});
        }
        else
        {
            return RedirectToAction("Login");
        }
    }

    

}
