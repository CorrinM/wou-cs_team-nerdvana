using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Petopia;
using Petopia.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Petopia_tests
{
    [TestClass]
    public class Corrin
    {
        [TestMethod]
        public void BadgesCreate()
        {
            // Arrange
            BadgesController badgeController= new BadgesController();

            // Act
            ViewResult result = badgeController.Create() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
