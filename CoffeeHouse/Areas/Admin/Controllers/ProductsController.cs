using CoffeeHouse.Data;
using CoffeeHouse.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeHouse.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductsController : Controller
    {
        private CoffeeHouseContext db ;
        public ProductsController(CoffeeHouseContext db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            var product = db.Products.ToList();
            return View(product);
        }
        // Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Products product)
        {
            if (ModelState.IsValid)
            {
                db.Products.Add(product);
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        // Edit
        public IActionResult Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = db.Products.Find(id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Products product)
        {
            if (ModelState.IsValid)
            {
                db.Update(product);
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        // Delete
        public IActionResult Delete(string id)
        {
            var product = db.Products.Find(id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);

        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(string id)
        {
            var product = db.Products.Find(id);
            if (product == null)
            {
                return NotFound();
            }

            db.Products.Remove( product);
            db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}

