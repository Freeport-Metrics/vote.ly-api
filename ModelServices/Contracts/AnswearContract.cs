using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ModelServices.Contracts
{
    [DataContract]
    public class AnswearContract
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public int? QuestionId { get; set; }

        [DataMember]
        public string Value { get; set; }
        
        [DataMember]
        public int? OrderSort { get; set; }
    }
}
