using Microsoft.VisualStudio.TestTools.UnitTesting;
using SquareSolverLib;
using System;

namespace SquareSolverTests
{
    [TestClass]
    public class SquareSolverTests
    {

        [TestMethod]
        public void GetCircleSquare_10_100PIreturned()
        {
            double r = 10;

            double res = SquareSolver.GetCircleSquare(r);

            Assert.AreEqual(100 * Math.PI, res);
        }
        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void GetCircleSquare_DoubleMaxValue_OverflowExceptionexpected()
        {
            double r = Double.MaxValue;

            double res = SquareSolver.GetCircleSquare(r);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GetCircleSquare_minus10_ArgumentExceptionexpected()
        {
            double r = -10;

            double res = SquareSolver.GetCircleSquare(r);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GetCircleSquare_0_ArgumentExceptionexpected()
        {
            double r = 0;

            double res = SquareSolver.GetCircleSquare(0);
        }


        [TestMethod]
        public void GetTriangleSquare_1_1_1_04330127018922193returned()
        {
            double a = 1;
            double b = 1;
            double c = 1;
            double expect = 0.4330127018922193;

            var res = SquareSolver.GetTriangleSquare(a, b, c);

            Assert.AreEqual(expect, res);
        }
        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void GetTriangleSquare_DoubleMaxValue_DoubleMaxValue_DoubleMaxValue_OverflowExceptionexpected()
        {
            double a = Double.MaxValue;

            var res = SquareSolver.GetTriangleSquare(a, a, a);
        }
        [TestMethod]
        public void GetSquare_Circle_1_MathPIreturned()
        {
            Circle cir = new Circle(1);

            var res = SquareSolver.GetSquare(cir);

            Assert.AreEqual(Math.PI, res);
        }
        [TestMethod]
        public void GetSquare_Triangle_1_1_1_0433013returned()
        {

            Triangle cir = new Triangle(1,1,1);

            var res = SquareSolver.GetSquare(cir);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GetTriangleSquare_minus1_1_1_ArgumentExceptionexpected()
        {
            var res = SquareSolver.GetTriangleSquare(-1, 1, 1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GetTriangleSquare_100_1_1_ArgumentExceptionexpected()
        {
            var res = SquareSolver.GetTriangleSquare(100, 1, 1);
        }

    }
}