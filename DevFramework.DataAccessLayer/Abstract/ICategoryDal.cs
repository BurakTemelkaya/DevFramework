using DevFramework.Core.DataAccess;
using DevFramework.Northwind.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFramework.DataAccessLayer.Abstract
{
    public interface ICategoryDal : IEntityRepository<Category>
    {
    }
}
