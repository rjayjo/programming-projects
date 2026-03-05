using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akses.DataModel
{
    public class AppDbContext : IdentityDbContext //Script-DbContext for cohesion
    {
        public DbSet<Customer> CustomersINV { get; set; }

        public DbSet<MedicineInventory> MedicineINV { get; set; }

        public DbSet<MedicineRequest>? MedicineRequestTbl { get; set; }

        public DbSet<Expenses>? ExpensesTbl { get; set; }

        public DbSet<Sales>? SalesTbl { get; set; }

        public DbSet<OrderHeader> OrderHeadersINV { get; set; }
        public DbSet<OrderDetail> OrderDetailsINV { get; set; }


        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("SERVER=LAPTOP-0FS0B40Q\\SQLEXPRESS;DATABASE=AksesDb;Integrated Security = SSPI;TRUSTSERVERCERTIFICATE=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<OrderDetail>()
                 .HasOne(p => p.OrderHeader)
                 .WithMany(p => p.OrderDetails)
                 .HasForeignKey(p => p.OrderHeaderId)
                 .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<OrderHeader>()
                .HasOne(p => p.Customer)
                .WithMany(p => p.OrderHeaders)
                .HasForeignKey(p => p.CustomerId)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<OrderDetail>()
                .HasOne(p => p.MedicineInventory)
                .WithMany(p => p.OrderDetails)
                .HasForeignKey(p => p.MedicineId)
                .OnDelete(DeleteBehavior.Restrict);
        }




        public void AccessedMedicineRequest()
        {
            var currentTime = DateTime.Now;
            foreach (var item in ChangeTracker.Entries()
                .Where(e => e.State == EntityState.Added && e.Entity is MedicineRequest))
            {
                var entity = item.Entity as MedicineRequest;
                entity.DateRequested = currentTime;
            }

        }

        public void DateSold()
        {
            var currentTime = DateTime.Now;
            foreach (var item in ChangeTracker.Entries()
                .Where(e => e.State == EntityState.Added && e.Entity is Sales))
            {
                var entity = item.Entity as Sales;
                entity.DatePurchased = currentTime;
            }

        }

    }
}
