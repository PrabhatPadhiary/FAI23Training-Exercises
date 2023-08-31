using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj1_SampleConApp
{
    class ToDo_LoanCalc
    {
        static string GetQuestion(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }

        static double GetAmount(int Lamount, int Tenure, double Roi)
        {
            double r = Roi / 100;
            double FirstCalc = Math.Pow((1 + r),Tenure);
            double Famount = Lamount * FirstCalc;
            Console.WriteLine("The total amount you need to pay: ");
            return Famount;
        }

        static double GetEmi(int Lamount, int Tenure, double Roi)
        {
            double r = Roi / 100;
            double amt1 = Lamount * (Roi / 100) * (1 + r) * Tenure;
            double amt2 = (1 + r) * Tenure - 1;
            double emi = amt1 / amt2;
            Console.WriteLine("The EMI of each month will be: ");
            return emi;
        }

        static void Main(string[] args)
        {
            int Lamount = int.Parse(GetQuestion("Enter your Principal Amount: "));
            int Tenure = int.Parse(GetQuestion("Enter your Tenure for Loan Amount: "));
            double Roi = double.Parse(GetQuestion("Enter your rate of interest: "));

            Console.WriteLine(GetAmount(Lamount, Tenure, Roi));
            Console.WriteLine(GetEmi(Lamount, Tenure, Roi));
           
        }
    }
}
