using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;
using EvalServiceLibrary;

namespace ClientCallRestful
{
   class Program
   {
      static void Main(string[] args)
      {
         Console.ReadLine();
         //var client = new EvalServiceClient("BasicHttpBinding_IEvalService");

         WebChannelFactory<IEvalService> cf = 
            new WebChannelFactory<IEvalService>(new Uri("http://localhost:8080/evalservice"));

         IEvalService client = cf.CreateChannel();

         client.SubmitEval(new Eval
         {
            Comments = "This came from code",
            Submitter = "Sean",
            TimeSubmitted = DateTime.Now
         });
         Console.WriteLine("Save success");
         Console.WriteLine("Load Evals");
         var evals = client.GetEvals();
         foreach (var eval in evals)
         {
            Console.WriteLine(eval.Comments);
         }
         Console.WriteLine("End load Evals");
         Console.Read();
      }
   }
}
