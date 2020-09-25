using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler.Models
{
    public class EulerProblem
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public EulerProblem()
        {
            Name = "Euler problem base";
            Description = "Euler problem base class";
        }
        public virtual void SolveProblem()
        { 
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
