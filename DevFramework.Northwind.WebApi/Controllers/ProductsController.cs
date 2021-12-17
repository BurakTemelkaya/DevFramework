using DevFramework.Northwind.Business.Abstract;
using DevFramework.Northwind.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DevFramework.Northwind.WebApi.Controllers
{
    public class ProductsController : ApiController
    {
        readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        public List<Product> Get()
        {
            return _productService.GetAll();
        }
    }
}
