using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    public class Triangle
    {
        private double lenght1;
        private double lenght2;
        private double lenght3;

        public Triangle(double lenght1, double lenght2, double lenght3)
        {
            this.lenght1 = lenght1;
            this.lenght2 = lenght2;
            this.lenght3 = lenght3;
        }


        public void Perimetr()
        {
            double perimetr = lenght1 + lenght2 + lenght3;
            Console.WriteLine($"Perimeter = {perimetr}\n");
        }

        public void Square()
        {
            double semiperimeter = (lenght1 + lenght2 + lenght3) / 2;
            double square = Math.Sqrt(semiperimeter * (semiperimeter - lenght1) * (semiperimeter - lenght2) * (semiperimeter - lenght3));
            Console.WriteLine($"Square = {square}\n");
        }

        public void Info()
        {
            Console.WriteLine($"Side length 1 = {lenght1}, Side length 2 = {lenght2}, Side length 3 = {lenght3}");
        }
    }
}
