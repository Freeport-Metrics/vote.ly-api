using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelServices.Contracts;

namespace ModelServices.DataAccess
{
    partial class Voting
    {
        /// <summary>
        /// Get voting by voting id
        /// </summary>
        /// <param name="id">voting id</param>
        /// <returns>voting entity for given id</returns>
        public static Voting GetById( int id )
        {
            var voteLyEntities = new voteLyEntities();
            return voteLyEntities.Votings.FirstOrDefault( x => x.Id == id );
        }

        /// <summary>
        /// Gets votings for given organiser
        /// </summary>
        /// <param name="userId">voting organiser</param>
        /// <returns>the list of votings for given organiser</returns>
        public static List<Voting> GetVotingsByUser( int userId )
        {
            var voteLyEntities = new voteLyEntities();
            return voteLyEntities.Votings.Where( x => x.UserId == userId ).ToList();
        }

        /// <summary>
        /// Converts entity to contract (json serialized object)
        /// </summary>
        /// <returns>json serializable object</returns>
        public VotingContract ToContract()
        {
            return new VotingContract()
            {
                Id = this.Id,
                Name = this.Name,
                SessionId = this.SessionId,
                UserId = this.UserId
            };
        }
    }
}
