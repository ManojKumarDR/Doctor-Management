using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DoctorSampleApp.Models
{
    public partial class ManojkumarDRContext : DbContext
    {
        public ManojkumarDRContext()
        {
        }

        public ManojkumarDRContext(DbContextOptions<ManojkumarDRContext> options)
            : base(options)
        {
        }

       
        public virtual DbSet<DoctorTable> DoctorTable { get; set; }
        
       

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=W-H44PY03-0;Database=Manojkumar D R;User ID=SA;Password=admin");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            

            

       

            modelBuilder.Entity<DoctorTable>(entity =>
            {
                entity.HasKey(e => e.DoctorId);
            });


            
           
           
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
