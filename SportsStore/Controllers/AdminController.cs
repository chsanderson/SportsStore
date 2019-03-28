using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;

namespace SportsStore.Controllers
{
    //this restricts users unless they are admin from accessing it
    //[Authorize]
    [Authorize]
    public class AdminController : Controller
    {
        //this allows the management of the products that are displayed to the user CRUD
        private IProductRepository repository;

        public AdminController(IProductRepository repo)
        {
            repository = repo;
        }
        public ViewResult Index() => View(repository.Products);

        //this creates an edit action to allow the editing of products
        public ViewResult Edit(int productId) =>
            View(repository.Products.FirstOrDefault(p => p.ProductID == productId));

        //this handles the edit post requests
        [HttpPost]
        public IActionResult Edit(Product product)
        {
            if(ModelState.IsValid)
            {
                repository.SaveProduct(product);
                TempData["message"] = $"{product.Name} has been saved";
                return RedirectToAction("Index");
            }
            else
            {
                //there is something wrong with the data values
                return View(product);
            }
        }

        //this allows the creation new products for general users to view
        public ViewResult Create() => View("Edit", new Product());

        //this deletes the specified product
        [HttpPost]
        public IActionResult Delete(int productID)
        {
            Product deletedProduct = repository.DeleteProduct(productID);
            if(deletedProduct != null)
            {
                TempData["message"] = $"{deletedProduct} was deleted";
            }
            return RedirectToAction("Index");
        }


        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}