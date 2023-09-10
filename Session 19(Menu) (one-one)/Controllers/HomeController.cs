using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Session_19_Menu_.Models;
using Session_19_Menu_.Models.Context;

namespace Session_19_Menu_.Controllers;

public class HomeController : Controller
{
   private readonly Context _context;
   
   public HomeController(Context context)
   {
    _context = context;
   }

    public IActionResult Index()
    {
        ViewBag.menu=_context.Tbl_Menus.OrderByDescending(x=>x.Id).ToList();
        return View();
    }

}
