using DevFramework.DataAccessLayer.Abstract;
using DevFramework.Northwind.Business.Abstract;
using DevFramework.Northwind.Entites.ComplexTypes;
using DevFramework.Northwind.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFramework.Northwind.Business.Concrete.Managers
{
    public class UserManager : IUserService
    {
        private readonly IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public User GetByUserNameAndPassword(string userName, string password)
        {
            var value = _userDal.Get(u => u.UserName == userName && u.Password == password);
            return value;
        }

        public List<UserRoleItem> GetUserRoles(User user)
        {
            var value = _userDal.GetUserRoles(user);
            return value;
        }
    }
}
