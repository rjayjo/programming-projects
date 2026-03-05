using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bernardo___ENTPROG___OTIS1;

public class AppDbContext : IdentityDbContext

{
    public AppDbContext(DbContextOptions options) : base(options)
    {

    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("SERVER=LAPTOP-0FS0B40Q\\SQLEXPRESS;DATABASE=SuppliersINV;UID=sa;PWD=123qwe;TRUSTSERVERCERTIFICATE=true");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Supplier>().Property(p => p.CompanyName).HasColumnType("nvarchar(100)");
        modelBuilder.Entity<Supplier>().Property(p => p.Address).HasColumnType("nvarchar(200)");
        modelBuilder.Entity<Supplier>().Property(p => p.Representative).HasColumnType("nvarchar(100)");
        modelBuilder.Entity<Supplier>().Property(p => p.ContactNo).HasColumnType("nvarchar(50)");
        modelBuilder.Entity<PurchaseOrderDetail>().Property(p => p.Price).HasColumnType("decimal(18,2)");
        modelBuilder.Entity<PurchaseOrderDetail>().Property(p => p.Amount).HasColumnType("decimal(18,2)");

        modelBuilder.Entity<PurchaseOrderDetail>()
            .HasOne(p => p.PurchaseOrderHeader)
            .WithMany(p => p.PurchaseOrderDetails)
            .HasForeignKey(p => p.PurchaseOrderHeaderId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<PurchaseOrderDetail>()
           .HasOne(p => p.Product)
           .WithMany(p => p.PurchaseOrderDetails)
           .HasForeignKey(p => p.ProductId)
           .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<PurchaseOrderHeader>()
            .HasOne(p => p.Supplier)
            .WithMany(p => p.PurchaseOrderHeaders)
            .HasForeignKey(p => p.SupplierId)
            .OnDelete(DeleteBehavior.Restrict);
    }

    public DbSet<Supplier>? SuppliersINV { get; set; }

    public DbSet<Product>? ProductsINV { get; set; }

    public DbSet<PurchaseOrderDetail>? PurchaseOrderDetailsINV { get; set; }

    public DbSet<PurchaseOrderHeader>? PurchaseOrderHeadersINV { get; set; }

    public void Accessed()
    {
        var currentTime = DateTime.UtcNow;
        foreach (var item in ChangeTracker.Entries()
            .Where(e => e.State == EntityState.Added && e.Entity is Supplier))
        {
            var entity = item.Entity as Supplier;
            entity.DateAdded = currentTime;
            entity.DateModified = currentTime;
        }

        foreach (var item in ChangeTracker.Entries()
            .Where(e => e.State == EntityState.Modified && e.Entity is Supplier))
        {
            var entity = item.Entity as Supplier;
            entity.DateModified = currentTime;
            item.Property(nameof(entity.DateAdded)).IsModified = false;
        }

    }
    public void Accessed2()
    {
        var currentTime = DateTime.UtcNow;
        foreach (var item in ChangeTracker.Entries()
            .Where(e => e.State == EntityState.Added && e.Entity is Product))
        {
            var entity1 = item.Entity as Product;
            entity1.DateAdded = currentTime;
            entity1.DateModified = currentTime;
        }

        foreach (var item in ChangeTracker.Entries()
            .Where(e => e.State == EntityState.Modified && e.Entity is Product))
        {
            var entity1 = item.Entity as Product;
            entity1.DateModified = currentTime;
            item.Property(nameof(entity1.DateAdded)).IsModified = false;
        }

    }



}

// Script, but when edit is click, DateAdded is gone/transferred towards DateModified 
//        migrationBuilder.Sql(
//@"CREATE TRIGGER [dbo].[SuppliersINV_UPDATE] ON [dbo].[SuppliersINV]

//    AFTER UPDATE
//AS
//BEGIN
//    SET NOCOUNT ON;

//    IF ((SELECT TRIGGER_NESTLEVEL()) > 1) RETURN;

//    DECLARE @SupplierID INT


//    SELECT @SupplierID = INSERTED.SupplierID
//    FROM INSERTED

//    UPDATE dbo.SuppliersINV
//    SET DateModified = GETUTCDATE()
//    WHERE SupplierID = @SupplierID
//END");