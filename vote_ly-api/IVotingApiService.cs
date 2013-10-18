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

        [OperationContract]
        [WebGet( ResponseFormat = WebMessageFormat.Json )]
        QuestionContract GetQuestion( int questionId );

        [OperationContract]
        [WebGet( ResponseFormat = WebMessageFormat.Json )]
        List<QuestionContract> GetQuestions( int votingId );

        [OperationContract]
        [WebGet( ResponseFormat = WebMessageFormat.Json )]
        AnswearContract GetAnswear( int answearId );

        [OperationContract]
        [WebGet( ResponseFormat = WebMessageFormat.Json )]
        List<AnswearContract> GetAnswears( int questionId );
       
        [OperationContract]
        //[WebInvoke( Method = "POST", BodyStyle = WebMessageBodyStyle.WrappedRequest, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json )]
        [WebGet( ResponseFormat = WebMessageFormat.Json )]
        bool SubmitVote( int answearId, string voterId, string sessionId );

        [OperationContract]
        [WebGet( ResponseFormat = WebMessageFormat.Json )]
        VotingResultsContract GetResults( int votingId, string sessionId );
       
    }
}
