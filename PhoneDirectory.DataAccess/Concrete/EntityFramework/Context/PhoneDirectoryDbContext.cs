using Microsoft.EntityFrameworkCore;
using PhoneDirectory.DataAccess.Concrete.EntityFramework.Mappings;
using PhoneDirectory.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhoneDirectory.DataAccess.Concrete.EntityFramework.Context
{
    public class PhoneDirectoryDbContext : DbContext
    {

        public PhoneDirectoryDbContext() : base() { }
        public PhoneDirectoryDbContext(DbContextOptions<PhoneDirectoryDbContext> options) : base(options) { }


        public DbSet<Person> Personels{ get; set; }
        public DbSet<Directory> Directories{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PersonMap());
            modelBuilder.ApplyConfiguration(new DirectoryMap());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           optionsBuilder.UseSqlServer(connectionString: @"Server = (localdb)\mssqllocaldb; Database = PhoneDirectoryDb; Trusted_Connection = true");
        }
    }
}
