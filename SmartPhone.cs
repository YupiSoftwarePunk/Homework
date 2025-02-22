using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    public class SmartPhone
    {
        private string model;
        private double cpu_ClockSpeed;
        private int ram;
        private int permanentMemory;
        private double weight;
        private string os;


        public SmartPhone(string model, double cpu_ClockSpeed, int ram, int permanentMemory, double weight, string os)
        {
            this.model = model;
            this.cpu_ClockSpeed = cpu_ClockSpeed;
            this.ram = ram;
            this.permanentMemory = permanentMemory;
            this.weight = weight;
            this.os = os;
        }

        public void Info()
        {
            Console.WriteLine($"Model: {model}, CPU clock speed: {cpu_ClockSpeed}, RAM: {ram}, Permanent memory: {permanentMemory}, Weight: {weight}, OS: {os}\n");

        }
    }
}
