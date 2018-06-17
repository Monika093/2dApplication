using System;

namespace _2dWorldApp
{   public class Diamond : SharpShape
    {
        public Diamond(string Name, PointIn2DIMSpace pointA, PointIn2DIMSpace pointB, 
            PointIn2DIMSpace pointC, PointIn2DIMSpace pointD, PointIn2DIMSpace pointE)
        {
            this.Name = Name;
            Vertices = new PointIn2DIMSpace[5];
            this.NumberOfSides = 5;
            Vertices[0] = pointA;
            Vertices[1] = pointB;
            Vertices[2] = pointC;
            Vertices[3] = pointD;
            Vertices[4] = pointE;
            UpdateCenter();
        }
    }
}
