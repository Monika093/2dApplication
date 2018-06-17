using System;

namespace _2dWorldApp
{   public class Rectangle : SharpShape
    {
        public Rectangle(string Name, PointIn2DIMSpace pointA, PointIn2DIMSpace pointB, PointIn2DIMSpace pointC, PointIn2DIMSpace pointD) 
        {
            this.Name = Name;
            NumberOfSides = 4;
            Vertices = new PointIn2DIMSpace[NumberOfSides];
            Vertices[0] = pointA;
            Vertices[1] = pointB;
            Vertices[2] = pointC;
            Vertices[3] = pointD;
            UpdateCenter();
        }
    }
}
