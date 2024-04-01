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
    public class ColorConfiguration : IEntityTypeConfiguration<Color>
    {
        public void Configure(EntityTypeBuilder<Color> builder)
        {
            builder.ToTable("Colors").HasKey(b => b.Id);
            builder.Property(b => b.Id).HasColumnName("Id").IsRequired();
            builder.Property(b => b.Name).HasColumnName("Name").IsRequired();


            //builder.HasIndex(indexExpression: b => b.Name, name: "UK_Categories_Name").IsUnique();

            builder.HasMany(b => b.Products).WithOne(b => b.Color).HasForeignKey("ColorId");
            builder.HasQueryFilter(b => !b.DeletedDate.HasValue);

        }
    }
}
