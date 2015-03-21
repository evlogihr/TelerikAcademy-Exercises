using EuclidianSpace.Models;
using System.IO;

namespace EuclidianSpace
{
    public static class PathStorage
    {
        public static void SavePath(Models.Path path, string filePath)
        {
            using (var sw = new StreamWriter(filePath))
            {
                foreach (var point in path)
                {
                    sw.WriteLine(point);
                }
            }
        }

        public static Models.Path LoadPath(string filePath)
        {
            var path = new Models.Path();
            using (var sr = new StreamReader(filePath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Point3D point = Point3D.Parse(line);
                    path.AddPoint(point);
                }
            }

            return path;
        }
    }
}
