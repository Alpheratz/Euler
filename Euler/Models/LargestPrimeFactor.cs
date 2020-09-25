using Euler.Helpers;
using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler.Models
{
    public class LargestPrimeFactor : EulerProblem
    {
       

        public LargestPrimeFactor()
        {
            Name = "3 Largest prime factor";
            Description = $"The prime factors of 13195 are 5, 7, 13 and 29.{Environment.NewLine}" +
                "What is the largest prime factor of the number 600851475143 ? ";
        }
        public override void SolveProblem()
        {
            long n = 600851475143;
            long maxPrime = -1;
            while (n % 2 == 0)
            {
                maxPrime = 2;
                n >>= 1; // equivalent to n /= 2 
            }
            for (int i = 3; i <= Math.Sqrt(n); i += 2)
            {
                while (n % i == 0)
                {
                    maxPrime = i;
                    n = n / i;
                }
            }

            if (n > 2)
                maxPrime = n;


            Print("Start");
            Print($"Result: {maxPrime}");
        }

       
    }
}
