using System;
using System.Collections.Generic;
using System.Globalization;
using System.ServiceModel;

namespace EvalServiceLibrary
{
   [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
   public class EvalService : IEvalService
   {
      List<Eval> evals = new List<Eval>();
      public void SubmitEval(Eval eval)
      {
         eval.Id = Guid.NewGuid().ToString();
         evals.Add(eval);
      }

      public List<Eval> GetEvals()
      {
         return evals;
      }

      public List<Eval> GetEvalsBySubmitter(string submitter)
      {
         return evals.FindAll(item => item.Submitter.Equals(submitter, StringComparison.OrdinalIgnoreCase));
      }

      public List<Eval> GetEvalsById(string id)
      {
         return evals.FindAll(item => item.Id.Equals(id.ToString(CultureInfo.InvariantCulture), StringComparison.OrdinalIgnoreCase));
      }

      public void RemoveEval(string id)
      {
         evals.Remove(evals.Find(item => item.Id.Equals(id, StringComparison.OrdinalIgnoreCase)));
      }
   }
}