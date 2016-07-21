using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threads
{
    public class ThreadPools
    {
        static string MyDownloadString(string uri)
        {
            string str;
            using (var wc = new System.Net.WebClient())
                str = wc.DownloadString(uri);
            return str;
        }
        public static string PoolAdd()
        {
            Task.Factory.StartNew(Go);
           
            Task<string> task = Task.Factory.StartNew<string>
                (() => MyDownloadString("http://www.linqpad.net"));
            Task.Factory.StartNew(Go);
           
            return task.Result;
        }

        static void Go()
        {
            Console.WriteLine("Hello from the thread pool!");
        }
        static void MyCallback(IAsyncResult ar)
        {
            int a = 0;

        }
        public static void Asyncs()
        {
            Func<string, int> method = Work;
            AsyncCallback a = MyCallback;
            IAsyncResult cookie = method.BeginInvoke("test", a, null);
            
            Go();
            Go();
            int result = method.EndInvoke(cookie);
            Console.WriteLine("String length is: " + result);
           
        }

        static int Work(string s)
        {
            Console.WriteLine("In Work method  ");
            return s.Length;
        }
    }
}
