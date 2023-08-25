using Microsoft.AspNetCore.Mvc;
public class ProductController : BaseController
{
  public IActionResult Index()
    {
        return View();
    }
}