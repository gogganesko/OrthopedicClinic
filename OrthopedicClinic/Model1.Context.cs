﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ClinicEntities1 : DbContext
    {
        public ClinicEntities1()
            : base("name=ClinicEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CabinetProcedures> CabinetProcedures { get; set; }
        public virtual DbSet<Cabinets> Cabinets { get; set; }
        public virtual DbSet<Diagnosises> Diagnosises { get; set; }
        public virtual DbSet<DiagnosisesProcedures> DiagnosisesProcedures { get; set; }
        public virtual DbSet<FilesProcedures> FilesProcedures { get; set; }
        public virtual DbSet<KindOfProcedures> KindOfProcedures { get; set; }
        public virtual DbSet<Patients> Patients { get; set; }
        public virtual DbSet<Pays> Pays { get; set; }
        public virtual DbSet<Procedures> Procedures { get; set; }
        public virtual DbSet<TreatmentPlanDagnosises> TreatmentPlanDagnosises { get; set; }
        public virtual DbSet<TreatmentPlanProcedures> TreatmentPlanProcedures { get; set; }
        public virtual DbSet<TreatmentPlans> TreatmentPlans { get; set; }
        public virtual DbSet<TypeOfProcedures> TypeOfProcedures { get; set; }
        public virtual DbSet<VisitProcedures> VisitProcedures { get; set; }
        public virtual DbSet<Visits> Visits { get; set; }
        public virtual DbSet<VisitWorkers> VisitWorkers { get; set; }
        public virtual DbSet<WorkerProcedures> WorkerProcedures { get; set; }
        public virtual DbSet<Workers> Workers { get; set; }
        public virtual DbSet<WorkerTypeOfProcedures> WorkerTypeOfProcedures { get; set; }
        public virtual DbSet<WorkerWorkingHours> WorkerWorkingHours { get; set; }
        public virtual DbSet<WorkingHours> WorkingHours { get; set; }
    }
}
