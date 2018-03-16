using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MvcBootstrap;
using MvcBootstrap.Controllers;

namespace MvcBootstrap.Tests.Controllers
{
	[TestClass]
	public class ComponentsControllerTest
	{
		[TestMethod]
		public void Index()
		{
			// Arrange
			ComponentsController controller = new ComponentsController();

			// Act
			ViewResult result = controller.Index() as ViewResult;

			// Assert
			Assert.IsNotNull(result);
		}

		[TestMethod]
		public void About()
		{
			// Arrange
			ComponentsController controller = new ComponentsController();

			// Act
			ViewResult result = controller.Alerts() as ViewResult;

			// Assert
			Assert.AreEqual("Alerts go here.", result.ViewBag.Message);
		}
	}
}
