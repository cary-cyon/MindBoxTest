namespace SquareSolverLib
{
    public class SquareSolver
    {
        /// <summary>
        /// возвращает площадь круга 
        /// </summary>
        /// <param name="radius"> радиус круга </param>
        /// <returns> число типа double </returns>
        /// <exception cref="OverflowException"> 
        /// Если площадь слишком велика или принимает значение Infinity
        /// </exception>
        /// <exception cref="ArgumentException">
        /// Если значение радиуса не корректно
        /// </exception>
        public static double GetCircleSquare(double radius)
        {
           var c = new Circle(radius);
           return c.GetSquare();
        }
        /// <summary>
        /// Возвращает площадь треугольника
        /// </summary>
        /// <param name="a">сторона a</param>
        /// <param name="b">сторона b</param>
        /// <param name="c">сторона c</param>
        /// <returns></returns>
        /// <exception cref="OverflowException">
        /// Если площадь слишком велика
        /// </exception>
        /// <exception cref="ArgumentException">
        /// Если стороны не корректны
        /// </exception>
        public static double GetTriangleSquare(double a, double b, double c)
        {
            var t = new Triangle(a, b, c);
            return t.GetSquare();
        }
        /// <summary>
        /// Универсальный метод вычислени площади. Может выбросить исключения используемого класса.
        /// </summary>
        /// <param name="shape"> Класс реализующий интефейс ISquare </param>
        /// <returns> Площадь полученной фигуры double</returns>
        public static double GetSquare(ISquare shape)
        {
            return shape.GetSquare();
        }
    }
}