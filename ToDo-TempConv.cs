using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj1_SampleConApp
{
    class ToDo_TempConv
    {
        static string GetQuestion(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }

        static void Main(string[] args)
        {
            string operation = GetQuestion("Enter the respective number for the conversion you want to have:\n1. Deg-Far\n2. Far-Deg\n3. Deg-Kel\n4. Kel-Deg\n5. Kel-Far\n6. Far-Kel");

            switch (operation)
            {
                case "1":
                    double Deg1 = double.Parse(GetQuestion("Enter the temp in Degree Celsius"));
                    Console.WriteLine(Deg1 * (9 / 5) + 32);
                    break;
                case "2":
                    double Far1 = double.Parse(GetQuestion("Enter the temp in Farheneit"));
                    Console.WriteLine((Far1 - 32) * (5/9));
                    break;
                case "3":
                    double Deg2 = double.Parse(GetQuestion("Enter the temp in Degree Celsius"));
                    Console.WriteLine(Deg2 + 273.15);
                    break;
                case "4":
                    double Kel1 = double.Parse(GetQuestion("Enter the temp in Kelvin"));
                    Console.WriteLine(Kel1 - 273.15);
                    break;
                case "5":
                    double Kel2 = double.Parse(GetQuestion("Enter the temp in Kelvin"));
                    Console.WriteLine(Kel2 * (9 / 5) - 459.67);
                    break;
                case "6":
                    double Far2 = double.Parse(GetQuestion("Enter the temp in Farheneit"));
                    Console.WriteLine((Far2 + 459.67) * (5/9));
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;


            }
        }
    }
}
