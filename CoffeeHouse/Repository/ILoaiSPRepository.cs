using CoffeeHouse.Models;
namespace CoffeeHouse.Repository
{
    public interface ILoaiSPRepository
    {
        Category Add(Category category);
        Category Update(Category category);
        Category Delete(string IdCategory);
        Category GetCategory(string IdCategory);

        IEnumerable<Category> GetAllCategories();
    }
}
