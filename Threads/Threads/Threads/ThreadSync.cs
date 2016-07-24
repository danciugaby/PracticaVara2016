using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threads
{
    public class ThreadSync
    {
        static readonly object _locker = new object();
        static int _val1, _val2;
        static decimal _savingsBalance, _checkBalance;

        static void Go()
        {

            Monitor.Enter(_locker);
            try
            {
                Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
                if (_val2 != 0)
                    Console.WriteLine(_val1 / _val2);
               // _val2 = 0;
            }
            finally
            {
               Monitor.Exit(_locker);
            }
        }

        public static void ExampleMonitor()
        {
            List<Thread> threads = new List<Thread>();
            for (int i = 0; i < 5; i++)
            {
                threads.Add(new Thread(Go));
            }
            for (int i = 0; i < 5; i++)
            {

                _val1 = i * i;
                _val2 = i;
                threads[i].Start();

            }
        }

        

        delegate void TransferDelegate(object a);
        public static void Examplelocker()
        {
            _savingsBalance = 10;
            _checkBalance = 20;
            TransferDelegate d = ThreadSync.Transfer;
            ParameterizedThreadStart pm = new ParameterizedThreadStart(d);
            new Thread(pm).Start(20);
            new Thread(pm).Start(20);
            new Thread(pm).Start(20);
        }

        public static decimal GetBankFee()
        {
            return 10;
        }
        static void Transfer(object a)
        {
            lock (_locker)
            {
                decimal amount = Decimal.Parse(a.ToString());
                _savingsBalance += amount;
                _checkBalance -= amount + GetBankFee();
                Console.WriteLine(_savingsBalance + " " + _checkBalance);

            }
        }
    }
}
