using System;

namespace _2dWorldApp
{   public class Ellipse : Shape
    {
        private double radius1;
        private double radius2;
        public Ellipse(string name, double x, double y, double radius1, double radius2) 
        : base(x, y)
        {
            this.Name = name;
            this.radius1 = radius1;
            this.radius2 = radius2;
        }

        public override double Perimeter()
        {
             return 2 * Math.PI * Math.Sqrt((Math.Pow(radius1, 2) + Math.Pow(radius2, 2)) / 2); 
        }
        public override void Draw()
        {
            Console.WriteLine("Drawing an Elipse");
        }
        public override double Area()
        {
             return Math.PI * radius2 * radius1; 
        }
    }
}
