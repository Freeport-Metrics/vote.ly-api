using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using ModelServices.Contracts;

namespace vote_ly_api
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IVotingApiService" in both code and config file together.
    [ServiceContract]
    public interface IVotingApiService
    {
        [OperationContract]
        [WebGet( ResponseFormat = WebMessageFormat.Json )]
        VotingContract GetVoting( int votingId );

        [OperationContract]
        [WebGet( ResponseFormat = WebMessageFormat.Json )]
        List<VotingContract> GetVotings( int userId );

    }
}
