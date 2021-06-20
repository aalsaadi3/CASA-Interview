using System;

namespace CASA_Interview
{
    class Program
    {
        static void Main(string[] args)
        {
            IsPrime(5);
            //maybe have a counter to keep track of how many i values
            //yield result of n%i = 0


        }
        public Boolean IsPrime(int n)
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
        }
    }
}
