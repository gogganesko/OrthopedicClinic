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
    
    public partial class Visits
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Visits()
        {
            this.VisitProcedures = new HashSet<VisitProcedures>();
            this.VisitWorkers = new HashSet<VisitWorkers>();
        }
    
        public int Id { get; set; }
        public Nullable<System.DateTime> DateStart { get; set; }
        public Nullable<System.DateTime> DateEnd { get; set; }
        public string Description { get; set; }
        public Nullable<int> Cabinet_ID { get; set; }
        public Nullable<int> Patient_ID { get; set; }
        public string Result { get; set; }
        public Nullable<int> Worker_ID { get; set; }
        public Nullable<System.DateTime> DeleteTime { get; set; }
    
        public virtual Cabinets Cabinets { get; set; }
        public virtual Patients Patients { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VisitProcedures> VisitProcedures { get; set; }
        public virtual Workers Workers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VisitWorkers> VisitWorkers { get; set; }
    }
}