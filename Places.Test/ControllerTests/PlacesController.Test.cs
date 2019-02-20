using System;
using System.Collections.Generic;
using PlacesToGo.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using PlacesToGo.Controllers;

namespace PlacesToGo.Tests
{
  [TestClass]
  public class PlacesControllerTest
  {
    [TestMethod]
    public void Index_ReturnsCorrectView_True()
    {
      PlacesController controller = new PlacesController();
      ActionResult indexView = controller.Index();
      Assert.IsInstanceOfType(indexView, typeof(ViewResult));
    }

    [TestMethod]
    public void Index_CorrectType_PlaceList()
    {
      PlacesController controller = new PlacesController();
      ViewResult viewIndex = controller.Index() as ViewResult;
      var result = viewIndex.ViewData.Model;
      Assert.IsInstanceOfType(result, typeof(List<Place>));
    }

    [TestMethod]
    public void Create_RedirectToIndex_True()
    {
      PlacesController controller = new PlacesController();
      RedirectToActionResult result = controller.Create("Chicago") as RedirectToActionResult;
      Assert.AreEqual("Create", result.ActionName);
      Assert.AreEqual("Index", result.ControllerName);

    }
  }
}
