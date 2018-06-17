using System;

namespace _2dWorldApp
{
    public struct PointIn2DIMSpace
    {
        public readonly double X;
        public readonly double Y;

        public PointIn2DIMSpace(double x, double y)
        {
            X = x;
            Y = y;
        }
        public double DistanceToPoint(PointIn2DIMSpace pt)
        {
            return Math.Sqrt(Math.Pow(pt.X - X, 2) + Math.Pow(pt.Y - Y, 2));
        }
        public static PointIn2DIMSpace operator +(PointIn2DIMSpace a, PointIn2DIMSpace b)
        {
            return new PointIn2DIMSpace(a.X + b.X, a.Y + b.Y);
        }
        public static PointIn2DIMSpace operator -(PointIn2DIMSpace a, PointIn2DIMSpace b)
        {
            return new PointIn2DIMSpace( b.X - a.X , b.Y - a.Y);
        }
    }
}
