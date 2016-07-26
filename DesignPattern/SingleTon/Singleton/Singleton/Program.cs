using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            LoadBalancer b1 = LoadBalancer.GetInstanceOfLoadBalancer();
            LoadBalancer b2 = LoadBalancer.GetInstanceOfLoadBalancer();
            LoadBalancer b3 = LoadBalancer.GetInstanceOfLoadBalancer();
            LoadBalancer b4 = LoadBalancer.GetInstanceOfLoadBalancer();

            if (b1==b2 && b2==b3 && b3==b4)
            {
                Console.WriteLine("same instance");
            }
            LoadBalancer b = LoadBalancer.GetInstanceOfLoadBalancer();
            for (int i = 0; i < 15; i++)
            {
                b.ClearAll();
                b.Populate();
                string server = b.Server;
                Console.WriteLine("Task goes to" + server);
            }
        }
    }
}
