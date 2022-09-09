using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace GeometryLib.Tests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void CalcSquare_A2_B2_C2sqrt2_returned2()
        {
            // при длинах сторон A = 2, B = 2, C = 2* sqrt(2) "два корня из двух"
            // ожидаем площадь S = 2 (половина площади квадрата со стороной 2)

            // визуализация:
            //                          
            // *                   **** 
            // **     - половина   **** 
            // ***         от      **** 
            // ****     квадрата   **** 
            //                          

            // Arrange
            Triangle triangle = new Triangle(2f, 2f, 2f * MathF.Sqrt(2f));
            var expected = 2f;

            // Act
            var actual = triangle.CalcSquare();

            // Assert

            // т.к. при работе с числами с плавающей запятой возможны ошибки округления,
            // требуем, чтобы погрешность (разница между ожидаемым и рассчитанным результатом)
            // была не больше 1-ой тысячной
            Assert.IsTrue( MathF.Abs(expected - actual) < 0.001f );
        }

        [TestMethod]
        public void IsRightTriangle_A3_B4_C5_returnedTrue()
        {
            // Arrange
            Triangle triangle = new Triangle(3f, 4f, 5f);

            // Act
            var result = triangle.IsRightTriangle();

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsRightTriangle_A1_B1_C1_returnedFalse()
        {
            // Arrange
            Triangle triangle = new Triangle(1f, 1f, 1f);

            // Act
            var result = triangle.IsRightTriangle();

            // Assert
            Assert.IsFalse(result);
        }
    }
}
