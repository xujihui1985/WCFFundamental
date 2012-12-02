using System;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EvalServiceLibrary
{
   [DataContract(Namespace = "http://test/evals")]
   public class Eval
   {
      [DataMember]
      public string Id { get; set; }
      [DataMember]
      public string Submitter { get; set; }
      [DataMember]
      public string Comments { get; set; }
      [DataMember]
      public DateTime TimeSubmitted { get; set; }
   }
}
