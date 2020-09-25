using Euler.Helpers;
using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler.Models
{
    public class EulerProblem : ViewModelBase
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
            Print("Hey implement the solution genius!");
        }

        public virtual void Print(string message)
        {
            MessengerInstance.Send<string>(message, MessengerTokens.Log);
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
