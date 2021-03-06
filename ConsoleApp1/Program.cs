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
            Circle D = new Circle(6);
            C.Show();
            D.Show();
            double s1 = C.Sqwere();
            double s2 = D.Sqwere();
            bool b = C.Intersect(D);
            Console.WriteLine("Площадь окружности C = " + s1);
            Console.WriteLine("Площадь окружности D = " + s2);
            if (b==true)
            {
                Console.WriteLine("Окружности пересекаются");
            }
            else
            {
                Console.WriteLine("Окружности не пересекаются");
            }

            Circle C1 = new Circle(A, 3);
            Circle C2 = new Circle(B, 5);
            C1.Show();
            C2.Show();
            double d = C1.Distance(C2);
            Console.WriteLine("Расстояние между центрами окружностей = " + d);

            Console.ReadLine();
        }
    }
}
