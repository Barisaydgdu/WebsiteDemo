//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public int UserID { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public System.DateTime RegisterDate { get; set; }
        public Nullable<int> AuthorizationTypeID { get; set; }
        public Nullable<bool> UserActivity { get; set; }
    
        public virtual UserAuthorization UserAuthorization { get; set; }
    }
}
