namespace Tasks1to4
{
    using System.Text;

    public struct Point3D
    {
        public static readonly int XBase = 0;
        public static readonly int YBase = 0;
        public static readonly int ZBase = 0;

        private static readonly Point3D pointO = new Point3D(XBase, YBase, ZBase);

        public Point3D(int x, int y, int z)
            : this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public static Point3D PointO
        {
            get
            {
                return PointO;
            }
        }

        public int X { get; set; }

        public int Y { get; set; }

        public int Z { get; set; }

        public override string ToString()
        {
            return string.Format("cordinates -> x:{0}, y:{1}, z:{2}", this.X, this.Y, this.Z);
        }
    }
}
