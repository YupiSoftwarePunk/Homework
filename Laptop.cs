using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    public class Laptop
    {
        private string model;
        private double cpu_ClockSpeed;
        private int ram;
        private int hdd;
        private double weight;

        public Laptop(string model, double cpu_ClockSpeed, int ram, int hdd, double weight)
        {
            this.model = model;
            this.cpu_ClockSpeed = cpu_ClockSpeed;
            this.ram = ram;
            this.hdd = hdd;
            this.weight = weight;
        }

        public void Info()
        {
            Console.WriteLine($"Model: {model}, CPU clock speed: {cpu_ClockSpeed}, RAM: {ram}, HDD: {hdd}, Weight: {weight}\n");
        }
    }
}
