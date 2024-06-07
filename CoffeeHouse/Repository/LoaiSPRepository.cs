using CoffeeHouse.Models;
using CoffeeHouse.Data;
namespace CoffeeHouse.Repository
{
    public class LoaiSPRepository : ILoaiSPRepository
    {
        private readonly CoffeeHouseContext _context;
        public LoaiSPRepository(CoffeeHouseContext context)
        {
            _context = context;
        }

        public Category Add(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
            return category;
        }

        public Category Delete(string IdCategory)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Category> GetAllCategories()
        {
            return _context.Categories;
        }

        public Category GetCategory(string IdCategory)
        {
            return _context.Categories.Find(IdCategory);
        }

        public Category Update(Category category)
        {
            _context.Update(category);
            _context.SaveChanges ();
            return category;
        }
    }
}
