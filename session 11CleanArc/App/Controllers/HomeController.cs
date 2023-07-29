using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using App.Models;
using Core.Myinterface;

namespace App.Controllers;

public class HomeController : Controller
{
    

    private readonly IUser _user;

    public HomeController(IUser user)
    {
         _user = user;

    }


    public IActionResult Index()
    {
        return View();
    }

    //send sms

    [HttpPost]
    public IActionResult SendSms(string Phone)
    {
      int Result = _user.SendSms(Phone);
    //Add to db
    
        return View();
    }

    public IActionResult Error()
    {
        return View();
    }

   
}
