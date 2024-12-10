// A view Model is usually needed when of our underlying Model is required differently. 
//as an exmaple the Product Model in this project that Category as property, but Categories need to be
//presented differently (drop-down list) in Product View. Therefore a ViewModel with variation of properties
//is required.
using InventoryManagementPortal.Models;

namespace InventoryManagementPortal.ViewModel
{
    public class ProductViewModel
    {
        public IEnumerable<Category> Categories { get; set; } = new List<Category>();
        public Product Product { get; set; } = new Product();
    }
}
