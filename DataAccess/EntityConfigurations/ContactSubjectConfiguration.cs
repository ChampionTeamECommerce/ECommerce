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
    internal class ContactSubjectConfiguration : IEntityTypeConfiguration<ContactSubject>
    {
        public void Configure(EntityTypeBuilder<ContactSubject> builder)
        {
            builder.ToTable("ContactSubject").HasKey(b => b.Id);
            builder.Property(b => b.Id).HasColumnName("Id");
            builder.Property(b => b.Name).HasColumnName("Name");
            builder.HasQueryFilter(b => !b.DeletedDate.HasValue);
        }
    }
}
