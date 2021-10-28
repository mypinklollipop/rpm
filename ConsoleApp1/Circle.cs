using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Circle : Point
    {
        private int r; // дополнительное поле радиус
        public Circle(int x, int y, int r) : base(x, y)
        {
            this.r = r;
        }

        public Circle(int r) : base (0,0)
        {
            this.r = r;
        }

        public Circle(Point A, int r) : base(A)
        {
            this.r = r;
        }
        /// <summary>
        /// Метод для рассчёта площади круга.
        /// </summary>
        /// <returns> Возвращает площадь круга. </returns>
        public double Sqwere()
        {
            double S;
            S = Math.PI * r * r;
            return S;
        }
        public bool Intersect(Circle B)
        {
            double d = this.Distance(B);
            if (d <= r + B.r)
                return true;
            else
                return false;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine("R = " + r);
        }
    }
}
