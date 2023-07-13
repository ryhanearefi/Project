using Kavenegar;
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

      Random rnd = new Random();
      string number = rnd.Next(1000, 9999).ToString();

        var api = new KavenegarApi("3871353043697339486A70384F544A4A574C74612B51432F4C7A4B305076645457396F5267456F7A5A34383D"); 
         api.VerifyLookup(Phone, number,"demo");


    return View();

  }


}