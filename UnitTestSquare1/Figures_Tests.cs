using Microsoft.VisualStudio.TestTools.UnitTesting;
using Figures;
using System;

namespace UnitTests
{
    [TestClass]
    public class Square_Tests
    {
        [TestMethod]
        public void Square_Area_Test1()
        {
            Square square = new Square();
            square.set_info(5);
            Assert.IsTrue(square.Area() == 25);
        }

        [TestMethod]
        public void Square_Area_Test2()
        {
            Square square = new Square();
            square.set_info(-5);
            Assert.IsTrue(square.Area() == -1);
        }

        [TestMethod]
        public void Square_Perimeter_Test1()
        {
            Square square = new Square();
            square.set_info(2);
            Assert.IsTrue(square.Area() == 4);
        }

        [TestMethod]
        public void Square_Perimeter_Test2()
        {
            Square square = new Square();
            square.set_info(-2);
            Assert.IsTrue(square.Area() == -1);
        }
    }
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void Circle_Area_Test1()
        {
            Circle circle = new Circle();
            circle.set_info(1);
            Assert.IsTrue(circle.Area() == Math.PI);
        }

        [TestMethod]
        public void Circle_Area_Test2()
        {
            Circle circle = new Circle();
            circle.set_info(-1);
            Assert.IsTrue(circle.Area() == -1);
        }

        [TestMethod]
        public void Circle_Perimeter_Test1()
        {
            Circle circle = new Circle();
            circle.set_info(1);
            Assert.IsTrue(circle.Perimeter() == Math.PI*2);
        }

        [TestMethod]
        public void Circle_Perimeter_Test2()
        {
            Circle circle = new Circle();
            circle.set_info(-1);
            Assert.IsTrue(circle.Perimeter() == -1);
        }
    }

    [TestClass]
    public class Trapeze_Tests
    {
        [TestMethod]
        public void Trapeze_Area_Test1()
        {
            Trapeze trapeze = new Trapeze();
            trapeze.set_info(4,2,5,4,5);
            Assert.IsTrue(trapeze.Area() == 15);
        }

        [TestMethod]
        public void Trapeze_Area_Test2()
        {
            Trapeze trapeze = new Trapeze();
            trapeze.set_info(4, -2, 5, 4, 5);
            Assert.IsTrue(trapeze.Area() == -1);
        }

        [TestMethod]
        public void Trapeze_Perimeter_Test1()
        {
            Trapeze trapeze = new Trapeze();
            trapeze.set_info(4, 2, 5, 4, 5);
            Assert.IsTrue(trapeze.Perimeter() == 15);
        }

        [TestMethod]
        public void Trapeze_Perimeter_Test2()
        {
            Trapeze trapeze = new Trapeze();
            trapeze.set_info(4, 2, 5, -4, 5);
            Assert.IsTrue(trapeze.Perimeter() == -1);
        }
    }

}
