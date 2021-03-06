﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using EvalServiceLibrary;

namespace EvalServiceHost
{
   class Program
   {
      static void Main(string[] args)
      {
         ServiceHost host = new ServiceHost(typeof(EvalService));
         try
         {
            host.Open();
            foreach (var endpoint in host.Description.Endpoints)
            {
               Console.WriteLine(endpoint.Address.ToString());
            }
            Console.WriteLine("EvalService is up and running");
            Console.ReadLine();
            host.Close();
         }
         catch (Exception e)
         {
            Console.WriteLine(e);
            host.Abort();
         }
         
         
        
         

      }
   }
}
