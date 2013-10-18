using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelServices.Contracts;

namespace ModelServices.DataAccess
{
    public partial class Question
    {
        public static Question GetById( int questionId )
        {
            var voteLyEntities = new voteLyEntities();
            return voteLyEntities.Questions.FirstOrDefault( x => x.Id == questionId );
        }

        public static List<Question> GetByVotingId( int votingId )
        {
            var voteLyEntities = new voteLyEntities();
            return voteLyEntities.Questions.Where( x => x.VotingId == votingId ).OrderBy(x=> x.OrderSort).ToList();
        }

        public QuestionContract ToContract()
        {
            return new QuestionContract()
            {
                Id = this.Id,
                Type = this.Type,
                Value = this.Value,
                OrderSort = this.OrderSort,
                VotingId = this.VotingId
            };
        }
    }
}
