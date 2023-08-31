using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj1_SampleConApp
{
    class ToDo_Basic
    {
        static string GetQuestion(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }
        
        static void PrintOut(string name, int age, string branch, string college, int strength)
        {
            Console.WriteLine($"Greetings, Mr.{name}. We've got the following information regarding your college:\nName: {name}\nAge: {age}\nBranch: {branch}\nCollege: {college}\nStrngth of your College: {strength}");
        }

        static void Main(string[] args)
        {
            do
            {
                string name = GetQuestion("Enter your name");
                int age = int.Parse(GetQuestion("Enter your age"));
                string branch = GetQuestion("Enter your branch");
                string college = GetQuestion("Enter the name of your college");
                int strength = int.Parse(GetQuestion("Enter the strength of your college"));

                PrintOut(name, age, branch, college, strength);
            }

            while (true);
        }
    }
}
