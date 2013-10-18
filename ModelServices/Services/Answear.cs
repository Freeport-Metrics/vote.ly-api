using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelServices.Contracts;


namespace ModelServices.DataAccess
{
    public partial class Answear
    {
        public static Answear GetById( int answearId )
        {
            var voteLyEntities = new voteLyEntities();
            return voteLyEntities.Answears.FirstOrDefault( x => x.Id == answearId );
        }

        public static bool CheckIfAnswearExist( int answearId )
        {
            if(GetById( answearId )!=null)
                return true;
            return false;
        }

        public static List<Answear> GetByQuestionId( int questionId )
        {
            var voteLyEntities = new voteLyEntities();
            return voteLyEntities.Answears.Where( x => x.QuestionId == questionId ).OrderBy( x => x.OrderSort ).ToList();
        }

        public AnswearContract ToContract()
        {
            return new AnswearContract()
            {
                Id = this.Id,
                QuestionId = this.QuestionId,
                Value = this.Value,
                OrderSort = this.OrderSort
            };
        }
    }
}
