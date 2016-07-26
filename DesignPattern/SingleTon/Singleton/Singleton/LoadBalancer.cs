using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class LoadBalancer
    {
       
        private static LoadBalancer instance;
        private List<string> servers = new List<string>();
        private Random randnom = new Random();
        private static object o = new object();

        protected LoadBalancer()
        {
          
            servers.Add("I");
            servers.Add("II");
            servers.Add("III");
            servers.Add("IV");

        }
        public void ClearAll()
        { 
            servers.Clear();
        }
        public void Populate()
        {
            servers.Add("I");
            servers.Add("II");
            servers.Add("III");
            servers.Add("IV");
        }
        public static LoadBalancer GetInstanceOfLoadBalancer()
        {
            if (instance == null)
            {
                lock(o)
                {
                    if (instance == null)
                    {
                        instance = new LoadBalancer();
                    }
                }
            }
                return instance;
        }
        public string Server
        {
            get
            {
                int r = randnom.Next(servers.Count);
                return servers[r];
            }
        }
    }

}
