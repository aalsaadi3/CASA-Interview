﻿using System;

namespace CASA_Interview
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            String keyboard;
            // Boolean result = program.IsPrime(num);
            Console.WriteLine("Enter a number: ");
            keyboard = Console.ReadLine();
            int intKeyboard = Convert.ToInt32(keyboard);
            bool result = program.IsPrime(intKeyboard);
            Console.WriteLine(result);

        }
        public bool IsPrime(int n)
        {
            //divisibility counter
            int counter = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    counter += 1;
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
