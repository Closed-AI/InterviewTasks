using System;
using System.Collections.Generic;
using System.Text;

namespace GeometryLib
{
    public class Circle : BaseFigure
    {
        public float Radius { get; set; }

        public Circle(float radius)
        {
            Radius = radius;
        }

        public override float CalcSquare()
        {
            // S = PI * R^2
            return MathF.PI * Radius * Radius;
        }
    }
}
