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
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products").HasKey(b => b.Id);
            builder.Property(b => b.Id).HasColumnName("Id").IsRequired();
            builder.Property(b => b.Name).HasColumnName("Name").IsRequired();
            builder.Property(b => b.Description).HasColumnName("Description").IsRequired();
            builder.Property(b => b.StockAmount).HasColumnName("StockAmount").IsRequired();
            builder.Property(b => b.ProductPrice).HasColumnName("ProductPrice").IsRequired();
            builder.Property(b => b.CategoryId).HasColumnName("CategoryId");
            builder.Property(b => b.SizeId).HasColumnName("SizeId");
            builder.Property(b => b.ColorId).HasColumnName("ColorId");
            builder.Property(b => b.GenderId).HasColumnName("GenderId");




            builder.HasOne(b => b.Gender).WithMany(b => b.Products).HasForeignKey("GenderId");
            builder.HasOne(b => b.Category).WithMany(b => b.Products).HasForeignKey("CategoryId");
            builder.HasOne(b => b.Color).WithMany(b => b.Products).HasForeignKey("ColorId");
            builder.HasOne(b => b.Size).WithMany(b => b.Products).HasForeignKey("SizeId");
            builder.HasMany(b => b.CartItems);


            builder.HasQueryFilter(b => !b.DeletedDate.HasValue);
        }
    }
}
