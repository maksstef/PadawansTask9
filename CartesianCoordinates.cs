using System;
using System.Collections.Generic;

namespace PadawansTask9
{
    public class CartesianCoordinates
    {
        public static List<Point> GetNeighbors(Point point, int range, params Point[] points)
        {
            // put your code here
            if (points == null)
                throw new ArgumentNullException();
            if (points.Length == 0)
                throw new ArgumentException();
            //передаётся точка, затем радиус вокруг неё, массив точек, которые нужно отсортировать
            List<Point> NewPoints = new List<Point>();
            for(int i = 0; i < points.Length; ++i)
            {
                if (points[i].X <= point.X + range && points[i].Y <= point.Y + range && points[i].X >= point.X - range && points[i].Y >= point.Y - range)
                {
                    NewPoints.Add(points[i]);
                }
            }
            return NewPoints;
        }
    }
}