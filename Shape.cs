using System;

namespace _2dWorldApp
{   public abstract class Shape : IDraw
    {
        // private properties
        private string _name;
        private PointIn2DIMSpace center;

        /// <summary>
        /// Event for Shape changed
        /// </summary>
        public event EventHandler ShapeChanged;

        public Shape(double x, double y)
        {
            Center = new PointIn2DIMSpace(x,y); 
        }

        public Shape()
        {

        }

        // public properties
        /// <summary>
        /// Name of the shape
        /// </summary>
        public string Name { get => _name; set => _name = value; } 
        public PointIn2DIMSpace Center
        {
            get { return center; }
            set
            {
                if ((center.X != value.X ) || (center.Y != value.Y))
                {
                    center = value;
                    OnShapeChanged(EventArgs.Empty);
                }
            }
        }
        /// <summary>
        /// Perimeter of shape
        /// </summary>
        public abstract double Perimeter();
        /// <summary>
        /// Area of the shape
        /// </summary>
        public abstract double Area();
        // public functions

        protected virtual void OnShapeChanged(EventArgs e)
        {
            ShapeChanged?.Invoke( this, e);
        }

        /// <summary>
        /// Draw the shape
        /// </summary>
        public virtual void Draw()
        {
            Console.WriteLine("Drawing a " + Name);
        }

        /// <summary>
        /// Quadrant of center of the shape
        /// </summary>
        public virtual int Quadrant()
        { 
            if (Center.X > 0 && Center.Y > 0)
            {
                return 1;
            }
            if (Center.X < 0 && Center.Y > 0)
            {
                return 2;
            }
            if (Center.X < 0 && Center.Y < 0)
            {
                return 3;
            }

            return 4;

        }    
        public virtual void Transform(PointIn2DIMSpace point)
        {
            var x = Center.X + point.X;
            var y = Center.Y + point.Y;
            var newpoint = new PointIn2DIMSpace(x, y);
            Center = newpoint;
        }
    }
}
