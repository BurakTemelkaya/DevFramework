﻿using DevFramework.Core.DataAccess.EntityFramework;
using DevFramework.DataAccessLayer.Abstract;
using DevFramework.Northwind.Entites.ComplexTypes;
using DevFramework.Northwind.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFramework.DataAccessLayer.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, NorthwindContext>, IUserDal
    {
        public List<UserRoleItem> GetUserRoles(User user)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var result = from ur in context.userRoles
                             join r in context.Roles
                             on ur.UserID equals user.Id
                             where ur.UserID == user.Id
                             select new UserRoleItem { RoleName = r.Name };
                return result.ToList();
            }
        }
    }
}