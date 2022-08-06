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
    public class IdentityDbContext : Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityDbContext<User>
    {
        public IdentityDbContext(DbContextOptions<IdentityDbContext> options) : base(options)
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
        DbSet<Device> Devices { get; set; }
        DbSet<Invoice> Invoices { get; set; }
        DbSet<Part> Parts { get; set; }
        DbSet<Voucher> Vouchers { get; set; }
        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return await base.SaveChangesAsync(cancellationToken);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(IdentityDbContext).Assembly);
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>()
                .HasMany(u => u.Devices)
                .WithOne(d => d.Costumer);
            modelBuilder.Entity<User>()
                .HasMany(u => u.Vouchers)
                .WithOne(v => v.Worker);
            modelBuilder.Entity<User>()
                .HasMany(u => u.Invoices)
                .WithOne(i => i.Costumer);
            modelBuilder.Entity<Voucher>()
                .HasOne(v => v.Device)
                .WithOne(d => d.Voucher)
                .HasForeignKey<Device>(d => d.VoucherId);
            modelBuilder.Entity<Invoice>()
                .HasOne(i => i.Voucher)
                .WithOne(v => v.Inovice)
                .HasForeignKey<Voucher>(v => v.InvoiceId);
        }

    }
}
