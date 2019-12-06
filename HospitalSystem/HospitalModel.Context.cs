namespace HospitalSystem
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class HospitalSystemEntities : DbContext
    {
        public HospitalSystemEntities()
            : base("name=HospitalSystemEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Appoinment> Appoinments { get; set; }
        public virtual DbSet<Doctor> Doctors { get; set; }
        public virtual DbSet<MedicationList> MedicationLists { get; set; }
        public virtual DbSet<Message> Messages { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<Test> Tests { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}
