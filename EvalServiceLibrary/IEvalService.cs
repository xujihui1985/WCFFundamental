using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace EvalServiceLibrary
{
   [ServiceContract]
   public interface IEvalService
   {
      [WebInvoke(Method = "POST",UriTemplate = "evals")]
      [OperationContract]
      void SubmitEval(Eval eval);

      [WebGet(UriTemplate = "eval", ResponseFormat = WebMessageFormat.Json)]
      [OperationContract]
      List<Eval> GetEvals();

      [WebGet(UriTemplate = "eval/{submitter}")]
      [OperationContract]
      List<Eval> GetEvalsBySubmitter(string submitter);

      [WebGet(UriTemplate = "eval/GetOne/{id}")]
      [OperationContract]
      List<Eval> GetEvalsById(string id);

      [WebInvoke(Method = "DELETE", UriTemplate = "eval/{id}")]
      [OperationContract]
      void RemoveEval(string id);
   }
}