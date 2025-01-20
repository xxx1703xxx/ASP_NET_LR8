using lr8.Models;
using Microsoft.AspNetCore.Mvc;
namespace lr8.Controllers 
{ 
public class ProductController : Controller
{
    public IActionResult Index()
    {
        var products = new List<Product>
            {
                new Product { ID = 1, Name = "Product A", Price = 10.99M, CreatedDate = DateTime.Now },
                new Product { ID = 2, Name = "Product B", Price = 20.49M, CreatedDate = DateTime.Now },
                new Product { ID = 3, Name = "Product C", Price = 15.00M, CreatedDate = DateTime.Now }
            };

        return View(products);
    }
}
}