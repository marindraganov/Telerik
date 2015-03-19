namespace Tasks1to4
{
    using System.IO;

    public static class PathStorage
    {
        public static void StorePath(Path path, string pathName)
        {
            string fileName = Directory.GetCurrentDirectory() + "\\" + pathName + ".txt";
            StreamWriter sw = new StreamWriter(fileName);

            using (sw)
            {
                for (int i = 0; i < path.Count; i++)
                {
                    Point3D currPoint = path[i];
                    sw.WriteLine("{0} {1} {2}", currPoint.X, currPoint.Y, currPoint.Z);
                }
            }
        }

        public static Path LoadPath(string pathName)
        {
            string fileName = Directory.GetCurrentDirectory() + "\\" + pathName + ".txt";
            Path path = new Path();

            if (!File.Exists(fileName))
            {
                System.Console.WriteLine("Please check name of the path you try to load. Path with name {0} was not found", fileName);
                return path;
            }

            StreamReader sr = new StreamReader(fileName);
            string line;

            using (sr)
            {
                while ((line = sr.ReadLine()) != null)
                {
                    string[] cordinatesAsString = line.Split();
                    int x = int.Parse(cordinatesAsString[0]);
                    int y = int.Parse(cordinatesAsString[1]);
                    int z = int.Parse(cordinatesAsString[2]);

                    path.AddPoint(new Point3D(x, y, z));
                }
            }

            return path;
        }
    }
}
