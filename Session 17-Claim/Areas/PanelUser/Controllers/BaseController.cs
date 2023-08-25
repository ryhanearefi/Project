using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


[Area("PanelUser")]
[Authorize(Roles ="User")]
public class BaseController : Controller
{
  
}