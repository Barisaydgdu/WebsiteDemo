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
    
    public partial class News
    {
        public int newsID { get; set; }
        public Nullable<bool> newsActivity { get; set; }
        public Nullable<int> newsQueue { get; set; }
        public string newsHeader { get; set; }
        public string newsCaption { get; set; }
        public Nullable<int> newsPostedBy { get; set; }
        public Nullable<System.DateTime> newsPostDate { get; set; }
        public string newsImage { get; set; }
    }
}
