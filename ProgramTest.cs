using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _2dWorldApp;
using _2dWorldApp.DifferentTriangles;

namespace _2dWordAppTest
{
    [TestClass]
    public class ProgramTest
    {
        [TestMethod]
        public void RayTraceTest()
        {
            var point1 = new PointIn2DIMSpace(2.0, 3.0);
            var point2 = new PointIn2DIMSpace(6.0, 5.0);
            var point3 = new PointIn2DIMSpace(9.0, 4.5);
            var point4 = new PointIn2DIMSpace(4.5, 5.6);
            var point5 = new PointIn2DIMSpace(6.5, 9.6);
            var shapes = new List<Shape>
            {
                 new Triangle("Triangle",   point1 , point2, point3),
                new EquilateralTriangle("EquilateralTriangle",  point1 , point2, point3),
                new IsoscelesTriangle("IsoscelesTriangle",  point1 , point2, point3),
                new Rectangle("Rectangle",  point1 , point2, point3, point4),
                new Circle("Circle", -9.0, -1.0 , 5.0),
                new Diamond("Diamond", point1 , point2, point3, point4, point5),
                new Ellipse("Ellipse", -10.0, 10.0 , 5.2, 4.5)
            };

            var actualRayTraceCount = Program.RayTrace(shapes);

            Assert.AreEqual(5, actualRayTraceCount);
        }
    }
}
