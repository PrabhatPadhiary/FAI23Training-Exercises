/*using Assignments;
using System;

namespace Proj1_SampleConApp
{
    enum RunMode { Start, Stop }

    class Car
    {
        public virtual void FuelIn(RunMode mode)
        {
            if(mode == RunMode.Start)
                Console.WriteLine("The car is running");
            else
                Console.WriteLine("Car is static");
        }
    }

    class Sedan : Car
    {
        public virtual void FuelIn(RunMode mode)
        {
            if (mode == RunMode.Start)
                Console.WriteLine("The sedan is static");
            else
                Console.WriteLine("Sedan is running");
        }
    }

    class Ex03_MethodOverriding
    {
        static void Main(string[] args)
        {
            Sedan s1 = new Sedan();
            s1.FuelIn(RunMode.Start);
        }
    }
}
*/