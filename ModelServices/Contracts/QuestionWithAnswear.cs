using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ModelServices.Contracts
{
    [DataContract]
    public class QuestionWithAnswear
    {
        [DataMember]
        public QuestionContract Question { get; set; }

        [DataMember]
        public List<AnswearScoresContract> Scores { get; set; }

        [DataMember]
        public int VotesCount { get; set; }
    }
}
