using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumericSequenceCalculator_UI;
using NumericSequenceCalculator_UI.Controllers;

namespace NumericSequenceCalculator_UI.Tests.Controllers
{
    [TestClass]
    public class NumericSequenceControllerTest
    {
        [TestMethod]
        public void NumericSequenceIndex()
        {
            // Arrange
            NumericSequenceController controller = new NumericSequenceController();

            // Act
            ViewResult result = controller.NumericSequenceIndex() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void NumericSequenceResult()
        {
            // Arrange
            NumericSequenceController controller = new NumericSequenceController();

            // Act
            PartialViewResult result = controller.NumericSequenceResult(10) as PartialViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
