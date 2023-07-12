using Microsoft.AspNetCore.Mvc;


public class HomeController : Controller
{

  public IActionResult Index()
  {
    return View();
  }
 public IActionResult about()
  {
    return View();
  }
  

  public IActionResult contact()
  {
    return View();
  }

}
