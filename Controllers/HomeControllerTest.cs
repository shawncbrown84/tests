using Microsoft.VisualStudio.TestTools.UnitTesting;
using PoliceApiWebToolWithTesting;
using PoliceApiWebToolWithTesting.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace PoliceApiWebToolWithTesting.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }


        [TestMethod]
        public void Summary()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            PartialViewResult result = controller.Summary(51.44237, -2.4981, "2021-01") as PartialViewResult;

            // Assert
            Assert.IsNotNull(result);
        }


        [TestMethod]
        public void AllData()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            PartialViewResult result = controller.AllData(51.44237, -2.4981, "2021-01") as PartialViewResult;

            // Assert
            Assert.IsNotNull(result);
        }


    }
}
