using System;

namespace ConAppLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            string choice;
            do
            {
                int num;
                Console.WriteLine("Enter number to get its table");
                num = int.Parse(Console.ReadLine());
                Console.WriteLine($"Table of {num} as follows");
                for (int i = 0; i < num; i++)
                {
                    Console.WriteLine($"{num} * {i} =\t{(num * i)}");
                }
                Console.WriteLine("Do you wish to continue? If yes press Y, if no press any other key");
                choice = Console.ReadLine().ToUpper();
            }
            while (choice == "Y");
            */
            /*
            string userName, userPassword;
            Console.WriteLine("Enter User Name");
            userName = Console.ReadLine();
            Console.WriteLine("Enter Password");
            userPassword = Console.ReadLine();
            if (userName == "admin1256" && userPassword == "admin@1256@1256")
            {
                Console.WriteLine("Sign Success");
            }
            else if (string.IsNullOrEmpty(userName) || userPassword == "")
            {
                Console.WriteLine("Please provide User Name and Password");
            }
            else
            {
                Console.WriteLine("Invalid User Name and Password");
            }
            */
            /*
            var myNum = 12;
            var myString = "Sam";
            var status = true;
            var grade = 'A';
            Console.WriteLine("Value stored in myNum is : " +myNum+ 
                "\n Data Type of myNum is : "+ myNum.GetType());
            Console.WriteLine("Value stored in myString is : " + myString +
                "\n Data Type of myNum is : " + myString.GetType());
            Console.WriteLine("Value stored in status is : " + status +
                "\n Data Type of myNum is : " + status.GetType());
            Console.WriteLine("Value stored in grade is : " + grade +
                "\n Data Type of myNum is : " + grade.GetType());
            dynamic myDynamic = 15;
            Console.WriteLine("Value stored in myDynamic is : " + myDynamic +
                "\n Data Type of myNum is : " + myDynamic.GetType());
            myDynamic = "I am Sam";
            Console.WriteLine("Value stored in myDynamic is : " + myDynamic +
                "\n Data Type of myNum is : " + myDynamic.GetType());
            myDynamic = 'A';
            Console.WriteLine("Value stored in myDynamic is : " + myDynamic +
                "\n Data Type of myNum is : " + myDynamic.GetType());
            */
            /*
            try
            {
                double num1, num2, result;
                Console.WriteLine("Enter First Number");
                num1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter Second Number");
                num2 = double.Parse(Console.ReadLine());
                result = num1 / num2;
                Console.WriteLine($"Result after dividing" +
                    $" {num1} by {num2} is = \t {result}");
            }
            catch (Exception ex) { Console.WriteLine("Error!! "+ex.Message); }
            finally { Console.ReadKey(); }
            */
            //try
            //{
            //    Console.WriteLine("Pease enter a number");
            //    string input = Console.ReadLine();
            //    if(int.TryParse(input, out int result)) {
            //        Console.WriteLine("Parsed number using TryParse is:\t" + result);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Failed to parse");
            //    }
            //}
            //catch (Exception ex) { Console.WriteLine("Error!! " + ex.Message); }
            //finally { Console.ReadKey(); }
            //    double num1, num2, result;
            //    Console.WriteLine("Enter First Number");
            //    double.TryParse(Console.ReadLine(), out num1);
            //    Console.WriteLine("Enter Second Number");
            //    double.TryParse(Console.ReadLine(), out num2);
            //    result = num1 / num2;
            //Console.WriteLine($"Result after dividing" +
            //    $" {num1} by {num2} is = \t {result}");
            //Console.ReadKey();
            try
            {
                string input = null;
                int tryParsedInt;
                int.TryParse(input, out tryParsedInt);
                //int parsedNumber = int.Parse(input);
                //Console.WriteLine("Parsed number is:\t" + parsedNumber);
                int convertedNumber = Convert.ToInt32(input);
                Console.WriteLine("Convert number is:\t" + convertedNumber);
                Console.WriteLine("TryParsed number is:\t" + tryParsedInt);
            }
            catch (Exception ex) { Console.WriteLine("Error!! " + ex.Message); }
            finally { Console.ReadKey(); }
        }
    }
}
