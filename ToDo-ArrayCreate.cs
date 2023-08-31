using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj1_SampleConApp
{
    class ToDo_ArrayCreate
    {
        static void Main(string[] args)
        {
            DynamicArrayExample();
        }

        private static void DynamicArrayExample()
        {
            int size = utilities.GetInteger("Enter the size of the array");
            string dataType = utilities.GetString("Enter the data type(CTS name) for the array");
            Type type = Type.GetType(dataType);
            if (type == null)
            {
                Console.WriteLine("Invalid Input of data type cannot create array");
                return;
            }
            Array array = Array.CreateInstance(type, size);
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Enter the value for the array at the index {i} of the data type {type.Name}");
                var value = Convert.ChangeType(Console.ReadLine(), type);
                array.SetValue(value, i);
            }
            Console.WriteLine("All the values are set !!");
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
