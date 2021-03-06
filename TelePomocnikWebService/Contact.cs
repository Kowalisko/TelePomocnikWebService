//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TelePomocnikWebService
{
    using System;
    using System.Collections.Generic;
    
    public partial class Contact
    {
        public Contact()
        {
            this.ContactHistory = new HashSet<ContactHistory>();
            this.MustCallInformation = new HashSet<MustCallInformation>();
            this.Event = new HashSet<Event>();
            this.Event1 = new HashSet<Event>();
        }
    
        public System.Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Job { get; set; }
        public string CommentFirst { get; set; }
        public string CommentSecond { get; set; }
        public System.DateTime DateContactAdd { get; set; }
        public Nullable<System.DateTime> DateLastContact { get; set; }
        public Nullable<System.Guid> TelemarketerId { get; set; }
        public Nullable<System.Guid> CompanyId { get; set; }
        public string ColorString { get; set; }
    
        public virtual Company Company { get; set; }
        public virtual Telemarketer Telemarketer { get; set; }
        public virtual ICollection<ContactHistory> ContactHistory { get; set; }
        public virtual ICollection<MustCallInformation> MustCallInformation { get; set; }
        public virtual ICollection<Event> Event { get; set; }
        public virtual ICollection<Event> Event1 { get; set; }
    }
}
