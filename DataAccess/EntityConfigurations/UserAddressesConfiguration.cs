using System;
using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations
{
    public class UserAddressesConfiguration : IEntityTypeConfiguration<UserAddresses>
    {
        public void Configure(EntityTypeBuilder<UserAddresses> builder)
        {
            builder.ToTable("UserAddresses").HasKey(b => b.Id);
            builder.Property(b => b.Id).HasColumnName("Id").IsRequired();
            builder.Property(b => b.Name).HasColumnName("Name").IsRequired();
            builder.Property(b => b.AddressId).HasColumnName("AddressId").IsRequired();


            builder.HasMany(b => b.Addresses);
            builder.HasOne(b => b.User);
            builder.HasQueryFilter(b => !b.DeletedDate.HasValue);
        }
    }
}

