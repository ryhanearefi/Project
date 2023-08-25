using System.Diagnostics;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Session_17_Claim.Models;

namespace Session_17_Claim.Controllers;

public class HomeController : Controller
{

    private readonly Context db;
    public HomeController(Context _db)
    {
        db = _db;
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
    public IActionResult check(string username,string password)
    {
        var ExistUser=db.Table_User.where(c=>c.username==username && c.password==password).FirstOrDefault;




        if(ExistUser!=null)
        { 
             //get id Role
             int IdRole=db.Table_RoleUsers.where(c=>c.UserId==ExistUser.id).FirstOrDefault().RoleId;

             string RoleName=db.Table_Roles.where(c=>c.IdRole).FirstOrDefault.RoleName;




            var claims=new List<Claim>
            {

                new Claim(ClaimTypes.Name,ExistUser.Name),
                new Claim(ClaimTypes.Role,RoleName),
                new Claim(ClaimTypes.NameIdentifier,ExistUser.id.Tostring()),
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
