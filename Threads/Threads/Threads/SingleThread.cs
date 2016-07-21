using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threads
{
    public class SingleThread
    {
       public  void CreateThread()
        {
           // Thread t = new Thread(WriteY); // Kick off a new thread
           Thread t = new Thread(new ThreadStart(WriteY));
            t.Start();
            for (int i = 0; i < 1000; i++)
                Console.Write("x");

        }
        void WriteY()
        {
            for (int i = 0; i < 2000; i++) 
                Console.Write("y");
        }

        public void CreateThreadAndJoin()
        {
            // Thread t = new Thread(WriteY); // Kick off a new thread
            Thread t = new Thread(new ThreadStart(WriteY));
            t.Start();
            t.Join();
            for (int i = 0; i < 1000; i++)
                Console.Write("x");

        }


    }
}
