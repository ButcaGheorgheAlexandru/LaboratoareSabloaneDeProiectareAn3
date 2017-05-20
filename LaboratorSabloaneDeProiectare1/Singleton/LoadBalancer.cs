using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonApplication
{
 
          public class LoadBalancer

          { 

              private static  LoadBalancer instance;
              private static object syncRoot = new Object();
              Random radom = new Random();
              public LoadBalancer() { }

              public static LoadBalancer Instance
              {
                  get
                  {
                      if (instance == null)
                      {
                          lock (syncRoot)
                          {
                              instance = new LoadBalancer();
                          }
                      }
                      return instance;
                  }
              }


              private bool randomAcces = true; 
              private List<Server> serverList = new List<Server>
                    {
                        new Server(){ Name = "Server1",IpAddress="192.168.1.2",NumOfRequests = 0 },
                        new Server(){ Name = "Server2",IpAddress="192.168.3.4",NumOfRequests = 0},
                        new Server(){ Name = "Server3", IpAddress="192.168.1.0",NumOfRequests = 0 },
                        new Server(){ Name = "Server4",IpAddress="192.168.1.2",NumOfRequests = 0  } ,
                        new Server(){ Name = "Server5", IpAddress="192.168.8.2",NumOfRequests = 0 },
                        new Server(){ Name = "Server6",IpAddress="192.168.1.2",NumOfRequests = 0},
                        new Server(){ Name = "Server7",IpAddress="192.168.1.2",NumOfRequests = 0},
                        new Server(){ Name = "Server8",IpAddress="192.168.1.2",NumOfRequests = 0},
                        new Server(){ Name = "Server9", IpAddress="192.168.1.3",NumOfRequests = 0  },
                        new Server(){ Name = "Server10",IpAddress="192.168.1.2",NumOfRequests = 0  }
                    };



              public List<Server> ServerList
              { get { return serverList; } }
                           

              

          public void processRequest(){

              Server server = null;
              if (randomAcces == true)
              {    
                  int randServerIndex = getRand();
                  server = serverList[randServerIndex];
                 
                 // serverList[randServerIndex].processRequest();
              }
              else if (randomAcces == false)
              {   
                 
                  int comp = int.MaxValue;
                  int min;
                  foreach (Server s in serverList)
                  {
                      if (s.NumOfRequests < comp)
                      {
                          comp  = s.NumOfRequests;
                          server = s;
                        
                      }

                      
                 }
            
                
              }


              server.processRequest();
          
          
          }


         private int getRand(){     
            
            int randInt = radom.Next(0, 9);
            return randInt;
         }


          public void generateRaport()
                 {
                     foreach (Server s in serverList)
                     {
                         Console.WriteLine("Numele serverului :  " + s.Name);
                         Console.WriteLine("Ip-ul serverului : " + s.IpAddress);
                         Console.WriteLine("Nr requests  : " + s.NumOfRequests);
                         Console.WriteLine("Min time : " + s.MinTime);
                         Console.WriteLine("Max time :  " + s.MaxTime);
                         Console.WriteLine("Average time : " + s.AverageTime);
                         Console.WriteLine("Total time : " + s.TotalTime);
                         Console.WriteLine();
                        
                     }
                 }

      

              //class
          }

          /* 
           * private static object syncRoot = new Object();
           * public static LoadBalancer Instance
                {
                    get
                    {
                        if (instance == null)
                        {
                            lock (syncRoot)
                            {
                                if (instance == null)
                                    instance = new LoadBalancer();
                            }
                        }

                        return instance;
                    }
                }
                */


          //namespace    
}
