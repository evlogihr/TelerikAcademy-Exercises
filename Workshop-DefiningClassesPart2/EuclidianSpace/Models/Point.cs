namespace EuclidianSpace.Models
{
    using System;
    using System.Linq;

    public struct Point3D
    {
        private static readonly Point3D origin =
            new Point3D() { X = 0, Y = 0, Z = 0 };

        public Point3D(double x, double y, double z)
            : this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public double X { get; set; }

        public double Y { get; set; }

        public double Z { get; set; }

        public static Point3D Origin
        {
            get
            {
                return origin;
            }
        }

        public override string ToString()
        {
            return string.Format("Point ({0}, {1}, {2})", this.X, this.Y, this.Z);
        }

        public static Point3D Parse(string text)
        {
            int openPar = text.IndexOf('(');
            double[] coord = text
                .Substring(openPar + 1, text.Length - openPar - 2)
                .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => double.Parse(x)).ToArray();

            return new Point3D(coord[0], coord[1], coord[2]);
        }
    }
}
