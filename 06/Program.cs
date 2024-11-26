using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace _06
{
    internal class Program
    {
        struct Point3D
        {
            int x, y, z;
            public override string ToString()
            {
                return $"({x}, {y}, {z})";
            }
            public Point3D(int xValue, int yValue, int zValue)
            {
                this.x = xValue;
                this.y = yValue;
                this.z = zValue;
            }

            public static Point3D operator +(Point3D a, Point3D b)
            {
                return new Point3D(a.x + b.x, a.y + b.y, a.z + b.z);
            }
        }
        static void Main(string[] args)
        {
            Point3D p1 = new Point3D(1, 2, 3);
            Point3D p2 = new Point3D(3, 2, 1);

            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(new string('-', 30));

            Console.WriteLine(p1 + p2);


            Console.ReadKey();
        }
    }
}
