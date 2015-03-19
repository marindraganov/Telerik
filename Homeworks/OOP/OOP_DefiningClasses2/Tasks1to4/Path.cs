namespace Tasks1to4
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Path
    {
        private List<Point3D> points;

        public Path()
        {
            this.points = new List<Point3D>();
        }

        public Path(List<Point3D> points)
        {
            this.points = points;
        }

        public List<Point3D> Points
        {
            get
            {
                return this.points;
            }
        }

        public int Count
        {
            get
            {
                return this.points.Count;
            }
        }

        public Point3D this[int index]
        {
            get
            {
                if (index < 0 || index > this.points.Count)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    return this.points[index];
                }
            }

            set
            {
                if (index < 0 || index > this.points.Count)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    this.points[index] = value;
                }
            }
        }

        public void AddPoint(Point3D point)
        {
            this.points.Add(point);
        }

        public override string ToString()
        {
            StringBuilder pathString = new StringBuilder();
            for (int i = 0; i < this.points.Count; i++)
            {
                pathString.AppendFormat("Point {0}: {1}\n\r", i, this.points[i]);
            }

            return pathString.ToString();
        }
    }
}
