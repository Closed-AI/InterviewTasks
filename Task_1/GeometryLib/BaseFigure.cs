using System;

namespace GeometryLib
{
    // это абстрактный базовый класс для всех остальных фигур
    // благодаря его использованию достигается легкость добавления других фигур
    // благодаря переопределению абстрактного метода CalcSquare()
    // возможно вычисление площади фигуры без знания типа фигуры в compile-time

    public abstract class BaseFigure
    {
        // метод вычисления площади
        public abstract float CalcSquare();
    }
}
