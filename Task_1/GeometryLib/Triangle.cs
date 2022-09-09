using System;
using System.Collections.Generic;
using System.Text;

namespace GeometryLib
{
    public class Triangle : BaseFigure
    {
        public float A { get; set; }
        public float B { get; set; }
        public float C { get; set; }

        public Triangle(float a, float b, float c)
        {
            A = a;
            B = b;
            C = c;
        }

        public override float CalcSquare()
        {
            // вычисление площади треугольника по трём сторонам (формула Герона)
            // S = ( p * (p-a) * (p-b) * (p-c) )^(1/2)
            // где p - полупериметр     p = (a + b + c)/2

            float p = (A + B + C) / 2f;

            return MathF.Sqrt( p * (p-A) * (p-B) * (p-C) );
        }

        // проверка треугольника на прямоугольность
        public bool IsRightTriangle()
        {
            return (A * A  + B * B == C * C) ||
                   (A * A == B * B  + C * C) ||
                   (A * A  + C * C == B * B);
        }
    }
}
