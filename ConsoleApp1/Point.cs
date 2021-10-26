using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Point
    {
        private int x; // Скрытые поля  - координаты точки.
        private int y;

        public Point(int x, int y) // Конструктор класса.
        {
            this.x = x;
            this.y = y;
        }
        /// <summary>
        /// Метод для рассчета расстояния от начала отсчёта до точки.
        /// </summary>
        /// <returns>возвращает расстояния от начала отсчёта до точки.</returns>
        public double Distance() 
        {
            double d;
            d = Math.Sqrt(x * x + y * y);
            return d;
        }

        /// <summary>
        /// Метод для рассчёта расстояния между двумя точками.
        /// </summary>
        /// <param name="B"> Передаём вторую точку.</param>
        /// <returns> Возвращаем расстояние между двумя точками.</returns>
        public double Distance(Point B)
        {
            double d;
            d = Math.Sqrt((this.x - B.x)*(this.x-B.x) + (this.y - B.y)*(this.y - B.y));
            return d;
        }

        public virtual void Show()
        {
            Console.WriteLine("X = {0} Y = {1}", x, y);
        }
    }
}
