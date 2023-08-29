using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Session_19_Menu_.Models;


namespace Session_19_Menu_.Admin.Controllers;
[Area("Admin")]
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

  [HttpPost]  

    public IActionResult Add(string CatName,string ParentId)
    {
        var Tbl_Menu = new Tbl_Menu()
        {
            CatName = CatName,
            ParentId= int.Parse(ParentId),
            Status = true
        };
        _context.Tbl_Menus.Add(Tbl_Menu);
        _context.SaveChanges();
        return RedirectToAction("Index");
        
    }  

}
