using System;
using EuclidianSpace.Models;

namespace EuclidianSpace.Extensions
{
    public static class Point3DExtensions
    {
        public static double CalculateDistance(Point3D firstPoint, Point3D secodPOint)
        {
            double distance = 0.0;
            distance = Math.Sqrt(
                (firstPoint.X - secodPOint.X) * (firstPoint.X - secodPOint.X) +
                (firstPoint.Y - secodPOint.Y) * (firstPoint.Y - secodPOint.Y) +
                (firstPoint.Z - secodPOint.Z) * (firstPoint.Z - secodPOint.Z));

            return distance;
        }
    }
}
