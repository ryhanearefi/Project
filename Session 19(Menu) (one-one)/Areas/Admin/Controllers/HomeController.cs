using Session_19_Menu_.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;
using Session_19_Menu_.Models.Context;
using Session_19_Menu_.Models.Entities;

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

        var Tbl_Menus = _context.Tbl_Menus.OrderByDescending(x=>x.Id).ToList();
        //new select 
        ViewBag.menu=new SelectList(Tbl_Menus,"Id","CatName"); 
        List<Menu>menus= new List<Menu>();
        foreach (var item in Tbl_Menus)
        {
           var menu = new Menu()
           {
            Id=item.Id,
            Name=item.CatName,
            ParentName = item.ParentId ==0 ? "دسته اصلی": Tbl_Menus.FirstOrDefault(x => x.Id == item.ParentId).CatName
           };
           menus.Add(menu);
        }


        ViewBag.Table=menus;

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
