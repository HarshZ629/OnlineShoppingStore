using ShoppingStore.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineShoppingStore.WebUI.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository productRepository;
        public ProductController(IProductRepository repo)
        {
            productRepository = repo;
        }
       public ViewResult List()
        {
            return View(productRepository.Products);
        }
    }
}