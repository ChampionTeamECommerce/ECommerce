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
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Orders").HasKey(o => o.Id);

            builder.Property(o => o.Id).HasColumnName("Id").IsRequired();
            builder.Property(o => o.UserId).HasColumnName("UserId").IsRequired();
            builder.Property(o => o.TrackingNumber).HasColumnName("TrackingNumber").IsRequired();

            builder.HasOne(o => o.User)
                .WithMany(u => u.Orders)
                .HasForeignKey(o => o.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(o => o.OrderDetails)
                .WithOne(od => od.Order)
                .HasForeignKey(od => od.OrderId);
            builder.HasQueryFilter(b => !b.DeletedDate.HasValue);

            // builder.Navigation(o => o.User).AutoInclude();
        }
    }
}
