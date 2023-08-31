using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    class Ex06_ArrayReversing
    {
        static void Main(string[] args)
        {
            ReverseArray();

            //string input = Console.ReadLine();
            //string reversed = new string(input.Reverse().ToArray());
            //Console.WriteLine(reversed);
        }

        private static void ReverseArray()
        {
            int size = utilities.GetInteger("Enter the size of the array");
            int[] arr = new int[size];

            for (int i = 0; i < size; i++)
            {
                arr[i] = utilities.GetInteger($"Enter the element for index {i}");
            }
            Console.Write("The input array is: ");
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }

            int[] newArr = new int[size];
            int j = 0;
            for (int i = size - 1; i >= 0; i--)
            {
                newArr[i] = arr[j];
                j += 1;
            }
            Console.WriteLine("The reverse array is: ");
            foreach (var items in newArr)
            {
                Console.Write(items + " ");
            }
        }
    }
}
