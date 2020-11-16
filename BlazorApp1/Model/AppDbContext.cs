using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Diplom.Shared.Model
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<ReportForm> ReportForms { get; set; }
        public DbSet<ReportPeriod> ReportPeriods { get; set; }
        public DbSet<ReportFormHead> ReportFormHeads { get; set; }
        public DbSet<ReportFormData> ReportFormDatas { get; set; }
        public DbSet<Organisation> Organisations { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }

        public AppDbContext()
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasKey(u => u.Username);
            modelBuilder.Entity<Organisation>().HasKey(Organisation => Organisation.UNK);
            modelBuilder.Entity<ReportForm>().HasKey(q => new { q.FormHeadId, q.FormDataId });
            modelBuilder.Entity<ReportFormData>().HasKey(q => new { q.FormHeadId, q.OrganisationId, q.RowCode, q.ReportPeriodId });
            modelBuilder.Entity<ReportFormHead>().HasKey(q => q.Id);

        }
    }
}
