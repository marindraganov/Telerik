namespace Tasks1to4
{
    using System;

     public class ConsoleApp
    {
        private static void Main()
        {
            Point3D firstPoint = new Point3D(4, 2, 3);
            Point3D secondPoint = new Point3D(-1, 2, 8);
            double distance = PointCalculations.DistanceBetweenPoints(firstPoint, secondPoint);

            Console.WriteLine("First point: " + firstPoint);
            Console.WriteLine("Second point: " + secondPoint);
            Console.WriteLine("Base point: " + Point3D.PointO);
            Console.WriteLine("Distance between first and second: " + distance);
            Console.WriteLine();

            Path path = new Path();
            path.AddPoint(firstPoint);
            path.AddPoint(secondPoint);
            path.AddPoint(new Point3D(5, -2, 10));

            PathStorage.StorePath(path, "myPath");
            Path loadedPath = PathStorage.LoadPath("myPath");
            Console.WriteLine(loadedPath);          
        }
    }
}
