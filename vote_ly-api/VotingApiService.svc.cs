using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Web.Mvc;
using ModelServices.Contracts;
using ModelServices.DataAccess;

namespace vote_ly_api
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "VotingApiService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select VotingApiService.svc or VotingApiService.svc.cs at the Solution Explorer and start debugging.
    public class VotingApiService : IVotingApiService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ModelServices.Contracts.VotingContract GetVoting( int votingId )
        {
            Voting voting = Voting.GetById( votingId );
            if( voting != null )
                return voting.ToContract();

            return null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public List<ModelServices.Contracts.VotingContract> GetVotings( int userId )
        {
            List<VotingContract> votings = Voting.GetVotingsByUser( userId ).Select( x => x.ToContract() ).ToList();
            return votings;
        }


        public QuestionContract GetQuestion( int questionId )
        {
            Question question = Question.GetById( questionId );
            if( question != null )
                return question.ToContract();

            return null;
        }

        public List<QuestionContract> GetQuestions( int votingId )
        {
            List<QuestionContract> questions = Question.GetByVotingId( votingId ).Select( x => x.ToContract() ).ToList();
            return questions;
        }

        public AnswearContract GetAnswear( int answearId )
        {
            Answear answear = Answear.GetById( answearId );
            if( answear != null )
                return answear.ToContract();

            return null;
        }

        public List<AnswearContract> GetAnswears( int questionId )
        {
            List<AnswearContract> questions = Answear.GetByQuestionId( questionId ).Select( x => x.ToContract() ).ToList();
            return questions;
        }

        public bool SubmitVote( int answearId, string voterId, string sessionId )
        {
            AnswearScore score = AnswearScore.AddVoteScore( answearId, voterId, sessionId );
            
            if(score !=null)
                return true;
            
            return false; 
        }

        public VotingResultsContract GetResults( int votingId, string sessionId )
        {
            return AnswearScore.GetVotingResults(votingId, sessionId);
        }
    }
}
