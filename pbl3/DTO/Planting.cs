//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace pbl3.DTO
{
    using System;
    using System.Collections.Generic;
    
    public partial class Planting
    {
        public int TreeID { get; set; }
        public Nullable<System.DateTime> DatePlanted { get; set; }
        public Nullable<int> NumberPlanted { get; set; }
        public string UserName { get; set; }
        public Nullable<System.DateTime> Water { get; set; }
        public Nullable<System.DateTime> Fertilize { get; set; }
    
        public virtual Account Account { get; set; }
        public virtual Tree Tree { get; set; }
    }
}