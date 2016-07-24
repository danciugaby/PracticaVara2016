using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Threads;

namespace ThreadRunner
{
    class Program
    {
        static void SingleThread()
        {
            SingleThread singleThread = new SingleThread();
           // singleThread.CreateThread();
            singleThread.CreateThreadAndJoin();
            Console.ReadLine();
        }

        static void ThreadSafety()
        {
            Thread.CurrentThread.Name = "main";
            //new Thread(ThreadSafe.Go).Start();
            Thread worker = new Thread(ThreadSafe.Go);
            worker.Name = "worker";
            worker.Priority = ThreadPriority.Lowest;           

            Thread worker1 = new Thread(ThreadSafe.Go);
            worker1.Name = "worker1";
            worker1.Priority = ThreadPriority.Highest;
            
            
            worker1.Start();
            worker.Start();

            ThreadSafe.Go();
            
            Console.ReadLine();
            
        }
        static void f()
        {
            Console.ReadLine();
        }
        static void ReadInthread()
        {
            Thread worker = new Thread(f);
            worker.IsBackground = true;
            worker.Start();
        }

        static void ThreadPooling()
        {
           string result = ThreadPools.PoolAdd();
            
        }
        static void ThreadAsyncs()
        {
           ThreadPools.Asyncs();
        }
        static void ThreadSyncing()
        {
            //ThreadSync.ExampleMonitor();
            ThreadSync.Examplelocker();
        }
        static void ff(object o)
        {
            List<string> l =  o as List<string>;
        }
        static void Main(string[] args)
        {

            Tasks.DisplayPrimesCount();

           // ThreadSyncing();
            Thread.Sleep(2000);

            //ParameterizedThreadStart pm = new ParameterizedThreadStart(ff);
            //Thread t = new Thread(pm);
            //List<string> l = new List<string>();
            //l.Add("");
            //t.Start(l);
        }
       
    }
}
