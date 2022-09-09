using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace GeometryLib.Tests
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void CalcSquare_R2_4PIreturned()
        {
            // ��� ������� ����� R = 2 ������� ������� S = 4 * PI

            // Arrange
            Circle circle = new Circle(2f);
            var expected = 4f * MathF.PI;

            // Act
            var actual = circle.CalcSquare();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
