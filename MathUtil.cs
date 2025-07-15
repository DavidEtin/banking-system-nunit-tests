using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTProject.lab1
{
    public class MathUtil
    {

        public int SumOfPrimes(int n)
        {
            int sum = 0;
            if (n >= 2)
            {
                for (int i = 2; i <= n; i++)
                {
                    if (IsPrime(i))
                    {
                        sum += i;
                    }
                }
            }
            return sum;
        }
             
        public bool IsPrime(int num)
        {
            if (num < 2)
                return false;

            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
