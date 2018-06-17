using System;
using System.Collections.Generic;

namespace _2dWorldApp
{
    public class ShapeContainer
    {
        public List<Shape> ListOfShapes { get; set; }
        private ILogger _log;

        public ShapeContainer(ILogger log, List<Shape> list)
        {
            ListOfShapes = list;
            _log = log;
        }

        #region Cebov

        //public void Draw()
        //{
        //    double temp;
        //    double[] distance = new double[ListOfShapes.Count];
        //    var lista = new List<Shape>(ListOfShapes);
        //    // init array with distances
        //    for (var i = 0; i < ListOfShapes.Count; i++)
        //    distance[i] = (Math.Pow(ListOfShapes[i].Center.X, 2) + Math.Pow(ListOfShapes[i].Center.Y, 2));
        //    // sort distances
        //    for (var i = 0; i < ListOfShapes.Count ; i++)
        //    {
        //        for (var j = i + 1; j < ListOfShapes.Count; j++)
        //        {
        //            if (distance[i] >= distance[j])
        //            {
        //                temp = distance[j];
        //                distance[j] = distance[i];
        //                distance[i] = temp;


        //                var tmpLista = lista[j];
        //                lista[j] = lista[i];
        //                lista[i] = tmpLista;

        //            }
        //        }
        //     lista[i].Draw();
        //    }
        //}

        #endregion

        public void Transform(int index, PointIn2DIMSpace point)
        {
            _log.WriteLine("asd " + ListOfShapes[index].Name);

            var x = ListOfShapes[index].Center.X + point.X;
            var y = ListOfShapes[index].Center.Y + point.Y;
            var newpoint = new PointIn2DIMSpace(x, y);
            //
            ListOfShapes[index].Center = newpoint;

            ListOfShapes[index].Transform(point);
        }

        public void ReDraw()
        {
            foreach (var shape in ListOfShapes)
            {
                shape.Draw();
            }
        }


    }
}
