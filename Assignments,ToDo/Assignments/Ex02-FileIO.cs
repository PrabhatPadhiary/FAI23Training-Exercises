using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    class Ex02_FileIO
    {
        static void Main(string[] args)
        {
            Prabhat();
        }

        private static void Prabhat()
        {
            string name = utilities.GetString("Enter your name");
            int age = utilities.GetInteger("Enter your age");
            string occ = utilities.GetString("Enter your occupation");

            Console.WriteLine($"Greetings Mr.{name}. Your age is {age} and your current occupation is {occ}");
        }
    }
}
