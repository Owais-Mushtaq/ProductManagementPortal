
namespace InventoryManagementPortal.Models
{
    public class CategoriesRepository
    {
        private static List<Category> _categories = new List<Category>()
        {
            new Category{CategoryId = 1, Name = "Beverages", Description = "Beverages"},
            new Category{CategoryId = 2, Name = "Meat", Description = "Meat"},
            new Category{CategoryId = 3, Name = "Bakery", Description = "Bakery"},

        };
        public static void AddCategory(Category category)
        {
            var CatMaxId = _categories.Max(x => x.CategoryId);
            category.CategoryId = CatMaxId + 1;
            _categories.Add(category);
        }

        public static List<Category> GetCategories() => _categories;

        //Alternative
        //public static List<Category> GetCategories1()
        //{
        //    return _categories;
        //}

        public static Category? GetCategoryById(int id)
        {
            var category = _categories.FirstOrDefault(x => x.CategoryId == id);
            if (category != null)
            {
                return new Category
                {
                    CategoryId = category.CategoryId,
                    Name = category.Name,
                    Description = category.Description
                };
            }
            return null;
        }
        public static void UpdateCategory(int categoryId, Category category)
        {
            if (categoryId != category.CategoryId) return;

            //var categoryToUpdate = GetCategoryById(categoryId);
            var categoryToUpdate = _categories.FirstOrDefault(x => x.CategoryId == categoryId);
            if (categoryToUpdate != null)
            {
                categoryToUpdate.Name = category.Name;
                categoryToUpdate.Description = category.Description;
            }
        }
        public static void DeleteCategory(int categoryId)
        {
            var category = _categories.FirstOrDefault(x => x.CategoryId == categoryId);
            if (category != null)
            {
                _categories.Remove(category);
            }
        }

        internal static object UpdateCategory(object categoryId1, object categoryId2)
        {
            throw new NotImplementedException();
        }
    }
}
