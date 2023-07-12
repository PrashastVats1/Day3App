using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string input;
                Console.WriteLine("Enter number");
                input = Console.ReadLine();
                int tryParsedInt;
                int.TryParse(input, out tryParsedInt);
                Console.WriteLine("TryParsed number is:\t" + tryParsedInt);
            }
            catch (Exception ex) { Console.WriteLine("Error!! " + ex.Message); }
            finally { Console.WriteLine("\n"); ; }

            try
            {
                string input1;
                Console.WriteLine("Enter number");
                input1 = Console.ReadLine();
                double convertedNumber = Convert.ToDouble(input1);
                Console.WriteLine("Convert number is:\t" + convertedNumber);
            }
            catch (Exception ex) { Console.WriteLine("Error!! " + ex.Message); }
            finally { Console.WriteLine("\n"); }

            try
            {
                string input2;
                Console.WriteLine("Enter number");
                input2 = Console.ReadLine();
                decimal parsedNumber = decimal.Parse(input2);
                Console.WriteLine("Parsed number is:\t" + parsedNumber);
            }
            catch (Exception ex) { Console.WriteLine("Error!! " + ex.Message); }
            finally { Console.ReadKey(); }
        }
    }
}
