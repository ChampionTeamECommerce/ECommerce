using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityConfigurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users").HasKey(b => b.Id);
            builder.Property(b => b.Id).HasColumnName("Id").IsRequired();
            builder.Property(b => b.FirstName).HasColumnName("FirstName").IsRequired();
            builder.Property(b => b.LastName).HasColumnName("LastName").IsRequired();
            builder.Property(b => b.Email).HasColumnName("Email").IsRequired();
            builder.Property(b => b.PhoneNumber).HasColumnName("PhoneNumber");
            builder.Property(b => b.PasswordSalt).HasColumnName("PasswordSalt").IsRequired();
            builder.Property(b => b.PasswordHash).HasColumnName("PasswordHash").IsRequired();
            builder.Property(b => b.BirthDate).HasColumnName("BirthDate");
            builder.Property(b => b.IdentityNumber).HasColumnName("IdentityNumber");
            builder.Property(b => b.UserAddressesId).HasColumnName("UserAddressesId");
            builder.Property(b => b.GenderId).HasColumnName("GenderId");




               builder.HasIndex(indexExpression: b => b.IdentityNumber, name: "UK_Users_IdentityNumber").IsUnique();
           // builder.HasOne(u => u.OperationClaim);
            builder.HasMany(u => u.Orders);
            builder.HasMany(u => u.Genders);
            builder.HasMany(u => u.UserAddresses);

            builder.HasQueryFilter(b => !b.DeletedDate.HasValue);
        }
    }
}
