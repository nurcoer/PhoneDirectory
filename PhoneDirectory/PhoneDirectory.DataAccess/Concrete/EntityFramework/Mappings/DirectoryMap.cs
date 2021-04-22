using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PhoneDirectory.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneDirectory.DataAccess.Concrete.EntityFramework.Mappings
{
    public class DirectoryMap : IEntityTypeConfiguration<Directory>
    {
        public void Configure(EntityTypeBuilder<Directory> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();

            builder.Property(p => p.Title).IsRequired();
            builder.Property(p => p.Title).HasMaxLength(50);

            builder.HasMany<Person>(c => c.Persons).WithOne(f => f.PhoneDirectory).HasForeignKey(f => f.PhoneDirectoryId);

            builder.HasData(
               new Directory
               {
                   Id = 1,
                   Title = "iş Partfolyösü"
               });
        }
    }
}
