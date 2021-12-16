using DevFramework.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFramework.Northwind.Entites.Concrete
{
    public class UserRole : IEntity
    {
        public int Id { get; set; }
        public int RoleID { get; set; }
        public int UserID { get; set; }
    }
}
