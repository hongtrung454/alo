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
    
    public partial class TreeLocation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TreeLocation()
        {
            this.Trees = new HashSet<Tree>();
        }
    
        public int TreeLocationID { get; set; }
        public string LocationName { get; set; }
        public string ClimateType { get; set; }
        public string SoilType { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tree> Trees { get; set; }
    }
}
