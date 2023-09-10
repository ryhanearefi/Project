using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration.UserSecrets;
using Session_17_Claim.Models;

namespace Session_17_Claim.Controllers;

public class HomeController : Controller
{

    private readonly Context _context;
    public HomeController(Context context)
    {
        _context = context;
    }
    
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
    public IActionResult Check(string username,string password)
    {
        
        var user = _context.Table_Users.Where(x => x.username == username && x.password == password).FirstOrDefault();

        if(username== user.username && password==user.password)
        {
            
            var claims=new List<Claim>
            {
                new Claim(ClaimTypes.Name,username),
                //new Claim(ClaimTypes.Role,"Admin"),
                new Claim(ClaimTypes.NameIdentifier,user.id.ToString())
            };

            var identity=new ClaimsIdentity(claims,CookieAuthenticationDefaults.AuthenticationScheme);
            var principal=new ClaimsPrincipal(identity);
            HttpContext.SignInAsync(principal);
             return RedirectToAction("Index","Home",new {area = "Admin"});
        }
        else
        {
            return RedirectToAction("Login");
        }
        
    }
    
    
}