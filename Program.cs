using System;

namespace CASA_Interview
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            // Boolean result = program.IsPrime(num);
            bool result = program.IsPrime(6);
            Console.WriteLine(result);
        }
        public bool IsPrime(int n)
        {
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
