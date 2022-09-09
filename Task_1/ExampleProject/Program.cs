using GeometryLib;
using System;

namespace ExampleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseFigure f1 = new Circle(2f);
            Triangle triangle = new Triangle(3f, 4f, 5f);

            Console.WriteLine("Площадь фигуры, вычисленная без знания типа: " + f1.CalcSquare());
            Console.WriteLine("Треугольник со сторонами {0} {1} {2} {3} прямоугольным",
                triangle.A, triangle.B, triangle.C,
                triangle.IsRightTriangle() ? "является" : "не является");
        }
    }
}
