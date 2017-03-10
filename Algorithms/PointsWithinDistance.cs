using System;
using System.Collections.Generic;

namespace Algorithms
{

    public class Point
    {
        public double x
        {
            get;
            set;
        }

        public double y
        {
            get;
            set;
        }

        double distanceTo(Point otherPoint)
        {
            double dist = Math.Sqrt((otherPoint.x - x) * (otherPoint.x - x) + (otherPoint.y - y) * (otherPoint.y - y));
            return dist;
        }

        bool isOtherPointWithinDistance(Point otherPoint, double distance)
        {
            if (distanceTo(otherPoint) <= distance)
                return true;
            else
                return false;
        }


        public static List<Point> GetPointsWithinDistance(List<Point> points, double distance, Point origin)
        {
            List<Point> pointsIn = new List<Point>();
           

            foreach (var point in points)
            {
                if (origin.isOtherPointWithinDistance(point, distance))
                    pointsIn.Add(point);
            }


            return pointsIn;
        }

    }


  
}

