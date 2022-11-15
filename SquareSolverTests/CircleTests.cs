using Microsoft.VisualStudio.TestTools.UnitTesting;
using SquareSolverLib;
using System;

namespace SquareSolverTests
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ctor_minus5_ArgumentExeptionexpected()
        {
            var c = new Circle(-5);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ctor_0_ArgumentExeptionexpected()
        {
            var c = new Circle(0);
        }
        [TestMethod]
        public void GetSqare_20_400PIreturned()
        {
            var c = new Circle(20);

            var res = c.GetSquare();

            Assert.AreEqual(400*Math.PI, res);
        }
    }
}
