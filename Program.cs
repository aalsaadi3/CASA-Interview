/*  
Ahmad Al Saadi, 06/18/2021 - 06/21/2021
*/
using System;
using System.Diagnostics;
namespace CASA_Interview
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            String keyboard;
            Console.WriteLine("Enter a number: ");
            keyboard = Console.ReadLine();
            stopwatch.Stop();
            Console.WriteLine("Elapsed Time for Program start and gathering user input is " + stopwatch.ElapsedTicks + " ticks.");

            stopwatch.Restart();
            //we reset the stopwatch in an attempt to measure program start and input gathering separately
            //from the typecasting and calling of the IsPrime function.
           
            Program program = new Program();
            int intKeyboard = Convert.ToInt32(keyboard);
            bool result = program.IsPrime(intKeyboard);
            Console.WriteLine(result);
            stopwatch.Stop();

            Console.WriteLine("Elapsed Time to create program instance, typecast user input, and call " +
             "IsPrime method and output to console is " + stopwatch.ElapsedTicks + " ticks.");
        }
        public bool IsPrime(int n)
        {
            //Negative numbers, 0 and 1 are not prime
            if (n <= 1)
            {
                return false;
            }
            //if is even but not equal to 2 return false since its not prime
            if (n % 2 == 0 && n != 2)
            {
                return false;
            }
            //their are many non-prime numbers that are multiples of 3, 5, and 7
            //if n is a multiple of 3 or 5 or 7 and n is greater than or equal to 
            //9 than return false since it is not a prime number
            else if ((n % 3 == 0 || n % 5 == 0 || n % 7 == 0) && n >= 9)
            {
                return false;
            }
            else
            {
                //divisibility counter
                int counter = 0;
                for (int i = 1; i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        counter += 1;
                    }
                    if (counter > 2)
                    {
                        break;
                    }
                }
                if (counter == 2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}

