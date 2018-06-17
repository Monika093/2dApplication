using System;

namespace _2dWorldApp
{   public class Circle : Shape, IDisplay
    {
        
        public Circle(string name, double x, double y,double radius) : base(x,y)
        {
            this.radius = radius;
        }

        private double radius;
        public double Radius
        {
            get { return radius; }
            set
            {
                if (radius != value)
                {
                    radius = value;
                    OnShapeChanged(EventArgs.Empty);
                }
            }
        }
        
        public override double Perimeter()
        {
            return 2*radius*Math.PI; 
        }
        public override void Draw()
        {
            Console.WriteLine("Drawing a Circle");
        }
        public void Display()
        {
            Console.WriteLine("Display a Circle");
        }
        public override double Area()
        {
            return radius * radius * System.Math.PI; 
        } 
    }
}
