using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalcApplication;
using CalcApplication.Controllers;
using CalcApplication.Models;

namespace CalcApplication.Tests.Controllers
{
    [TestClass]
    public class CalcuControllerTest
    {
        [TestMethod]
        public void sum()
        {
            // Arrange
            CalcuController controller = new CalcuController();
            NumbersInp inp = new NumbersInp { Num1 = 2, Num2 = 3 };

            // Act
            int result = controller.sum(inp);

            // Assert
            Assert.AreEqual(result, 5);
        }

        [TestMethod]
        public void subsytraction()
        {
            // Arrange
            CalcuController controller = new CalcuController();
            NumbersInp inp = new NumbersInp() { Num1 =3,Num2=1};
            //inp.Num1 = 3;
            //inp.Num2 = 2;

            // Act
            int result = controller.subsytraction(inp);


            // Assert
            Assert.AreEqual(result, 2);

        }
    }
}
