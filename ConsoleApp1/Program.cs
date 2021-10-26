using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Point A = new Point(3,-5);
            Point B = new Point(2, 4);
            A.Show();
            B.Show();
            double d1 = A.Distance();
            double d2 = B.Distance();
            double d3 = A.Distance(B);
            Console.WriteLine("Расстояние от начала отсчёта: ");
            Console.WriteLine(" до точки A " + d1);
            Console.WriteLine(" до точки B " + d2);
            Console.WriteLine(" между точками A и B " + d3);

            Circle C = new Circle(3,-5,4);
            Circle D = new Circle(2,4,6);
            C.Show();
            D.Show();
            double s1 = C.Sqwere();
            double s2 = D.Sqwere();
            bool b = C.Intersect(D);
            Console.WriteLine("Площадь окружности : ");
            Console.WriteLine(" C = " + s1);
            Console.WriteLine(" D = " + d2);
            Console.WriteLine(" между точками A и B " + d3);

            Console.ReadLine();
        }
    }
}
