//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ModelServices.DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class Question
    {
        public Question()
        {
            this.Answears = new HashSet<Answear>();
        }
    
        public int Id { get; set; }
        public Nullable<int> VotingId { get; set; }
        public string Type { get; set; }
        public string Value { get; set; }
    
        public virtual ICollection<Answear> Answears { get; set; }
        public virtual Voting Voting { get; set; }
    }
}