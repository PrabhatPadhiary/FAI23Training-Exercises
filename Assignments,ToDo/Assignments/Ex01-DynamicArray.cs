using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    class Ex01_DynamicArray
    {
        static void Main(string[] args)
        {
            DynamicArrayCreate();
        }

        private static void DynamicArrayCreate()
        {
            int size = utilities.GetInteger("Enter the size of the array you want to create");
            string dataType = utilities.GetString("Enter the data type for your array");
            Type type = Type.GetType(dataType);
            if(type == null)
            {
                Console.WriteLine("Invalid input of data type. Array cannot be created");
                return;
            }
            Array array = Array.CreateInstance(type, size);
            for(int i = 0; i < size; i++)
            {
                Console.WriteLine($"Enter the element at index {i} of the data type {type.Name}");
                var value = Convert.ChangeType(Console.ReadLine(), type);
                array.SetValue(value, i);
            }
            Console.WriteLine("All the values has been added");
            foreach(var item in array)
            {
                Console.Write("The formed array is as follows: ");
                Console.WriteLine(item);
            }
        }
    }
}
