using PhoneDirectory.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneDirectory.Entities.Concrete

{
    public class Directory:IEntity
    {
        public int Id{ get; set; }
        public string Title{ get; set; }
        public ICollection<Person> Persons{ get; set; }
    }
}
