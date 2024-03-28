using Entities.Concretes;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityConfigurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {

        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Categories").HasKey(b => b.Id);
            builder.Property(b => b.Id).HasColumnName("Id").IsRequired();
            builder.Property(b => b.Name).HasColumnName("Name").IsRequired();


            builder.HasIndex(indexExpression: b => b.Name, name: "UK_Categories_Name").IsUnique();

           // builder.HasOne(b => b.ParentCategory).WithMany(b => b.SubCategory).HasForeignKey("ParentId");
            builder.HasQueryFilter(b => !b.DeletedDate.HasValue);
        }

    }
}
