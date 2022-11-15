using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareSolverLib
{
    public class Circle : ISquare
    {
        private double _radious;
        /// <summary>
        /// Создает круг по радиусу 
        /// </summary>
        /// <param name="r"> радиус </param>
        /// <exception cref="ArgumentException"> если радус отрицательный или нулевой</exception>
        public Circle(double r)
        {
            if (r <= 0)
                throw new ArgumentException("радиус не может быть меньше или равен нулю");
            _radious = r;
        }
        /// <summary>
        /// Вычисляет площадь
        /// </summary>
        /// <returns> число double </returns>
        /// <exception cref="OverflowException">Если площадь слишком велика или принимает значение Infinity</exception>
        public double GetSquare()
        {
            var res = _radious * _radious * Math.PI;
            if (res > Double.MaxValue)
                throw new OverflowException("Значение radius слишком велико");
            return res;
        }
    }
}
