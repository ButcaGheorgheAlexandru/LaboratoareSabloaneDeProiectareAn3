using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonApplication
{
    public class Server
    {
        public String Name { get; set; }
        public String IpAddress { get; set; }
        public int NumOfRequests { get; set; }
        public int MinTime  { get; set; }
        public int MaxTime { get; set; }
        public int TotalTime { get; set; }
        public int AverageTime { get; set; }    
        
        public Server(){
            MinTime = int.MaxValue;
            MaxTime = int.MinValue;
        }
        


        public void processRequest()
        {
            

            int processTime = getRand();
            NumOfRequests++;
            if (processTime > MaxTime)
            {
                MaxTime = processTime;
            }
            else if (processTime < MinTime)
            {
                MinTime = processTime;
            }

            TotalTime += processTime;
            AverageTime = TotalTime / NumOfRequests;
        }


        private int getRand()
        {
            Random radom = new Random();
            int randInt = radom.Next(500, 1000);
            return randInt;
        }



    }
}
