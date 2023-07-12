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
                Console.WriteLine("TryParsed number multiplied by 5 is:\t" 
                    + tryParsedInt * 5);
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
                Console.WriteLine("Convert number multiplied by 5 is:\t" +
                    convertedNumber * 5);
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
                Console.WriteLine("Parsed number multiplied by 5 is:\t" +
                    parsedNumber * 5);
            }
            catch (Exception ex) { Console.WriteLine("Error!! " + ex.Message); }
            finally { Console.WriteLine("\n"); }

            try
            {
                string input2;
                Console.WriteLine("Enter date");
                input2 = Console.ReadLine();
                DateTime convertedDate = Convert.ToDateTime(input2);
                Console.WriteLine("Converted Date is:\t" + convertedDate);
                DateTime lastMonth = convertedDate.AddMonths(-1);
                Console.WriteLine("Converted month after reducing a month is:\t" +
                    lastMonth);
            }
            catch (Exception ex) { Console.WriteLine("Error!! " + ex.Message); }
            finally { Console.WriteLine("\n"); }

            try
            {
                Console.WriteLine("Input Time in hh:mm:ss \n");
                string timeString = Console.ReadLine();
                TimeSpan timeSpan = TimeSpan.Parse(timeString);
                Console.WriteLine("Converted TimeSpan is "+timeSpan);
                TimeSpan past2hours = new TimeSpan(2, 0, 0);
                Console.WriteLine("Converted time after reducing 2 hours is:\t" +
                    (timeSpan-past2hours));
            }
            catch (Exception ex) { Console.WriteLine("Error!! " + ex.Message); }
            finally { Console.ReadKey(); }
        }
    }
}
