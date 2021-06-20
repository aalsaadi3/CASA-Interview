using System;

namespace CASA_Interview
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            Number number = new Number()
            // Boolean result = program.IsPrime(num);


        }

    }

    class Number
    {
        bool _prime = true;
        int num;
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
        }
    }
}
