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
    public class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.ToTable("Addresses").HasKey(b => b.Id);
            builder.Property(b => b.Id).HasColumnName("Id").IsRequired();
            builder.Property(b => b.AddressDetail).HasColumnName("AddressDetail").IsRequired();
            builder.Property(b => b.CityId).HasColumnName("CityId").IsRequired();
            builder.Property(b => b.CountryId).HasColumnName("CountryId").IsRequired();
            builder.Property(b => b.DistrictId).HasColumnName("DistrictId").IsRequired();
            builder.Property(b => b.NeighborhoodId).HasColumnName("NeighborhoodId").IsRequired();



            //builder.HasIndex(indexExpression: b => b.Name, name: "UK_Categories_Name").IsUnique();

           // builder.HasOne(b => b.City).WithOne(b => b.Address).HasForeignKey("CityId");
            //builder.HasOne(b => b.Country).WithOne(b => b.Address).HasForeignKey("CountryId");
            //builder.HasOne(b => b.District).WithOne(b => b.Address).HasForeignKey("DistrictId");
            //builder.HasOne(b => b.Neighborhood).WithOne(b => b.Address).HasForeignKey("NeighborhoodId");
            builder.HasQueryFilter(b => !b.DeletedDate.HasValue);
        }
    }
}
