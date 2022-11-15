using Microsoft.VisualStudio.TestTools.UnitTesting;
using SquareSolverLib;
using System;

namespace SquareSolverTests
{
    [TestClass]
    public class TriangeTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ctor_100_1_1_ArgumentExeptionexpected()
        {
            var t = new Triangle(100,1,1);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ctor_1_100_1_ArgumentExeptionexpected()
        {
            var t = new Triangle(1, 100, 1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ctor_1_1_100_ArgumentExeptionexpected()
        {
            var t = new Triangle(1, 1, 100);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ctor_minus1_1_1_ArgumentExeptionexpected()
        {
            var t = new Triangle(-1, 1, 1);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ctor_1_minus1_1_ArgumentExeptionexpected()
        {
            var t = new Triangle(1, -1, 1);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ctor_1_1_minus1_ArgumentExeptionexpected()
        {
            var t = new Triangle(1, 1, -1);
        }

        [TestMethod]
        public void GetSquare_2_2_2_17320508075688772returned()
        {
            double a = 2;
            Triangle triangle = new Triangle(a, a, a);

            double res = triangle.GetSquare();

            Assert.AreEqual(1.7320508075688772, res);
        }

        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void GetSquare_DoubleMax_DoubleMax_DoubleMax_OverflowExceptionexpected()
        {
            double a = Double.MaxValue;
            Triangle triangle = new Triangle(a, a, a);

            double res = triangle.GetSquare();
        }
        [TestMethod]
        public void IsRight_3_4_5_Truereturned()
        {
            Triangle trig = new Triangle(3, 4, 5);

            bool res = trig.IsRight();

            Assert.IsTrue(res);
        }
        [TestMethod]
        public void IsRight_3_5_5_Falsereturned()
        {
            Triangle trig = new Triangle(3, 5, 5);

            bool res = trig.IsRight();

            Assert.IsTrue(!res);
        }

    }
}
