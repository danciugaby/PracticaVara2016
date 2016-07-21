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
            singleThread.CreateThreadAndJoin();
            Console.ReadLine();
        }

        static void ThreadSafety()
        {
            Thread.CurrentThread.Name = "main";
            //new Thread(ThreadSafe.Go).Start();
            Thread worker = new Thread(ThreadSafe.Go);
            worker.Name = "worker";
            worker.Start();

            ThreadSafe.Go();
            Console.ReadLine();
        }

        static void ReadInthread()
        {
            Thread worker = new Thread(() => Console.ReadLine());
           // worker.IsBackground = true;
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
            ThreadSync.ExampleMonitor();
            ThreadSync.Examplelocker();
        }
        static void Main(string[] args)
        {

            ThreadSyncing();
            Console.ReadLine();
        }
    }
}
