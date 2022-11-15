using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareSolverLib
{
    public class Triangle : ISquare
    {
        private double _a;
        private double _b;
        private double _c;
        /// <summary>
        /// метод возвращает площадь треугольника
        /// </summary>
        /// <returns> число типа double</returns>
        /// <exception cref="OverflowException"> 
        /// Если площадь слишком велика или принимает значение Infinity
        /// </exception>
        public double GetSquare()
        {
            double p = (_a+_b+_c)/2;
            if (p > Double.MaxValue)
                throw new OverflowException("значение сторон слишком велико");
            double square = Math.Sqrt( p * (p-_a) * (p - _b) * (p - _c) );
            if (square > Double.MaxValue)
                throw new OverflowException("значение сторон слишком велико");
            return square;
        }
        /// <summary>
        /// Принимает значение 3 сторон
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <exception cref="ArgumentException">
        /// Если сторона принимет невозможное зачение или не выполняет неравенство
        /// </exception>
        public Triangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new ArgumentException("Стороны не могут имень отрицательную или нулевую длинну");
            if (a >= b + c)
                throw new ArgumentException("Сторона a не выполянет неравенство треугольника");
            if (b >= a + c)
                throw new ArgumentException("Сторона b не выполянет неравенство треугольника");
            if (c >= b + a)
                throw new ArgumentException("Сторона c не выполянетне равенство треугольника");
            _a = a;
            _b = b;
            _c = c;
        }
        /// <summary>
        /// Проверяет является или треугольник прямоугольным
        /// </summary>
        /// <returns> true - если прямоугольный, false - eсли нет</returns>
        public bool IsRight()
        {
            if(Math.Pow(_c,2) == Math.Pow(_a,2) + Math.Pow(_b, 2))
                return true;
            if (Math.Pow(_a, 2) == Math.Pow(_c, 2) + Math.Pow(_b, 2))
                return true;
            if (Math.Pow(_b, 2) == Math.Pow(_a, 2) + Math.Pow(_c, 2))
                return true;
            return false;
        }
    }
}
