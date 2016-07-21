using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threads
{
    public class ThreadSafe
    {

        static bool done;
        static readonly object locker = new object();

      
        public static void Go()
        {
            lock (locker)
            {
                if (!done)
                {
                    Console.WriteLine(Thread.CurrentThread.Name + " Done");
                    done = true;
                }
            }
        }
    }
}
