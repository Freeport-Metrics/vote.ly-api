using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ModelServices.Contracts
{
    [DataContract]
    public class QuestionContract
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public int? VotingId { get; set; }

        [DataMember]
        public string Type { get; set; }

        [DataMember]
        public string Value { get; set; }

        [DataMember]
        public Nullable<int> OrderSort { get; set; }
    }
}
