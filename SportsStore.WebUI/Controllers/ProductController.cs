using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SportsStore.Domain.Abstract;
using SportsStore.Domain.Entities;
using SportsStore.WebUI.Models;
namespace SportsStore.WebUI.Controllers

{
    public class ProductController : Controller
    {
        private IProductRepository productRepository;
        public ProductController(IProductRepository repository)
        {
            productRepository = repository;
        }
        public int pageSize=3;
        public ViewResult List(string category, int page=1)
        {
            ProductsListViewModel model = new ProductsListViewModel
            {
          Products=  productRepository.Products.Where(p => category == null || p.Category == category)
                    .OrderBy
                (p=>p.ProductID).Skip((page-1)*pageSize).Take(pageSize),
            PagingInfo = new PagingInfo {
           CurrentPage = page,
           ItemsPerPage = pageSize,
                TotalItems = category == null ?
                      productRepository.Products.Count() :
                     productRepository.Products.Where(e => e.Category == category).Count()
            },
                CurrentCategory = category
            };
            return View(model);

        }
        public FileContentResult GetImage(int productId)
        {
            Product prod =productRepository.Products
            .FirstOrDefault(p => p.ProductID == productId);
            if (prod != null)
            {
                return File(prod.ImageData, prod.ImageMimeType);
            }
            else
            {
                return null;
            }
        }
    }
}