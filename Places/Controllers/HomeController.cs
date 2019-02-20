using PlacesToGo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace PlacesToGo.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}
