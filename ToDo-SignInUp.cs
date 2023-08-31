using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj1_SampleConApp.Week_2
{
    class UserUtils
    {
        private static Dictionary<string, string> User = new Dictionary<string, string>();
        public static void SignUp()
        {
            string uname = utilities.GetString("Please set your UserName: ");
            string pwd = utilities.GetString("Please set your Password: ");

            User.Add(uname, pwd);

            Console.WriteLine("Now Please sign in to your account and check for your credentials");
        }

        public static void SignIn()
        {
            string uname = utilities.GetString("Enter your username: ");
            string pwd = utilities.GetString("Enter your password: ");

            if (!User.ContainsKey(uname))
            {
                Console.WriteLine("Username is not registered. Invalid Credentials!");
                return;
            }
            else
            {
                if (User[uname] != pwd)
                {
                    Console.WriteLine("Incorrect Password");
                }
                else
                {
                    Console.WriteLine("Login Successfull");
                }
            }
        }
    }
    class ToDo_SignInUp
    {
        
        static void Main(string[] args)
        {
            do
            {
                var choice = utilities.GetString("----------USER PAGE----------\nSIGN IN--->PRESS 1\nSIGN UP--->PRESS 2\n---------------------------- - ");

                switch (choice)
                {
                    case "1":
                        UserUtils.SignIn();
                        break;

                    case "2":
                        UserUtils.SignUp();
                        break;

                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
            } while (true);
        }
    }
}
