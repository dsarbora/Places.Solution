using System;
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
  }
}
