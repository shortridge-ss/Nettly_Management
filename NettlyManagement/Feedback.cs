//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NettlyManagement
{
    using System;
    using System.Collections.Generic;
    
    public partial class Feedback
    {
        public int FeedbackID { get; set; }
        public Nullable<int> UserID { get; set; }
        public string Comments { get; set; }
        public Nullable<int> Rating { get; set; }
        public Nullable<System.DateTime> DateSubmitted { get; set; }
        public Nullable<int> RatingOptionID { get; set; }
    
        public virtual User User { get; set; }
        public virtual RatingOption RatingOption { get; set; }
    }
}
