using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityConfigurations
{
    public class DistrictConfiguration : IEntityTypeConfiguration<District>
    {
        public void Configure(EntityTypeBuilder<District> builder)
        {
            builder.ToTable("Districts").HasKey(b => b.Id);
            builder.Property(b => b.Id).HasColumnName("Id").IsRequired();
            builder.Property(b => b.Name).HasColumnName("Name").IsRequired();

            builder.HasOne(b => b.Address);
            builder.HasOne(b => b.City);


            builder.HasIndex(b => b.Name).IsUnique().HasName("UK_Districts_Name");

            builder.HasQueryFilter(b => !b.DeletedDate.HasValue);

        }
    }
    
}
