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
    public class CartItemConfiguration : IEntityTypeConfiguration<CartItem>
    {
        public void Configure(EntityTypeBuilder<CartItem> builder)
        {
            builder.ToTable("CartItems").HasKey(b => b.Id);
            builder.Property(b => b.Id).HasColumnName("Id").IsRequired();
            builder.Property(b => b.Quantity).HasColumnName("Quantity").IsRequired();
            builder.Property(b => b.ProductId).HasColumnName("ProductId");
            builder.HasOne(b => b.Product).WithMany(b => b.CartItems).HasForeignKey("ProductId");
            builder.HasQueryFilter(b => !b.DeletedDate.HasValue);
        }
    }
}
