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
    
    public partial class CabinetProcedures
    {
        public int Cabinet_ID { get; set; }
        public int ProcedureType_ID { get; set; }
        public Nullable<System.DateTime> DeleteTime { get; set; }
    
        public virtual Cabinets Cabinets { get; set; }
        public virtual TypeOfProcedures TypeOfProcedures { get; set; }
    }
}
