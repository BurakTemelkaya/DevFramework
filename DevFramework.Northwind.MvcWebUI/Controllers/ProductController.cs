using DevFramework.Northwind.Business.Abstract;
using DevFramework.Northwind.Entites.Concrete;
using DevFramework.Northwind.MvcWebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DevFramework.Northwind.MvcWebUI.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        public ActionResult Index()
        {
            var model = new ProductListViewModel
            {
                Products = _productService.GetAll()
            };
            return View(model);
        }
        public string Add()
        {
            _productService.Add(new Product
            {
                CategoryID = 1,
                ProductName = "Gsm",
                QuantityPerUnit = "1",
                UnitPrice = 21
            });
            return "Added";
        }
        public string AddUpdate()
        {
            _productService.TransactionalOperationg(new Product
            {
                CategoryID = 1,
                ProductName = "Computer",
                QuantityPerUnit = "1",
                UnitPrice = 2
            },
            new Product
            {
                CategoryID = 1,
                ProductName = "Computer2",
                QuantityPerUnit = "1",
                UnitPrice = 30,
                ProductId = 80
            });
            return "done";
        }
    }
}