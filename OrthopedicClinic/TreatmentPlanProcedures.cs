//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OrthopedicClinic
{
    using System;
    using System.Collections.Generic;
    
    public partial class TreatmentPlanProcedures
    {
        public int TreatmentPlan_ID { get; set; }
        public int Procedure_ID { get; set; }
        public Nullable<int> Count { get; set; }
        public Nullable<System.DateTime> DeleteTime { get; set; }
    
        public virtual Procedures Procedures { get; set; }
        public virtual TreatmentPlans TreatmentPlans { get; set; }
    }
}