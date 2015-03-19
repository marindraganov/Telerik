namespace Tasks1to4
{
    using System;

    public static class PointCalculations
    {
        public static double DistanceBetweenPoints(Point3D point1, Point3D point2)
        {
            int deltaX = point1.X - point2.X;
            int deltaY = point1.Y - point2.Y;
            int deltaZ = point1.Z - point2.Z;
            double distance = Math.Sqrt((deltaX * deltaX) + (deltaY * deltaY) + (deltaZ * deltaZ));

            return distance;
        }
    }
}
