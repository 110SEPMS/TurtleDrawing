using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TurtleDrawing;

namespace TurtleDrawingTest
{
    [TestClass]
    public class TurtleTest
    {
        [TestMethod]
        public void Test_DegreeToRadian()
        {
            // Arrange
            PrivateObject target = new PrivateObject(new Turtle());

            // Act
            var actual = target.Invoke("DegreeToRadian", 90);

            // Assert
            Assert.AreEqual(Math.PI * 0.5, actual);
        }
    }
}
