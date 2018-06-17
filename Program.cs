using System;
using System.Collections.Generic;
using _2dWorldApp.DifferentTriangles;

namespace _2dWorldApp
{   public class Program
    {   static void Main(string[] args)
        {
            var point1 = new PointIn2DIMSpace(2.0,3.0);
            var point2 = new PointIn2DIMSpace(6.0, 5.0);
            var point3 = new PointIn2DIMSpace(9.0,4.5);
            var point4 = new PointIn2DIMSpace(4.5,5.6);
            var point5 = new PointIn2DIMSpace(6.5, 9.6);
            // collection initializer
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
            foreach (var shape in shapes)
            {
                shape.ShapeChanged += ShapeOnShapeChanged;
            }
            ShapeContainer sc = new ShapeContainer(new TextFileLogger(), shapes);

            var newPointTransform = new PointIn2DIMSpace(15.0, 41.0);
            foreach (var shape in shapes)
            {
                Console.WriteLine(shape.Name);
                Console.WriteLine("The point is in (" + shape.Center.X + "," + shape.Center.Y + ")");
                Console.WriteLine("Perimeter is: "+ shape.Perimeter());
                Console.WriteLine("Area is: " + shape.Area());
                    
                shape.Draw();
                shape.Quadrant();
                if (shape.GetType() == typeof(IDisplay))
                {
                    ((IDisplay)shape).Display();
                }                
                shapes[0].Transform(newPointTransform);
            }
            Console.WriteLine("The minimum number of rays :   " + RayTrace(shapes));
            Console.ReadLine();
        }
        private static void ShapeOnShapeChanged(object sender, EventArgs eventArgs)
        {
            //  re - draws the shape 
        }
        /// <summary>
        /// RayTracing
        /// </summary>
        /// <param name="shapes"></param>
        /// <returns></returns>
        public static int RayTrace(List<Shape> shapes)
        {
            if (shapes == null)
                throw new ArgumentNullException();

            if (shapes.Count == 0)
                return 0;

            var angles = CalculateAngles(shapes);

            BubbleSort(angles);

            var numOfRays = CountDistinct(angles);

            return numOfRays;  //return just the number of distinct angles
        }
        private static double[] CalculateAngles(List<Shape> shapes)
        {
            var angles = new double[shapes.Count]; //array of angles
            for (int i = 0; i < shapes.Count; i++) //position of shape
            {
                var shape = shapes[i]; //assign each shape

                angles[i] = Math.Atan2(shape.Center.Y, shape.Center.X); //calculate each angle
            }
            return angles;
        }
        private static void BubbleSort(double[] items)
        {
            for (int i = 0; i < items.Length - 1; i++)
                for (int j = i + 1; j < items.Length; j++)
                    if (items[i] > items[j])
                        BubbleSortSwap(items, i, j);
        }
        private static void BubbleSortSwap(double[] items, int i, int j)
        {
            var temp = items[j];
            items[j] = items[i];
            items[i] = temp;
        }
        private static int CountDistinct(double[] items)
        {
            var counter = 1;
            for (int i = 0; i < items.Length - 1; i++)
                if (items[i] != items[i + 1])
                    counter++;
            return counter;
        }
    }
}










