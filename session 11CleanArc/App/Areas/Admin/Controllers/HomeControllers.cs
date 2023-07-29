
using Microsoft.AspNetCore.Mvc;

namespace Areas.Admin.Controllers;


[Area("Admin")]
class HomeControllers : Controller
{
 
public IActionResult index()
{

  return View();
}

}
