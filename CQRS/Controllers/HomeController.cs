using Microsoft.AspNetCore.Mvc;
using MediatR;


namespace CQRS.Controllers;

public class HomeController : Controller
{
 
    private readonly IMediator _mediator;

    public HomeController(IMediator mediator)
    {
        _mediator = mediator;
    }
    public IActionResult Index()
    {
        return View();
    }


public IActionResult add(SaveProductCommand pr)
    {
         var result = _mediator.Send(pr);
         return RedirectToAction("Index");
    }
 
}
