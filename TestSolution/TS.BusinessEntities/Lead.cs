//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TS.BusinessEntities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Lead
    {
        public int leadId { get; set; }
        public System.Guid uniqueKey { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string make { get; set; }
        public string model { get; set; }
        public string year { get; set; }
        public string pu_city { get; set; }
        public string pu_state { get; set; }
        public string de_city { get; set; }
        public string de_state { get; set; }
        public Nullable<System.DateTime> dateAdded { get; set; }
        public Nullable<System.DateTime> moveDate { get; set; }
        public short unsubscribed { get; set; }
        public int leftReview { get; set; }
    }
}
