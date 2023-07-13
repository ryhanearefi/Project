using Microsoft.AspNetCore.Mvc;

public class LoginController : Controller
{

  public IActionResult index(string Phone)
  {

    return View();

  }
  [HttpPost]
  public IActionResult Sendcode(string Phone)
  {

    return View();

  }


}