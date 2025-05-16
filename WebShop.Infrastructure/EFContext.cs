using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebShop.Domain.Models;
using WebShop.Domain.Models.Enums;

namespace WebShop.Infrastructure;

public class EFContext : IdentityDbContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<ProductImage> ProductImages { get; set; }
    public DbSet<ProductAttribute> ProductAttributes { get; set; }

    public DbSet<Category> Categories { get; set; }
    public DbSet<Manufacturer> Manufacturers { get; set; }

    public DbSet<Customer> Customers { get; set; }
    public DbSet<Address> Addresses { get; set; }

    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderItem> OrderItems { get; set; }

    public DbSet<Cart> Carts { get; set; }
    public DbSet<CartItem> CartItems { get; set; }

    public DbSet<PaymentMethod> PaymentMethods { get; set; }
    public DbSet<ShippingMethod> ShippingMethods { get; set; }

    public EFContext(DbContextOptions options) : base(options)
    {
    }

    protected EFContext()
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<Product>().Property(p => p.PriceGross).HasPrecision(18, 2);
        builder.Entity<Product>().Property(p => p.PriceNet).HasPrecision(18, 2);

        builder.Entity<Order>().Property(o => o.TaxAmount).HasPrecision(18, 2);
        builder.Entity<Order>().Property(o => o.TotalGross).HasPrecision(18, 2);
        builder.Entity<Order>().Property(o => o.TotalNet).HasPrecision(18, 2);

        builder.Entity<OrderItem>().Property(oi => oi.UnitPrice).HasPrecision(18, 2);
        builder.Entity<CartItem>().Property(ci => ci.UnitPrice).HasPrecision(18, 2);

        builder.Entity<PaymentMethod>().Property(pm => pm.TransactionFee).HasPrecision(18, 2);
        builder.Entity<ShippingMethod>().Property(sm => sm.Cost).HasPrecision(18, 2);

        builder.Entity<Order>()
            .HasOne(o => o.ShippingAddress)
            .WithMany()
            .HasForeignKey(o => o.ShippingAddressId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.Entity<Order>()
            .HasOne(o => o.BillingAddress)
            .WithMany()
            .HasForeignKey(o => o.BillingAddressId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
