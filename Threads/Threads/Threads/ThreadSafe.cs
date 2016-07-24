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

        public static bool Done
        {
            get
            {
                return done;
            }

            set
            {
                done = value;
            }
        }

        public static void Go()
        {
            
            lock (locker)
            {
                Console.WriteLine(Thread.CurrentThread.Name + " Trying to access");
               
            }
            lock (locker)
            {
              
                if (!Done)
                {
                   
                    Console.WriteLine(Thread.CurrentThread.Name + " Done");
                    //done = true;
                }
                ///...
                ///
            }
            //...
        }
    }
}
