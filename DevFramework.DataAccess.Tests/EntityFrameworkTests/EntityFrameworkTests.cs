using DevFramework.DataAccessLayer.Concrete.EntityFramework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DevFramework.DataAccess.Tests.EntityFrameworkTests
{
    [TestClass]
    public class EntityFrameworkTest
    {
        [TestMethod]
        public void Get_all_returns_all_products()
        {
            EfProductDal productDal = new EfProductDal();
            //veritabanında şu anda 78 ürün var
            var result = productDal.GetList();

            Assert.AreEqual(78, result.Count);
        }
        [TestMethod]
        public void Get_all_with_parameter_return_filtered_products()
        {
            EfProductDal productDal = new EfProductDal();
            //veritabanında şu anda içinde ab harfleri geçen 4 ürün var
            var result = productDal.GetList(x=> x.ProductName.Contains("ab"));

            Assert.AreEqual(4, result.Count);
        }
    }
}
