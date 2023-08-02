using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using session_Services14.Models;

namespace session_Services14.Controllers;

public class HomeController : Controller
{
   //singletone
   private readonly ISingletone _singletone1;

   private readonly ISingletone _singletone2;

   //transient

   private readonly ITransient _transient1;

   private readonly ITransient _transient2;

   //scoped

   private readonly IScoped _scoped1;
   private readonly IScoped _scoped2;


   public HomeController(ISingletone singletone1, ISingletone singletone2, ITransient transient1, ITransient transient2, IScoped scoped1, IScoped scoped2)
   {
    _singletone1 = singletone1;
    _singletone2 = singletone2;
    _transient1 = transient1;
    _transient2 = transient2;
    _scoped1 = scoped1;
    _scoped2 = scoped2;

   }

    public IActionResult Index()
    {
       
    ViewBag.singletone1 = _singletone1.GetGuid();
    ViewBag.singletone2 = _singletone2.GetGuid();

    ViewBag.transient1 = _transient1.GetGuid();
    ViewBag.transient2 = _transient2.GetGuid();


    ViewBag.scoped1 = _scoped1.GetGuid();
    ViewBag.scoped2 = _scoped2.GetGuid();



    return View();


    }

   
}
