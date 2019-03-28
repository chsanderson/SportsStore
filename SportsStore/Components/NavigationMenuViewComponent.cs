using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;

namespace SportsStore.Components
{
    public class NavigationMenuViewComponent: ViewComponent
    {
        public IProductRepository repository;

        public NavigationMenuViewComponent(IProductRepository repo)
        {
            repository = repo;
        }

        public /*string*/IViewComponentResult Invoke()
        {
            //finding the value of the current category being viewed in the browser
            ViewBag.SelectedCategory = RouteData?.Values["Category"];
            return View(repository.Products
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x));
            //return "Hello from the Nav View Component";
        }
    }
}
