using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweetstakes1.Stack
{
    public class Stack : ISweepstakesManager
    {
        Stack<Sweepstakes> stack;

        public Stack()
        {
            stack = new Stack<Sweepstakes>();
        }
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {

        }
        public Sweepstakes GetSweepstakes()
        {

        }
    }
}
