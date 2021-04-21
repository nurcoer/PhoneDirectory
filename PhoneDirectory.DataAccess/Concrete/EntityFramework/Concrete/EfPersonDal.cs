using PhoneDirectory.Core.DataAccess.EntityFramework;
using PhoneDirectory.DataAccess.Abstract;
using PhoneDirectory.DataAccess.Concrete.EntityFramework.Context;
using PhoneDirectory.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneDirectory.DataAccess.Concrete.EntityFramework.Concrete
{
    public class EfPersonDal : EfEntityRepositaryBase<Person, PhoneDirectoryDbContext>, IPersonDal
    {
    }
}
