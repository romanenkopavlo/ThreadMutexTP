using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadTD
{
    public class Work
    {
        public Mutex mut;
        public StreamWriter sw;
        public Random random;

        public void Run() {
            for (int i = 0; i < 10; i++)
            {
                mut.WaitOne();
                Thread.Sleep(random.Next(0, 10));
                sw.WriteLine("Ligne " + (i + 1));
                mut.ReleaseMutex();
            }
        }
    }
}
