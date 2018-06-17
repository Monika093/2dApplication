using System;

namespace _2dWorldApp
{
    public abstract class SharpShape : Shape, IDisplay
    {
        /// <summary>
        /// Vertices of shapes
        /// </summary>
        public PointIn2DIMSpace[] Vertices;

        /// <summary>
        /// Number of Angles in shape
        /// </summary>
        public int NumberOfAngles { get; set; }

        /// <summary>
        /// Number of sides in shape
        /// </summary>
        public int NumberOfSides { get; set;  }

        public virtual void Display()
        {
            Console.WriteLine("Display a " + Name);
        }
        public override double Perimeter()
        {
            var distance = 0.0;
            for (int i = 0; i < NumberOfSides; i++)
                distance += Vertices[i].DistanceToPoint(Vertices[(i + 1) % NumberOfSides]);

            return distance;
        }
        public override double Area()
        {
            double area = 0;
            for (int i = 0; i < Vertices.Length; i++)
            {
                int j = (i + 1) % Vertices.Length;
                area += Vertices[i].X * Vertices[j].Y;
                area -= Vertices[i].Y * Vertices[j].X;
            }
            area = Math.Abs(area) / 2;
            return area;
        }
        protected void UpdateCenter()
        {
            var sum = new PointIn2DIMSpace(0, 0);
            foreach (var point in Vertices)
                sum += point;
            Center = new PointIn2DIMSpace(sum.X / Vertices.Length, sum.Y / Vertices.Length);
        }
        public override void Transform(PointIn2DIMSpace point)
        {
            for (int i = 0; i < Vertices.Length; i++)
            {
                var x = point.X - Center.X;
                var y = point.Y - Center.Y;
                var newpoint = new PointIn2DIMSpace(x, y);
                Vertices[i] += newpoint;
            }
           
        }
    }
}
