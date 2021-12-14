using DevFramework.DataAccessLayer.Concrete.NHibernate;
using DevFramework.DataAccessLayer.Concrete.NHibernate.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DevFramework.DataAccess.Tests.NHibernateTests
{
    [TestClass]
    public class NHibernateTests
    {
        [TestMethod]
        public void Get_all_returns_all_products()
        {
            NhProductDal productDal = new NhProductDal(new SqlServerHelper());
            //veritabanında şu anda 78 ürün var
            var result = productDal.GetList();

            Assert.AreEqual(78, result.Count);
        }
        [TestMethod]
        public void Get_all_with_parameter_return_filtered_products()
        {
            NhProductDal productDal = new NhProductDal(new SqlServerHelper());
            //veritabanında şu anda içinde ab harfleri geçen 4 ürün var
            var result = productDal.GetList(x => x.ProductName.Contains("ab"));

            Assert.AreEqual(4, result.Count);
        }
    }
}
