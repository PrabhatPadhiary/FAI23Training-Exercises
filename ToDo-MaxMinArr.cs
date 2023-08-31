using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj1_SampleConApp
{
    class ToDo_MaxMinArr
    {
        static string GetString(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }

        static void ArrCreate(int size)
        {
            int[] NewArr = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Enter the elements");
                NewArr[i] = int.Parse(Console.ReadLine());
            }

            //Display the elements in the array
            Console.WriteLine("The Array you entered is below: ");
            foreach (int item in NewArr)
            {
                Console.WriteLine(item);
            }

      
            int sum = 0; int max = 0; int min = NewArr[0];


            for (int i = 0; i < size; i++)
            {
                sum += NewArr[i];
                if(NewArr[i] > max)
                {
                    max = NewArr[i];
                }
                if(NewArr[i] < min)
                {
                    min = NewArr[i];
                }
            }
            double avg = sum / size;

            Console.WriteLine($"The average of all the elements inside the array is {avg}");
            Console.WriteLine($"The maximum of all the elements in the array is {max}");
            Console.WriteLine($"The minimum of all the elements in the array is {min}");
        }
        static void Main(string[] args)
        {
            int size = int.Parse(GetString("Enter the size of your desired array"));
            ArrCreate(size);
        }
    }
}
