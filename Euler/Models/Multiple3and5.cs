using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler.Models
{
    public class Multiple3and5 : EulerProblem
    {
        public Multiple3and5()
        {
            Name = "Multiples of 3 and 5";
            Description = $"If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9.The sum of these multiples is 23." +
                $"{Environment.NewLine}Find the sum of all the multiples of 3 or 5 below 1000.";
        }

        public override void SolveProblem()
        {
            base.SolveProblem();
        }
    }
}
