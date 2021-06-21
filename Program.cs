/*  
Ahmad Al Saadi, 06/18/2021 - 06/21/2021
*/
using System;
using System.Diagnostics;
using System.Threading;
namespace CASA_Interview
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch1 = new Stopwatch();
            stopwatch1.Start();
            String keyboard;
            Console.WriteLine("Enter a number: ");
            keyboard = Console.ReadLine();
            stopwatch1.Stop();
            TimeSpan ts1 = stopwatch1.Elapsed;
            Console.WriteLine("Elapsed Time for Program start and gathering user input is {0:00}:{1:00}:{2:00}.{3}", ts1.Hours, ts1.Minutes, ts1.Seconds, ts1.Milliseconds);

            Stopwatch stopwatch2 = new Stopwatch();
            stopwatch2.Start();
            //we suspend previous thread to allow another thread to complete the remainder of the program
            //this way we measure elapsed time in a more granular manner, divided between Program start and gathering 
            //user input vs creating a program instance, typecasting string input to integer, calling IsPrime method 
            //and outputting result.
            Thread.Sleep(1000);
            Program program = new Program();
            int intKeyboard = Convert.ToInt32(keyboard);
            bool result = program.IsPrime(intKeyboard);
            Console.WriteLine(result);
            stopwatch2.Stop();
            TimeSpan ts2 = stopwatch2.Elapsed;

            Console.WriteLine("Elapsed Time (including thread sleep) to create program instance, typecast user input, and call " +
             "IsPrime method and output to console is {0:00}:{1:00}:{2:00}.{3}", ts2.Hours, ts2.Minutes, ts2.Seconds, ts2.Milliseconds);
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

