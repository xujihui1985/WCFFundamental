using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.EvalService;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
            var client = new EvalServiceClient("BasicHttpBinding_IEvalService");
            client.SubmitEval(new Eval
                                 {
                                     Comments = "This came from code",
                                     Submitter = "Sean",
                                     TimeSubmitted = DateTime.Now
                                 });
            Console.WriteLine("Save success");
            Console.WriteLine("dfffsdf");
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
