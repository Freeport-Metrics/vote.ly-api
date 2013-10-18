using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ModelServices.Contracts
{
    [DataContract]
    public class VotingContract
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public int? UserId { get; set; }

        [DataMember]
        public string SessionId { get; set; }

        [DataMember]
        public string Name { get; set; }
    }
}
