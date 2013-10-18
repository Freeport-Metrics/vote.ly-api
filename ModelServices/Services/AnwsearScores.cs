using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelServices.Contracts;

namespace ModelServices.DataAccess
{
    public partial class AnswearScore
    {
        public static AnswearScore GetById( int answearScoreId )
        {
            var voteLyEntities = new voteLyEntities();
            return voteLyEntities.AnswearScores.FirstOrDefault( x => x.Id == answearScoreId );
        }

        public static bool CheckExistingVote( int answearId, string voterId, string sessionId )
        {
            var voteLyEntities = new voteLyEntities();
            List<AnswearScore> scores = voteLyEntities.AnswearScores.Where( x => (x.AnswearId == answearId && x.VoterId == voterId && x.SessionId == sessionId ) ).ToList();
            if( scores != null && scores.Count() > 0 )
                return true;

            return false;
        }

        public static double GetScoreCount( int answearId, string sessionId )
        {
            var voteLyEntities = new voteLyEntities();
            int count = voteLyEntities.AnswearScores.Where( x => x.AnswearId == answearId  ).ToList().Count();
            return (double)count;
        }

        public static AnswearScore AddVoteScore( int answearId, string voterId, string sessionId )
        {
            if( !Answear.CheckIfAnswearExist( answearId ) )
                return null;

            if(CheckExistingVote(answearId, voterId, sessionId))
                return null;

            var voteLyEntities = new voteLyEntities();
            
            AnswearScore score = new AnswearScore();
            score.SessionId = sessionId;
            score.VoterId = voterId;
            score.AnswearId = answearId;

            voteLyEntities.AnswearScores.Add(score);

            voteLyEntities.SaveChanges();

            return score;
        }

        public static VotingResultsContract GetVotingResults( int votingId, string sessionId )
        {
            VotingResultsContract results = new VotingResultsContract();

            List<QuestionWithAnswear> qwaList = new List<QuestionWithAnswear>();
            
            List<QuestionContract> questions = Question.GetByVotingId( votingId ).Select( x => x.ToContract() ).ToList();

            foreach( var question in questions )
            {
                QuestionWithAnswear qwa = new QuestionWithAnswear();
                qwa.Question = question;
                
                List<AnswearScoresContract> scores = new List<AnswearScoresContract>();

                List<AnswearContract> answears = Answear.GetByQuestionId(question.Id).Select( x=>x.ToContract()).ToList();
                foreach(var answear in answears){
                    AnswearScoresContract asc = new AnswearScoresContract();
                    asc.Anwsear = answear;
                    asc.Score = GetScoreCount(answear.Id, sessionId);
                    scores.Add(asc);
                }

                qwa.Scores = scores;
                qwaList.Add( qwa );
            }

            results.Questions = qwaList;

            return results;
        }
    }
}
