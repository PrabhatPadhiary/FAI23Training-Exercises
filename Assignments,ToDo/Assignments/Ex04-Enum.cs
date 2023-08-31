using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    class Ex04_Enum
    {
        enum Days
        { Modnay, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday }

        static void Main(string[] args)
        {
            SelDay();
        }

        private static void SelDay()
        {
            int num = utilities.GetInteger("Enter the number: 0 -> Monday, 1 -> Tuesday, 2 -> Wednesday, 3 -> Thursday, 4 -> Friday, 5 -> Saturday, 6 -> Sunday");

            if (num < 0 || num > 6)
            {
                Console.WriteLine("Invalid input. Please enter a number within the specified range");
                return;
            }

            Days SelDay = (Days)(num);
            Console.WriteLine("The day you selected is: " + SelDay);

        }
    }
}
