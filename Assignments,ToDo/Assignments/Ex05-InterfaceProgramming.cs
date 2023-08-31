using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;
using Assignments;

namespace Proj1_SampleConApp
{
    interface IDistance
    {
        double GetDistance();
    }

    class CarSpeed: IDistance
    {
        public double speed { get; set; }
        public double time { get; set; }

        public double GetDistance()
        {
            double distance;
            return distance = time * speed;
        }
    }
    class Ex05_InterfaceProgramming
    {
        static void Main(string[] args)
        {
            CarSpeed sedanSpeed = new CarSpeed { speed = 56, time = 4 };
            Console.WriteLine($"The speed of the sedan is {sedanSpeed.GetDistance()}");
        }
    }
        
}