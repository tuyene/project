using CoffeeHouse.Data;
using Microsoft.AspNetCore.Mvc;
using CoffeeHouse.Models;
using Microsoft.EntityFrameworkCore;
using X.PagedList;

namespace CoffeeHouse.Controllers
{
    public class CoffeeHouseController : Controller
    {
        CoffeeHouseContext db;
        public CoffeeHouseController(CoffeeHouseContext db)
        {
            this.db = db;
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Menu(int? page)
        {
            int pageSize = 2;
            int pageNumber = page==null||page<0?1:page.Value;
            var lstsanpham = db.Products.AsNoTracking().OrderBy(x=>x.IdProduct);
            PagedList<Products> lst = new PagedList<Products>(lstsanpham, pageNumber, pageSize);
            return View(lst);
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Shop()
        {
            return View();
        }

        public IActionResult Shop_Cart()
        {
            return View();
        }

        public IActionResult Shop_Checkout()
        {
            return View();
        }

        public IActionResult Shop_Single()
        {
            return View();
        }

        public IActionResult Blog()
        {
            return View();
        }

        public IActionResult Blog_Single()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Join()
        {
            return View();
        }
    }
}
