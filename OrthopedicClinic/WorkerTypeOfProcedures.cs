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
    
    public partial class WorkerTypeOfProcedures
    {
        public int Worker_ID { get; set; }
        public int TypeOfProcedure_ID { get; set; }
        public Nullable<System.DateTime> DeleteTime { get; set; }
    
        public virtual TypeOfProcedures TypeOfProcedures { get; set; }
        public virtual Workers Workers { get; set; }
    }
}
