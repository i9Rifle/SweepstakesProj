using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweetstakes1.Queue
{
    public class Queue : ISweepstakesManager
    {
        Queue<Sweepstakes> queue;

        public Queue()
        {
            queue = new Queue<Sweepstakes>();
        }
        public Sweepstakes GetSweepstakes()
        {
            return queue.Dequeue();
        }
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            queue.Enqueue(sweepstakes);
        }
    }
}
