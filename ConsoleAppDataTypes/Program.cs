using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            byte myByte = 12;
            sbyte mySbyte = 1;
            short myShort = 12;
            int myInt = 12;
            long myLong = 12;
            double myDouble = 12.5;
            float myFloat = 15.5F;
            decimal myDecimal = 12;
            char myChar = 'A';
            string myString = "Our String";
            DateTime myDateTime = new DateTime(day:12, month:05, year:2023);
            bool myBool = false;
            */
            try
            {
                byte ourByte;
                Console.WriteLine("Enter a number");
                ourByte = Convert.ToByte(Console.ReadLine());
                Console.WriteLine("Number is " + ourByte);
            }
            catch(FormatException ex) {
                Console.WriteLine("Format Exception: " + ex.Message);
            }
            catch(OverflowException ex)
            {
                Console.WriteLine("Overflow Exception" + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Errorr!!" + ex.Message);
            }
            finally { Console.WriteLine("End of Program");
                Console.ReadKey();
            }
            
        }
    }
}
