using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityConfigurations
{
    public class OrderDetailConfiguration : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.ToTable("OrderDetails").HasKey(od => od.Id);

            builder.Property(od => od.Id).HasColumnName("Id").IsRequired();
            builder.Property(od => od.OrderId).HasColumnName("OrderId").IsRequired();
            builder.Property(od => od.ProductId).HasColumnName("ProductId").IsRequired();
            builder.Property(od => od.Quantity).HasColumnName("Quantity").IsRequired();
            builder.Property(od => od.UnitPrice).HasColumnName("UnitPrice").IsRequired();
            builder.Property(od => od.TotalPrice).HasColumnName("TotalPrice").IsRequired();

            builder.HasOne(od => od.Order)
                .WithMany(o => o.OrderDetails)
                .HasForeignKey(od => od.OrderId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(od => od.Products);
            builder.HasQueryFilter(b => !b.DeletedDate.HasValue);

        }
    }
}
