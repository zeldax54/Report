//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Orders.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PMS
    {
        public PMS()
        {
            this.WorkOrder = new HashSet<WorkOrder>();
        }
    
        public int id { get; set; }
        public string ecoDispatch { get; set; }
        public Nullable<System.DateTime> etaPromise { get; set; }
        public Nullable<decimal> techNTE { get; set; }
        public Nullable<System.DateTime> dispatchDate { get; set; }
        public Nullable<System.DateTime> dateComp { get; set; }
    
        public virtual ICollection<WorkOrder> WorkOrder { get; set; }
    }
}
