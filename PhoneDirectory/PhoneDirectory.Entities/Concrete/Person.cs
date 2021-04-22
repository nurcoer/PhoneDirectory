using PhoneDirectory.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneDirectory.Entities.Concrete
{
    public class Person : IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Description { get; set; }
        public string PhoneNumber { get; set; }
        public int PhoneDirectoryId { get; set; }
        public Directory PhoneDirectory { get; set; }
    }
}
