using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ModelServices.Contracts
{
    [DataContract]
    public class AnswearScoresContract
    {
        [DataMember]
        public AnswearContract Anwsear { get; set; }

        [DataMember]
        public double Score { get; set; }
    }
}
