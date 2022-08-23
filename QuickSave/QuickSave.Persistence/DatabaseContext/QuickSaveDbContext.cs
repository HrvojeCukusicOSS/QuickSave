using QuickSave.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace QuickSave.Persistence.DatabseContext
{
    public class QuickSaveDbContext : Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityDbContext<User>
    {
        public QuickSaveDbContext(DbContextOptions<QuickSaveDbContext> options) : base(options)
        {

        }

        public override int SaveChanges()
        {
            var entities = ChangeTracker.Entries().Where(x => x.Entity is BaseEntity && (x.State == EntityState.Added || x.State == EntityState.Modified));

            foreach (var entity in entities)
            {
                if (entity.State == EntityState.Added)
                {
                    ((BaseEntity)entity.Entity).CreatedAt = DateTime.UtcNow;
                }

                ((BaseEntity)entity.Entity).UpdatedAt = DateTime.UtcNow;
            }

            return base.SaveChanges();
        }
        public DbSet<Submission> Submissions { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Part> Parts { get; set; }
        public DbSet<Repairment> Repairments { get; set; }
        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return await base.SaveChangesAsync(cancellationToken);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(QuickSaveDbContext).Assembly);
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>()
                .HasMany(u => u.Submissions)
                .WithOne(d => d.Costumer);
            modelBuilder.Entity<User>()
                .HasMany(u => u.Invoices)
                .WithOne(i => i.Costumer);
            modelBuilder.Entity<Submission>()
                .HasOne(s => s.Repairment)
                .WithOne(r => r.Submission)
                .HasForeignKey<Repairment>(r => r.SubmissionId);
            modelBuilder.Entity<Invoice>()
                .HasOne(i => i.Repairment)
                .WithOne(r => r.Invoice)
                .HasForeignKey<Repairment>(r => r.InvoiceId);
            modelBuilder.Entity<Repairment>()
                .HasMany(r => r.Parts)
                .WithOne(p => p.Repairment);
        }

    }
}
