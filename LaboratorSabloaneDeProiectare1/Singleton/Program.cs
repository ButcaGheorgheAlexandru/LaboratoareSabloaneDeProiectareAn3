using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            LoadBalancer instance =  LoadBalancer.Instance;

            for (int i = 0; i < 100; i++)
            {
                instance.processRequest();
              
            }
            instance.generateRaport();
        }
    }
}
