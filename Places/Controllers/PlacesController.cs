using PlacesToGo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace PlacesToGo.Controllers
{
  public class PlacesController : Controller
  {
    [HttpGet("/places")]
    public ActionResult Index()
    {
      return View(Place.GetAll());
    }

    [HttpGet("/places/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/places")]
    public ActionResult Create(string cityName)
    {
      Place newPlace = new Place(cityName);
      return RedirectToAction("Index");
    }

    [HttpGet("/places/{id}")]
    public ActionResult Show(int id)
    {
      Place place = Place.Find(id);
      return View(place);
    }

    [HttpPost("/places/{id}")]
    public ActionResult Destroy(int id)
    {
      Place.Delete(id);
      return RedirectToAction("Index");
    }
  }
}
