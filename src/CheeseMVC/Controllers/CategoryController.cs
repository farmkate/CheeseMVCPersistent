using CheeseMVC.Data;
using CheeseMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CheeseMVC.ViewModels;

namespace CheeseMVC.Controllers
{
    public class CategoryController
    {
        private readonly CheeseDbContext context;

        public CategoryController(CheeseDbContext dbContext)
        {
            context = dbContext;
        }


        public IActionResult Index()
        {
            List<CheeseCategory> categories = context.Categories.ToList();

            return View(categories);
        }

        public IActionResult Add()
        {
            AddCategoryViewModel addCategoryViewModel = new AddCategoryViewModel();
            return View(addCategoryViewModel);
        }

        [HttpPost]
        public IActionResult Add(AddCategoryViewModel addCategoryViewModel)
        {
            if (ModelState.IsValid)
            {
                // Add the new category to my existing cheeses
                CheeseCategory newCategory = new CheeseCategory
                {
                    Name = addCategoryViewModel.Name
                };

                context.Categories.Add(newCategory);
                context.SaveChanges();
            }
            
            return Redirect("/Category");
        }

        //[HttpPost]
        //public IActionResult Add(AddCheeseViewModel addCheeseViewModel)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        // Add the new cheese to my existing cheeses
        //        Cheese newCheese = new Cheese
        //        {
        //            Name = addCheeseViewModel.Name,
        //            Description = addCheeseViewModel.Description,
        //            Type = addCheeseViewModel.Type
        //        };

        //        context.Cheeses.Add(newCheese);
        //        context.SaveChanges();

        //        return Redirect("/Cheese");
        //    }

        //    return View(addCheeseViewModel);
        //}
    }
}
