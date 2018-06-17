namespace _2dWorldApp
{
    public class Triangle : SharpShape
    {
        public Triangle(string name, PointIn2DIMSpace pointA, PointIn2DIMSpace pointB, PointIn2DIMSpace pointC)
        {
            Name = name;
            NumberOfSides = 3;
            Vertices = new PointIn2DIMSpace[NumberOfSides];
            Vertices[0] = pointA;
            Vertices[1] = pointB;
            Vertices[2] = pointC;
            UpdateCenter();
        }
    }
}