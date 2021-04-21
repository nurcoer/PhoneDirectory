using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PhoneDirectory.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneDirectory.DataAccess.Concrete.EntityFramework.Mappings
{
    public class PersonMap : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {

            builder.HasKey(p=>p.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();

            builder.Property(p => p.FirstName).IsRequired();
            builder.Property(p => p.FirstName).HasMaxLength(50);


            builder.Property(p => p.LastName).IsRequired();
            builder.Property(p => p.LastName).HasMaxLength(50);


            builder.Property(p => p.Description).IsRequired(false);
            builder.Property(p => p.Description).HasMaxLength(255);


            builder.HasOne<Directory>(c => c.PhoneDirectory).WithMany(c => c.Persons).HasForeignKey(c => c.PhoneDirectoryId);

            builder.HasData(
               new Person
               {
                   Id = 1,
                   PhoneDirectoryId = 1,
                   FirstName = "Nur",
                   LastName = "Cöer",
                   Description = "ilk Kişi",
               });
        }
    }
}
