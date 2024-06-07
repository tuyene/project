using CoffeeHouse.Models;
using CoffeeHouse.Repository;
using Microsoft.AspNetCore.Mvc;
namespace CoffeeHouse.ViewComponents
{
    public class LoaiSPMenuViewComponent:ViewComponent
    {
        private readonly ILoaiSPRepository _loaiSp;
        public LoaiSPMenuViewComponent(ILoaiSPRepository loaiSpRepository)
        {
            _loaiSp = loaiSpRepository;
        }
        public IViewComponentResult Invoke()
        {
            var loaisp = _loaiSp.GetAllCategories().OrderBy(x => x.Name);
            return View(loaisp);
        }
    }
} 
