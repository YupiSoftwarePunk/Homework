using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    public class Circle
    {
        private double x;
        private double y;
        private double r;


        public Circle(double x, double y, double r)
        {
            this.x = x;
            this.y = y;
            this.r = r;
        }


        public void Lenght()
        {
            double res = Math.PI * 2 * r;
            Console.WriteLine($"Lenght of circle = {res}\n");
        }

        public void Square()
        {
            double square = Math.PI * Math.Pow(r, 2);
            Console.WriteLine($"Circle square = {square}\n");
        }
    }
}
